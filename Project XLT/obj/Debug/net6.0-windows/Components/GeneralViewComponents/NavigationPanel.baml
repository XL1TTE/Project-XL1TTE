   M S B A M L   `   `   `  ����E  AProjectXLT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Project_XLT.CustomControlsProject_XLT.CustomControls  5      ?$clr-namespace:Project_XLT.ComponentsProject_XLT.Components  5      ,    &Project_XLT.Components.NavigationPanel   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7cc(clr-namespace:Project_XLT.CustomControls     5      6local$clr-namespace:Project_XLT.Components     5        � 	Resources  5         ProfilePageImageBlack �� 	UriSource  ProfilePageImageWhite  FinancePageImageBlack  FinancePageImageWhite  NutritionPageImageBlack  NutritionPageImageWhite  TrainingsPageImageBlack  TrainingsPageImageWhite  ExitImageWhite 	 ExitImageBlack��%^  &	        &	 L     &	 �     &	 �     &	 0    &	 ~    &	 �    &	     &	 h    &		 �    �� 5   
   $8 2..\..\Images\Navigation Icons\ProfileIconBlack.png?�64   �� 5   
   $8 2..\..\Images\Navigation Icons\ProfileIconWhite.png?�64   �� 5   
   $8 2..\..\Images\Navigation Icons\FinanceIconBlack.png?�64   �� 5   
   $8 2..\..\Images\Navigation Icons\FinanceIconWhite.png?�64   �� 5   
   $: 4..\..\Images\Navigation Icons\NutritionIconBlack.png?�66   �� 5   
   $: 4..\..\Images\Navigation Icons\NutritionIconWhite.png?�66   �� 5   
   $: 4..\..\Images\Navigation Icons\TrainingsIconBlack.png?�66   �� 5   
   $: 4..\..\Images\Navigation Icons\TrainingsIconWhite.png?�66   �� 5   
   $5 /..\..\Images\Navigation Icons\ExitIconWhite.png?�6-   �� 5   
   $5 /..\..\Images\Navigation Icons\ExitIconBlack.png?�6-   5      .��5      �� 
������� �� CornerRadius$ 15��6    ._�5   
   �  � RowDefinitions 5      �� 5      $	��120 �6    �� 5       $��* �6    .+�5"      � $��0��6   .+�5#      �� $��XL1TTE��6   $��Center=�6*   $��Center=�6G   $��38(�6b   $
��Bold"�6p   5$      � 5%      $��1��6   .+�5&      �� .+�5'      6   0Project_XLT.CustomControls.NavigationRadioButton  $��Профиль��6/   $��30��5(   .   $��10q�5)   .    d� 	IsChecked$
 TrueY�5*   .    
 NavigationPanelButtonStyle#��[
 5,   .      IconWhenChecked# [ 5-   .      IconWhenUnChecked# [  5.   .   ��5+   .   �� *NavigateToMainMenu+5/        51      $��Финансы��60   $��30��52   0   $��10q�53   0   #��[
 54   0   # [ 55   0   # [ 56   0     58      $��Питание��6/   $��30��59   /   $��10q�5:   /   #��[
 5<   /   # [ 5=   /   # [ 5>   /   ��5;   /   �� *NavigateToNutrition+5>   /     5@      $��Тренировки��6/   $��30��5A   /   $��10q�5B   /   #��[
 5C   /   # [ 5D   /   # [ 5E   /     5G      $��
Выход��6/   $��30��5H   /   $��10q�5I   /   #��[
 5K   /   # [ 5L   /   # [	 5M   /   ��5J   /   �� *ExitCommand+5M   /   5N      5O      5P      5R      5S      