using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_test_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void caluclater1_OnCaluclate(int obj)
        //{
        //    MessageBox.Show("Rasult = " + obj);
        //}

        private void caluclater1_Load(object sender, EventArgs e)
        {

        }

        private void caluclater1_Load_1(object sender, EventArgs e)
        {

        }

        private void caluclater1_OnCaluclationComplet(object sender, Caluclater.CalculateComplateEventArgs e)
        {
        }

        private void caluclater1_IsCalculationComplete(object sender, Caluclater.CalculateComplateEventArgs e)
        {
            MessageBox.Show($"V1 ={e._Val1},V2 ={e._Val2},V3 ={e._Val3} \n AVG = {e._AVG} ");

        }
    }
}
