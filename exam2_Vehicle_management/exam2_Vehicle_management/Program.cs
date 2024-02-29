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
            int prevdaysale = 1;
            int todaysale = 0;
            int AugToSep15sales = 0;
            int aprilSales = 0;
            int maysales = 0;
            int junesales = 0;
            int julysales = 0;
            int augsales = 0;
            int septsales = 0;
            int day = 0;
            for(int i = 1; i <= 183; i++)
            {
                todaysale = prevdaysale + (day*2);
                if (i >= 1 && i <= 30)
                {
                    aprilSales += todaysale;
                    if(i == 30){
                        day = 0;
                        prevdaysale = 1;
                    }
                }
                else if(i > 30 && i <= 61)
                {
                    maysales += todaysale;
                    if(i == 61){
                    day = 0;
                    prevdaysale = 1;
                    }
                }
                else if (i > 61 && i <= 91)
                {
                    junesales += todaysale;
                    if(i == 91){
                    day = 0;
                    prevdaysale = 1;
                    }
                }
                else if (i > 91 && i <= 112)
                {
                    julysales += todaysale;
                    if(i == 112){
                    day = 0;
                        prevdaysale = 1;
                    }
                }
                else if (i > 112 && i <= 143)
                {
                    augsales += todaysale;
                    if(i == 143){
                    day = 0;
                        prevdaysale = 1;
                    }
                }
                else
                {
                    septsales += todaysale;
                }
                
                
                if(day%4 == 0 && day!= 0){
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
                day++;
                prevdaysale = todaysale;
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
