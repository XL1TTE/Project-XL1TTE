using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Project_XLT.CustomControls
{
    public class NavigationRadioButton: RadioButton
    {
        public BitmapImage IconWhenChecked
        {
            get { return ((BitmapImage)GetValue(IconWhenCheckedProperty)); }
            set { SetValue(IconWhenCheckedProperty, value); }
        }
        public BitmapImage IconWhenUnChecked
        {
            get { return ((BitmapImage)GetValue(IconWhenUnCheckedProperty)); }
            set { SetValue(IconWhenUnCheckedProperty, value); }
        }

        public static readonly DependencyProperty IconWhenCheckedProperty =
            DependencyProperty.Register("IconWhenChecked", typeof(BitmapImage), typeof(NavigationRadioButton));
        public static readonly DependencyProperty IconWhenUnCheckedProperty =
            DependencyProperty.Register("IconWhenUnChecked", typeof(BitmapImage), typeof(NavigationRadioButton));


        static NavigationRadioButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NavigationRadioButton), new FrameworkPropertyMetadata(typeof(NavigationRadioButton)));
        }
    }
}
