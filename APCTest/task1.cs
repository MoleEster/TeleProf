using APCTest.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APCTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();
            cities.Add(new City("Москва"));
            cities.Add(new City("Санкт-Петербург"));
            cities.Add(new City("Самара"));
            cities.Add(new City("Рязань"));
            cities.Add(new City("Владивосток"));
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine($"{cities[i].GetId()}" + "|" + cities[i].GetName());
            }
            Console.ReadLine();
        }
    }
}
