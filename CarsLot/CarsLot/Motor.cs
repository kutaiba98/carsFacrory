using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarsLot
{
    internal class Motor : Vechile
    {
        //variables
        private string subModel;
        private string license;

        //setter /getter methods
        public string SubModel
        {
            get { return subModel; }
            set { this.subModel = value; }
        }
        public string License
        {
            get { return license; }
            set { this.license = value; }
        }
        //default constructor
        public Motor()
        {

        }
        //class parameterized constuctor
        public Motor(string id, int price = 0, int model = 0, string manufacturer = "",
        string color = "", string subModel = "",
         string license = "", bool available = true)
        {
            this.Id = id;
            this.Price = price;
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Color = color;
            this.SubModel = subModel;
            this.License = license;
            this.Available = available;
        }

        //declare list
        List<Motor> MotorList = new List<Motor>();
        //appending data into list
        string[] idArr = { "12-852-52", "78-888-46", "18-145-52", "19-252-92", "56-156-52", "70-527-52", "71-652-52", "16-745-25", "10-785-20", "56-412-92" };
        int[] priceArr = { 120000, 25000, 65000, 160000, 18500, 200000, 35000, 60000, 37000, 45000 };
        int[] modelArr = { 2018, 2016, 2019, 2013, 2015, 2016, 2010, 2014, 2019, 2010 };
        string[] manufacturerArr = { "yamaha", "Suzuki", "honda", "BMW", "kawazaki", "Harley", "KTM", "Royal", "Triumph", "Ducati" };
        string[] colorArr = { "blue", "red", "white", "black", "white", "green", "blue", "gold", "black", "red" };
        bool[] availableArr = { true, true, true, true, true, true, true, true, true, true };
        string[] subModelArr = { "R6", "gxsr", "cbr", "s1000rr", "z900", "harly", "450", "650", "Tiger", "Diavel" };
        string[] licenseArr = { "A", "A", "A1", "A", "A1", "A", "A1", "A1", "A1", "A" };
      
        //functions

        //overriding the abstract method (ploymorphism)
        public override void StoreVechile()
        {
            for (int i = 0; i < idArr.Length; i++)
            {
                //adding data in class member variables through class constructor(pra) with list   
                MotorList.Add(new Motor(idArr[i], priceArr[i], modelArr[i], manufacturerArr[i], 
                   colorArr[i], subModelArr[i], licenseArr[i], availableArr[i]));
            }
        }

        public override void DisplayVechile()
        {

                    Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("| ID\t\t| Price\t\t| Model\t| Manufacturer\t| Color\t| subModel | license | Available|");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            foreach (Motor motor in MotorList)
            {
                if (motor.Available)
                {
                    Console.WriteLine($"| {motor.Id}\t| {motor.Price,-6}\t| {motor.Model,-5}\t| {motor.Manufacturer,-12}\t| {motor.Color,-5}\t| {motor.subModel,-8} | {motor.license,-7} | {motor.Available,-8} |");
                }
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
                    Console.ResetColor();
        }
        public override void RemoveVechile()
        {
            DisplayVechile();
            Console.ForegroundColor = ConsoleColor.Blue;
            Motor motorToRemove = null;
            // קוד לבדיקה שהרשימה אינה ריקה
            if (MotorList.Count > 0)
            {
                // קליטת הקלט מהמשתמש
                Console.Write("Enter the ID of the motor you want to remove: ");
                string motorIdToRemove = Console.ReadLine();

                // חיפוש הרכב לפי ה-ID שהוזן
                foreach (Motor motor in MotorList)
                {
                    if (motor.Id == motorIdToRemove)
                    {
                        motorToRemove = motor;
                        break;
                    }
                }

                if (motorToRemove != null)
                {
                    // הסרת הרכב מהרשימה
                    MotorList.Remove(motorToRemove);
                    Console.WriteLine($"motor with ID {motorIdToRemove} has been removed successfully.");

                }
                else
                {
                    Console.WriteLine($"motor with ID {motorIdToRemove} was not found.");
                }
            }
            else
            {
                Console.WriteLine("motor List is empty.");
            }
            Console.ResetColor();
        }

        public override void AddNewVechile()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nEnter motor ID:");
            string newId = Console.ReadLine();

            // Check if vehicle ID already exists
            bool idExists = idArr.Contains(newId);
            if (idExists)
            {
                Console.WriteLine("motor ID Already Exists!\n");
                return;
            }

            Motor motor = new Motor();
            motor.Id = newId;

            Console.WriteLine("Enter motor Price:");
            motor.Price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter motor Model:");
            motor.Model = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter motor Manufacturer:");
            motor.Manufacturer = Console.ReadLine();

            Console.WriteLine("Enter motor Color:");
            motor.Color = Console.ReadLine();

            Console.WriteLine("Enter motor Color:");
            motor.SubModel = Console.ReadLine();

            Console.WriteLine("Enter motor Color:");
            motor.License = Console.ReadLine();

            motor.Available = true;


            //increasing array size using .Resize() method
            int newLength = idArr.Length + 1;
            Array.Resize(ref idArr, newLength);
            Array.Resize(ref priceArr, newLength);
            Array.Resize(ref modelArr, newLength);
            Array.Resize(ref manufacturerArr, newLength);
            Array.Resize(ref colorArr, newLength);
            Array.Resize(ref subModelArr, newLength);
            Array.Resize(ref licenseArr, newLength);
            Array.Resize(ref availableArr, newLength);
            // Adding new item on the last
            int lastIndex = newLength - 1;
            idArr[lastIndex] = newId;
            priceArr[lastIndex] = motor.Price;
            modelArr[lastIndex] = motor.Model;
            manufacturerArr[lastIndex] = motor.Manufacturer;
            colorArr[lastIndex] = motor.Color;
            subModelArr[lastIndex] = motor.SubModel;
            licenseArr[lastIndex] = motor.License;
            availableArr[lastIndex] = motor.Available;
            MotorList.Add(new Motor(idArr[lastIndex], priceArr[lastIndex], modelArr[lastIndex], manufacturerArr[lastIndex]
                              , colorArr[lastIndex], subModelArr[lastIndex], licenseArr[lastIndex], availableArr[lastIndex]));
            Console.WriteLine("\n New motor Added Successfully!\n");
            DisplayVechile();
            Console.ResetColor();

        }

        public override void BuyVechile()
        {
            DisplayVechile();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nEnter motor ID to Buy\n");
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
 motor id     : {idArr[i]}
 Manufacturer : {manufacturerArr[i]}
 price        : {bill}
{cus.ToString()}
------------------------------

|   Thank you for Shopping   |
");
                    Console.Write("------------------------------\n");
                    MotorList[i].Available = false;
                    break;
                }
            }
            Console.ResetColor();
        }
        public override void ShowCheapestVechile()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("| ID\t\t| Price\t\t| Model\t| Manufacturer\t| Color\t| subModel | license | Available|");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine($"| {idArr[n]}\t| {priceArr[n],-6}\t| {modelArr[n],-5}\t| {manufacturerArr[n],-12}\t| {colorArr[n],-5}\t| {subModelArr[n],-8} | {licenseArr[n],-7} | {availableArr[n],-8} |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.ResetColor();
        }
        public override void ShowExpensiveVechile()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("| ID\t\t| Price\t\t| Model\t| Manufacturer\t| Color\t| subModel | license | Available|");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine($"| {idArr[n]}\t| {priceArr[n],-6}\t| {modelArr[n],-5}\t| {manufacturerArr[n],-12}\t| {colorArr[n],-5}\t| {subModelArr[n],-8} | {licenseArr[n],-7} | {availableArr[n],-8} |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.ResetColor();
        }
        public override void EditVechile()
        {
            DisplayVechile();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nEnter motor ID:");
            string idToEdit = Console.ReadLine();

            // Find the index of the vehicle to edit
            int indexToEdit = Array.IndexOf(idArr, idToEdit);
            if (indexToEdit == -1)
            {
                Console.WriteLine("motor ID does not exist!\n");
                return;
            }

            // Edit the vehicle's properties
            Console.WriteLine("Enter motor Price:");
            priceArr[indexToEdit] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter motor Model:");
            modelArr[indexToEdit] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter motor Manufacturer:");
            manufacturerArr[indexToEdit] = Console.ReadLine();

            Console.WriteLine("Enter motor Color:");
            colorArr[indexToEdit] = Console.ReadLine();

            Console.WriteLine("Enter motor sub model:");
            subModelArr[indexToEdit] = Console.ReadLine();

            Console.WriteLine("Enter motor license:");
            licenseArr[indexToEdit] = Console.ReadLine();

            Console.WriteLine("motor details updated successfully!\n");
            Console.ResetColor();

        }
        public override void RentVechile()
        {
            string type = "motor";
            DisplayVechile();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nEnter motor ID to Rent\n");
            string newId = Console.ReadLine();
            bool exist = false;
            for (int i = 0; i < idArr.Length; i++)
            {
                if (newId == idArr[i])
                {
                    exist = true;
                    int dailyPrice = 90;
                    Console.WriteLine("hello enter the date you want to pick the motor");
                    Console.WriteLine("enter the day");
                    int pickDay = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the month");
                    int pickMonth = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the year");
                    int pickYear = int.Parse(Console.ReadLine());
                    Date pickDate = new Date(pickDay, pickMonth, pickYear);
                    Console.WriteLine("now enter the date you want to return the motor");
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
                    Rent rent = new Rent(type,dailyPrice, totalDays, customer, pickDate, returnDate, newId);
                    MotorList[i].Available = false;
                    Console.WriteLine(rent.ToString());
                    break;
                }

            }
            if(exist==false)
            {
                Console.WriteLine("\nthe motor id isn't exist");
            }
            Console.ResetColor();
        }

    }
}
