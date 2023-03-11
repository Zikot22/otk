namespace OTKInformationSystem.Forms
{
    partial class BookingFormationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            logOutButton = new Button();
            welcomeLabel = new Label();
            bookingsDataGridView = new DataGridView();
            newBookingGroupBox = new GroupBox();
            deleteButton = new Button();
            editButton = new Button();
            addBookingButton = new Button();
            countedPriceLabel = new Label();
            priceLabel = new Label();
            discountTextBox = new TextBox();
            serviceComboBox = new ComboBox();
            discountLabel = new Label();
            serviceLabel = new Label();
            clientLabel = new Label();
            clientComboBox = new ComboBox();
            dateTimePicker = new DateTimePicker();
            dateLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookingsDataGridView).BeginInit();
            newBookingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(logOutButton);
            panel1.Controls.Add(welcomeLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 45);
            panel1.TabIndex = 0;
            // 
            // logOutButton
            // 
            logOutButton.Location = new Point(17, 15);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(127, 27);
            logOutButton.TabIndex = 1;
            logOutButton.Text = "Выйти из системы";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += LogOut;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(12, 16);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(52, 21);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "label1";
            // 
            // bookingsDataGridView
            // 
            bookingsDataGridView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            bookingsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bookingsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookingsDataGridView.Location = new Point(7, 58);
            bookingsDataGridView.MultiSelect = false;
            bookingsDataGridView.Name = "bookingsDataGridView";
            bookingsDataGridView.RowTemplate.Height = 25;
            bookingsDataGridView.Size = new Size(532, 235);
            bookingsDataGridView.TabIndex = 15;
            // 
            // newBookingGroupBox
            // 
            newBookingGroupBox.Controls.Add(deleteButton);
            newBookingGroupBox.Controls.Add(editButton);
            newBookingGroupBox.Controls.Add(addBookingButton);
            newBookingGroupBox.Controls.Add(countedPriceLabel);
            newBookingGroupBox.Controls.Add(priceLabel);
            newBookingGroupBox.Controls.Add(discountTextBox);
            newBookingGroupBox.Controls.Add(serviceComboBox);
            newBookingGroupBox.Controls.Add(discountLabel);
            newBookingGroupBox.Controls.Add(serviceLabel);
            newBookingGroupBox.Controls.Add(clientLabel);
            newBookingGroupBox.Controls.Add(clientComboBox);
            newBookingGroupBox.Controls.Add(dateTimePicker);
            newBookingGroupBox.Controls.Add(dateLabel);
            newBookingGroupBox.Dock = DockStyle.Bottom;
            newBookingGroupBox.Location = new Point(0, 310);
            newBookingGroupBox.Name = "newBookingGroupBox";
            newBookingGroupBox.Size = new Size(544, 216);
            newBookingGroupBox.TabIndex = 14;
            newBookingGroupBox.TabStop = false;
            newBookingGroupBox.Text = "Новый заказ";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(224, 224, 224);
            deleteButton.Location = new Point(12, 180);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(133, 31);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Удалить выбранный";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += DeleteBooking;
            // 
            // editButton
            // 
            editButton.Location = new Point(151, 180);
            editButton.Name = "editButton";
            editButton.Size = new Size(137, 31);
            editButton.TabIndex = 11;
            editButton.Text = "Изменить выбранный";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditBooking;
            // 
            // addBookingButton
            // 
            addBookingButton.Location = new Point(294, 180);
            addBookingButton.Name = "addBookingButton";
            addBookingButton.Size = new Size(81, 31);
            addBookingButton.TabIndex = 10;
            addBookingButton.Text = "Добавить";
            addBookingButton.UseVisualStyleBackColor = true;
            addBookingButton.Click += AddBooking;
            // 
            // countedPriceLabel
            // 
            countedPriceLabel.AutoSize = true;
            countedPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            countedPriceLabel.Location = new Point(175, 150);
            countedPriceLabel.Name = "countedPriceLabel";
            countedPriceLabel.Size = new Size(40, 21);
            countedPriceLabel.TabIndex = 9;
            countedPriceLabel.Text = "0,00";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(12, 150);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(90, 21);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Стоимость:";
            // 
            // discountTextBox
            // 
            discountTextBox.Location = new Point(175, 120);
            discountTextBox.Name = "discountTextBox";
            discountTextBox.Size = new Size(200, 23);
            discountTextBox.TabIndex = 7;
            discountTextBox.Text = "0";
            discountTextBox.TextChanged += CountPrice;
            // 
            // serviceComboBox
            // 
            serviceComboBox.FormattingEnabled = true;
            serviceComboBox.Location = new Point(175, 90);
            serviceComboBox.Name = "serviceComboBox";
            serviceComboBox.Size = new Size(200, 23);
            serviceComboBox.TabIndex = 6;
            serviceComboBox.SelectedIndexChanged += CountPrice;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            discountLabel.Location = new Point(12, 120);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(85, 21);
            discountLabel.TabIndex = 5;
            discountLabel.Text = "Скидка, %:";
            // 
            // serviceLabel
            // 
            serviceLabel.AutoSize = true;
            serviceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            serviceLabel.Location = new Point(12, 90);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new Size(59, 21);
            serviceLabel.TabIndex = 4;
            serviceLabel.Text = "Услуга:";
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clientLabel.Location = new Point(12, 60);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new Size(63, 21);
            clientLabel.TabIndex = 3;
            clientLabel.Text = "Клиент:";
            // 
            // clientComboBox
            // 
            clientComboBox.FormattingEnabled = true;
            clientComboBox.Location = new Point(175, 60);
            clientComboBox.Name = "clientComboBox";
            clientComboBox.Size = new Size(200, 23);
            clientComboBox.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "";
            dateTimePicker.Location = new Point(175, 30);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 1;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(12, 30);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(142, 21);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "Дата оформления:";
            // 
            // BookingFormationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 526);
            Controls.Add(bookingsDataGridView);
            Controls.Add(newBookingGroupBox);
            Controls.Add(panel1);
            Name = "BookingFormationForm";
            Text = "Формирование заказов";
            FormClosing += OnClose;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookingsDataGridView).EndInit();
            newBookingGroupBox.ResumeLayout(false);
            newBookingGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label welcomeLabel;
        private Button logOutButton;
        private DataGridView bookingsDataGridView;
        private GroupBox newBookingGroupBox;
        private Button addBookingButton;
        private Label countedPriceLabel;
        private Label priceLabel;
        private TextBox discountTextBox;
        private ComboBox serviceComboBox;
        private Label discountLabel;
        private Label serviceLabel;
        private Label clientLabel;
        private ComboBox clientComboBox;
        private DateTimePicker dateTimePicker;
        private Label dateLabel;
        private Button deleteButton;
        private Button editButton;
    }
}