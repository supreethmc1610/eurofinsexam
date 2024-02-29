using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2_Vehicle_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total_sales = 0;
            int retail_sales = 0;
            int corporate_sales = 0;
            int prevdaysale = 0;
            int todaysale = 0;
            int AugToSep15sales = 0;
            int aprilSales = 0;
            int maysales = 0;
            int junesales = 0;
            int julysales = 0;
            int augsales = 0;
            int septsales = 0;
            for(int i = 1; i <= 183; i++)
            {

                todaysale += prevdaysale + 2;
                if (i >= 1 && i <= 31)
                {
                    aprilSales += todaysale;
                }
                else if(i > 31 && i <= 61)
                {
                    maysales += todaysale;
                }
                else if (i > 61 && i <= 92)
                {
                    junesales += todaysale;
                }
                else if (i > 92 && i <= 112)
                {
                    julysales += todaysale;
                }
                else if (i > 112 && i <= 143)
                {
                    augsales += todaysale;
                }
                else
                {
                    septsales += todaysale;
                }
                if (i%5 == 0)
                {
                    corporate_sales += todaysale;
                }
                else
                {
                    retail_sales += todaysale;
                }
                total_sales += todaysale;
                if (i >= 137 && i <= 167)
                {
                    AugToSep15sales += todaysale;
                }
            }
            Console.WriteLine($"April sales : {aprilSales}");

            Console.WriteLine($"may sales : {maysales}");

            Console.WriteLine($"june sales : {junesales}");

            Console.WriteLine($"july sales : {julysales}");

            Console.WriteLine($"aug sales : {augsales}");

            Console.WriteLine($"sept sales : {septsales}");
            Console.WriteLine($"the total sale of the month from April 1st to sept 30 is  : {total_sales}");
            Console.WriteLine($"The number of retail sales is :  {retail_sales}");
            Console.WriteLine($"The number of corporate sales is : {corporate_sales}");
            Console.WriteLine($"From aug 15 to sep 15 the sales are : {AugToSep15sales}");

        }
    }
}
