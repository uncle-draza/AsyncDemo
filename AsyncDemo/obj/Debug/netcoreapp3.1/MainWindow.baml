   M S B A M L   `   `   `  ????D  @AsyncDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AsyncDemo	AsyncDemo  5   	       AsyncDemo.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:AsyncDemo     5   	     ? Title$  Sync vs Async Demo??5   	   $	??474??6$   $	??815??61    ? 
ResizeMode$ NoResize=?5	   	   .??5
      ? -   5         ?Name$ 
Async_Demo??5
      ???	#FF71ACB6.+?5   
   ?? -   5         ??Name$ executeSync??5      $??Sychrounous??6&   $
??Left=?6<   $??	10,10,0,0q?6W   $	??Top=?6j   $??86??6?   $	??205??6?   6?   ?? 5   
   -   5        $ executeAsync??5      $??Asychrounous??6'   $
??Left=?6>   $??10,0,0,0q?6Y   $??Center=?6k   $??86??6?   $	??205??6?   6?   ?? 5   
   -   5        $ executeParallel??5      $??Async Parallel??6*   $
??Left=?6C   $??
10,338,0,0q?6^   $	??Top=?6r   $??86??6?   $	??205??6?   6?   ?? 5   
   -   5         ??Name$ resultWindow??5      $
??Left=?6*   $??	231,0,0,0q?6E   $
??Wrap=?6X   $??Center=?6l   $	??414??6?   $	??559??6?   
???????6?   5      5      