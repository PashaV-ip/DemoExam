   M S B A M L   `   `   `  ����b  ^ООО «Стройматериалы», Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullw@clr-namespace:ООО__Стройматериалы_.View.Windows2ООО__Стройматериалы_.View.Windows  5   	   J    DООО__Стройматериалы_.View.Windows.ApplicationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Rlocal@clr-namespace:ООО__Стройматериалы_.View.Windows     5   	   -   5          � Icon$  \Resources\icon.ico��5	   
    � Title$G AООО «Стройматериалы» - Главное окно��5
   	   ���	#FF76E382$	��450��6L   $	��800��6Y   .��5      �� $��10q�6    �� CornerRadius$ 30��6   
�������._�5   
   � $��10q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      �� 5      �� 5      .+�5      �� .+�5      �� $��-10,-10,-10,10q�6    �� Padding$ 10q�61   ���	#FF498C51._�5      � .+�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� $��20(�6S   ��6(   �� *User.UserInfo.UserSurname+6S   �� 5      $��20(�6P   $
��10,0q�6^   ��6(   �� *User.UserInfo.UserName+6^   5      �� 5      $��Админ панель��6!   $��Right=�68   $
��10,0q�6T   
�������$��10, 0q�6u   5      5      5      &   System.Windows.Controls.DataGrid  5      
�������$��1��6*   $��3��67      
IsReadOnly .    AutoGenerateColumns .  ��6v   �� *
Products+   Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Название��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   �� *NameItem.Name+  5"      $	 Ед.изм.��6)   
 6:   �� *Unit+  5#      $	 Цена��6)   
 67   �� *Price+  5$      $	 Скидка��6)   
 69   �� *CurrentDiscount+  5%      $	 Описание��6)   
 6;   �� *Discription+5'      5(      5)      5*      