using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLines
{
    class Program
    {

        /// <summary>
        /// pattern your trying to achieve looks like below
        ///              /\
        ///              \/
        /// this represents one and two doubles everything.
        /// </summary>

        static void Main(string[] args)
        {
            for (int i = 0; i <= 6; i++)
            {
                for (int j = 1; j <= 1 + i; j++)
                {
                    Console.Write(@"\");
                }
                Console.Write("\n");

            }
            //***************************
            for (int i = 0; i <= 6; i++)
            {
                for (int j = 1; j <= 7 - i; j++)
                {
                    Console.Write("/");
                }
                Console.Write("\n");

            }
            Console.ReadLine();
        }

    //    ********************************************************
    //    {
    //        Console.WriteLine("Please enter the number of lines in the pattern numerically");
    //        int BigNumber = Convert.ToInt32(Console.ReadLine());

        //        string LeftHandSide = "/";
        //        string rightHandSide = @"\";
        //        string MiddleOfitAll = " ";
        //        //var shapesize = numberOfLines;
        //        var top = LeftHandSide + rightHandSide;
        //        var bottom = rightHandSide + LeftHandSide;

        //        if (BigNumber >= 0)
        //        {

        //            Console.WriteLine(top);
        //            Console.WriteLine(bottom);

        //        }
        //        //Console.ReadLine();

        //        while (int n = 0; n < 5; n++)
        //        {
        //            for (int decreaser = BigNumber - 1; decreaser >= 0; --decreaser)

        //                Console.Write(rightHandSide);
        //            {
        //                for (int a = 0; a < BigNumber; a++)
        //                {
        //                    Console.Write(MiddleOfitAll);
        //                }
        //                for (int i = 0; i < BigNumber; i++)
        //                {
        //                    Console.Write(LeftHandSide);

        //                }
        //                for (int a = 0; a < BigNumber; a++)
        //                {
        //                    Console.Write(rightHandSide);
        //                }

        //            }
        //        }

        //        Console.ReadLine();
        //    }

    }
}
