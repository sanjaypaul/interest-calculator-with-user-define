using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interest_calculator
{
    public partial class calculator_UI : Form
    {
        public calculator_UI()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            calculate aCalculator = new calculate();
            aCalculator.amount = Convert.ToDouble(amounttextBox.Text);
            aCalculator.interest = Convert.ToDouble(interesttextBox.Text);
            aCalculator.year = Convert.ToDouble(yeartextBox.Text);

            aCalculator.total = aCalculator.amount*Math.Pow(1 + aCalculator.interest/100,aCalculator.year);
            resulttextBox.Text = aCalculator.total.ToString();

            // resulttextBox.Text = aCalculator.percent().ToString();

        }
    }
}
