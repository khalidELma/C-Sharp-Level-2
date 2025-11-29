using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Example
{
    public class Point
    {

        public int X {  get; set; }
        public int Y { get; set; }

      public   Point (int x ,int y ) {
        
            X = x;
            Y = y;
        }


        static public Point operator +(Point p1, Point p2) {

            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        
        }
        
        static public Point operator -(Point p1, Point p2)
        {
            return new Point((p1.X - p2.X), (p1.Y - p2.Y));
        }

        static public Point operator *(Point p1, Point p2)
        {

            return new Point(p1.X * p2.X, p1.Y * p2.Y);

        }
        
        static public Point operator /(Point p1, Point p2)
        {
            int Value = 0;
            return new Point((Value = (p2.X == 0) ? 0 : (p1.X / p2.X)), Value = (p2.Y == 0) ? 0 : (p1.Y / p2.Y));
        }

        static public bool operator ==(Point p1, Point p2)
        {
            return (p1.X == p2.X) && (p1.Y == p2.Y);
        }

        static public bool operator !=(Point p1, Point p2)
        {
            return (p1.X != p2.X) || (p1.Y != p2.Y);
        }

        static public Point operator ++(Point p1)
        {

            return new Point(p1.X++ , p1.Y++);

        }

        static public Point operator --(Point p1)
        {

            return new Point(p1.X--, p1.Y--);

        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }




    }

    internal class Program
    {



        static void Main(string[] args)
        {

            Point p1 =new Point(1, 2);
            Console.WriteLine( p1.ToString());



            Point p2 = new Point(3, 4);
            Console.WriteLine( p2.ToString());
            
            
            Point p3 = p1 +p2;
            Console.WriteLine(p3.ToString());


            p3 = p1 -p2;
            Console.WriteLine(p3.ToString());


            p3 = p1 *p2;
            Console.WriteLine(p3.ToString());


            p3 = p2/p1;
            Console.WriteLine(p3.ToString()) ;

            p3 = p2-- / p1++;
            Console.WriteLine(p3.ToString());

            p3 = p2++ / p1--;
            Console.WriteLine(p3.ToString());



            if (p3 == p2)
            {


                Console.WriteLine("Yes ,p3= p2");

            }
            else if (p3 != p2)
            {

                Console.WriteLine("Yes ,p3 != p2");

            }





        }
    }
}
