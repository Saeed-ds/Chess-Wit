   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��850��6   $
��1350��6)   .��5	      � ��5
   
   �� 5       �� ImageSource$ /dr2.jpg��6   .+�5   
   � -   5         �Name$ Grid_1��5      $	��450��6   $��Center=�6+   $	��800��6H   $��	850,0,0,0q�6U   ��5      �� 5      $ 	/pj1b.jpg��6   .+�5      �� -   5         ��Name$
 btne��5      $
��Exit��6#   $��Center=�62   $��50��6O   $��0,50,0,0q�6[   $	��Top=�6m   $	��150��6�   $��14(�6�   $
��Bold"�6�   ��5      �� 5      $ 
/pj1b2.jpg��6!   5      �� 5      -   5        $ btnback��5      $	��◀��6&   $
��Left=�62   $��50��6M   $��0,0,0,0q�6Y   $	��Top=�6j   $	��150��6�   $��14(�6�   $
��Bold"�6�   ��5      �� 5      $ 
/pj1b2.jpg��6!   5      �� 5      -   5        $ 
btnforward��5      $	��▶��6)   $
��Left=�65   $��50��6P   $��	150,0,0,0q�6\   $	��Top=�6o   $	��150��6�   $��14(�6�   $
��Bold"�6�   ��5      �� 5      $ 
/pj1b2.jpg��6!   5      �� 5       -   5        $ btnsurrender1��5       $��	Surrender��6,   $
��Left=�6@   $��50��6[   $��	262,0,0,0q�6g   $��Center=�6z   $	��150��6�   $��14(�6�   $
��Bold"�6�   ��5!      �� 5"      $ 
/pj1b2.jpg��6!   5$      �� 5%      -   5        $ btnsurrender2��5%      $��	Surrender��6,   $
��Left=�6@   $��50��6[   $��265,725,0,0q�6g   $	��Top=�6|   $	��150��6�   $��14(�6�   $
��Bold"�6�   ��5&      �� 5'      $ 
/pj1b2.jpg��6!   5)      �� 5*      -   5        $ btnpw��5*      $�� ��6$   $
��Left=�6/   $��75��6J   $��
37,300,0,0q�6V   $	��Top=�6j   $��75��6�   ��5+      �� 5,      $ /Pawn_W.png��6!   5.      �� 5/      -   5        $ btnrw��5/      $�� ��6$   $
��Left=�6/   $��75��6J   $��112,300,0,0q�6V   $	��Top=�6k   $��76��6�   ��50      �� 51      $ /Rook_W.png��6!   53      �� 54      -	   5        $ btnkw��54      $�� ��6$   $��Center=�6/   $��75��6L   $��	0,300,0,0q�6X   $	��Top=�6k   $��75��6�   ��55      �� 56      $ /Knight_W.png��6!   58      �� 59      -
   5        $ btnbw��59      $�� ��6$   $
��Left=�6/   $��75��6J   $��262,300,0,0q�6V   $	��Top=�6k   $��75��6�   ��5:      �� 5;      $ /Bishop_W.png��6!   5=      �� 5>      -   5        $ btnqw��5>      $�� ��6$   $
��Left=�6/   $��75��6J   $��337,300,0,0q�6V   $	��Top=�6k   $��75��6�   ��5?      �� 5@      $ /Queen_W.png��6!   5B      �� 5C      -   5        $ btnpb��5C      $�� ��6$   $
��Left=�6/   $��75��6J   $��
40,650,0,0q�6V   $	��Top=�6j   $��75��6�   ��5D      �� 5E      $ /Pawn_B.png��6!   5G      �� 5H      -   5        $ btnrb��5H      $�� ��6$   $
��Left=�6/   $��75��6J   $��115,650,0,0q�6V   $	��Top=�6k   $��75��6�   ��5I      �� 5J      $ /Rook_B.png��6!   5L      �� 5M      -   5        $ btnkb��5M      $�� ��6$   $
��Left=�6/   $��75��6J   $��190,650,0,0q�6V   $	��Top=�6k   $��75��6�   ��5N      �� 5O      $ /Knight_B.png��6!   5Q      �� 5R      -   5        $ btnbb��5R      $�� ��6$   $
��Left=�6/   $��75��6J   $��265,650,0,0q�6V   $	��Top=�6k   $��75��6�   ��5S      �� 5T      $ /Bishop_B.png��6!   5V      �� 5W      -   5        $ btnqb��5W      $�� ��6$   $
��Left=�6/   $��75��6J   $��340,650,0,0q�6V   $	��Top=�6k   $��75��6�   ��5X      �� 5Y      $ /Queen_B.png��6!   5[      �� 5\      -   5        $ btnrs��5\      $��Restart��6$   $
��Left=�66   $��50��6Q   $��
300,50,0,0q�6]   $	��Top=�6q   $	��150��6�   $��14(�6�   $
��Bold"�6�   ��5]      �� 5^      $ 
/pj1b2.jpg��6!   5`      �� 5a      -   5         ��Name$ label6��5a      $��0��6$   $
��Left=�60   $��50��6K   $��
40,600,0,0q�6W   $	��Top=�6k   $��75��6�   $
��Bold"�6�   $��36(�6�   $��Center=�6�   $��Center=�6�   �� 5b      -   5        $ label7��5b      $��0��6$   $
��Left=�60   $��50��6K   $��115,600,0,0q�6W   $	��Top=�6l   $��75��6�   $
��Bold"�6�   $��36(�6�   $��Center=�6�   $��Center=�6�   �� 5c      -   5        $ label8��5c      $��0��6$   $
��Left=�60   $��50��6K   $��190,600,0,0q�6W   $	��Top=�6l   $��75��6�   $
��Bold"�6�   $��36(�6�   $��Center=�6�   $��Center=�6�   �� 5d      -   5        $ label9��5d      $��0��6$   $
��Left=�60   $��50��6K   $��265,600,0,0q�6W   $	��Top=�6l   $��75��6�   $
��Bold"�6�   $��36(�6�   $��Center=�6�   $��Center=�6�   �� 5e      -   5        $ label10��5e      $��0��6%   $
��Left=�61   $��50��6L   $��340,600,0,0q�6X   $	��Top=�6m   $��75��6�   $
��Bold"�6�   $��36(�6�   $��Center=�6�   $��Center=�6�   �� 5f      -   5        $ label1��5f      $��0��6$   $
��Left=�60   $��50��6K   $��
37,250,0,0q�6W   $	��Top=�6k   $��75��6�   $
��Bold"�6�   $��36(�6�   $��Center=�6�   $��Center=�6�   �� 5g      -   5        $ label2��5g      $��0��6$   $
��Left=�60   $��50��6K   $��112,250,0,0q�6W   $	��Top=�6l   $��75��6�   $
��Bold"�6�   $��36(�6�   $��Center=�6�   $��Center=�6�   �� 5h      -   5        $ label3��5h      $��0��6$   $��Center=�60   $��50��6M   $��	0,250,0,0q�6Y   $	��Top=�6l   $��75��6�   $
��Bold"�6�   $��36(�6�   $��Center=�6�   $��Center=�6�   �� 5i      -   5        $ label4��5i      $��0��6$   $
��Left=�60   $��50��6K   $��262,250,0,0q�6W   $	��Top=�6l   $��75��6�   $
��Bold"�6�   $��36(�6�   $��Center=�6�   $��Center=�6�   �� 5j      -   5        $ label5��5j      $��0��6$   $
��Left=�60   $��50��6K   $��337,250,0,0q�6W   $	��Top=�6l   $��75��6�   $
��Bold"�6�   $��36(�6�   $��Center=�6�   $��Center=�6�   �� 5k      -   5        $ btnn2��5k      $�� ��6$   $
��Left=�6/   $��50��6J   $��352,550,0,0q�6V   $	��Top=�6k   $��50��6�    J� RenderTransformOrigin$ 0.536,0.535&�6�   
���  ��6�   �� 5l      -   5        $ btnn1��5l      $�� ��6$   $
��Left=�6/   $��50��6J   $��350,200,0,0q�6V   $	��Top=�6k   $��50��6�   
��� � �6�   �� 5m      $��Player 1��6   $
��Left=�6'   $��51��6B   $��	0,100,0,0q�6N   $	��Top=�6a   $	��150��6y   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��24(�6�   �� 5n      $��Player 2��6   $
��Left=�6'   $��51��6B   $��	0,428,0,0q�6N   $	��Top=�6a   $	��150��6y   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��24(�6�   �� 5o      -   5        $ time1��5o      $��0��6#   $
��Left=�6/   $��51��6J   $��228,144,0,0q�6V   $	��Top=�6k   $	��150��6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��24(�6�   �� 5p      -   5        $ time2��5p      $��0��6#   $
��Left=�6/   $��51��6J   $��228,499,0,0q�6V   $	��Top=�6k   $	��150��6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��24(�6�   �� 5q      -    5        $��Start��5q      $
��Left=�6%   $��50��6@   $��	300,0,0,0q�6L   $	��Top=�6_   $	��150��6w   $��14(�6�   $
��Bold"�6�   ��5r      �� 5s      $ 
/pj1b2.jpg��6!   5u      �� 5v      -!   5        $ check1��5v      $�� ��6$   $
��Left=�6/   $��51��6J   $��
37,151,0,0q�6V   $	��Top=�6j   $	��150��6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��24(�6�   �� 5w      -"   5        $ check2��5w      $�� ��6$   $
��Left=�6/   $��51��6J   $��	0,484,0,0q�6V   $	��Top=�6i   $	��150��6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��24(�6�   �� 5x      -#   5        $ final��5x      $�� ��6#   $
��Left=�6.   $��51��6I   $��2,50,0,0q�6U   $	��Top=�6g   $	��150��6   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��24(�6�   �� 5y      -$   5        $ mate1��5y      $�� ��6#   $
��Left=�6.   $��51��6I   $��	0,377,0,0q�6U   $	��Top=�6h   $	��150��6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��24(�6�   �� 5z      -%   5        $ mate2��5z      $�� ��6#   $
��Left=�6.   $��51��6I   $��	2,725,0,0q�6U   $	��Top=�6h   $	��150��6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��24(�6�   5{      � 5}   
   -&   5        $ Grid_2��5}      $	��800��6   $	��800��6,   $��Center=�68   $
��Left=�6S   $��25,0,0,0q�6n   ��5~      �� 5      $ /chessboard.png��6   .+�5�      �� -'   5        $
 btn1��5�      $�� ��6#   $
��Left=�6.   $	��100��6I   $��700,700,0,0q�6V   $	��Top=�6k   $	��100��6�   ��5�      �� 5�      $ /Rook_W.png��6!   5�      �� 5�      -(   5        $
 btn2��5�      $�� ��6#   $
��Left=�6.   $	��100��6I   $��600,700,0,0q�6V   $	��Top=�6k   $	��100��6�   ��5�      �� 5�      $ /Knight_W.png��6!   5�      �� 5�      -)   5        $
 btn3��5�      $�� ��6#   $
��Left=�6.   $	��100��6I   $��500,700,0,0q�6V   $	��Top=�6k   $	��100��6�   ��5�      �� 5�      $ /Bishop_W.png��6!   5�      �� 5�      -*   5        $
 btn4��5�      $�� ��6#   $
��Left=�6.   $	��100��6I   $��400,700,0,0q�6V   $	��Top=�6k   $	��100��6�   ��5�      �� 5�      $ /King_W.png��6!   5�      �� 5�      -+   5        $
 btn5��5�      $�� ��6#   $
��Left=�6.   $	��100��6I   $��300,700,0,0q�6V   $	��Top=�6k   $	��100��6�   ��5�      �� 5�      $ /Queen_W.png��6!   5�      �� 5�      -,   5        $
 btn6��5�      $�� ��6#   $
��Left=�6.   $	��100��6I   $��200,700,0,0q�6V   $	��Top=�6k   $	��100��6�   ��5�      �� 5�      $ /Bishop_W.png��6!   5�      �� 5�      --   5        $
 btn7��5�      $�� ��6#   $
��Left=�6.   $	��100��6I   $��100,700,0,0q�6V   $	��Top=�6k   $	��100��6�   ��5�      �� 5�      $ /Knight_W.png��6!   5�      �� 5�      -.   5        $
 btn8��5�      $�� ��6#   $
��Left=�6.   $	��100��6I   $��	0,700,0,0q�6V   $	��Top=�6i   $	��100��6�   ��5�      �� 5�      $ /Rook_W.png��6!   5�      �� 5�      -/   5        $
 btn9��5�      $�� ��6#   $
��Left=�6.   $	��100��6I   $��700,600,0,0q�6V   $	��Top=�6k   $	��100��6�   ��5�      �� 5�      $ /Pawn_W.png��6!   5�      �� 5�      -0   5        $ btn10��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��600,600,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5�      �� 5�      $ /Pawn_W.png��6!   5�      �� 5�      -1   5        $ btn11��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��500,600,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5�      �� 5�      $ /Pawn_W.png��6!   5�      �� 5�      -2   5        $ btn12��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��400,600,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5�      �� 5�      $ /Pawn_W.png��6!   5�      �� 5�      -3   5        $ btn13��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��300,600,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5�      �� 5�      $ /Pawn_W.png��6!   5�      �� 5�      -4   5        $ btn14��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��200,600,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5�      �� 5�      $ /Pawn_W.png��6!   5�      �� 5�      -5   5        $ btn15��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��100,600,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5�      �� 5�      $ /Pawn_W.png��6!   5�      �� 5�      -6   5        $ btn16��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��	0,600,0,0q�6W   $	��Top=�6j   $	��100��6�   ��5�      �� 5�      $ /Pawn_W.png��6!   5�      �� 5�      -7   5        $ btn17��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��700,500,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5�      �� 5�      5�      �� 5�      -8   5        $ btn18��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��600,500,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5�      �� 5�      5�      �� 5�      -9   5        $ btn19��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��500,500,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5�      �� 5�      5�      �� 5�      -:   5        $ btn20��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��400,500,0,0q�6W   $	��Top=�6l   $	��100��6�   $
��Bold"�6�   $��16(�6�   ��6�   Z� 6�   �� 5�      -;   5        $ btn21��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��300,500,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5�      �� 5�      5�      �� 5�      -<   5        $ btn22��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��200,500,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5�      �� 5�      5�      �� 5�      -=   5        $ btn23��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��100,500,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5�      �� 5�      5�      �� 5�      ->   5        $ btn24��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��	0,500,0,0q�6W   $	��Top=�6j   $	��100��6�   ��5�      �� 5�      5�      �� 5�      -?   5        $ btn25��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��700,400,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5�      �� 5�      5�      �� 5�      -@   5        $ btn26��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��600,400,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5�      �� 5�      5�      �� 5�      -A   5        $ btn27��5�      $�� ��6$   $
��Left=�6/   $	��100��6J   $��500,400,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5      �� 5     5     �� 5     -B   5        $ btn28��5     $�� ��6$   $
��Left=�6/   $	��100��6J   $��400,400,0,0q�6W   $	��Top=�6l   $	��100��6�   ��6�   Z� �� 5     -C   5        $ btn29��5     $�� ��6$   $
��Left=�6/   $	��100��6J   $��300,400,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5     �� 5     5	     �� 5
     -D   5        $ btn30��5
     $�� ��6$   $
��Left=�6/   $	��100��6J   $��200,400,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5     �� 5     5     �� 5     -E   5        $ btn31��5     $�� ��6$   $
��Left=�6/   $	��100��6J   $��100,400,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5     �� 5     5     �� 5     -F   5        $ btn32��5     $�� ��6$   $
��Left=�6/   $	��100��6J   $��	0,400,0,0q�6W   $	��Top=�6j   $	��100��6�   ��5     �� 5     5     �� 5     -G   5        $ btn33��5     $�� ��6$   $
��Left=�6/   $	��100��6J   $��700,300,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5     �� 5     5     �� 5     -H   5        $ btn34��5     $�� ��6$   $
��Left=�6/   $	��100��6J   $��600,300,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5     �� 5      5"     �� 5#     -I   5        $ btn35��5#     $�� ��6$   $
��Left=�6/   $	��100��6J   $��500,300,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5$     �� 5%     5'     �� 5(     -J   5        $ btn36��5(     $�� ��6$   $
��Left=�6/   $	��100��6J   $��400,300,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5)     �� 5*     5,     �� 5-     -K   5        $ btn37��5-     $�� ��6$   $
��Left=�6/   $	��100��6J   $��300,300,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5.     �� 5/     51     �� 52     -L   5        $ btn38��52     $�� ��6$   $
��Left=�6/   $	��100��6J   $��200,300,0,0q�6W   $	��Top=�6l   $	��100��6�   ��53     �� 54     56     �� 57     -M   5        $ btn39��57     $�� ��6$   $
��Left=�6/   $	��100��6J   $��100,300,0,0q�6W   $	��Top=�6l   $	��100��6�   ��58     �� 59     5;     �� 5<     -N   5        $ btn40��5<     $�� ��6$   $
��Left=�6/   $	��100��6J   $��	0,300,0,0q�6W   $	��Top=�6j   $	��100��6�   ��5=     �� 5>     5@     �� 5A     -O   5        $ btn41��5A     $�� ��6$   $
��Left=�6/   $	��100��6J   $��700,200,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5B     �� 5C     5E     �� 5F     -P   5        $ btn42��5F     $�� ��6$   $
��Left=�6/   $	��100��6J   $��600,200,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5G     �� 5H     5J     �� 5K     -Q   5        $ btn43��5K     $�� ��6$   $
��Left=�6/   $	��100��6J   $��500,200,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5L     �� 5M     5O     �� 5P     -R   5        $ btn44��5P     $�� ��6$   $
��Left=�6/   $	��100��6J   $��400,200,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5Q     �� 5R     5T     �� 5U     -S   5        $ btn45��5U     $�� ��6$   $
��Left=�6/   $	��100��6J   $��300,200,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5V     �� 5W     5Y     �� 5Z     -T   5        $ btn46��5Z     $�� ��6$   $
��Left=�6/   $	��100��6J   $��200,200,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5[     �� 5\     5^     �� 5_     -U   5        $ btn47��5_     $�� ��6$   $
��Left=�6/   $	��100��6J   $��100,200,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5`     �� 5a     5c     �� 5d     -V   5        $ btn48��5d     $�� ��6$   $
��Left=�6/   $	��100��6J   $��	0,200,0,0q�6W   $	��Top=�6j   $	��100��6�   ��5e     �� 5f     5h     �� 5i     -W   5        $ btn49��5i     $�� ��6$   $
��Left=�6/   $	��100��6J   $��700,100,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5j     �� 5k     $ /Pawn_B.png��6!   5m     �� 5n     -X   5        $ btn50��5n     $�� ��6$   $
��Left=�6/   $	��100��6J   $��600,100,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5o     �� 5p     $ 
Pawn_B.png��6!   5r     �� 5s     -Y   5        $ btn51��5s     $�� ��6$   $
��Left=�6/   $	��100��6J   $��500,100,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5t     �� 5u     $ 
Pawn_B.png��6!   5w     �� 5x     -Z   5        $ btn52��5x     $�� ��6$   $
��Left=�6/   $	��100��6J   $��400,100,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5y     �� 5z     $ 
Pawn_B.png��6!   5|     �� 5}     -[   5        $ btn53��5}     $�� ��6$   $
��Left=�6/   $	��100��6J   $��300,100,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5~     �� 5     $ 
Pawn_B.png��6!   5�     �� 5�     -\   5        $ btn54��5�     $�� ��6$   $
��Left=�6/   $	��100��6J   $��200,100,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5�     �� 5�     $ 
Pawn_B.png��6!   5�     �� 5�     -]   5        $ btn55��5�     $�� ��6$   $
��Left=�6/   $	��100��6J   $��100,100,0,0q�6W   $	��Top=�6l   $	��100��6�   ��5�     �� 5�     $ 
Pawn_B.png��6!   5�     �� 5�     -^   5        $ btn56��5�     $�� ��6$   $
��Left=�6/   $	��100��6J   $��	0,100,0,0q�6W   $	��Top=�6j   $	��100��6�   ��5�     �� 5�     $ 
Pawn_B.png��6!   5�     �� 5�     -_   5        $ btn57��5�     $�� ��6$   $
��Left=�6/   $	��100��6J   $��	700,0,0,0q�6W   $	��Top=�6j   $	��100��6�   ��5�     �� 5�     $ /Rook_B.png��6!   5�     �� 5�     -`   5        $ btn58��5�     $�� ��6$   $
��Left=�6/   $	��100��6J   $��	600,0,0,0q�6W   $	��Top=�6j   $	��100��6�   ��5�     �� 5�     $ /Knight_B.png��6!   5�     �� 5�     -a   5        $ btn59��5�     $�� ��6$   $
��Left=�6/   $	��100��6J   $��	500,0,0,0q�6W   $	��Top=�6j   $	��100��6�   ��5�     �� 5�     $ /Bishop_B.png��6!   5�     �� 5�     -b   5        $ btn60��5�     $�� ��6$   $
��Left=�6/   $	��100��6J   $��	400,0,0,0q�6W   $	��Top=�6j   $	��100��6�   ��5�     �� 5�     $ /King_B.png��6!   5�     �� 5�     -c   5        $ btn61��5�     $�� ��6$   $
��Left=�6/   $	��100��6J   $��	300,0,0,0q�6W   $	��Top=�6j   $	��100��6�   ��5�     �� 5�     $ /Queen_B.png��6!   5�     �� 5�     -d   5        $ btn62��5�     $�� ��6$   $
��Left=�6/   $	��100��6J   $��	200,0,0,0q�6W   $	��Top=�6j   $	��100��6�   ��5�     �� 5�     $ /Bishop_B.png��6!   5�     �� 5�     -e   5        $ btn63��5�     $�� ��6$   $
��Left=�6/   $	��100��6J   $��	100,0,0,0q�6W   $	��Top=�6j   $	��100��6�   ��5�     �� 5�     $ /Knight_B.png��6!   5�     �� 5�     -f   5        $ btn64��5�     $�� ��6$   $
��Left=�6/   $	��100��6J   $��0,0,0,0q�6W   $	��Top=�6h   $	��100��6�   ��5�     �� 5�     $ /Rook_B.png��6!   5�     5�     5�     5�     