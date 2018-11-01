using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tippy4000
{
    class Calculate
    {
        
        public Calculate()
        {
            Displaytext();
        }

        private void Displaytext()
        {
            double billAmount = 0;
            double tipAmount = 0;

            Console.Clear();
            Console.WriteLine("What is your bill amount?");

            try
            {
                billAmount = Double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Enter a valid amount...");
                Console.ReadLine();
                Displaytext();
            }

            Console.WriteLine("how much would you like to tip?");
            Console.WriteLine("1) 10%");
            Console.WriteLine("2) 15%");
            Console.WriteLine("3) 75%");

            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    tipAmount = .10;
                    break;
                case 2:
                    tipAmount = .15;
                    break;
                case 3:
                    tipAmount = .75;
                    break;

            }

            CalculateTip(billAmount,tipAmount);
        }

        private void CalculateTip(double billAmount, double tipAmount)
        {
            double calculatedTip = billAmount * tipAmount;
            double finalAmount = billAmount + calculatedTip;

            PrintResults(calculatedTip, finalAmount);
        }

        private void PrintResults(double calculatedTip, double finalAmount)
        {
            Console.Clear();
            Console.WriteLine("Your tip should be: $"+calculatedTip);
            Console.WriteLine("Your final total is: $"+finalAmount);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Displaytext();
        }

    }
}
