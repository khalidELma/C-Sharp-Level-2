using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event
{
    public partial class SampleCalculator : UserControl
    {
        public SampleCalculator()
        {
            InitializeComponent();
        }

        public event Action<double> OnCalculationComplete;

        protected virtual void CalculationComplete(double PersonID)
        {
            Action<double> handler = OnCalculationComplete;
            if (handler != null) { 
             
                handler(PersonID);
            
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Result = -1;
            if (double.TryParse((Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)).ToString(), out Result))
            {

                label2.Text = Result.ToString();

            }
            else
            {
                MessageBox.Show("Please Entre a Number");
            }
            if (OnCalculationComplete != null)
                CalculationComplete(Result);
        }

        private void SampleCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
