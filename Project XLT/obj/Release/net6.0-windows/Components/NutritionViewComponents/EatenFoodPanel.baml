   M S B A M L   `   `   `  ���� E  AProjectXLT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Project_XLT.ComponentsProject_XLT.Components  +    %Project_XLT.Components.EatenFoodPanel   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:Project_XLT.Components     _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a4ec+http://schemas.microsoft.com/xaml/behaviors  -     >�Name$
  this�� � 	Resources ��%    .��� $	��350��$	��350��.+��� 
������� �� CornerRadius$ 25��._��  � RowDefinitions �� $��60 ��� $��* ��� $��80 �.+��� $ 15��
�������$��20 10 20 10q�._���    NunitoFontStyle#��[  $#��Съесть продукты��$��Center=�$��Center=�$��32(��� $��Hidden=�$��5q�$��1��.���� ���� *EatenFoodList+���� .R��� $ 5��
�������$��1q�����  �� 
TargetType" �� �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 True��. ���  �� Property � ��	 �� Value
	 �������  � ��$	 3 5 3 5q���  �@J�Effect	 3  -System.Windows.Media.Effects.DropShadowEffect  
   
BlurRadius$
 10Q�   ShadowDepth$ 0Q�   Opacity$ 0Q�.���  � ��
	 �������  � ��
	 �������  � ��$	 3q�._��  � ColumnDefinitions �� $��40 ��� $��* ��� $��60 ��� $��40 �.+��� $��0��$��Center=�$��Center=����� *Image+�� $��1��$��10 0 0 0q�$
��Left=�$��Center=�.+��� $��18(�$��Center=�$��Center=�$
��Bold"�$��/Fonts/#Nunito Font)���`�  �� StringFormat$	 {0}��.1���  �� Path$ Title���   CustomTextBox#��[ $��2��
 � Tag$ 
Грамм��$��/Fonts/#Nunito Font)�
�������$��Right=�$��20��$��1q�$��60������ *Gramms+ �� Mode$ TwoWay=��� $��3��
������   
DeleteIcon# [   CircularButton#��[ *  $Microsoft.Xaml.Behaviors.Interaction   Triggers +  %Microsoft.Xaml.Behaviors.EventTrigger     	EventName$ Click��*  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     PassEventArgsToCommand$
 True��   Command ��  �� ElementName$
 this��$# DataContext.RemoveFoodCommand��� #��[ $��3��$��40��$	��240�����#2aa7ff$��Съесть��$��18(����� *
EatAllFood+