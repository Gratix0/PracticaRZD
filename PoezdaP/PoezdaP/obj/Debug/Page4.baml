   M S B A M L   `   `   `  ����B  >PoezdaP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PoezdaPPoezdaP  5          PoezdaP.Page4   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:PoezdaP     5        N� Title$  Page4��5	      .��5      �  J� RenderTransformOrigin$ 0.499,0.497&�6   $��Center=�6/   $	��583��6L   
������� � RowDefinitions 5   
   �� 5      $��56 �6   �� 5      �� 5      $��35 �6    � ColumnDefinitions 5   
   �� 5      $	��190 �6   �� 5      $	��190 �6   �� 5      $��60 �6   �� 5      $��67 �6   �� 5      $��74 �6   .+�5   
   �� -   5         ��Name$ DolhnostBtn��5      $��Должности��6&   $��	0,12,0,12q�6T   �� 5   
   -   5        $ 
ProfileBtn��5      $��1��6%   $��Профили��65   $��	0,12,0,12q�6G   6Z   �� 5   
   -   5        $ 	TicketBtn��5      $��2��6$   $��3��64   $��Билеты��6H   $��	0,12,0,12q�6Y   6l   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	TableGrid��5      $��0��6&   $��2��66   $��1��6J   $��2��6W   �� 5   
   -   5        $ 	ChangeBtn��5      $��2��6$   $��2��61   $��Изм��6A   $��0,2,0,1q�6O   6`   �� 5   
   -   5        $ 
AllProfile��5      $��1��6%   $��2��62   $��3��6B   $��Все профили��6V   $��0,2,0,40q�6l   $��Bottom=�6~   �� 5    
   -   5        $ AddBtn��5       $��2��6!   $��3��6.   $��
Добав��6>   $��0,2,0,1q�6N   6_   �� 5!   
   -   5        $ 	DeleteBtn��5!      $��2��6$   $��4��61   $��Удал��6A   $��0,2,0,1q�6P   6a    � 5"   
   -	   5          �Name$ MyFrame4��5"      $��4��6"   $��5��63   5#      5$      