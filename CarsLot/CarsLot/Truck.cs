using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarsLot
{
    internal class Truck : Vechile
    {
        //variables
        private int wheels;
        private int weight;
        private int maxLoad;
        //setter/getter methods
        public int Wheels
        {
            get { return wheels; }
            set { wheels = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int MaxLoad
        {
            get { return maxLoad; }
            set { maxLoad = value; }
        }
        //default constructor
        public Truck()
        {

        }
        //class parameterized constuctor
        public Truck(string id, int price = 0, int model = 0, string manufacturer = "",
            string color = "", int wheels = 0, int weight = 0,
         int maxLoad = 0, bool available = true)
        {
            this.Id = id;
            this.Price = price;
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Color = color;
            this.Wheels = wheels;
            this.Weight = weight;
            this.MaxLoad = maxLoad;
            this.Available = available;
        }

        //declare list
        List<Truck> TruckList = new List<Truck>();
        //appending data into list
        string[] idArr = { "24-512-34", "27-856-78", "98-698-76", "45-243-21", "98-265-43", "34-532-10", "74-178-90", "41-587-65", "78-590-87", "59-623-45" };
        int[] priceArr = { 50000, 100000, 150000, 200000, 250000, 300000, 350000, 400000, 450000, 500000 };
        int[] modelArr = { 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023 };
        string[] manufacturerArr = { "Isuzu", "Scania", "Ford", "Toyota", "Nissan", "Volvo", "Mercedes", "Mitsubishi", "Chevrolet", "Hyundai" };
        string[] colorArr = { "White", "Black", "Red", "Blue", "Green", "red", "Gray", "blue", "black", "Brown" };
        bool[] availableArr = { true, true, true, true, true, true, true, true, true, true };
        int[] wheelsArr = { 10, 12, 8,10,12,16,12,10,14,8 };
        int[] weightArr = { 5000, 6000, 7000, 8000, 9000, 10000,11000,12000,13000,14000 };
        int[] maxLoadArr = { 1000, 2000, 3000, 4000, 5000,6000,7000,8000,9000,10000 };


        //functions
        public override void StoreVechile()
        {
            for (int i = 0; i < idArr.Length; i++)
            {
                //adding data in class member variables through class constructor(pra) with list   
                TruckList.Add(new Truck(idArr[i], priceArr[i], modelArr[i], manufacturerArr[i],
                   colorArr[i], wheelsArr[i], weightArr[i],
                    maxLoadArr[i], availableArr[i]));
            }
        }
        public override void DisplayVechile()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| ID\t\t| Price\t\t| Model\t| Manufacturer\t| Color\t| Wheels | weight | maxload | Available|");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            foreach (Truck truck in TruckList)
            {
                if (truck.Available)
                {
                    Console.WriteLine($"| {truck.Id}\t| {truck.Price,-6}\t| {truck.Model,-5}\t| {truck.Manufacturer,-12}\t| {truck.Color,-5}\t| {truck.Wheels,-6} | {truck.Weight,-6} | {truck.MaxLoad,-7} | {truck.Available,-8} |");

                }

            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.ResetColor();
        }

        public override void RemoveVechile()
        {
            DisplayVechile();
            Console.ForegroundColor = ConsoleColor.Green;
            Truck truckToRemove = null;
            // קוד לבדיקה שהרשימה אינה ריקה
            if (TruckList.Count > 0)
            {
                // קליטת הקלט מהמשתמש
                Console.Write("Enter the ID of the truck you want to remove: ");
                string truckIdToRemove = Console.ReadLine();

                // חיפוש הרכב לפי ה-ID שהוזן
                foreach (Truck truck in TruckList)
                {
                    if (truck.Id == truckIdToRemove)
                    {
                        truckToRemove = truck;
                        break;
                    }
                }

                if (truckToRemove != null)
                {
                    // הסרת הרכב מהרשימה
                    TruckList.Remove(truckToRemove);
                    Console.WriteLine($"truck with ID {truckIdToRemove} has been removed successfully.");

                }
                else
                {
                    Console.WriteLine($"truck with ID {truckIdToRemove} was not found.");
                }
            }
            else
            {
                Console.WriteLine("truck List is empty.");
            }
            Console.ResetColor();
        }

        public override void AddNewVechile()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEnter truck ID:");
            string newId = Console.ReadLine();

            // Check if vehicle ID already exists
            bool idExists = idArr.Contains(newId);
            if (idExists)
            {
                Console.WriteLine("truck ID Already Exists!\n");
                return;
            }

            Truck truck = new Truck();
            truck.Id = newId;

            Console.WriteLine("Enter truck Price:");
            truck.Price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter truck Model:");
            truck.Model = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter truck Manufacturer:");
            truck.Manufacturer = Console.ReadLine();

            Console.WriteLine("Enter truck Color:");
            truck.Color = Console.ReadLine();

            Console.WriteLine("Enter truck wheels amount:");
            truck.Wheels = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter truck weight:");
            truck.Weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter truck max load:");
            truck.MaxLoad = int.Parse(Console.ReadLine());

            truck.Available = true;
            //increasing array size using .Resize() method
            int newLength = idArr.Length + 1;
            Array.Resize(ref idArr, newLength);
            Array.Resize(ref priceArr, newLength);
            Array.Resize(ref modelArr, newLength);
            Array.Resize(ref manufacturerArr, newLength);
            Array.Resize(ref colorArr, newLength);
            Array.Resize(ref wheelsArr, newLength);
            Array.Resize(ref weightArr, newLength);
            Array.Resize(ref maxLoadArr, newLength);
            Array.Resize(ref availableArr, newLength);
            // Adding new item on the last
            int lastIndex = newLength - 1;
            idArr[lastIndex] = newId;
            priceArr[lastIndex] = truck.Price;
            modelArr[lastIndex] = truck.Model;
            manufacturerArr[lastIndex] = truck.Manufacturer;
            colorArr[lastIndex] = truck.Color;
            wheelsArr[lastIndex] = truck.Wheels;
            weightArr[lastIndex] = truck.Weight;
            maxLoadArr[lastIndex] = truck.MaxLoad;
            availableArr[lastIndex] = truck.Available;
            TruckList.Add(new Truck(idArr[lastIndex], priceArr[lastIndex], modelArr[lastIndex], manufacturerArr[lastIndex],
                         colorArr[lastIndex],  wheelsArr[lastIndex], weightArr[lastIndex],
                          maxLoadArr[lastIndex], availableArr[lastIndex]));
            Console.WriteLine("\n New truck Added Successfully!\n");
            DisplayVechile();
            Console.ResetColor();

        }

        public override void BuyVechile()
        {
            DisplayVechile();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEnter truck ID to Buy\n");
            string newId = Console.ReadLine();
            int bill;
            for (int i = 0; i < idArr.Length; i++)
            {
                if (newId == idArr[i])
                {
                    bill = priceArr[i];//calculate bill
                    Customer cus = new Customer();
                    cus.CollectCustomerDetails();
                    Revenue revnue = new Revenue();
                    revnue.AddSaleRevenue(bill);
                    int orderId = revnue.GetNextOrderId();
                    Console.WriteLine($@"------------------------------
|        Buy Details         |
------------------------------
 Order Id     : {orderId}
 truck id     : {idArr[i]}
 Manufacturer : {manufacturerArr[i]}
 price        : {bill}
{cus.ToString()}
------------------------------

|   Thank you for Shopping   |
");
                    Console.Write("------------------------------\n");
                    TruckList[i].Available = false;
                    break;
                }

            }
            Console.ResetColor();
        }

        public override void ShowCheapestVechile()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int cheap = priceArr[0];
            int n = 0;
            for (int i = 0; i < idArr.Length; i++) //iterate through the list
            {
                if (priceArr[i] < cheap)
                {
                    cheap = priceArr[i];  //select the most cheap product 
                    n = i;
                }
            }
    Console.WriteLine("--------------------------------------------------------------------------------------------------------");
    Console.WriteLine("| ID\t\t| Price\t\t| Model\t| Manufacturer\t| Color\t| Wheels | weight | maxload | Available|");
    Console.WriteLine("--------------------------------------------------------------------------------------------------------");
    Console.WriteLine($"| {idArr[n]}\t| {priceArr[n],-6}\t| {modelArr[n],-5}\t| {manufacturerArr[n],-12}\t| {colorArr[n],-5}\t| {wheelsArr[n],-6} | {weightArr[n],-6} | {maxLoadArr[n],-7} | {availableArr[n],-8} |");
    Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.ResetColor();

        }
        public override void ShowExpensiveVechile()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int expensive = priceArr[0];
            int n = 0;
            for (int i = 0; i < idArr.Length; i++) //iterate through the list
            {
                if (priceArr[i] > expensive)
                {
                    expensive = priceArr[i];  //select the most cheap product 
                    n = i;
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| ID\t\t| Price\t\t| Model\t| Manufacturer\t| Color\t| Wheels | weight | maxload | Available|");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"| {idArr[n]}\t| {priceArr[n],-6}\t| {modelArr[n],-5}\t| {manufacturerArr[n],-12}\t| {colorArr[n],-5}\t| {wheelsArr[n],-6} | {weightArr[n],-6} | {maxLoadArr[n],-7} | {availableArr[n],-8} |");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.ResetColor();
        }
        public override void EditVechile()
        {
            DisplayVechile();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEnter truck ID:");
            string idToEdit = Console.ReadLine();

            // Find the index of the vehicle to edit
            int indexToEdit = Array.IndexOf(idArr, idToEdit);
            if (indexToEdit == -1)
            {
                Console.WriteLine("truck ID does not exist!\n");
                return;
            }

            // Edit the vehicle's properties
            Console.WriteLine("Enter truck Price:");
            priceArr[indexToEdit] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter truck Model:");
            modelArr[indexToEdit] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter truck Manufacturer:");
            manufacturerArr[indexToEdit] = Console.ReadLine();

            Console.WriteLine("Enter truck Color:");
            colorArr[indexToEdit] = Console.ReadLine();

            Console.WriteLine("Enter truck wheels amount:");
            wheelsArr[indexToEdit] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter truck weight:");
            weightArr[indexToEdit] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter truck max load:");
            maxLoadArr[indexToEdit] = int.Parse(Console.ReadLine());

            Console.WriteLine("truck details updated successfully!\n");
            Console.ResetColor();

        }
        public override void RentVechile()
        {
            DisplayVechile();
            Console.ForegroundColor = ConsoleColor.Green;
            string type = "truck";
            Console.WriteLine("\nEnter truck ID to Rent\n");
            string newId = Console.ReadLine();
            bool exist = false;
            for (int i = 0; i < idArr.Length; i++)
            {
                if (newId == idArr[i])
                {
                    exist = true;
                    int dailyPrice = 280;
                    Console.WriteLine("hello enter the date you want to pick the truck");
                    Console.WriteLine("enter the day");
                    int pickDay = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the month");
                    int pickMonth = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the year");
                    int pickYear = int.Parse(Console.ReadLine());
                    Date pickDate = new Date(pickDay, pickMonth, pickYear);
                    Console.WriteLine("now enter the date you want to return the truck");
                    Console.WriteLine("enter the day");
                    int returnDay = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the month");
                    int returnMonth = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the year");
                    int returnYear = int.Parse(Console.ReadLine());
                    Date returnDate = new Date(returnDay, returnMonth, returnYear);

                    Date dateInstance = new Date();
                    int totalDays = dateInstance.Difference(pickDate, returnDate);
                    Customer customer = new Customer();
                    customer.CollectCustomerDetails();
                    Rent rent = new Rent(type, dailyPrice, totalDays, customer, pickDate, returnDate, newId);
                    TruckList[i].Available = false;
                    Console.WriteLine(rent.ToString());
                    break;
                }

            }
            if (exist == false)
            {
                Console.WriteLine("\nthe truck id isnt exist");
            }
            Console.ResetColor();

        }

    }
}
