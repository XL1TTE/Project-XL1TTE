﻿using Project_XLT.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Project_XLT.CustomControls
{
    public class Resizer: Thumb
    {
        public static DependencyProperty ResizerDirectionProperty = DependencyProperty.Register("Direction", typeof(ResizerDirections), typeof(Resizer));



        public ResizerDirections ResizerDirection
        {
            get
            {
                return (ResizerDirections)GetValue(ResizerDirectionProperty);
            }

            set
            {
                SetValue(ResizerDirectionProperty, value);
            }
        }

        
        public Resizer()
        {
            
            DragDelta += new DragDeltaEventHandler(Resizer_DragDelta);
        }

        private void Resizer_DragDelta(object sender, DragDeltaEventArgs e)
        {
            
            Grid? ItemToResize = this.Parent as Grid;
            if(ItemToResize != null)
            {
                switch (ResizerDirection)
                {

                    case ResizerDirections.Bottom:
                        ResizeBottom(ItemToResize, e);
                        break;
                    case ResizerDirections.Top:
                        DragWindow();
                        break;
                    case ResizerDirections.Left:
                        ResizeLeft(ItemToResize, e);
                        break;
                    case ResizerDirections.Right:
                        ResizeRight(ItemToResize, e);
                        break;
                    case ResizerDirections.TopRight:
                        TopRight(ItemToResize, e);
                        break;
                    case ResizerDirections.BottomLeft:
                        BottomLeft(ItemToResize, e);
                        break;
                    case ResizerDirections.BottomRight:
                        BottomRight(ItemToResize, e);
                        break;
                    case ResizerDirections.TopLeft:
                        TopLeft(ItemToResize, e);
                        break;

                }
            }
        }

        private static void ResizeBottom(Grid Target, DragDeltaEventArgs e)
        {
            Window mw = App.Current.MainWindow;
            Target.Height = mw.ActualHeight;

            double deltaVertical;
            Point GetMousePos() => Mouse.GetPosition(Target);
            deltaVertical = GetMousePos().Y + 7;
            if(deltaVertical > mw.MinHeight)
                mw.Height = deltaVertical-7;
        }
        private static void ResizeTop(Grid Target, DragDeltaEventArgs e)
        {
            Window mw = App.Current.MainWindow;
            Target.Height = mw.ActualHeight;

            double deltaVertical;
            Point GetMousePos() => Mouse.GetPosition(Target);
            deltaVertical = GetMousePos().Y - 7;
            if ((Target.ActualHeight - deltaVertical) > mw.MinHeight)
            {
                mw.Top += deltaVertical-7;
                mw.Height -= deltaVertical-7;
            }

        }
        private static void ResizeLeft(Grid Target, DragDeltaEventArgs e)
        {
            Window mw = App.Current.MainWindow;
            Target.Width = mw.ActualWidth;
            double deltaHorisontal;
            Point GetMousePos() => Mouse.GetPosition(Target);
            deltaHorisontal = GetMousePos().X - 7;
            if ((mw.ActualWidth - deltaHorisontal) > mw.MinWidth)
            {
                mw.Left += deltaHorisontal -7;

                mw.Width -= deltaHorisontal-7;
            }

        }
        private static void ResizeRight(Grid Target, DragDeltaEventArgs e)
        {
            Window mw = App.Current.MainWindow;

            double deltaHorisontal;
            Point GetMousePos() => Mouse.GetPosition(Target);
            deltaHorisontal = GetMousePos().X + 7;
            if (deltaHorisontal > mw.MinWidth)
                mw.Width = deltaHorisontal;
        }

        private static void TopRight(Grid Target, DragDeltaEventArgs e)
        {
            ResizeTop(Target, e);
            ResizeRight(Target, e);
        }
        private static void TopLeft(Grid Target, DragDeltaEventArgs e)
        {
            ResizeTop(Target, e);
            ResizeLeft(Target, e);
        }
        private static void BottomLeft(Grid Target, DragDeltaEventArgs e)
        {
            ResizeBottom(Target, e);
            ResizeLeft(Target, e);
        }
        private static void BottomRight(Grid Target, DragDeltaEventArgs e)
        {
            ResizeBottom(Target, e);
            ResizeRight(Target, e);
        }

        private static void DragWindow()
        {
            while (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                App.Current.MainWindow.DragMove();
            }
        }

        public enum ResizerDirections
        {
            TopLeft,
            Left,
            Right,
            Top,
            Bottom,
            BottomLeft,
            TopRight,
            BottomRight,
        }
    }
}
