   M S B A M L   `   `   `  ����L  HProyecto_HotelABC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:Proyecto_HotelABC.Views.ManagerViews$Proyecto_HotelABC.Views.ManagerViews  5   	   =    7Proyecto_HotelABC.Views.ManagerViews.ManageRoomServices   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:Proyecto_HotelABC.Views.ManagerViews     5   	     � Title$  ManageRoomServices��5   	   $	��450��6$   $	��800��61    � 	Resources 5	         ColoredDataGridStyle �� 
TargetType&   System.Windows.Controls.DataGrid �� Property �� Value  CustomDataGridHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  &	        &	     �� 5
   
   "  6-   .�5      ��  � �� �#CDE3B16+   �� 5       � ��
 �   �6+   �� 5       �@ RowBackground �#E6F7D06.   �� 5        �@ AlternatingRowBackground
 �����69   �� 5       � ��
 �����6,   5      �� 5   
   "  62   .�5      ��  � �� �#8593726+   �� 5       � ��
 �����6+   �� 5       � �� �#E6F7D06,   5      5      .��5      � .+�5   
     -   5          Name$ 
dgServices��5         AutoGenerateColumns$ False��6'      CanUserAddRows$ False��6C      
IsReadOnly$
 True��6Z   	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 6l   $
 �� IsSynchronizedWithCurrentItem$

 TrueY�6|   $��115,55,73,55q�6�   #��[  6�      ColumnHeaderStyle# [ 6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Huesped��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Correo+  5       $ Servicio��6%    67   �� *NameService+4  .System.Windows.Controls.DataGridTemplateColumn  5"      $ Eliminar��6)      CellTemplate 5#      �� 5$      .R�5%      �� -   5        $��Eliminar��5%   %   ���#C1CCB26M   5&      5(      5-      �� 5.   
   -   5         ��Name$ 
BTN_GoBack��5.      $
��Left=�6&   $��24��6A   $��
715,17,0,0q�6M   $	��Top=�6a   $��61��6y   $��0,0,0,1q�6�   ��6�   Z� .��5/      �� $$��/Images/flecha-hacia-atras.png��6   50      52      53      