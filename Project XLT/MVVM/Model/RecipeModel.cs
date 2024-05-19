using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Project_XLT.MVVM.Model
{
    public class RecipeModel
    {
        public string? Title {  get; set; }
        public string? Description { get; set; }
        public Image? Image { get; set; }

        public double Colories { get; set; }
        public double? Proteins { get; set; } = 0;
        public double? Carbs { get; set; } = 0;
        public double? Fats { get; set;}

        public string BJUStatistic { get; set; }

        public RecipeModel(string title, string description, double colories, double proteins, double carbs, double fats)
        {
            Title = title; 
            Description = description;
            Colories = colories;
            Proteins = proteins;
            Carbs = carbs;
            Fats = fats;

            BJUStatistic = $"Жиры - {Fats} г. Белки - {Proteins} г. Углеводы - {Carbs} г. Калории на 100 г - {Colories} калл.";
        }
    }

    static public class RecipeDataBase
    {
        static public ObservableCollection<RecipeModel> Recipes = new ObservableCollection<RecipeModel>()
        {
            new RecipeModel("Камамбер с помидорами",
                "Изумительное угощение к бокалу белого или розового вина! Камамбер с помидорами - это настоящий кулинарный шедевр французский кухни своими руками.",
                277, 10, 4, 25
                ),
            new RecipeModel("Яйца в панировке на сковороде",
                "Такого завтрака вы еще точно не пробовали! Яйца, жареные в панировке на сковороде — блюдо французской кухни, изысканное и в то же время простое в исполнении",
                391, 9, 18, 32
                ),
            new RecipeModel("Картофельные драники с грибами",
                "Простое, но очень вкусное угощение для будней и праздников. Картофельные драники с грибами - это полноценный питательный обед или ужин для всей семьи.",
                119, 3, 15, 6
                ),

        };
    }
}
