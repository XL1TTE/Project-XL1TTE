   M S B A M L   `   `   `  ����E  AProjectXLT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Project_XLT.ComponentsProject_XLT.Components  5      I)clr-namespace:Project_XLT.MVVM.ViewModelsProject_XLT.MVVM.ViewModels  5      %    Project_XLT.Components.EatPanel   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Project_XLT.Components     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a4ec+http://schemas.microsoft.com/xaml/behaviors  5      3vms)clr-namespace:Project_XLT.MVVM.ViewModels  5      -   5          >�Name$
  this��5
       � 	Resources 5      ��%    5      .��5      � .+�5   
   �� 
������� �� CornerRadius$ 25��5      ._�5      �  � RowDefinitions 5      �� 5      $��50 �6$   �� 5      $��* �6$   .+�5      � .+�5      ��    SearchTextBox#��[  6   $��10q�5      
���������5      �� *SearchFoodFieldText+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�
 � Tag 5      �� *OpenFoodListPopup+.��6@   5      5      �� 5!      $��1��6   
�������$ 15��5#      $��4q�5$      ._�5%      � .+�5&      �� $��Hidden=�6'   $��5q�5'      .��5(      �� ��6+   �� *
FoodList+y�5)   (   �� *IsFoodListVisible+$ PropertyChanged=���5*   "   �� 5+   &   .R�5,   *   �� $ 5��61   $��1q�5-   1   ��5.   .   �� 5/   2    �� 
TargetType" ��68    �� Triggers 50   6   P� 51   :   	 P� Property	 �@J�IsMouseOver
 P� Value$

 True��6Y   . �52   >   ��  �� Property � �� �� Value
 �����6\   �� 53   >    � ��$ 3 5 3 5q�6W   �� 54   >    �@J�Effect 55   B   3  -System.Windows.Media.Effects.DropShadowEffect  56   F      
BlurRadius$ 10Q�6W      ShadowDepth$ 0Q�57   W      Opacity$ 0Q�58   W   5:   ?   5;   ;   .�5=   6   ��  � ��
 �����6S   �� 5>   6    � ��
 �����6T   �� 5@   6    � ��$ 3q�6O   5A   3   ._�5C   .   �  � ColumnDefinitions 5D   2   �� 5E   6   $��40 �6G   �� 5F   6   $��* �6G   �� 5G   6   $��40 �6G   .+�5J   2   �� $��0��68   $��Center=�5K   ,   $��Center=�5L   ,   ��5M   ,   �� *Image+�� 5Q   2   $��1��6=   $��5 0 0 0q�5R   =   $
��Left=�5S   1   $��Center=�5T   1   .+�5U   6   �� $
��Bold"�6@   $��14(�5V   @     NunitoFontStyle#��[ 5W   @   ��5X   :   `� 5Y   >    �� StringFormat$	 {0}��6K   .1�5Z   B   ��  �� Path$ Title�6J   5[   ?   5]   7   �� 5^   6   #��[ 5_   @   ��5^   @   �� *BJUStatictis+5_   @   5`   3   �� 5b   2   $��2��69   
������   AddIcon# [ 5d   5     CircularButton#��[ 5e   5   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5f   6   +  %Microsoft.Xaml.Behaviors.EventTrigger  5g   :      	EventName$ Click��6J   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5h   >   2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     PassEventArgsToCommand$
 True��6U      Command 5i   =   ��  �� ElementName$
 this��$  DataContext.AddFoodCommand�5j   ;   5l   3   5m   /   5n   +   5o   '   5q      5r      5t      5v      5z      5{      5|      5}      