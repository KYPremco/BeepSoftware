   M S B A M L   `   `   `  ����?  ;Beep, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BeepBeep  5   	       Beep.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Beep     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	     � Title$  
MainWindow��5	   	   $	��350��6   $	��525��6)   .��5
      � 
������� � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $	��100 �6   6-   .+�5   
   �� $��0��6   $��0��6%    �� Orientation$ 
Horizontal=�62   5      � 5   
   -   5         �Name$ beepGrid��5   ,   $��0��6   $��1��6   $��Center=�6>   $��Center=�6[   .+�5      �� $��Images/beep-empty.png��6   $��Stretch=�63   $��Stretch=�6Q   6o   5      �� 5   
   $��0��6   $��1��6"   $��2��62   .+�5      �� 
Simulate6"   �� 5      -   5         ��Name$ btnSad��5      .��6<   Sad6A   �� 5      -   5        $ 
btnNeutral��5      .��6D   	Neutral6M   �� 5      -   5        $ btnHappy��5      .��6@   Happy6G   �� 5      -   5        $ 
btnThirsty��5      .��6D   	Thirsty6M   5       � 5!   
   -   5        $ gridPreview��5!      $��0��6$   $��0��61   $��2��6A   $��2��6R   $��Stretch=�6f   $��Stretch=�6�   
�������.+�5"      �� $��Center=�6   $��Center=�65   Sluit een beep aan6d   5#      5$      5%      