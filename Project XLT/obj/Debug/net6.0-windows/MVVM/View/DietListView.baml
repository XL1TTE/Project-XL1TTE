   M S B A M L   `   `   `  ����E  AProjectXLT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Project_XLT.MVVM.ViewProject_XLT.MVVM.View  5      (    "Project_XLT.MVVM.View.DietListView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Project_XLT.MVVM.View     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a4ec+http://schemas.microsoft.com/xaml/behaviors  5      -   5          >�Name$
  this��5	       � 	Resources 5         	FoodImage �� 	UriSource  PickedItemIcon  ToPickImageIcon��%�   &	        &	 @     &	 z     �� 5   
   $, &../../Images/Nutrition Images/food.jpg?�6(   �� 5   
   $&  ..\..\Images\UI icons\picked.png?�6-   �� 5   
   $' !../../Images/UI icons/plus150.png?�6.   5      .��5      � .+�5   
   ��  �� CornerRadius$ 15��6   
�������._�5      �  � RowDefinitions 5      �� 5      $	��120 �6$   �� 5      $��* �6$   .+�5      �� $��0��6   
�������$ 25��5      $��5q�5      ._�5      �  � ColumnDefinitions 5      �� 5      $��* �6/   �� 5       $	��360 �6/   .+�5#      �� $��0��6!   ._�5$      �� $��Center=�6)   $��25 0 0 0q�5%   )   .+�5&   "   �� $'��!Программы питания��6,     NunitoFontStyle#��[ 5'   (   $��32(�5(   (   �� 5)   "   $%��Выбери свою цель!��6,   #��[ 5*   (   $��18(�5+   (   $��Center=�5,   (   5-      50      �� 52      $��1��6!   ���#c38cfa$ 15��53   !   $��10 10 10 10q�54   !   $
��auto��55   !   $	��300��56   !   ._�57      � $��5q�6$   .+�58   "   � $��0��6'   .+�59   &   �� $��0q�61   $��Center=�6<   .+�5:   *   �� $��25 0 0 0q�61   ._�5;   .   �� $��0��68   $$��Выбранная диета:��5<   (   #��[ 5=   0   $
��Bold"�5>   (   $��18(�5?   (   5@   +   �� 5A   *   $��	25 0 10 0q�61   $��1��6D   ._�5B   .   �� $��0��68   $
��Wrap=�5D   <    �� TextAlignment$
 Left=�5E   <   #��[ 5F   <   $��Normal"�5G   <   $��16(�5H   <   ��5C   =   �� *PickedDiet.DietTitle+5H   <   5I   +   5J   '   5K   #   5L      5M      5N      5O      �� 5R      $��1��6   
�������$ 25��5T      $��5 0 5 5q�5U      ._�5V      � .+�5W      �� $��Hidden=�6'   .��5X      �� ��6+   �� *
DietList+��5Y   "   �� 5Z   &   .R�5[   *   �� 
�������$��0 2 0 0q�5\      $��
25 10 25 0q�5]      ._�5^   .   � $��5q�63    5_   2   �� 5`   6   $	��200 �6G   �� 5a   6   $��* �6G   �� 5b   6   $	��120 �6G   .+�5f   2   �� $��0��69   ._�5g   6   A� $��Center=�6>   $��Center=�5h   >   $	��160��5i   >   $	��160��5j   >    J� Effect 5k   :   3  -System.Windows.Media.Effects.DropShadowEffect  5l   >      Opacity$ 1Q�6O   	   ShadowDepth$	 0Q�5m   O   
   
BlurRadius$
 10Q�5n   O   ��5q   :   �� 5r   >    �� ImageSource# [  6I   5t   7   5u   3   �� 5w   2   $��1��69   ._�5x   6   ��  �� Orientation$ Vertical=�6A   $��Center=�5y   %   $
��Left=�5z   %   $��10 0 0 0q�5{   %   .+�5|   :   �� #��[ 5}   (   $��18(�5~   (   $
��Bold"�5   (   ��5|   D   �� *	DietTitle+5   (   �� 5�   :   #��[ 5�   (   $
��Wrap=�5�   (   $��14(�5�   (   ��5�   D   �� *DietDescription+5�   (   5�   7   5�   3   �� 5�   2   $��2��69   ._�5�   6   	� $��Center=�5�   !   $��Center=�5�   !    d� 	IsChecked 5�      �� *IsDietChoosed+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5�   :   +  %Microsoft.Xaml.Behaviors.EventTrigger  5�   >      	EventName$ Click��6N   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5�   B   2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     PassEventArgsToCommand$
 True��6Y      Command 5�   %   ��  �� ElementName$
 this�� �� Path$! DataContext.PickDietCommand�5�   ?   ��5�   :   �� 5�   >    �� 
TargetType" 	�6D    �� BasedOn# [B	�5�   (   �5�   B   �� 5�   F    �� Property � �� �� Value 5�   J   �� 5�   N    �� 
TargetType" 	�6^   .R�5�   R   � .+�5�   V   �� $ 10��6]   
������ ._�5�   Z   � $��Center=�6_   $��Center=�5�   C   .+�5�   ^   ��  ��Name$ 
PART_Image��5�   d   $��Center=�5�   e   $��Center=�5�   e    J� IsHitTestVisible$ False��5�   e   ��5�   d   �� *Tag+ �� RelativeSource �� *TemplatedParent+5�   d   5�   [   5�   W   5�   S    �� Triggers 5�   R   P� 5�   V     P� Property  �@d�	IsChecked! P� Value$
! TrueY�6s   . �5�   Z   �� " �� 
TargetName$" 
PART_Image��6a   # [ 6�    � ��5�   W   P� 5�   V     �@d�	IsChecked$! FalseY�6s   . �5�   Z   �� $" 
PART_Image��6a   # [ 6�    � ��5�   W   5�   O   5�   G   �� 5�   F    �@�Tag# [ 6\   �� 5�   F    � ��$ 60��6^   �� 5�   F    � ��$ 60��6_   # �� Triggers# 5�   B   P� 5�   F     �@J�IsMouseOver$
! True��6e   . �5�   J   ��  � ��$ 80��6b   �� 5�   J    � ��$ 80��6c   5�   G   5�   ?   5�   7   5�   3   5�   /   5�   +   5�   '   ��5�   "   �� 5�   &   .R�5�   *   �� $ Vertical=�65   5�   '   5�      5�      5�      5�      5�      5�      5�      5�      