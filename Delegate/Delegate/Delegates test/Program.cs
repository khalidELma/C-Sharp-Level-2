using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_test
{
    internal class Program
    {

        class ball
        {

            private int _Location;
            public int Location
            {
                get => _Location;
                set
                {
                    if (_Location != value)
                    {
                        _Location = value;
                        OnLocationChanged?.Invoke(_Location);
                    }
                }
            }

            
            public delegate void ball_delegate(int x);
            public ball_delegate OnLocationChanged;
        }

        public class Refree
        {
           public void PrintRefree(int x) => Console.WriteLine("1 = " + x);
        }

        public class audience {

            public void Printaudience(int x) => Console.WriteLine("2 = "+x);

        }

        public class Player
        {
            public void PrintPlayer(int x) => Console.WriteLine("3 = " + x);


        }

        static void Main(string[] args)
        {

            ball ball1 = new ball();
            
            Player player1 = new Player();
            audience audience1 = new audience();
            Refree refree1 = new Refree();







            ball1.OnLocationChanged += audience1.Printaudience;
            ball1.Location = 2;

            ball1.OnLocationChanged -= audience1.Printaudience;

            

            ball1.OnLocationChanged += refree1.PrintRefree;
            ball1.Location = 1;
            ball1.OnLocationChanged -= refree1.PrintRefree;


            ball1.OnLocationChanged += player1.PrintPlayer;

            ball1.Location = 3;
            ball1.OnLocationChanged -= player1.PrintPlayer;





        }
    }
}
