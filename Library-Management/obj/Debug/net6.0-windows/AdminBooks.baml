   M S B A M L   `   `   `  ????M  ILibrary-Management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Library_ManagementLibrary_Management  5   	   #    Library_Management.AdminBooks   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Library_Management     5   	   .??5	      ? .+?5
   
   ?? $
??Left=?6   $	??332??60   $	??Top=?6=   $	??655??6U   $??10,30,-10,0q?6a   .+?5      &   System.Windows.Controls.DataGrid  -   5           Name$  dgBooks??5   H      
IsReadOnly$
 True??6   $	??333??6)   $??0,0,24,0q?66      AutoGenerateColumns$ False??6Y   #??? ??6u      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Book Id??6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   ?? *BookId+6W     5      $ 	Book Name??6)    6<   ?? *
BookName+6[     5      $ Book Author??6)    6>   ?? *
BookAuthor+6_     5      $ 	Book ISBN??6)    6<   ?? *
BookISBN+6[     5      $ 
Book Price??6)    6=   ?? *	BookPrice+6]     5      $ Quantity??6)    6;   ?? *
BookCopies+6\   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Actions??6-      CellTemplate 5      ?? 5      .R?5   "   ??  ??Name$ BtnEdit??6)   -   5        $?? Edit ??5   :   6c   5      5        5      $  ??6-    5      ?? 5      .R?5   "   ?? $ 	BtnDelete??6)   -   5        $?? Delete ??5   <   6i   5      5       5"      5#      ?? 5$   
   -   5        $??BtnAdd??5$   t   $??Add Book??6   $
??Left=?6$   $	??Top=?6?   $??75??6W   $??10,0,0,0q?6b   6?   ?? 5%   
   $??Book Section??6   $
??Left=?6'   $??
521,-7,0,0q?6B   $	??Top=?6V   
???????$??NORTHEN)?6?   $??20(?6?   ??6n   Z? 6?   5(      5)      