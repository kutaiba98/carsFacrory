using System;
using System.Collections.Generic;
using System.Text;

namespace CarsLot
{
    internal class Revenue
    {
        //static variables
        public static int RevenueAmount;
        public static int OrderId = 0;

        //function that returned amount revenue
        public int AmountRev
        {
            get { return RevenueAmount; }
            set { RevenueAmount = value; }
        }
        //function that adding sale revenue to the amount rev...
        public void AddSaleRevenue(int amt)
        {
            RevenueAmount += amt;
        }
        //function that returned id number and adding 1 to the order id
        public int GetNextOrderId()
        {
            OrderId++;
            return OrderId;
        }

        public void ShowRevenue()
        {
            Console.WriteLine("\nTotal Factory Revenue is: " + AmountRev);
        }

    }

}
