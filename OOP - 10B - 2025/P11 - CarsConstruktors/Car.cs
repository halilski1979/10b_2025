using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11___CarsConstruktors
{
    public class Car
    {
        // Частни полета
        private string brand;
        private string model;
        private int year;
        private double engineVolume;
        private double price;

        // Конструктор по подразбиране
        public Car()
        {
            brand = "Unknown";
            model = "Unknown";
            year = 2000;
            engineVolume = 1.0;
            price = 10000;
        }

        // Конструктор с параметри
        public Car(string brand, string model, int year, double engineVolume, double price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.EngineVolume = engineVolume;
            this.Price = price;
        }

        // Пропърти за достъп
        public string Brand { get { return brand; } set { brand = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Year { get { return year; } set { year = value; } }
        public double EngineVolume { get { return engineVolume; } set { engineVolume = value; } }
        public double Price { get { return price; } set { price = value; } }

        // Метод за отпечатване на информация за автомобила
        public void Print()
        {
            Console.WriteLine($"Avtomobil: {brand} {model}, godina: {year}, dvigatel: {engineVolume}L, cena: {price} lv.");
        }

        // Метод за връщане на описание на автомобила
        public string GetDescription()
        {
            return $"Marka: {brand}, model: {model}, godina: {year}, obem: {engineVolume} litra, cena: {price} lv.";
        }

        // Метод за увеличаване на цената
        public void IncreasePrice(double percentage)
        {
            price += price * (percentage / 100);
        }

        // Метод за намаляване на цената
        public void DecreasePrice(double percentage)
        {
            price -= price * (percentage / 100);
        }

        // Метод за връщане на информация на английски
        public override string ToString()
        {
            return $"Car: {brand} {model}, Year: {year}, Engine: {engineVolume}L, Price: {price} lv.";
        }
    }
}
