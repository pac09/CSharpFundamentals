﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlFlowDemo.Models;

namespace ControlFlowDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle myCar = new Vehicle()
            {
                Color = "Green",
                ModelName = "Yaris",
                BrandName = "Toyota",
                Year = 2015
            };

            Vehicle familyCar = new Vehicle();
            familyCar.Color = "Red";
            familyCar.ModelName = "Corolla";
            familyCar.BrandName = "Toyota";
            familyCar.Year = 2003;

            vehicles.Add(myCar);
            vehicles.Add(familyCar);

            //for (int i = 0; i < vehicles.Count; i++)
            //{
            //    Console.WriteLine("Color: " + vehicles[i].Color + " Model: " + vehicles[i].ModelName + 
            //        " BrandName: " + vehicles[i].BrandName + " Year: " + vehicles[i].Year);
            //}

            foreach (var element in vehicles)
            {
                Console.WriteLine("Color: " + element.Color + " Model: " + element.ModelName +
                " BrandName: " + element.BrandName + " Year: " + element.Year);
            }

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}