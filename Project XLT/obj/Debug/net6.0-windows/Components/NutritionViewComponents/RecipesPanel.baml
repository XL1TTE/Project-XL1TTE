   M S B A M L   `   `   `  ����E  AProjectXLT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Project_XLT.ComponentsProject_XLT.Components  5      )    #Project_XLT.Components.RecipesPanel   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Project_XLT.Components     5        � 	Resources  5	         ButtonFilterImage �� 	UriSource  
SearchIcon  FoodImageExample��%�   &	        &	 :     &	 t     �� 5
   
   $&  ..\..\Images\UI icons\filter.png?�60   �� 5   
   $&  ..\..\Images\UI icons\search.png?�6)   �� 5   
   $8 2../../Images/Nutrition Images/FoodImageExample.jpg?�6/   5      .��5      � .+�5   
   ��  �� CornerRadius$ 25��6   
�������._�5      �  � RowDefinitions 5      �� 5      $��70 �6$   �� 5      $��* �6$   .+�5      �� $��0��6   ._�5      �  � ColumnDefinitions 5      �� 5      $��* �6/   �� 5      $
��0.7* �6/   .+�5      �� $��0��6%   $��25 0 0 0q�5    %    �� Orientation$ Vertical=�5!   %   $��Center=�5"   %   $
��Left=�5#   %   .+�5$      �� $1��+Рекомендованые рецепты��6(   $��18(�5%   (   $
��Bold"�5&   (     NunitoFontStyle#��[ 5'   (   �� 5(      $4��.Всего 892, 192 отфильтровано��6(   #��[ 5)   (   5*      �� 5,      $��1��6%   $ 
Horizontal=�5-   %   $��Center=�5.   %   $��Center=�5/   %   .+�51      ��   SearchTextBox#��[ 6&   $	��240��52   &   $��16(�53   &   
���������55   &   �� *SearchRecipeFieldText+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 57      
 � Tag# [  6%   
������ $��5 0 0 0q�59   %   $��0q�5:   %     CircularButton#��[ 5;   %   5<      5=      5>      5?      �� 5B      $��1��6   $��Hidden=�5C      $��
20 0 20 10q�5D      .��5E      �� ��6#   �� *	Recipes+��5F      �� 5G      .R�5H   "   �� $��0 2 0 0q�6)   
�������
�������$��80��5J   )   ._�5K   &   �  5L   *   �� 5M   .   $	��120 �6?   �� 5N   .   $��* �6?   .+�5Q   *   �� $��0��60   $
��Fill=�6@   $��5q�6O   #��[ 6Z   	 J� Effect	 5R   .   3  -System.Windows.Media.Effects.DropShadowEffect  5S   2   
   Opacity$
 1Q�6C      
BlurRadius$ 10Q�5T   C      ShadowDepth$ 0Q�5U   C   5W   +   �� 5Y   *   $ Vertical=�65   $��Center=�5Z   5   $��1��5[   5   $��10 0 0 0q�5\   5   .+�5]   .   �� $��16(�5^   8   $
��Bold"�5_   8   $��/Fonts/#Nunito Font)�5`   8   ��5]   8   �� *Title+5`   8   �� 5a   .   $��14(�5b   8   $
��Wrap=�5c   8   $��/Fonts/#Nunito Font)�5d   8   ��5a   8   �� *Description+5d   8   �� 5e   .   $��12(�5f   8   
�������$��/Fonts/#Nunito Font)�5h   8   ��5e   8   �� *BJUStatistic+5h   8   5i   +   5j   '   5k   #   5l      5n      5o      5p      5q      5s      5t      