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
        public BitmapImage Icon
        {
            get { return ((BitmapImage)GetValue(IconProperty)); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(BitmapImage), typeof(NavigationRadioButton));


        static NavigationRadioButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NavigationRadioButton), new FrameworkPropertyMetadata(typeof(NavigationRadioButton)));
        }
    }
}
