   M S B A M L   `   `   `  ���� E  AProjectXLT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Project_XLT.ComponentsProject_XLT.Components  I)clr-namespace:Project_XLT.MVVM.ViewModelsProject_XLT.MVVM.ViewModels  %    Project_XLT.Components.EatPanel   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:Project_XLT.Components     _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a4ec+http://schemas.microsoft.com/xaml/behaviors  3vms)clr-namespace:Project_XLT.MVVM.ViewModels  -     >�Name$
  this�� � 	Resources ��%    .��� .+��� 
������� �� CornerRadius$ 25��._��  � RowDefinitions �� $��50 ��� $��* �.+�� .+���    SearchTextBox#��[  $��10q�
����������� *SearchFoodFieldText+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�
 � Tag �� *OpenFoodListPopup+.���� $��1��
�������$ 15��$��4q�._�� .+��� $��Hidden=�$��5q�.���� ���� *
FoodList+y��� *IsFoodListVisible+$ PropertyChanged=����� .R��� $ 5��$��1q�����  �� 
TargetType" �� �� Triggers P� 	 P� Property	 �@J�IsMouseOver
 P� Value$

 True��. ���  �� Property � �� �� Value
 �������  � ��$ 3 5 3 5q���  �@J�Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   ShadowDepth$ 0Q�   Opacity$ 0Q�.���  � ��
 �������  � ��
 �������  � ��$ 3q�._��  � ColumnDefinitions �� $��40 ��� $��* ��� $��40 �.+��� $��0��$��Center=�$��Center=����� *Image+�� $��1��$��5 0 0 0q�$
��Left=�$��Center=�.+��� $
��Bold"�$��14(�  NunitoFontStyle#��[ ��`�  �� StringFormat$	 {0}��.1���  �� Path$ Title��� #��[ ���� *BJUStatictis+�� $��2��
������   AddIcon# [   CircularButton#��[ *  $Microsoft.Xaml.Behaviors.Interaction   Triggers +  %Microsoft.Xaml.Behaviors.EventTrigger     	EventName$ Click��*  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     PassEventArgsToCommand$
 True��   Command ��  �� ElementName$
 this��$  DataContext.AddFoodCommand�