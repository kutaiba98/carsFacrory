using System;

namespace CarsLot
{
    class Program
    {

        static void Main(string[] args)
        {
            const string Password = "admin";
            int choice;
            int type;
            string option;
            //instance of child class footwear from parent class Product(abstract)  
            Vechile Cars = new Car();
            Vechile Motors = new Motor();
            Vechile Trucks = new Truck();
            Revenue revenue = new Revenue();
            Cars.StoreVechile();
            Motors.StoreVechile();
            Trucks.StoreVechile();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\t\t\t*************Welcome To Cars Lot*************");
            Console.ResetColor();
            /*****************************************************/

            while (true)
            {
                choice = MenuChoice();
                switch (choice)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nAll the Cars\n");
                        Cars.DisplayVechile();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nAll the Motors\n");
                        Motors.DisplayVechile();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nAll the Trucks\n");
                        Trucks.DisplayVechile();
                        Console.ResetColor();

                        break;
                    case 1:
                        option = "Buying";
                        type = TypeOfVechile(option);
                        switch (type)
                        {
                            case 0:
                                Cars.BuyVechile();
                                break;
                            case 1:
                                Motors.BuyVechile();
                                break;
                            case 2:
                                Trucks.BuyVechile();
                                break;
                        }
                        break;
                    case 2:
                        option = "Adding";
                        if (ValidatePassword(Password))
                        {
                            type = TypeOfVechile(option);
                            switch (type)
                            {
                                case 0:
                                    Cars.AddNewVechile();
                                    break;
                                case 1:
                                    Motors.AddNewVechile();
                                    break;
                                case 2:
                                    Trucks.AddNewVechile();
                                    break;
                            }
                        }
                        else
                            Console.WriteLine("wrong password Please try again later");
                        break;
                    case 3:
                        option = "Removing";
                        if (ValidatePassword(Password))
                        {
                            type = TypeOfVechile(option);
                            switch (type)
                            {
                                case 0:
                                    Cars.RemoveVechile();
                                    break;
                                case 1:
                                    Motors.RemoveVechile();
                                    break;
                                case 2:
                                    Trucks.RemoveVechile();
                                    break;
                            }
                        }
                        else
                            Console.WriteLine("wrong password Please try again later");
                        break;
                    case 4:
                        option = "Editing";
                        if (ValidatePassword(Password))
                        {
                            type = TypeOfVechile(option);
                            switch (type)
                            {
                                case 0:
                                    Cars.EditVechile();
                                    break;
                                case 1:
                                    Motors.EditVechile();
                                    break;
                                case 2:
                                    Trucks.EditVechile();
                                    break;
                            }
                        }
                        else
                            Console.WriteLine("wrong password Please try again later");
                        break;
                    case 5:
                        option = "Showing Most Expinsive";
                        type = TypeOfVechile(option);
                        switch (type)
                        {
                            case 0:
                                Cars.ShowExpensiveVechile();
                                break;
                            case 1:
                                Motors.ShowExpensiveVechile();
                                break;
                            case 2:
                                Trucks.ShowExpensiveVechile();
                                break;
                        }
                        break;
                    case 6:
                        option = "Showing cheapest";
                        type = TypeOfVechile(option);
                        switch (type)
                        {
                            case 0:
                                Cars.ShowCheapestVechile();
                                break;
                            case 1:
                                Motors.ShowCheapestVechile();
                                break;
                            case 2:
                                Trucks.ShowCheapestVechile();
                                break;
                        }
                        break;
                    case 7:
                        if (ValidatePassword(Password))
                        {
                            revenue.ShowRevenue();
                        }
                        else
                            Console.WriteLine("wrong password Please try again later");
                        break;
                    case 8:
                        option = "Renting";
                        type = TypeOfVechile(option);
                        switch (type)
                        {
                            case 0:
                                Cars.RentVechile();
                                break;
                            case 1:
                                Motors.RentVechile();
                                break;
                            case 2:
                                Trucks.RentVechile();
                                break;
                        }
                        break;
                    case 9:
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
                if (choice == 9)
                {
                    break;
                }
            }
        }

        static int MenuChoice()
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine(@"Press 0 For Display All vechiles
Press 1 For Buying vechile
Press 2 For Add new vechile
Press 3 For Removing vechile
Press 4 For Editing vechile
Press 5 To View Most Expensive vechile
Press 6 To View Most Cheap vechile
Press 7 To View Total Factory Revenue
Press 8 for renting vechile
Press 9 To Exit");
            Console.WriteLine("\nEnter your choice");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        static int TypeOfVechile(string str)
        {

            Console.WriteLine(@$"enter the type of vechile:
press 0 for {str} a car
press 1 for {str} a motor
press 2 for {str} a truck
");
            Console.WriteLine("\nEnter your choice");
            int type = int.Parse(Console.ReadLine());
            return type;
        }

        static bool ValidatePassword(string Password)
        {
            Console.WriteLine("enter the password to continue");
            string pw = Console.ReadLine();
            if (pw == Password)
            {
                return true;
            }
            return false;
        }
    }
}
