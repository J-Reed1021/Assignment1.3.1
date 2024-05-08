using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Assignment1._3._1
{
    internal class CalculateArea
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter the length of the side of the square: ");
                double side = Convert.ToDouble(Console.ReadLine());

                double area = CalculateArea(side);
                Console.WriteLine("The area of the square is: " + area);
            }

            static double CalculateArea(double side)
            {
                return side * side;



                //Calculate area of triangle




                Console.WriteLine("Enter the length of the rectangle: ");
                double length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the width of the rectangle: ");
                double width = Convert.ToDouble(Console.ReadLine());

                double area = length * width;
                Console.WriteLine("The area of the rectangle is: " + area);

                 CalculateArea(length* width);
                {
                    return length * width;

                }
            }
        }
    }
}    

    

