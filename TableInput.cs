using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesTracker
{
    internal class TableInput
    {
        public Font TextFont { get; set; }
        public Label Name { get; set; }
        public Label Type { get; set; }
        public Label Date { get; set; }
        public Label Amount { get; set; }
        public Button Delete { get; set; }



        public TableInput(ComboBox T, TextBox N, DateTimePicker D, TextBox A)
        {
            this.TextFont = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.Name = new Label() { Text = N.Text, Font = this.TextFont };
            this.Type = new Label() { Text = T.Text, Font = this.TextFont };
            this.Date = new Label() { Text = D.Value.ToShortDateString(), Font = this.TextFont };
            this.Amount = new Label() { Text = $"{A.Text}$", Font = this.TextFont };

            this.Delete = new Button
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                BackColor = Color.DimGray,
                ImageAlign = ContentAlignment.MiddleLeft,
                Location = new Point(863, 3),
                Name = "button1",
                Size = new Size(63, 44),
                TabIndex = 8,
                Text = "X",
                UseVisualStyleBackColor = false



            };
        }
    }


}

