   M S B A M L   `   `   `  ����?  ;Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TestTest  5   	       Test.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Test     5   	   X TXceed.Wpf.Toolkit, Version=3.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  TestTask��5
   	   $	��550��6   $
��1000��6'   $	��450��64   $	��800��6D    � DataContext 5         Test.AppViewModel  5   
   6   .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��20* �6   �� 5      $	��67* �6   .+�5   
   �� $��2��6   ��6#   �� *	equations+ �� SelectedItem 5      �� *SelectedEquation+��5      �� 5      .R�5      �� ��6    ��  �� Path$
 name�6=   5      5      �� 5   
   $��1��6   $	��Top=�6%   $
��Left=�6=   $��5q�6X    �� Orientation$ 
Horizontal=�6c   .+�5!      �� .��6   Введите а:6    %  Xceed.Wpf.Toolkit.MaskedTextBox  5"         Mask$ 0��6!   $��40��6N   $��Center=�6Y   ��6*   �� *SelectedEquation.A+6v   �� 5#      .��6   Введите b:6      5$      $ 0��6!   $��Center=�6*   $��40��6E   ��6P   �� *SelectedEquation.B+6v   �� 5%      .��6   Выберите с:6!   �� 5&      $��Center=�6   $��70��62   ��6=   �� *SelectedEquation.Ls_c+ �� UpdateSourceTrigger$ PropertyChanged=�	 �� SelectedValue	 6�   �� *SelectedEquation.C+5(      5)      &   System.Windows.Controls.DataGrid  5*   
   $��1��6   $��1��6#   
   AutoGenerateColumns
 .  ��60   �� *SelectedEquation.Solution+$ PropertyChanged=�   Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   MinWidth$ 50Q�6%      Header$ x��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *X+6V     5.      $ 50Q�6%   $ y��63    6>   �� *Y+6V     5/      $ 50Q�6%   $ f(x,y)��63      
IsReadOnly .  6U   �� *F_X_Y+6q   51      �� 52   
   $!��Рассчитать f(x,y)��6+   $
��Left=�6G   $��	10,70,0,0q�6b   $	��Top=�6u   $	��100��6�   $��1��6�   ��6   �� *Click+6�   53      54      