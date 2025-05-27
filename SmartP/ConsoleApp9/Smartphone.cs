using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Smartphone
    {
		private string brand;
        private string model;
        private int releaseYear;
        private int storage;
        private double price;

        public Smartphone(string brand, string model, int releaseYear, int storage, double price)
        {
            this.Brand = brand;
            this.Model = model;
            this.ReleaseYear = releaseYear;
            this.Storage = storage;
            this.Price = price;
        }

		public Smartphone()
		{
			brand = "Unknown";
			model = "Unknown";
			releaseYear = 0;
			storage = 0;
			price = 0.0;
		}

        public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

		

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		

		public int ReleaseYear
		{
			get { return releaseYear; }
			set { releaseYear = value; }
		}

		

		public int Storage
		{
			get { return storage; }
			set { storage = value; }
		}

		

		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		public void Print()
		{
			Console.WriteLine($"Smartphone: {this.Brand} {this.Model}, Year: {this.ReleaseYear}, Storage:{this.Storage}GB, Price: {this.Price} lv.;");
		}

		public void IncreasePrice (double percentage)
		{
			price += price * (percentage / 100);
		}

		public void DecreasePrice(double percentage)
		{
			price -= price * (percentage / 100);
		}

        public override string ToString()
        {
			return $"Smartphone: {this.Brand} {this.Model}, Year: {this.ReleaseYear}, Storage:{this.Storage}GB, Price: {this.Price} lv.;";
        }






    }
}
