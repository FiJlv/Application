﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BL.Model
{
    [Serializable]
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Callories { get; set; }

        /// <summary>
        /// Белки
        /// </summary>
        public double Proteins { get; set; }
        /// <summary>
        /// Жиры
        /// </summary>
        public double Fats { get; set; }

        /// <summary>
        /// Углеводы
        /// </summary>
        public double Carbonydrates { get; set; }
        /// <summary>
        /// Калорийность на 100 грамм 
        /// </summary>
        public double Calories { get; set; }

        private double CalloriesOneGramm { get { return Calories / 100.0; } }
        private double ProteinsOneGramm { get { return Proteins / 100.0; } }
        private double FatsOneGramm { get { return Fats / 100.0; } }
        private double CarbohydratesOneGramm { get { return Carbonydrates / 100.0; } }
        public Food() { }
        public Food(string name) : this(name, 0, 0, 0, 0) { }
        public Food(string name, double callories, double proteins, double fats, double carbonydrates)
        {
            //TODO proverka
            Name = name;
            Callories = callories / 100.0;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbonydrates = carbonydrates / 100.0;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
