using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_XLT.MVVM.Model
{
    static public class LocalFoodDataBase
    {
        static public ObservableCollection<Product> Products = new ObservableCollection<Product>()
        {
            new Product("Гречневая крупа", 308, (57.1, 12.6, 3.3, 0,0,14)),
            new Product("Грудка цыпленка-бройлера", 116, (3.3, 19.6, 4.1, 0,0,75)),
            new Product("BURGER KING гамбургер", 261 , (25.8, 14.9, 10.6, 0,0,46 ))

        };
    }
}
