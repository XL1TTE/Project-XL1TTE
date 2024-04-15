using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_XLT.MVVM.Model
{
    public class Product
    {
        public string Title { get; set; }

        private double? _gramms = 100;
        public double? Gramms
        {
            get
            {
                return _gramms;
            } 
            set
            {
                ColoriesSum = Colories * (value / 100);
                Minerals = Minerals * (value / 100);
                Water = Water * (value / 100);
                Proteins = Proteins * (value / 100);
                Carbs = Carbs * (value / 100);
                Vitamins = Vitamins * (value / 100);
                Fats = Fats * (value / 100);
                _gramms = value;
            } 
        }
        public double? ColoriesSum { get; set; }
        public double? Colories { get; set; }
        public string Image { get; set; } = "../Images/eat.png";
        public double? Minerals { get; set; } = 0;
        public double? Water { get; set; } = 0;
        public double? Proteins { get; set; } = 0;
        public double? Carbs { get; set; } = 0;
        public double? Vitamins { get; set; } = 0;
        public double? Fats { get; set; } = 0;

        public string BJUStatictis { get; set; }

        public Product(string title, double? Colories, (double Carbs, double Proteins, double Fats, double? Minerals, double? Vitamins, double? Water) BJU)
        {
            Title = title;

            Carbs = BJU.Carbs;
            Proteins = BJU.Proteins;
            Fats = BJU.Fats;

            if(BJU.Minerals != null) { Minerals = BJU.Minerals; }
            if (BJU.Vitamins != null) { Vitamins = BJU.Vitamins; }
            if (BJU.Water != null) { Water = BJU.Water; }

            BJUStatictis = $"В 100г: {Carbs}г. углеводов, {Proteins}г. белков, {Fats}г. жиров.";
        }
    }
}
