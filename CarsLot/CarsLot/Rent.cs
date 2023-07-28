using System;
using System.Collections.Generic;
using System.Text;

namespace CarsLot
{
    internal class Rent
    {
        //class variables
        string type;
        int dailyPrice;
        int totalDays;
        string vechileId;
        Customer customer;
        Date pickDate;
        Date returnDate;
        //get / set methods
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int DailyPrice
        {
            get { return dailyPrice; }
            set { dailyPrice = value; }
        }
        public int TotalDays
        {
            get { return totalDays; }
            set { totalDays = value; }
        }
        public string VechileId
        {
            get { return vechileId; }
            set { vechileId = value; }
        }
 
        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        public Date PickDate
        {
            get { return pickDate; }
            set { pickDate = value; }
        }
        public Date ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
        //default constructor
        public Rent()
        {

        }
        //class parameterized constructor
        public Rent(string type, int dailyPrice, int totalDays, Customer customer, Date pickDate, Date returnDate, string vechileId)
        {
            this.Type = type;
            this.DailyPrice = dailyPrice;
            this.TotalDays = totalDays;
            this.Customer = customer;
            this.PickDate = pickDate;
            this.ReturnDate = returnDate;
            this.VechileId = vechileId;
        }
        //פונקצייה מחזירה מחיר כללי להשכרה
        public int GetPrice()
        {
            int price = totalDays * dailyPrice;
            Revenue revenue = new Revenue();
            revenue.AddSaleRevenue(price);
            int orderid = revenue.GetNextOrderId();
            return price;//add bill to revenue
        }

        public override string ToString()
        {
            return $@"------------------------------
|---------Rent Details-------|
------------------------------
| vechile type    :{type}
| Customer name   : {Customer.Name}
| Customer email  : {Customer.Email}
| Customer address: {Customer.Address}
| Customer number : {Customer.Number}
| Vehicle ID      : {VechileId}
| Daily Price     : {DailyPrice}
| Total Days      : {TotalDays}
| price           : {GetPrice()}
| Pick Date       : {PickDate}
| Return Date     : {ReturnDate}
| order id        : {Revenue.OrderId}
------------------------------";

        }

    }
}