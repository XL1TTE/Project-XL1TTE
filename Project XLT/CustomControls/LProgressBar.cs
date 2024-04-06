using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_XLT.CustomControls
{
    public class LProgressBar : Control
    {

        public double Percents
        {
            get { return ((double)GetValue(PercentsProperty)); }
            set { SetValue(PercentsProperty, value); }
        }

        public static readonly DependencyProperty PercentsProperty =
            DependencyProperty.Register("Percents", typeof(double), typeof(LProgressBar));



        public string ProgressBarLabel
        {
            get { return (string)GetValue(ProgressBarLabelProperty); }
            set { SetValue(ProgressBarLabelProperty, value); }
        }

       
        public static readonly DependencyProperty ProgressBarLabelProperty =
            DependencyProperty.Register("ProgressBarLabel", typeof(string), typeof(LProgressBar));



        static LProgressBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LProgressBar), new FrameworkPropertyMetadata(typeof(LProgressBar)));
        }
    }
}
