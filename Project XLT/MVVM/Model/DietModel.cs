using Project_XLT.MVVM.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_XLT.MVVM.Model
{
    public class DietBaseModel : ObservableObject
    {
        private DietModel? _choosenDiet;
        public DietModel? ChoosenDiet
        {
            get => _choosenDiet;
            set
            {
                _choosenDiet = value;
                OnPropertyChanged();
            }
        }

        public List<DietModel> DietList = new List<DietModel>()
        {
            new DietModel("Набор мышечной массы", "Программа направленная на набор мышечной массы."),
            new DietModel("Поддержание мышечной массы", "Программа направленная на поддержание мышечной массы. \nВыбирая эту программу вы гарантируете себе милионы деняг и популярность в социальный сетях!"),
            new DietModel("Похудение", "Сжигание жира без ушерба для мышечной массы."),
            new DietModel("Ожирение", "Ну вдруг кому нужно."),
            new DietModel("Витаминка", "Восполнение витаминов."),
            new DietModel("Секретное", "ну реально имба, не веришь?"),
            new DietModel("Галивудский бодибилдинг", "За неделю ты качок, прямо как супергерой из фильмов."),

        };

        public void AddDietsData(DietModel diet)
        {
            DietList.Add(diet);
        }
        public void AddDietsData(List<DietModel> dietBase)
        {
            DietList = dietBase;
        }

    }

    public class DietModel: ObservableObject
    {
        public string DietTitle { get; set; }
        public string DietDescription { get; set; }

        private bool _isDietChoosed;
        public bool IsDietChoosed
        {
            get => _isDietChoosed;
            set
            {
                _isDietChoosed = value;
                OnPropertyChanged();
            }
        }


        public DietModel(string dietTitle, string dietDescription)
        {
            DietTitle = dietTitle;
            DietDescription = dietDescription;
        }
    }
}
