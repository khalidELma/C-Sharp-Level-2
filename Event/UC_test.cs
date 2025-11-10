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
    public partial class UC_test : UserControl
    {
        public struct PersonInfo
        {
            public string Name;
            public int Age;
            public string Phone;
            public string Email;
            public string Address;
            public string Country;


        }

        public PersonInfo getPersonInfo()
        {
            PersonInfo Person= new PersonInfo();
            Person.Name = "Khalid Elmandour";
            Person.Age = 19;
            Person.Phone = "0770457505";
            Person.Email = "khalidElmandour2006@gmail.com";
            Person.Address = "1544 amgad St ";
            Person.Country = "Morocco";
            return Person;

        }

        



        public event Action<PersonInfo> OnPersonIsFound;


        public virtual void PersonIsFound(PersonInfo Person)
        {

            Action<PersonInfo> handler = OnPersonIsFound;

            if (handler != null)
            {
                handler(Person);
            }

        }

       

        public UC_test()
        {
            InitializeComponent();
        }

        private void UC_test_Load(object sender, EventArgs e)
        {

        }

        private void FindBu_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "khalid elmandour")
            {
                if(OnPersonIsFound != null)
                PersonIsFound(getPersonInfo());
            }
        }
    }
}
