   M S B A M L   `   `   `  ����E  AProjectXLT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Project_XLT.ComponentsProject_XLT.Components  5      )    #Project_XLT.Components.RecipesPanel   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Project_XLT.Components     5        � 	Resources  5	         ButtonFilterImage �� 	UriSource  
SearchIcon��%�   &	        &	 :     �� 5
   
   $&  ..\..\Images\UI icons\filter.png?�60   �� 5   
   $&  ..\..\Images\UI icons\search.png?�6)   5      .��5      � .+�5   
   ��  �� CornerRadius$ 25��6   
�������._�5      �  � RowDefinitions 5      �� 5      $��70 �6$   �� 5      $��* �6$   .+�5      �� $��0��6   ._�5      �  � ColumnDefinitions 5      �� 5      $��* �6/   �� 5      $
��0.7* �6/   .+�5      �� $��0��6%   $��25 0 0 0q�5   %    �� Orientation$ Vertical=�5    %   $��Center=�5!   %   $
��Left=�5"   %   .+�5#      �� $1��+Рекомендованые рецепты��6(   $��18(�5$   (   $
��Bold"�5%   (     NunitoFontStyle#��[ 5&   (   �� 5'      $4��.Всего 892, 192 отфильтровано��6(   #��[ 5(   (   5)      �� 5+      $��1��6%   $ 
Horizontal=�5,   %   $��Center=�5-   %   $��Center=�5.   %   .+�50      ��   SearchTextBox#��[ 6&   $	��240��51   &   $��16(�52   &   
�������53   &   �� 55      
 � Tag# [  6%   
������ $��5 0 0 0q�57   %   $��0q�58   %     CircularButton#��[ 59   %   5:      5;      5<      5=      �� 5@      $��1��6   $��Hidden=�5A      $��
20 0 20 10q�5B      .��5C      �� ��6#   �� *EatenFoodList+��5D      �� 5E      .R�5F   "   �� $��0 2 0 0q�6)   
�������._�5H   &   �  5I   *   �� 5J   .   $��60 �6?   �� 5K   .   $��* �6?   .+�5N   *   �� $��0��60   $��5q�6@   ��6K   �� *Image+�� 5P   *   $ Vertical=�65   $��Center=�5Q   5   $��1��5R   5   $��5 0 0 0q�5S   5   .+�5T   .   �� $��16(�5U   8   $
��Bold"�5V   8   $��/Fonts/#Nunito Font)�5W   8   ��5T   8   �� *Title+5W   8   �� 5X   .   $��12(�5Y   8   $��/Fonts/#Nunito Font)�5Z   8   ��5X   8   �� *BJUStatictis+5Z   8   5[   +   5\   '   5]   #   5^      5`      5a      5b      5c      5e      5f      