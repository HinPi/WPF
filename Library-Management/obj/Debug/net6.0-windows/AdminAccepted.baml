   M S B A M L   `   `   `  ????M  ILibrary-Management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Library_ManagementLibrary_Management  5   	   &     Library_Management.AdminAccepted   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Library_Management     5   	   .??5	      ? .+?5
   
   ?? $
??Left=?6   $	??332??60   $	??Top=?6=   $	??655??6U   $??10,30,-10,0q?6a   .+?5      &   System.Windows.Controls.DataGrid  -   5           Name$  
dgAccepted??5   ?   $	??333??6   #??? ??6$   $??0,0,24,0q?6o      
IsReadOnly$
 True??6?      AutoGenerateColumns$ False??6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Book Id??6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   ?? *BookId+6W     5      $ 	Book Name??6)    6<   ?? *
BookName+6[     5      $ Date Recieved??6)    6@   ?? *DateRecieved+6c     5      $ User Id??6)    6:   ?? *UserId+6W     5      $ 	User Name??6)    6<   ?? *
UserName+6[   5      5      ?? 5   
   $??Accepted Section??6   $
??Left=?6+   $??
482,-6,0,0q?6F   $	??Top=?6Z   
???????$??NORTHEN)?6?   $??20(?6?   ??6r   Z? 6?   5      5      