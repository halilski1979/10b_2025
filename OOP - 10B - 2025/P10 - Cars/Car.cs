using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10___Cars
{
    public class Car
    {
		private string brand;
        private string modell;
        private int year;
        private double engineVolume;
        private double price;
		       

        public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}		

		public string Modell
		{
			get { return modell; }
			set { modell = value; }
		}		

		public int Year
		{
			get { return year; }
			set { year = value; }
		}		

		public double EngineVolume
		{
			get { return engineVolume; }
			set { engineVolume = value; }
		}			

		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		public void Print()
		{
            Console.WriteLine($"Avtomobil: {this.Brand} {this.Modell}, godina: {this.Year}, dvigatel: {this.EngineVolume}L, cena:{this.Price} lv.");
		}

		public string GetDescription()
		{
			return $"Marka: {this.Brand}, model: {this.Modell}, godina: {this.Year}, obem: {this.EngineVolume} litra,cena: {this.Price} lv.";
		}

        public override string ToString()
        {
			return $"Car: {this.Brand} {this.Modell}, Year: {this.Year}, Engine: {this.EngineVolume}L, Price: {this.Price} lv.";
        }

        public void IncreasePrice(double percentage)
		{
			this.Price=this.Price+(this.Price*percentage/100);
		}

        public void DecreasePrice(double percentage)
		{
            this.Price = this.Price - (this.Price * percentage / 100);
        }

    }
}
