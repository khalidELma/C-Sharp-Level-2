using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Club_Project_Idea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_EndOfTable(object sender, UserControl2.tableArgs e)
        {
            MessageBox.Show($"Time Consumed {e.TotalTime} ,Total Seconds = {e.TotalSeconds},Hour tyRate ={e.hourlyRate},Total Fees = {e.TotalFees}") ;
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_EndOfTable_1(object sender, UserControl2.tableArgs e)
        {
            MessageBox.Show($"Time Consumed {e.TotalTime} ,Total Seconds = {e.TotalSeconds},Hour tyRate ={e.hourlyRate},Total Fees = {e.TotalFees}");

        }

        private void userControl22_EndOfTable(object sender, UserControl2.tableArgs e)
        {
            MessageBox.Show($"Time Consumed {e.TotalTime} ,Total Seconds = {e.TotalSeconds},Hour tyRate ={e.hourlyRate},Total Fees = {e.TotalFees}");

        }

        private void userControl23_EndOfTable(object sender, UserControl2.tableArgs e)
        {
            MessageBox.Show($"Time Consumed {e.TotalTime} ,Total Seconds = {e.TotalSeconds},Hour tyRate ={e.hourlyRate},Total Fees = {e.TotalFees}");

        }
    }
}
