using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Pool_Club_Project_Idea
{
    public partial class UserControl2 : UserControl
    {
        public enum eStatus { start=0,stop=1 }

        public eStatus _status = eStatus.start;
        public float _hourlyRate {  get; set; }
        public string _TableName = "";
        public string TableName
        {
            get {  return _TableName; }
            set {
                _TableName = value;
                groupBox1.Text = _TableName;
            
            } 
        }

        public string _PlayerName;

        public string PlayerName
        {
            get { return _PlayerName; }
            set
            {

                _PlayerName = value;
                label2.Text = _PlayerName;

            }
        }

        public UserControl2()
        {
            InitializeComponent();
        }
       public class tableArgs : EventArgs
        {
           public int TotalSeconds;
            public float hourlyRate = 100;
            public double TotalFees;
            public string TotalTime;

           
           public tableArgs( float hourlyRate, string totalTime,int TotalSeconds)
            {

                this.hourlyRate = hourlyRate;
                this.TotalFees = TotalSeconds * hourlyRate / (3600);
                this.TotalTime = totalTime;
                this.TotalSeconds = TotalSeconds;
            }
        }

        

        public event EventHandler<tableArgs> EndOfTable;

        private void UserControl2_Load(object sender, EventArgs e)
        {
            //if(DesignMode) return;
            //t.Start();
            //status = eStatus.start;
            //button1.Text = "start";
        }

        public  int TimerCount = 0;
        private void t_Tick(object sender, EventArgs e)
        {

            TimerCount++;
            TimeSpan time = TimeSpan.FromSeconds(TimerCount);
            label1.Text = time.ToString(@"hh\:mm\:ss");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (eStatus.start==_status )
            {
                
                t.Start();
                button1.Text = "stop";
                _status = eStatus.stop;
            }
            else
            {
                t.Stop();
                button1.Text = "start";
                _status = eStatus.start;

            }
                
        }
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Stop();
            EndOfTable?.Invoke(this, new tableArgs( _hourlyRate, label1.Text, TimerCount));
            TimerCount = 0;
            label1.Text = "00:00:00";
            button1.Text = "start";
            _status = eStatus.start;


        }
    }
}
