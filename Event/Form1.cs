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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sampleCalculator1_Load(object sender, EventArgs e)
        {

        }

        private void sampleCalculator1_Load_1(object sender, EventArgs e)
        {

        }

        private void sampleCalculator1_OnCalculationComplete(double obj)
        {
            MessageBox.Show("Result = " + obj.ToString());
        }

        private void uC_test1_OnPersonIsFound(UC_test.PersonInfo obj)
        {

            label1.Text = obj.Name;
            label2.Text = obj.Age.ToString();
            label3.Text = obj.Phone;
            label4.Text = obj.Email;
            label5.Text = obj.Address;
            label6.Text = obj.Country;
        }

        private void uC_test1_Load(object sender, EventArgs e)
        {

        }
    }
}
