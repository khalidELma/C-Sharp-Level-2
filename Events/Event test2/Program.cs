using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_test2
{
    //public  class TemperatureChangedEventArgs
    //{
    //   public float _OldTemperature{ get; }
    //   public float _NewTemperature { get; }
    //   public float _Diffrence { get;}

    //    public TemperatureChangedEventArgs (float oldTemperature, float newTemperature)
    //    {
    //        this._OldTemperature = oldTemperature;
    //        this._NewTemperature = newTemperature;
    //        this._Diffrence = oldTemperature - newTemperature;
    //    }
    //}

    public class TemperatureChangedEventArgs : EventArgs
    {
        public float _OldTemperature{ get; }
        public float _NewTemperature { get; }
        public float _Diffrence {  get;}


        public TemperatureChangedEventArgs(float oldTemperature, float newTemperature)
        {
            _OldTemperature = oldTemperature;
            _NewTemperature = newTemperature;
            _Diffrence = newTemperature - oldTemperature;
        }

    }
    //public class Temperature
    //{
    //    public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

    //    public float _OldTemperature;
    //    public float _CurrentTemperature;

    //    public  void SetTemperature (float newTemperature)
    //    {
    //        if(newTemperature != _CurrentTemperature)
    //        {
    //            _OldTemperature = _CurrentTemperature;
    //            _CurrentTemperature = newTemperature;
    //            onTemperatureChanged(_OldTemperature, _CurrentTemperature);
    //        }

    //    }
    //    public void onTemperatureChanged(float oldTemperature, float newTemperature)
    //    {
    //        onTemperatureChanged(new TemperatureChangedEventArgs(oldTemperature, newTemperature));
    //    }
    //    public void onTemperatureChanged(TemperatureChangedEventArgs e)
    //    {
    //       TemperatureChanged?.Invoke(this, e); 
    //    }

    //}

    public class Temperature
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        public float _OldTemperature;
        public float _CurrentTemperature;

        public void SetTemperature(float newTemperature) { 

           
            if (_CurrentTemperature != newTemperature)
            {
                _OldTemperature = _CurrentTemperature;
                _CurrentTemperature = newTemperature;
                onTemperatureChanged(_OldTemperature, newTemperature);

            }
        }

           public void onTemperatureChanged(float oldTemperature, float newTemperature)
           {
               onTemperatureChanged(new TemperatureChangedEventArgs(oldTemperature, newTemperature));
           }

        protected virtual void onTemperatureChanged(TemperatureChangedEventArgs e) { 
        
                   this.TemperatureChanged?.Invoke(this, e);
        }


    }
    //public class Display
    //{
    //    public void Subscribe (Temperature Temperature)
    //    {
    //        Temperature.TemperatureChanged += HandelTemperatureChanged;
    //    }
    //    public void HandelTemperatureChanged(object sender, TemperatureChangedEventArgs e)
    //    {
    //        Console.WriteLine("\n\nTemperature changed");
    //        Console.WriteLine($"Temperature changed    from : {e._OldTemperature}C");
    //        Console.WriteLine($"Temperature changed    tov  : {e._NewTemperature}C");
    //        Console.WriteLine($"Temperature Differance      : {e._Diffrence}C");


    //    }
    //}
    public class Display
    {

        public void Subscribe(Temperature T)
        {
            T.TemperatureChanged += HandelTemperatureChanged;
        }

        public void HandelTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine("\n\nTemperature changed");
            Console.WriteLine($"Temperature changed    from : {e._OldTemperature}C");
            Console.WriteLine($"Temperature changed    to   : {e._NewTemperature}C");
            Console.WriteLine($"Temperature Diffrence       : {e._Diffrence}C");


        }




    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Temperature temperature = new Temperature();
            //temperature._OldTemperature = 50;

            //Display display = new Display();
            //display.Subscribe(temperature);

            //temperature.SetTemperature(20);

            //temperature.SetTemperature(50);

            Temperature temperature = new Temperature();
            Display display = new Display();

            display.Subscribe(temperature);
            temperature.SetTemperature(10);
            temperature.SetTemperature(10);
            temperature.SetTemperature(20);
            temperature.SetTemperature(40);
            temperature.SetTemperature(-10);
            temperature.SetTemperature(-200);
            temperature.SetTemperature(1010);

        }
    }
}
