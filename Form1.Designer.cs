namespace ExpensesTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TypeBox = new TextBox();
            NameBox = new TextBox();
            PaymentLocation = new TextBox();
            TypeOfPay = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            InputTable = new TableLayoutPanel();
            DateBox = new TextBox();
            DateOfPayment = new DateTimePicker();
            AmountBox = new TextBox();
            AmountSpent = new TextBox();
            Submit = new Button();
            DataTable = new TableLayoutPanel();
            AmountColumn = new TextBox();
            TypeColumn = new TextBox();
            DateColumn = new TextBox();
            NameColumn = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            InputTable.SuspendLayout();
            DataTable.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TypeBox
            // 
            TypeBox.BorderStyle = BorderStyle.None;
            TypeBox.Dock = DockStyle.Fill;
            TypeBox.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TypeBox.Location = new Point(3, 3);
            TypeBox.Name = "TypeBox";
            TypeBox.ReadOnly = true;
            TypeBox.Size = new Size(143, 32);
            TypeBox.TabIndex = 2;
            TypeBox.Text = "Type:";
            // 
            // NameBox
            // 
            NameBox.BorderStyle = BorderStyle.None;
            NameBox.Dock = DockStyle.Fill;
            NameBox.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            NameBox.Location = new Point(610, 3);
            NameBox.Name = "NameBox";
            NameBox.ReadOnly = true;
            NameBox.Size = new Size(143, 32);
            NameBox.TabIndex = 5;
            NameBox.Text = "Name:";
            // 
            // PaymentLocation
            // 
            PaymentLocation.Dock = DockStyle.Fill;
            PaymentLocation.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PaymentLocation.ForeColor = Color.Gray;
            PaymentLocation.Location = new Point(759, 3);
            PaymentLocation.Name = "PaymentLocation";
            PaymentLocation.Size = new Size(454, 30);
            PaymentLocation.TabIndex = 6;
            PaymentLocation.Text = " Where was the expense made?";
            PaymentLocation.Click += PaymentLocation_Click;
            PaymentLocation.Leave += PaymentLocation_Leave;
            // 
            // TypeOfPay
            // 
            TypeOfPay.Dock = DockStyle.Fill;
            TypeOfPay.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeOfPay.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TypeOfPay.ForeColor = Color.Gray;
            TypeOfPay.FormattingEnabled = true;
            TypeOfPay.ItemHeight = 23;
            TypeOfPay.Items.AddRange(new object[] { "Cash", "Debit Card", "Credit Card", "Check" });
            TypeOfPay.Location = new Point(152, 3);
            TypeOfPay.Name = "TypeOfPay";
            TypeOfPay.Size = new Size(452, 31);
            TypeOfPay.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1240, 53);
            label1.TabIndex = 4;
            label1.Text = "Expense Tracker";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Peru;
            label2.Location = new Point(0, 53);
            label2.Name = "label2";
            label2.Size = new Size(1240, 35);
            label2.TabIndex = 5;
            label2.Text = "Add a new item:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InputTable
            // 
            InputTable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InputTable.AutoSize = true;
            InputTable.ColumnCount = 4;
            InputTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.29F));
            InputTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.71F));
            InputTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.28814F));
            InputTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.71186F));
            InputTable.Controls.Add(DateBox, 0, 1);
            InputTable.Controls.Add(PaymentLocation, 3, 0);
            InputTable.Controls.Add(NameBox, 2, 0);
            InputTable.Controls.Add(TypeBox, 0, 0);
            InputTable.Controls.Add(TypeOfPay, 1, 0);
            InputTable.Controls.Add(DateOfPayment, 1, 1);
            InputTable.Controls.Add(AmountBox, 2, 1);
            InputTable.Controls.Add(AmountSpent, 3, 1);
            InputTable.Location = new Point(12, 91);
            InputTable.Name = "InputTable";
            InputTable.RowCount = 2;
            InputTable.RowStyles.Add(new RowStyle(SizeType.Percent, 46.3576164F));
            InputTable.RowStyles.Add(new RowStyle(SizeType.Percent, 53.6423836F));
            InputTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            InputTable.Size = new Size(1216, 82);
            InputTable.TabIndex = 7;
            // 
            // DateBox
            // 
            DateBox.BorderStyle = BorderStyle.None;
            DateBox.Dock = DockStyle.Fill;
            DateBox.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            DateBox.Location = new Point(3, 41);
            DateBox.Name = "DateBox";
            DateBox.ReadOnly = true;
            DateBox.Size = new Size(143, 32);
            DateBox.TabIndex = 7;
            DateBox.Text = "Date:";
            // 
            // DateOfPayment
            // 
            DateOfPayment.CalendarFont = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateOfPayment.CustomFormat = "  dd/MM/yyyy";
            DateOfPayment.Dock = DockStyle.Fill;
            DateOfPayment.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DateOfPayment.Format = DateTimePickerFormat.Custom;
            DateOfPayment.Location = new Point(152, 41);
            DateOfPayment.Name = "DateOfPayment";
            DateOfPayment.Size = new Size(452, 27);
            DateOfPayment.TabIndex = 8;
            DateOfPayment.Value = new DateTime(2023, 8, 4, 10, 19, 5, 0);
            // 
            // AmountBox
            // 
            AmountBox.BorderStyle = BorderStyle.None;
            AmountBox.Dock = DockStyle.Fill;
            AmountBox.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            AmountBox.Location = new Point(610, 41);
            AmountBox.Name = "AmountBox";
            AmountBox.ReadOnly = true;
            AmountBox.Size = new Size(143, 32);
            AmountBox.TabIndex = 9;
            AmountBox.Text = "Amount:";
            // 
            // AmountSpent
            // 
            AmountSpent.Dock = DockStyle.Fill;
            AmountSpent.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AmountSpent.ForeColor = Color.Black;
            AmountSpent.Location = new Point(759, 41);
            AmountSpent.Name = "AmountSpent";
            AmountSpent.Size = new Size(454, 30);
            AmountSpent.TabIndex = 10;
            AmountSpent.KeyPress += AmountSpent_KeyPress;
            // 
            // Submit
            // 
            Submit.Anchor = AnchorStyles.Top;
            Submit.BackColor = Color.FromArgb(101, 190, 37);
            Submit.BackgroundImageLayout = ImageLayout.None;
            Submit.FlatAppearance.BorderColor = Color.FromArgb(101, 190, 37);
            Submit.FlatAppearance.BorderSize = 3;
            Submit.FlatAppearance.MouseDownBackColor = Color.FromArgb(101, 190, 37);
            Submit.FlatAppearance.MouseOverBackColor = Color.FromArgb(101, 190, 37);
            Submit.FlatStyle = FlatStyle.Popup;
            Submit.Font = new Font("Myanmar Text", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Submit.ForeColor = Color.White;
            Submit.Location = new Point(542, 232);
            Submit.Name = "Submit";
            Submit.Size = new Size(192, 49);
            Submit.TabIndex = 8;
            Submit.Text = "Add Expense";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // DataTable
            // 
            DataTable.AutoSize = true;
            DataTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DataTable.BackColor = Color.DimGray;
            DataTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            DataTable.ColumnCount = 5;
            DataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 249F));
            DataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 263F));
            DataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            DataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 270F));
            DataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            DataTable.Controls.Add(AmountColumn, 3, 0);
            DataTable.Controls.Add(TypeColumn, 0, 0);
            DataTable.Controls.Add(DateColumn, 2, 0);
            DataTable.Controls.Add(NameColumn, 1, 0);
            DataTable.Dock = DockStyle.Top;
            DataTable.ForeColor = Color.FromArgb(224, 224, 224);
            DataTable.Location = new Point(0, 0);
            DataTable.Name = "DataTable";
            DataTable.RowCount = 1;
            DataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            DataTable.Size = new Size(1216, 52);
            DataTable.TabIndex = 9;
            // 
            // AmountColumn
            // 
            AmountColumn.BackColor = Color.DimGray;
            AmountColumn.BorderStyle = BorderStyle.FixedSingle;
            AmountColumn.Dock = DockStyle.Fill;
            AmountColumn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            AmountColumn.ForeColor = Color.FromArgb(224, 224, 224);
            AmountColumn.Location = new Point(749, 4);
            AmountColumn.Multiline = true;
            AmountColumn.Name = "AmountColumn";
            AmountColumn.ReadOnly = true;
            AmountColumn.Size = new Size(264, 44);
            AmountColumn.TabIndex = 5;
            AmountColumn.Text = "Amount";
            // 
            // TypeColumn
            // 
            TypeColumn.BackColor = Color.DimGray;
            TypeColumn.BorderStyle = BorderStyle.FixedSingle;
            TypeColumn.Dock = DockStyle.Fill;
            TypeColumn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TypeColumn.ForeColor = Color.FromArgb(224, 224, 224);
            TypeColumn.Location = new Point(4, 4);
            TypeColumn.Multiline = true;
            TypeColumn.Name = "TypeColumn";
            TypeColumn.ReadOnly = true;
            TypeColumn.Size = new Size(243, 44);
            TypeColumn.TabIndex = 4;
            TypeColumn.Text = "Type:";
            // 
            // DateColumn
            // 
            DateColumn.BackColor = Color.DimGray;
            DateColumn.BorderStyle = BorderStyle.FixedSingle;
            DateColumn.Dock = DockStyle.Fill;
            DateColumn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            DateColumn.ForeColor = Color.FromArgb(224, 224, 224);
            DateColumn.Location = new Point(518, 4);
            DateColumn.Multiline = true;
            DateColumn.Name = "DateColumn";
            DateColumn.ReadOnly = true;
            DateColumn.Size = new Size(224, 44);
            DateColumn.TabIndex = 7;
            DateColumn.Text = "Date";
            // 
            // NameColumn
            // 
            NameColumn.BackColor = Color.DimGray;
            NameColumn.BorderStyle = BorderStyle.FixedSingle;
            NameColumn.Dock = DockStyle.Fill;
            NameColumn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            NameColumn.ForeColor = Color.FromArgb(224, 224, 224);
            NameColumn.Location = new Point(254, 4);
            NameColumn.Multiline = true;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Size = new Size(257, 44);
            NameColumn.TabIndex = 3;
            NameColumn.Text = "Name";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(DataTable);
            panel1.Location = new Point(12, 303);
            panel1.Name = "panel1";
            panel1.Size = new Size(1216, 260);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(537, 566);
            label3.Name = "label3";
            label3.Size = new Size(197, 32);
            label3.TabIndex = 9;
            label3.Text = "Fields can't be empty";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1240, 607);
            Controls.Add(label3);
            Controls.Add(Submit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(InputTable);
            MinimumSize = new Size(200, 0);
            Name = "Form1";
            Text = "Form1";
            Click += Form1_Click;
            InputTable.ResumeLayout(false);
            InputTable.PerformLayout();
            DataTable.ResumeLayout(false);
            DataTable.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TypeBox;
        private ComboBox TypeOfPay;
        private TextBox NameBox;
        private TextBox PaymentLocation;
        private Label label1;
        private Label label2;
        private TableLayoutPanel InputTable;
        private TextBox DateBox;
        private DateTimePicker DateOfPayment;
        private TextBox AmountBox;
        private TextBox AmountSpent;
        private Button Submit;
        private TableLayoutPanel DataTable;
        private TextBox NameColumn;
        private TextBox DateColumn;
        private TextBox AmountColumn;
        private TextBox TypeColumn;
        private Panel panel1;
        private Label label3;
    }
}