using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Event_test_1.Caluclater;

namespace Event_test_1
{
    public partial class Caluclater : UserControl
    {


        public class CalculateComplateEventArgs : EventArgs
        {
           public double _AVG = 0;
           public int _Val1 = 0;
           public int _Val2 = 0;
           public int _Val3 = 0;

            public CalculateComplateEventArgs(int Val1, int Val2, int Val3, double AVG)
            {
                _AVG = AVG;
                _Val1 = Val1;
                _Val2 = Val2;
                _Val3 = Val3;

            }

        }


        public event EventHandler<CalculateComplateEventArgs> IsCalculationComplete;

        public void CaluclationComplet(int V1, int V2, int V3, double AVG)
        {
            CalculationComplete(new CalculateComplateEventArgs(V1, V2, V3, AVG));
        }
        protected virtual void CalculationComplete(CalculateComplateEventArgs e)
        {
            IsCalculationComplete?.Invoke(this, e);
        }
        public Caluclater()
        {
            InitializeComponent();
        }


      //protected virtual  void Caluclate(int obj)
      //  {
      //      Action<int > action = OnCaluclationComplet;

      //      if(action != null) action(obj);
      //  }

      
        
        private void button1_Click(object sender, EventArgs e)
        {

            int V1 = int.Parse(textBox1.Text);
            int V2 = int.Parse(textBox2.Text);
            int V3 = int.Parse(textBox3.Text);
            double AVG = (V1 + V2 + V3 ) /3;

            label3.Text = (V1 + V2 + V3).ToString();

            if(IsCalculationComplete != null)
            CaluclationComplet(V1, V2, V3, AVG);


        }

        private void Caluclater_Load(object sender, EventArgs e)
        {

        }
    }
}
