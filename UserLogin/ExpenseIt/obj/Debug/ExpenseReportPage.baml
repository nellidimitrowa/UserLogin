   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5       	ExpenseIt!   ExpenseIt.ExpenseReportPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6sys&clr-namespace:System;assembly=mscorlib     5        N� Title$  EExpenseIt - View Expense��5	       � 	Resources 5         strTitle��%5   &	        ��5   
   View Expense Report��6;   5      .��5      � $��
10,0,10,10q�6    � ColumnDefinitions 5   
   �� 5      �� 5      $	��230 �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   �� 5      ��5   
   �� 5       �� ImageSource$ watermark.png��6   .+�5   
   �� $��1��6   $��0��6    $��Center=�6-   $
��Bold"�6H   $��20(�6Z   ���#4E87D4#��[  6}   6�   �� 5   
   $��1��6   $��1��6    $
��Bold"�6-   $��Center=�6?   .��6[   Name:6b   �� 5    
   $��1��6   $��1��6    $��Center=�6-   $��Center=�6J   ��6e   ��  �� XPath$ @Name��6�   �� 5!   
   $��1��6   $��1��6    $
��Bold"�6-   $��Center=�6?   $��	0,75,0,12q�6Z   .��6n   Department:6{   � 5#   
   $��1��6   $��3��6   $
��Auto��6,    5$      �� 5%      �� 5&       5(      �� 5)      $
��Auto �6    �� 5*      .+�5,      �� $��0��6   $��0��6%   $��40��62    �� Padding$ 5q�6>   ���#4E87D4._�5-      �� $��Center=�6   
�������$��Center=�6F   .��6c   Expense type6q   5.      �� 5/      $��1��6   $��0��6%   $��40��62   $ 5q�6>   ���#4E87D4._�50      �� $��Center=�6   
�������$��Center=�6F   .��6c   Amount6k   51      �� 52      -   5        $��expenseTypeListBox��52   3   $��0��6   $��1��6&   .@�53      �� .��6   test16%   �� 54      .��6   test26%   �� 55      .��6   test36%   �� 56      .��6   test46%   �� 57      .��6   test56%   58      �� 59      -   5        $��amountListBox��59   3   $��1��6   $��1��6&   .@�5:      �� .��6   56!   �� 5;      .��6   86!   �� 5<      .��6   126"   �� 5=      .��6   26!   �� 5>      .��6   06!   5?      5@      5A      5B      