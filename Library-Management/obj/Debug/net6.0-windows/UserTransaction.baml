   M S B A M L   `   `   `  ????M  ILibrary-Management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Library_ManagementLibrary_Management  5   	   (    "Library_Management.UserTransaction   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Library_Management     5   	   .??5	      ? .+?5
   
   ?? -   5        $??requestStackPanel??5
   t   $
??Left=?6   $	??332??60   $??	10,30,0,0q?6=   $	??Top=?6P   $	??277??6h   .+?5      &   System.Windows.Controls.DataGrid  -   5        $??	dgRequest??5   6       
IsReadOnly$
  True??6   $	??332??6)      AutoGenerateColumns$ False??6G   #??? ??6c      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Book Id??6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   ?? *BookId+6W     5      $ 	Book Name??6)    6<   ?? *
BookName+6[     5      $ Requested Date??6)    6A   ?? *DateRequested+6e   5      5      ?? 5   
   -   5        $??returnStackPanel??5   u   $
??Left=?6   $	??332??60   $??
298,30,0,0q?6=   $	??Top=?6Q   $	??347??6i   .+?5        -   5        $??dgReturn??5   6   $
  True??6   $	??332??6)   $ False??6F   #??? ??6b    5        5      $ Book Id??6)    6:   ?? *BookId+6W     5      $ 	Book Name??6)    6<   ?? *
BookName+6[     5      $ Recieved Date??6)    6@   ?? *DateRecieved+6c   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Actions??6-      CellTemplate 5      ?? 5      .R?5   "   ??  ??Name$ 	BtnReturn??6)   -   5        $?? Return ??5   <   6i   5      5      5!      5"      ?? 5#   
   $??Recieved Books??6   $
??Left=?6)   $??
375,-4,0,0q?6D   $	??Top=?6X   
???????$??NORTHEN)?6?   $??20(?6?   $	??221??6?   ??6p   Z? 6?   ?? 5$   
   $??Requested Books??6   $
??Left=?6*   $??	66,-4,0,0q?6E   $	??Top=?6X   
???????$??NORTHEN)?6?   $??20(?6?   $	??221??6?   ??6p   Z? 6?   5&      5'      