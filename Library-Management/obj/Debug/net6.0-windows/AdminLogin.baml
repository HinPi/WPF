   M S B A M L   `   `   `  ????M  ILibrary-Management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Library_ManagementLibrary_Management  5   	   #    Library_Management.AdminLogin   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Library_Management     5   	     ? WindowStyle$  
ToolWindow=?5   	    ? 
ResizeMode$ NoResize=?6"    ? Title$ Admin Login??5	   	   $	??400??6   $	??342??6*   .??5
      ?  ? ColumnDefinitions 5   
   ?? 5      $	??17* ?6   ?? 5      $	??40* ?6   .+?5   
   ?? #??? ??6   $
??Left=?6T   $	??294??6o   $??	30,40,0,0q?6|   
???   ?$	??Top=?6?   $	??274??6?    J? Opacity$	 0.7Q?6?   $??2??6?   ?? 5   
   $??    Admin Login??6   $??	95,70,0,0q?6*   $	??Top=?6=   $??42??6U   $	??156??6a   $??18(?6m   $
??Left=?6{   $??2??6?   ?? 5   
   $
??Left=?6   $	??120??60   $??
66,137,0,0q?6=   $	??Top=?6Q   $	??204??6i   $??2??6u   .+?5      ?? $??Email??6   $??32??6$   ?? 5      -   5        $??tbAdminEmail??5   6   $??20??6    ?? TextWrapping$
 Wrap=?6"   66   ?? 5      $??Password??6   $??32??6'   G? 5      -   5        $??tbAdminPass??5   &   $??20??6   6&   5      ?? 5   
   -   5        $??BtnLogin??5   s   $??Login??6   $
??Left=?6!   $??
28,262,0,0q?6<   $	??Top=?6P   $??74??6h   $??1??6?   ?? 5   
   -   5        $??
alertAdmin??5   n   $?? ??6   $
??Left=?6   $??
66,308,0,0q?66   $	??Top=?6J   $	??204??6b   
???  ??$??2??6?   5      5      