   M S B A M L   `   `   `  ����N  JRealEstateAgencyApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:RealEstateAgencyAppRealEstateAgencyApp  5   	       RealEstateAgencyApp.Agent   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:RealEstateAgencyApp     5   	   -   5          � Title$  Agent��5   	   $	��600��6   $
��1000��6$    � WindowStartupLocation$ CenterScreen=�61   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��33 �6   �� 5      �� 5      $��33 �6    � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      �� 5      $��80 �6   .+�5   
   �� $
��1000��5      $��3��6!   $��3��65   $��0,0,-8,0q�6F   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �  � Color$ #ff3f��6#    � Offset$	 0.0Q�61   � 5      $
 #ff3��6#   $	 1.0Q�60   5      5      �� 5   
   
�������$��3��6$   $��3��68   $��15 15 15 15q�6I    �� CornerRadius$ 30��6^   ._�5      �� .+�5       �  5!      �� 5"      $��* �6+   �� 5#      �� 5$      $��* �6+    5&      �� 5'      $	��180 �6(   �� 5(      $	��180 �6(   �� 5)      $	��180 �6(   .+�5+      �� -   5        $��0��5+      $��0��6-   $��
Назад��6:   $��13(�6J   $��20,20,186,130q�6X   $
��Auto��6o      MaterialDesignFlatButton#��[  6~   6�   �� 5,      -   5        $��0��5,      $��2��6-   $��Добавить��6:   $��13(�6M   $��100,134,100,16q�6[   $
��Auto��6s   6�   �� 5-      $��1��6   $��2��6-   $��Изменить��6:   $��13(�6M   $��100,132,100,16q�6[   $
��Auto��6s   �� 5.      -   5        $��2��5.      $��2��6-   $��Удалить��6:   $��13(�6L   $��100,132,100,16q�6Z   $
��Auto��6r   6�   �� 5/      $��0��6    $��Наши Агенты��6-   $��Center=�6@   $��24(�6]   $��80,20,80,130q�6k   $��1��6�   50      51      52      &   System.Windows.Controls.DataGrid  53   
   -   5        	  Name$	 	AgentGrid��53      $��1��6&   $��1��63   
   AutoGenerateColumns
 .     Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	FirstName+6T     56      $ Имя��6%   $ * 6Q    62   �� *
MiddleName+6Q     57      $ Отчество��6%   $ * 6T    67   �� *
LastName+6T     58      $ Доля в сделке��6%   $ * 6Z    6<   �� *	DealShare+6Z   5:      5<      5=      