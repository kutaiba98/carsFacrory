using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarsLot
{
    internal class Car : Vechile
    {//virables
        private int doors;
        private bool haveRoof;
        private int numRiders;
        //set/get methods
        public int Doors
        {
            get { return doors; }
            set { doors = value; }
        }
        public bool HaveRoof
        {
            get { return haveRoof; }
            set { haveRoof = value; }
        }
        public int NumRiders
        {
            get { return numRiders; }
            set { numRiders = value; }
        }
        //class default constuctor
        public Car()
        {

        }
        //class parameterized constuctor
        public Car(string id, int price = 0, int model = 0, string manufacturer = "", string color = "",
            int doors = 0, bool haveRoof = false, int numRiders = 0, bool available = true)
        {
            this.Id = id;
            this.Price = price;
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Color = color;
            this.Available = available;
            this.Doors = doors;
            this.HaveRoof = haveRoof;
            this.NumRiders = numRiders;
        }

        //declare list
        List<Car> CarList = new List<Car>();
        //appending data into list
        string[] idArr = { "16-784-11", "12-849-21", "12-945-21", "74-849-38", "12-455-21", "47-789-30", "45-720-36", "124-87-110", "120-80-210", "172-74-147" };
        int[] priceArr = { 35500, 42600, 68000, 58400, 250000, 62000, 80000, 98000, 160000, 1000000 };
        int[] modelArr = { 2013, 2015, 2019, 2010, 2021, 2004, 2017, 2019, 2020, 2014 };
        string[] manufacturerArr = { "Hyundai", "Hyundai", "mazda", "B.M.W", "B.M.W", "camri", "ferrari", "toyota", "cruzie", "supra" };
        string[] colorArr = { "brown", "black", "white", "blue", "white", "green", "pink", "brown", "red", "black" };
        bool[] availableArr = { true, true, true, true, true, true, true, true, true, true };
        int[] doorsArr = { 4, 4, 4, 2, 4, 2, 4, 4, 4, 2 };
        bool[] haveRoofArr = { false, true, true, false, true, false, true, false, true, false };
        int[] numRidersArr = { 5, 5, 5, 4, 5, 5, 2, 2, 5, 2 };


        //overriding the abstract method (ploymorphism)
        public override void StoreVechile()
        {
            for (int i = 0; i < idArr.Length; i++)
            {
                if(CarList!=null)
                //adding data in class member variables through class constructor(pra) with list   
                CarList.Add(new Car(idArr[i], priceArr[i], modelArr[i], manufacturerArr[i], colorArr[i],
                    doorsArr[i], haveRoofArr[i],numRidersArr[i], availableArr[i]));
            }
        }
        public override void DisplayVechile()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| ID\t\t| Price\t\t| Model\t| Manufacturer\t| Color\t| Doors | HaveRoof | NumRiders | Available|");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            foreach (Car car in CarList)
            {
                if (car.Available)
                {
                    Console.WriteLine($"| {car.Id}\t| {car.Price,-6}\t| {car.Model,-5}\t| {car.Manufacturer,-12}\t| {car.Color,-5}\t| {car.Doors,-5} | {car.HaveRoof,-8} | {car.NumRiders,-9} | {car.Available,-8} |");
                }
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.ResetColor();
        }

        public override void RemoveVechile()
        {
            DisplayVechile();
            Console.ForegroundColor = ConsoleColor.Red;
            Car carToRemove = null;
            // קוד לבדיקה שהרשימה אינה ריקה
            if (CarList.Count > 0)
            {
                // קליטת הקלט מהמשתמש
                Console.Write("Enter the ID of the car you want to remove: ");
                string carIdToRemove = Console.ReadLine();

                // חיפוש הרכב לפי ה-ID שהוזן
                foreach (Car car in CarList)
                {
                    if (car.Id == carIdToRemove)
                    {
                        carToRemove = car;
                        break;
                    }
                }

                if (carToRemove != null)
                {
                    // הסרת הרכב מהרשימה
                    CarList.Remove(carToRemove);
                    Console.WriteLine($"Car with ID {carIdToRemove} has been removed successfully.");

                }
                else
                {
                    Console.WriteLine($"Car with ID {carIdToRemove} was not found.");
                }
            }
            else
            {
                Console.WriteLine("Car List is empty.");
            }
            Console.ResetColor();
        }





        public override void AddNewVechile()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEnter car ID:");
            string newId = Console.ReadLine();

            // Check if vehicle ID already exists
            bool idExists = idArr.Contains(newId);
            if (idExists)
            {
                Console.WriteLine("Car ID Already Exists!\n");
                return;
            }

            Car car = new Car();
            car.Id = newId;

            Console.WriteLine("Enter car Price:");
            car.Price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter car Model:");
            car.Model = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter car Manufacturer:");
            car.Manufacturer = Console.ReadLine();

            Console.WriteLine("Enter car Color:");
            car.Color = Console.ReadLine();

            Console.WriteLine("Enter car Doors Amount:");
            car.Doors = int.Parse(Console.ReadLine());

            Console.WriteLine("The car Have Roof:");
            car.HaveRoof = bool.Parse(Console.ReadLine());

            Console.WriteLine("Enter car Riders Amount:");
            car.NumRiders = int.Parse(Console.ReadLine());

            car.Available = true;

            // Resize arrays
            int newLength = idArr.Length + 1;
            Array.Resize(ref idArr, newLength);
            Array.Resize(ref priceArr, newLength);
            Array.Resize(ref modelArr, newLength);
            Array.Resize(ref manufacturerArr, newLength);
            Array.Resize(ref colorArr, newLength);
            Array.Resize(ref doorsArr, newLength);
            Array.Resize(ref haveRoofArr, newLength);
            Array.Resize(ref numRidersArr, newLength);
            Array.Resize(ref availableArr, newLength);

            // Add new vehicle to arrays
            int lastIndex = newLength - 1;
            idArr[lastIndex] = newId;
            priceArr[lastIndex] = car.Price;
            modelArr[lastIndex] = car.Model;
            manufacturerArr[lastIndex] = car.Manufacturer;
            colorArr[lastIndex] = car.Color;
            doorsArr[lastIndex] = car.Doors;
            haveRoofArr[lastIndex] = car.HaveRoof;
            numRidersArr[lastIndex] = car.NumRiders;
            availableArr[lastIndex] = car.Available;

            CarList.Add(new Car(idArr[lastIndex], priceArr[lastIndex], modelArr[lastIndex], manufacturerArr[lastIndex],
            colorArr[lastIndex], doorsArr[lastIndex], haveRoofArr[lastIndex],
             numRidersArr[lastIndex], availableArr[lastIndex]));
           Console.WriteLine("\nNew car Added Successfully!\n");
            DisplayVechile();
            Console.ResetColor();

        }

        public override void BuyVechile()
        {
            DisplayVechile();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEnter car ID to Buy\n");
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
 car id       : {idArr[i]}
 Manufacturer : {manufacturerArr[i]}
 price        : {bill}
{cus.ToString()}
------------------------------

|   Thank you for Shopping   |
");
                    Console.Write("------------------------------\n");
                    CarList[i].Available = false;
                    break;
                }
            }
            Console.ResetColor();
        }
        public override void ShowCheapestVechile()
        {
            Console.ForegroundColor = ConsoleColor.Red;
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
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| ID\t\t| Price\t\t| Model\t| Manufacturer\t| Color\t| Doors | HaveRoof | NumRiders | Available|");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"| {idArr[n]}\t| {priceArr[n],-6}\t| {modelArr[n],-5}\t| {manufacturerArr[n],-12}\t| {colorArr[n],-5}\t| {doorsArr[n],-5} | {haveRoofArr[n],-8} | {numRidersArr[n],-9} | {availableArr[n],-8} |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.ResetColor();

        }
        public override void ShowExpensiveVechile()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int expensive = priceArr[0];
            int n = 0;
            for (int i = 0; i < idArr.Length; i++) //iterate through the list
            {
                if (priceArr[i] > expensive)
                {
                    expensive = priceArr[i];  //select the most expensive product 
                    n = i;
                }
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| ID\t\t| Price\t\t| Model\t| Manufacturer\t| Color\t| Doors | HaveRoof | NumRiders | Available|");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"| {idArr[n]}\t| {priceArr[n],-6}\t| {modelArr[n],-5}\t| {manufacturerArr[n],-12}\t| {colorArr[n],-5}\t| {doorsArr[n],-5} | {haveRoofArr[n],-8} | {numRidersArr[n],-9} | {availableArr[n],-8} |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.ResetColor();
        }

        public override void EditVechile()
        {
            DisplayVechile();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEnter car ID:");
            string idToEdit = Console.ReadLine();

            // Find the index of the vehicle to edit
            int indexToEdit = Array.IndexOf(idArr, idToEdit);
            if (indexToEdit == -1)
            {
                Console.WriteLine("car ID does not exist!\n");
                return;
            }

            // Edit the vehicle's properties
            Console.WriteLine("Enter car Price:");
            priceArr[indexToEdit] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter car Model:");
            modelArr[indexToEdit] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter car Manufacturer:");
            manufacturerArr[indexToEdit] = Console.ReadLine();

            Console.WriteLine("Enter car Color:");
            colorArr[indexToEdit] = Console.ReadLine();

            Console.WriteLine("Enter car Doors Amount:");
            doorsArr[indexToEdit] = int.Parse(Console.ReadLine());

            Console.WriteLine("The car Have Roof:");
            haveRoofArr[indexToEdit] = bool.Parse(Console.ReadLine());

            Console.WriteLine("Enter car Riders Amount:");
            numRidersArr[indexToEdit] = int.Parse(Console.ReadLine());

            Console.WriteLine("car details updated successfully!\n");
            Console.ResetColor();
        }
        public override void RentVechile()
        {
            string type = "car";
            DisplayVechile();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEnter car ID to Rent\n");
            string newId = Console.ReadLine();
            bool exist = false;
            for (int i = 0; i < idArr.Length; i++)
            {
                if (newId == idArr[i])
                {
                    exist = true;
                    int dailyPrice = 150;
                    Console.WriteLine("hello enter the date you want to pick the car");
                    Console.WriteLine("enter the day");
                    int pickDay = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the month");
                    int pickMonth = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the year");
                    int pickYear = int.Parse(Console.ReadLine());
                    Date pickDate = new Date(pickDay, pickMonth, pickYear);
                    Console.WriteLine("now enter the date you want to return the car");
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
                    Rent rent = new Rent(type,dailyPrice, totalDays, customer,pickDate,returnDate, newId);
                    CarList[i].Available = false;
                    Console.WriteLine(rent.ToString());
                    break;
                }
              
            }
            if (exist == false)
            {
                Console.WriteLine("\nthe car id isn't exist");
            }
            Console.ResetColor();
        }
    }
}
