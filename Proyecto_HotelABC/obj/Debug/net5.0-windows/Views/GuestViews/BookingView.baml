   M S B A M L   `   `   `  ����L  HProyecto_HotelABC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Proyecto_HotelABC.Views.GuestViews"Proyecto_HotelABC.Views.GuestViews  5   	   4    .Proyecto_HotelABC.Views.GuestViews.BookingView   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:Proyecto_HotelABC.Views.GuestViews     5   	     � Title$  BookingView��5   	   $	��450��6   $	��450��6*    � 	Resources 5	         MainButtonStyle �� 
TargetType �� Property �� Value �� 
StartPoint �� EndPoint � Offset � Color	 �� 
TargetType
 ��Name �� CornerRadius J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName��%[  &	        �� 5
   
   " ��6(   .�5      ��  � ��
 �����6+   �� 5       � ��$ 
Montserrat)�6+   �� 5       � ��$ 16(�6)   �� 5       � ��$
 10.5q�6(   �� 5       � ��$	 7.5q�6'   �� 5       � ��$	 150��6)   �� 5       � ��$ 60��6*   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � �� 5      �� 5      $	 0,0&�6*   $	 1,1&�6;   .��5      � $	 0.1Q�6'   $ #638A2E��64   � 5      $	 0.8Q�6'   $ #638A2E��64   5      5      �� 5       � �� 5      �� 5       "	 ��6&   .R�5!      �� $
 ButtonBorder��6!   #��z��67   $ 10��5"      $
 True��6/   ._�5#      �� $��Center=�6/   $��Center=�6L   5$       5%      P� 5'       �@J�IsMouseOver$
 True��6=   . �5(   "   �� $ ButtonBorder��6)    � �� 5)   &   �� 5*   *   $	 0,0&�6>   $	 1,1&�6O   .��5+   .   � $ 0Q�6;   $ #537624��6F   � 5,   .   $ 1Q�6;   $ #537624��6F   5-   +   5/   #   50      P� 52       � ��$
 True��6;   . �53   "   �� $ ButtonBorder��6)    � �� 54   &   �� 55   *   $	 0,0&�6>   $	 1,1&�6O   .��56   .   � $ 0Q�6;   $ #537624��6F   � 57   .   $ 1Q�6;   $ #537624��6F   58   +   5:   #   5;      5=      5?      5@      5A      .��5B      � ���#ADC48F � RowDefinitions 5C   
   �� 5D      $
��Auto �6   �� 5E      $��* �6   �� 5F      $
��Auto �6   .+�5J   
   �� $��Hotel ABC - Reservación��6   $��Center=�62   $��24(�6O   $
��Bold"�6]   $��0,10,0,0q�6o   � 5M   
   $��1��6    � ColumnDefinitions 5N      �� 5O      $��* �6#   �� 5P      $��* �6#   .+�5T      �� $��20q�6   .+�5U      �� $��Correo:��6   $
��Bold"�6*   $��18(�6<   �� 5V      -   5         ��Name$ txtMail��5V      $��30��6+    �� TextWrapping$
 Wrap=�67   �� 5W      $��Días a reservar:��6   $
��Bold"�63   $��18(�6E   $��0,10,0,0q�6S   �� 5X      -   5        $ txtDays��5X      $��30��6+   $
 Wrap=�67   �� 5Y      $��Cantidad de personas:��6   $
��Bold"�68   $��18(�6J   $��0,10,0,0q�6X   �� 5Z      -   5        $ 	txtAmount��5Z      $��30��6-   $
 Wrap=�69   5[      �� 5^      $��1��6   $��20q�6)   .+�5_      �� $��Suite a reservar:��6   $
��Bold"�64   $��18(�6F   �� 5`      -   5         ��Name$ SelectSuites��5`      $��30��61   5a      5b      �� 5e   
   -   5         ��Name$ 
BtnReserve��5e      $��RESERVAR��6%   #��[  68   $��1��6a   $��47��6n   $��	0,282,0,0q�6z   $
��Bold"�6�   $��2��6�   $	��Top=�6�   �� 5f   
   -   5        $ 
BTN_GoBack��5f      $
��Left=�6&   $��24��6A   $��374,314,0,0q�6M   $	��Top=�6b   $��61��6z   $��0,0,0,1q�6�   $��1��6�   $��2��6�   ��6�   Z� .��5g      �� $$��/Images/flecha-hacia-atras.png��6   5h      5i      5j      