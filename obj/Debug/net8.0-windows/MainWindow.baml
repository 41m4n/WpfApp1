   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
To-Do List��5   	   $	��350��6   $	��400��6)    � 	Resources 5	      +   %WpfApp1.DoneToTextDecorationConverter !  DoneToTextDecorationConverter��%   &	          5
   
   6.   5      .��5      �� $��10q�6   .+�5   
   �� -   5         ��Name$ 	TaskInput��5      $	��300��5   
   $��30��6   $��0,0,0,10q�6"   $��Enter a task...��5   
   
�������5   
   �� 5   
   -   5        $��Add Task��5      $	��100��6$   60   �� 5   
   -   5         ��Name$ TaskList��5      $��	0,10,0,10q�6$   $	��180��67   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��5q�6@    d� 	IsChecked 6#   �� *IsDone+6@   �� 5      $��5,0,0,0q�6A   ��6$   �� *Description+��5      �� *IsDone+ �� 	Converter# [  5      5      5      �� 5!   
   -   5        $��Remove Selected��5!      $	��150��6+   67   �� 5"   
   $ 
Horizontal=�6   $��0,5,0,0q�6.   $��Center=�6?   .+�5#      �� -   5        $��
Save Tasks��5#      $	��100��6*   $��0,0,10,0q�66   6H   �� 5$      -   5        $��
Load Tasks��5$      $	��100��6*   66   5%      5&      5'      