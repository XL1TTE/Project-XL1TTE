   M S B A M L   `   `   `  ���� E  AProjectXLT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Project_XLT.MVVM.ViewProject_XLT.MVVM.View  (    "Project_XLT.MVVM.View.DietListView   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5local#clr-namespace:Project_XLT.MVVM.View     _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a4ec+http://schemas.microsoft.com/xaml/behaviors  -     >�Name$
  this�� � 	Resources    	FoodImage �� 	UriSource  PickedItemIcon  ToPickImageIcon��%�   &	        &	 2     &	 ^     �� $, &../../Images/Nutrition Images/food.jpg?��� $&  ..\..\Images\UI icons\picked.png?��� $' !../../Images/UI icons/plus150.png?�.��� .+���  �� CornerRadius$ 15��
�������._��  � RowDefinitions �� $	��120 ��� $��* �.+��� $��0��
�������$ 25��$��5q�._��  � ColumnDefinitions �� $��* ��� $	��360 �.+��� $��0��._��� $��Center=�$��25 0 0 0q�.+��� $'��!Программы питания��  NunitoFontStyle#��[ $��32(��� $%��Выбери свою цель!��#��[ $��18(�$��Center=��� $��1�����#c38cfa$ 15��$��10 10 10 10q�$
��auto��$	��300��._�� $��5q�.+�� $��0��.+��� $��0q�$��Center=�.+��� $��25 0 0 0q�._��� $��0��$$��Выбранная диета:��#��[ $
��Bold"�$��18(��� $��	25 0 10 0q�$��1��._��� $��0��$
��Wrap=� �� TextAlignment$
 Left=�#��[ $��Normal"�$��16(����� *PickedDiet.DietTitle+�� $��1��
�������$ 25��$��5 0 5 5q�._�� .+��� $��Hidden=�.���� ���� *
DietList+���� .R��� 
�������$��0 2 0 0q�$��
25 10 25 0q�._�� $��5q� �� $	��200 ��� $��* ��� $	��120 �.+��� $��0��._�A� $��Center=�$��Center=�$	��160��$	��160������  �� ImageSource# [  �� $��1��._���  �� Orientation$ Vertical=�$��Center=�$
��Left=�$��10 0 0 0q�.+��� #��[ $��18(�$
��Bold"����� *	DietTitle+�� #��[ $
��Wrap=�$��14(����� *DietDescription+�� $��2��._�	� $��Center=�$��Center=�	 d� 	IsChecked	 �� *IsDietChoosed+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�*  $Microsoft.Xaml.Behaviors.Interaction   Triggers +  %Microsoft.Xaml.Behaviors.EventTrigger     	EventName$ Click��*  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     PassEventArgsToCommand$
 True��   Command ��  �� ElementName$
 this�� �� Path$! DataContext.PickDietCommand�����  �� 
TargetType" 	� �� BasedOn# [B	����  �� Property � �� �� Value ��  �� 
TargetType" 	�.R�� .+��� $ 10��
������ ._�� $��Center=�$��Center=�.+���  ��Name$ 
PART_Image��$��Center=�$��Center=� J� IsHitTestVisible$ False������ *Tag+ �� RelativeSource �� *TemplatedParent+ �� Triggers P�  P� Property �@d�	IsChecked P� Value$
 TrueY�. ���  �� 
TargetName$ 
PART_Image��# [  � ��P�  �@d�	IsChecked$ FalseY�. ��� $ 
PART_Image��# [  � ����  �@�Tag# [ ��  � ��$ 60����  � ��$ 60�� �� Triggers P�  �@J�IsMouseOver$
 True��. ���  � ��$ 80����  � ��$ 80������ .R��� $ Vertical=�