   M S B A M L   `   `   `  ����D  @semana3_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:semana3_1	semana3_1  5   	       semana3_1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:semana3_1     5   	     � Title$  
MainWindow��5   	   $	��520��6   $	��800��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ Comic Sans MS)�6+   �� 5       � ��$ 14(�6)   5      5      .��5   
   �� .+�5      �� .+�5      �� $��PEDIDO DE RANGS POR FECHA��6   5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� .��6   Fecha Inicio :6)   �� 5      -   5         ��Name$ txtFechaInicio��5      $��
01/01/1990��62   �� 5      .��6   Fecha Fin :6&   �� 5      -   5        $ txtFechaFin��5      $��
01/01/1990��6/   �� 5      -   5         ��Name$ btnConsultar��5      .��6J   	Consultar6U   5      �� 5      .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgvPedido��5   *   $��180px��6   	   AutoGenerateColumns	 . 
   GridLinesVisibility$
 Vertical=�5          HeadersVisibility$	 All=�6:   
�������$��5q�5!   2   5"      5#      �� 5$      .+�5%      �� $��DETALLES DE PEDIDOS��6   5&      �� 5'      .+�5(        -   5        $ dgvDetallePedido��5(   *   $��180px��6   	 . $
 Vertical=�5)      $	 All=�6:   
�������   RowBackground
 �����   AlternatingRowBackground
 ��ح�
�������$��5q�5*   �   5+      5,      �� 5-      $ 
Horizontal=�6   .+�5.      �� $��TOTAL��6   �� 5/      -   5        $ txtTotal��5/       �� 
IsReadOnly . 6@   50      51      53      