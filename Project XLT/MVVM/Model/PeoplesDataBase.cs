using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_XLT.MVVM.Model
{
    public class PeoplesDataBase
    {
        public ObservableCollection<Person> PeoplesData = new ObservableCollection<Person>();

        public void GeneratePeoples(int PeoplesCount)
        {
            Random random = new Random();

            string[] names = {"Иван Козаков", "Михаил Каучаков", "Федор Прокофьев",
                                "Влад Дракула", "Tyler Joseph", "Josh Dun"};
            string[] cities = { "Москва", "Санкт-Питербург", "Томск", "New York", "Ohio", "Mexico" };
            
            for(int i = 0;  i < PeoplesCount; i++)
            {
                string name = names[random.Next(0, names.Length)];
                int age = random.Next(0, 50);
                string city = cities[random.Next(0, cities.Length)];
                PeoplesData.Add(new Person(name, age, city));
            }
        }

    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Avatar { get; set; } = "../Images/person.png"; 
        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }
    }
}
