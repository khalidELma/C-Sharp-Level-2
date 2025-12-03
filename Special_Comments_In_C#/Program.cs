using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Comments_In_C_
{
    internal class Program
    {
        /// <summary>
        /// This class is represent a sample Calculator.
        /// </summary>
         public class Calculator
        {
            /// <summary>
            /// Adds Tow numbers And return the result 
            /// </summary>
            /// <param name="x">The first number to be added   </param>
            /// <param name="y">The Last number to be added </param>
            /// <returns></returns>
            public int Add(int x, int y) { 
            
                return x + y;
            }


            /// <summary>
            /// Subtracts the second number from the first  number and return the result 
            /// </summary>
            /// <param name="x">The number from which to subtract   </param>
            /// <param name="y">The number to subtract</param>
            /// <returns></returns>
            public int Sub(int x, int y) { 
            
                return x - y;
            }

        }
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Add(1, 2);
            calculator.Sub(2, 3);
        }
    }
}








/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;

namespace PresentationLayer
{
    public partial class frmPeople : Form
    {

        private void _CustomizePeopleDisplayColumns()
        {

            dataGridView1.Columns["Address"].Visible = false;
            dataGridView1.Columns["ImagePath"].Visible = false;

            dataGridView1.Columns["PersonID"].HeaderText = "Person ID";
            dataGridView1.Columns["FirstName"].HeaderText = "First Name";
            dataGridView1.Columns["SecondName"].HeaderText = "Second Name";
            dataGridView1.Columns["ThirdName"].HeaderText = "Third Name";
            dataGridView1.Columns["LastName"].HeaderText = "Last Name";
            dataGridView1.Columns["DateOfBirth"].HeaderText = "Birth Date";
            dataGridView1.Columns["NationalityCountryID"].HeaderText = "Nationality";

        }

        private void  _RefreshPeopleList()
        {

            DataView peopleView = clsPerson.GetAllPeople().DefaultView;
            dataGridView1.DataSource = peopleView;

            if (dataGridView1.Columns.Count > 0 )
                _CustomizePeopleDisplayColumns();


        }

        public frmPeople()
        {
            InitializeComponent();

            _RefreshPeopleList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}*/
