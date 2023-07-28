using System;
using System.Collections.Generic;
using System.Text;

namespace CarsLot
{
    abstract class Vechile
    {
        private string id;
        private int price;
        private int model;
        private string manufacturer;
        private string color;
        private bool available;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public bool Available
        {
            get { return available; }
            set { available = value; }
        }
        //declare abstract methods
        public abstract void StoreVechile();
        public abstract void DisplayVechile();
        public abstract void RemoveVechile();
        public abstract void AddNewVechile();
        public abstract void BuyVechile();
        public abstract void EditVechile();
        public abstract void ShowCheapestVechile();
        public abstract void ShowExpensiveVechile();
        public abstract void RentVechile();
       
    }
}
