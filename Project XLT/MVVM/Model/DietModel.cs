using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_XLT.MVVM.Model
{
    public class DietBaseModel
    {

        public List<DietModel> DietList = new List<DietModel>()
        {
            new DietModel("Набор мышечной массы", "Программа направленная на набор мышечной массы."),
            new DietModel("Поддержание мышечной массы", "Программа направленная на поддержание мышечной массы. \nВыбирая эту программу вы гарантируете себе милионы деняг и популярность в социальный сетях!"),
            new DietModel("Похудение", "Сжигание жира без ушерба для мышечной массы."),
        };

        public void AddDietsData(DietModel diet)
        {
            DietList.Add(diet);
        }
        public void AddDietsData(List<DietModel> dietBase)
        {
            DietList = dietBase;
        }

        public DietBaseModel()
        {

        }
    }

    public class DietModel
    {
        public string DietTitle { get; set; }
        public string DietDescription { get; set; }

        public DietModel(string dietTitle, string dietDescription)
        {
            DietTitle = dietTitle;
            DietDescription = dietDescription;
        }
    }
}
