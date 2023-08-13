using System;
using System.Windows.Forms;

namespace ExpensesTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PaymentLocation_Click(object sender, EventArgs e)
        {
            if (this.PaymentLocation.Text == " Where was the expense made?")
            {
                this.PaymentLocation.Text = "";
                this.PaymentLocation.ForeColor = Color.Black;
            }
            else
                this.PaymentLocation.Focus();
        }

        private void PaymentLocation_Leave(object sender, EventArgs e)
        {
            if (this.PaymentLocation.Text.Trim() == "")
            {
                this.PaymentLocation.Text = " Where was the expense made?";
                this.PaymentLocation.ForeColor = Color.Gray;
            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void AmountSpent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.' && !this.AmountSpent.Text.Contains('.')) return;
            e.Handled = true;
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            var panel = this.DataTable;
            Button btn = (Button)sender;
            int row = panel.GetRow(btn);
            for (int i = 0; i < panel.ColumnCount; i++)
            {
                panel.GetControlFromPosition(i, row).Dispose();

            }
        }
        private void Submit_Click(object sender, EventArgs e)
        {

            if (this.TypeOfPay.SelectedIndex == -1 || this.PaymentLocation.Text == " Where was the expense made?" || this.AmountSpent.Text == "")
            {
                this.label3.Visible = true;
                return;
            }

            var panel = this.DataTable;
            TableInput input = new TableInput(this.TypeOfPay, this.PaymentLocation, this.DateOfPayment, this.AmountSpent);
            panel.RowCount += 1;
            panel.Controls.Add(input.Type, 0, panel.RowCount - 1);
            panel.Controls.Add(input.Name, 1, panel.RowCount - 1);
            panel.Controls.Add(input.Date, 2, panel.RowCount - 1);
            panel.Controls.Add(input.Amount, 3, panel.RowCount - 1);
            panel.Controls.Add(input.Delete, 4, panel.RowCount - 1);
            input.Delete.Click += new EventHandler(DynamicButton_Click);

            this.TypeOfPay.SelectedIndex = -1;
            this.PaymentLocation.Text = " Where was the expense made?";
            this.PaymentLocation.ForeColor = Color.Gray;
            this.AmountSpent.ResetText();
            this.label3.Visible = false;

        }


    }
}