   M S B A M L   `   `   `  ����E  AProjectXLT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Project_XLT.ComponentsProject_XLT.Components  5      +    %Project_XLT.Components.EatenFoodPanel   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Project_XLT.Components     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a4ec+http://schemas.microsoft.com/xaml/behaviors  5      -   5          >�Name$
  this��5
       � 	Resources 5      ��%    5      .��5      � $	��350��6   $	��350��6   .+�5   
   �� 
������� �� CornerRadius$ 25��5      ._�5      �  � RowDefinitions 5      �� 5      $��60 �6$   �� 5      $��* �6$   �� 5      $��80 �6$   .+�5      �� $ 15��6   
�������$��20 10 20 10q�5      ._�5      ��    NunitoFontStyle#��[  6    $#��Съесть продукты��5      $��Center=�5      $��Center=�5       $��32(�5!      5"      �� 5%      $��Hidden=�6   $��5q�5&      $��1��5'      .��5(      �� ��6#   �� *EatenFoodList+��5)      �� 5*      .R�5+   "   �� $ 5��6)   
�������$��1q�5-   !   ��5.   &   �� 5/   *    �� 
TargetType" ��60    �� Triggers 50   .   P� 51   2    P� Property �@J�IsMouseOver P� Value$
 True��6Q   . �52   6   ��  �� Property � ��	 �� Value
	 �����6T   �� 53   6    � ��$	 3 5 3 5q�6O   �� 54   6    �@J�Effect	 55   :   3  -System.Windows.Media.Effects.DropShadowEffect  56   >   
   
BlurRadius$
 10Q�6O      ShadowDepth$ 0Q�57   W      Opacity$ 0Q�58   W   5:   7   5;   3   .�5=   .   ��  � ��
	 �����6K   �� 5>   .    � ��
	 �����6L   �� 5@   .    � ��$	 3q�6G   5A   +   ._�5C   &   �  � ColumnDefinitions 5D   *   �� 5E   .   $��40 �6?   �� 5F   .   $��* �6?   �� 5G   .   $��60 �6?   �� 5H   .   $��40 �6?   .+�5K   *   �� $��0��60   $��Center=�5L   $   $��Center=�5M   $   ��5N   $   �� *Image+�� 5R   *   $��1��65   $��10 0 0 0q�5S   5   $
��Left=�5T   )   $��Center=�5U   )   .+�5V   .   �� $��18(�68   $��Center=�5W   8   $��Center=�5X   8   $
��Bold"�5Y   8   $��/Fonts/#Nunito Font)�5Z   8   ��5[   2   `� 5\   6    �� StringFormat$	 {0}��6C   .1�5]   :   ��  �� Path$ Title�6B   5^   7   5`   /   5b   +   �� 5c   *     CustomTextBox#��[ 62   $��2��5d   2   
 � Tag$ 
Грамм��5f   2   $��/Fonts/#Nunito Font)�5g   2   
�������$��Right=�5i   2   $��20��5j   2   $��1q�5k   2   $��60��5l   2   ��5e   2   �� *Gramms+ �� Mode$ TwoWay=�5l   2   �� 5n   *   $��3��61   
������   
DeleteIcon# [ 5p   -     CircularButton#��[ 5q   -   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5r   .   +  %Microsoft.Xaml.Behaviors.EventTrigger  5s   2      	EventName$ Click��6B   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5t   6   2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     PassEventArgsToCommand$
 True��6M      Command 5u   5   ��  �� ElementName$
 this��$# DataContext.RemoveFoodCommand�5v   3   5x   +   5y   '   5z   #   5{      5}      5~      �� 5�      #��[ 6   $��3��5�      $��40��5�      $	��240��5�      ���#2aa7ff$��Съесть��5�      $��18(�5�      ��5�      �� *
EatAllFood+5�      5�      5�      5�      