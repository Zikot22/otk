using MySql.Data.MySqlClient;
using OTKInformationSystem.Models;

namespace OTKInformationSystem.Forms
{
    public partial class BookingFormationForm : Form
    {
        private AuthorizationForm authorizationForm;
        private bool closedByLogOut = false;
        private int discount;
        private Employee employee;
        private MySqlConnection connection;
        private List<Service> services = new List<Service>();
        private List<Client> clients = new List<Client>();
        private List<Booking> bookings = new List<Booking>();

        public BookingFormationForm(AuthorizationForm authorizationForm, Employee employee)
        {
            this.authorizationForm = authorizationForm;
            this.employee = employee;

            var connectionString = "SERVER=localhost;DATABASE=OTKInformationSystem;UID=root;PASSWORD=root;";
            connection = new MySqlConnection(connectionString);

            InitializeComponent();

            MinimumSize = new Size(560, 565);
            MaximumSize = new Size(850, 600);

            GetServices();
            GetClients();
            GetBookings();

            welcomeLabel.Text = $"Добро пожаловать, {employee.Name}";
            logOutButton.Location = new Point(logOutButton.Location.X + welcomeLabel.Width, logOutButton.Location.Y);
        }

        private void GetServices()
        {
            connection.Open();
            var query =
                $"SELECT * FROM service";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            services.Clear();
            while (dataReader.Read())
            {
                services.Add(new Service
                {
                    Id = dataReader.GetInt16("id"),
                    Name = dataReader.GetString("name"),
                    Price = dataReader.GetFloat("price")
                });
            }

            dataReader.Close();
            connection.Close();

            serviceComboBox.DataSource = services;
            serviceComboBox.ValueMember = "Name";
        }

        private void GetClients()
        {
            connection.Open();
            var query =
                $"SELECT * FROM client";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            clients.Clear();
            while (dataReader.Read())
            {
                clients.Add(new Client
                {
                    Id = dataReader.GetInt16("id"),
                    Name = dataReader.GetString("name"),
                    Adress = dataReader.GetString("adress"),
                    PhoneNumber = dataReader.GetString("phone_number")
                });
            }

            dataReader.Close();
            connection.Close();

            clientComboBox.DataSource = clients;
            clientComboBox.ValueMember = "Name";
        }

        private void GetBookings()
        {
            connection.Open();
            var query =
                $"SELECT booking.id, booking.date, booking.discount, booking.status, client.name, employee.name, service.name FROM booking " +
                $"JOIN client on id_client = client.id " +
                $"JOIN employee on id_employee = employee.id " +
                $"JOIN service on id_service = service.id; ";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            bookings.Clear();
            while (dataReader.Read())
            {
                bookings.Add(new Booking
                {
                    Id = dataReader.GetInt16(0),
                    Date = dataReader.GetDateTime(1),
                    Discount = dataReader.GetInt16(2),
                    Status = dataReader.GetString(3),
                    ClientName = dataReader.GetString(4),
                    EmployeeName = dataReader.GetString(5),
                    ServiceName = dataReader.GetString(6),
                });
            }

            dataReader.Close();
            connection.Close();

            bookingsDataGridView.DataSource = null;
            bookingsDataGridView.DataSource = bookings;

            bookingsDataGridView.Update();
            bookingsDataGridView.Refresh();
        }

        /// <summary>
        /// Рассчитывает цену с учётом скидки, здесь же проводит валидацию скидки и реагирует на изменение её значения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountPrice(object sender, EventArgs e)
        {
            try
            {
                discount = int.Parse(discountTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Укажите число в поле скидки");
                discount = 0;
                discountTextBox.Text = "0";
            }
            if (discount > 100 || discount < 0)
            {
                MessageBox.Show("Скидка должны быть числом в диапазоне от 0 до 100");
                discount = 0;
                discountTextBox.Text = "0";
            }
            var price = (serviceComboBox.SelectedItem as Service)?.Price;
            countedPriceLabel.Text = (price - price * discount / 100).ToString();
        }

        private void AddBooking(object sender, EventArgs e)
        {
            CountPrice(sender, e);
            connection.Open();
            var query =
                $"INSERT INTO booking(date, discount, status, id_client, id_employee, id_service) " +
                $"VALUES('{dateTimePicker.Value.ToString("yyyyMMdd")}', {discount}, 'в работе', {((Client)clientComboBox.SelectedItem).Id}, {employee.Id}, {((Service)serviceComboBox.SelectedItem).Id})";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            connection.Close();

            GetBookings();
        }

        private void DeleteBooking(object sender, EventArgs e)
        {
            connection.Open();
            var query = $"INSERT INTO booking_backup(date, discount, status, id_client, id_employee, id_service)" +
                $" SELECT date, discount, 'закрыт', id_client, id_employee, id_service" +
                $" FROM booking WHERE id = {((Booking)bookingsDataGridView.CurrentRow.DataBoundItem).Id}; " +
                $"DELETE FROM booking WHERE id = {((Booking)bookingsDataGridView.CurrentRow.DataBoundItem).Id};";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            connection.Close();

            GetBookings();
        }

        private void EditBooking(object sender, EventArgs e)
        {
            connection.Open();
            var query =
                $"UPDATE booking " +
                $"SET date = '{dateTimePicker.Value.ToString("yyyyMMdd")}', discount = {discount}, " +
                $"id_client = {((Client)clientComboBox.SelectedItem).Id}, id_employee = {employee.Id}, id_service = {((Service)serviceComboBox.SelectedItem).Id} " +
                $"WHERE id = {((Booking)bookingsDataGridView.CurrentRow.DataBoundItem).Id}";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            connection.Close();

            GetBookings();
        }
        
        /// <summary>
        /// Возврат на окно авторизации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogOut(object sender, EventArgs e)
        {
            closedByLogOut = true;
            this.Close();
        }

        /// <summary>
        /// Действие при закрытии, необходим для избежания утечек памяти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClose(object sender, FormClosingEventArgs e)
        {
            if (closedByLogOut) authorizationForm.Show();
            else authorizationForm.Close();
        }
    }
}
