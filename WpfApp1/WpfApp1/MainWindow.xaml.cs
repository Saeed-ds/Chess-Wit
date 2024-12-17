using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
//written by Saeed Solymany => Saeed Paya
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int pw, pb, rw, rb, kw, kb, bw, bb, qw, qb, kiw, kib;
        int[,] bafo = new int[5, 4];
        int cm = 0, cn, cb, cbp, n = 0, npw = 0, nrw = 0, nkw = 0, nbw = 0, nqw = 0, npb = 0, nrb = 0, nkb = 0, nbb = 0, nqb = 0, s1, s2, s3 = 60, s4 = 14, s5 = 60, s6 = 14;
        int b1 = 20, b2 = 30, b3 = 40, b4 = 60, b5 = 50, b6 = 40, b7 = 30, b8 = 20, b9 = 10, b10 = 10, b11 = 10, b12 = 10, b13 = 10, b14 = 10, b15 = 10, b16 = 10, b17 = 0, b18 = 0, b19 = 0, b20 = 0, b21 = 0, b22 = 0, b23 = 0, b24 = 0, b25 = 0, b26 = 0, b27 = 0, b28 = 0, b29 = 0, b30 = 0, b31 = 0, b32 = 0, b33 = 0, b34 = 0, b35 = 0, b36 = 0, b37 = 0, b38 = 0, b39 = 0, b40 = 0, b41 = 0, b42 = 0, b43 = 0, b44 = 0, b45 = 0, b46 = 0, b47 = 0, b48 = 0, b49 = 11, b50 = 11, b51 = 11, b52 = 11, b53 = 11, b54 = 11, b55 = 11, b56 = 11, b57 = 21, b58 = 31, b59 = 41, b60 = 61, b61 = 51, b62 = 41, b63 = 31, b64 = 21;
        public void left_cl()
        {
            if (x2 % 8 == 0) f = 8 * (x2 / 8);
            else f = 8 * (x2 / 8 + 1);
        }
        public DispatcherTimer timer1 = new DispatcherTimer();
        public DispatcherTimer timer2 = new DispatcherTimer();
        public Dictionary<int, Button> buttonMap;
        public Dictionary<int, int> stateMap;
        public Dictionary<int, int> razorMap;
        public MainWindow()
        {
            InitializeComponent();
            map();
            timer1.Interval = TimeSpan.FromSeconds(1);
            timer2.Interval = TimeSpan.FromSeconds(1);
            timer1.Tick += Timer1_Tick;
            timer2.Tick += Timer2_Tick;

        }
        public void map()
        {
            buttonMap = new Dictionary<int, Button>
        {
            { 1, btn1 },
            { 2, btn2 },
            { 3, btn3 },
            { 4, btn4 },
            { 5, btn5 },
            { 6, btn6 },
            { 7, btn7 },
            { 8, btn8 },
            { 9, btn9 },
            { 10, btn10 },
            { 11, btn11 },
            { 12, btn12 },
            { 13, btn13 },
            { 14, btn14 },
            { 15, btn15 },
            { 16, btn16 },
            { 17, btn17 },
            { 18, btn18 },
            { 19, btn19 },
            { 20, btn20 },
            { 21, btn21 },
            { 22, btn22 },
            { 23, btn23 },
            { 24, btn24 },
            { 25, btn25 },
            { 26, btn26 },
            { 27, btn27 },
            { 28, btn28 },
            { 29, btn29 },
            { 30, btn30 },
            { 31, btn31 },
            { 32, btn32 },
            { 33, btn33 },
            { 34, btn34 },
            { 35, btn35 },
            { 36, btn36 },
            { 37, btn37 },
            { 38, btn38 },
            { 39, btn39 },
            { 40, btn40 },
            { 41, btn41 },
            { 42, btn42 },
            { 43, btn43 },
            { 44, btn44 },
            { 45, btn45 },
            { 46, btn46 },
            { 47, btn47 },
            { 48, btn48 },
            { 49, btn49 },
            { 50, btn50 },
            { 51, btn51 },
            { 52, btn52 },
            { 53, btn53 },
            { 54, btn54 },
            { 55, btn55 },
            { 56, btn56 },
            { 57, btn57 },
            { 58, btn58 },
            { 59, btn59 },
            { 60, btn60 },
            { 61, btn61 },
            { 62, btn62 },
            { 63, btn63 },
            { 64, btn64 }
        };
            stateMap = new Dictionary<int, int>
            {
            { 1, b1 },
            { 2, b2 },
            { 3, b3 },
            { 4, b4 },
            { 5, b5 },
            { 6, b6 },
            { 7, b7 },
            { 8, b8 },
            { 9, b9 },
            { 10, b10 },
            { 11, b11 },
            { 12, b12 },
            { 13, b13 },
            { 14, b14 },
            { 15, b15 },
            { 16, b16 },
            { 17, b17 },
            { 18, b18 },
            { 19, b19 },
            { 20, b20 },
            { 21, b21 },
            { 22, b22 },
            { 23, b23 },
            { 24, b24 },
            { 25, b25 },
            { 26, b26 },
            { 27, b27 },
            { 28, b28 },
            { 29, b29 },
            { 30, b30 },
            { 31, b31 },
            { 32, b32 },
            { 33, b33 },
            { 34, b34 },
            { 35, b35 },
            { 36, b36 },
            { 37, b37 },
            { 38, b38 },
            { 39, b39 },
            { 40, b40 },
            { 41, b41 },
            { 42, b42 },
            { 43, b43 },
            { 44, b44 },
            { 45, b45 },
            { 46, b46 },
            { 47, b47 },
            { 48, b48 },
            { 49, b49 },
            { 50, b50 },
            { 51, b51 },
            { 52, b52 },
            { 53, b53 },
            { 54, b54 },
            { 55, b55 },
            { 56, b56 },
            { 57, b57 },
            { 58, b58 },
            { 59, b59 },
            { 60, b60 },
            { 61, b61 },
            { 62, b62 },
            { 63, b63 },
            { 64, b64 }
            };
            razorMap = new Dictionary<int, int>
            {
                { 1, p1 },
                { 2, p2 },
                { 3, p3 },
                { 4, p4 },
                { 5, p5 },
                { 6, p6 },
                { 7, p7 }
            };
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer1.Start();
            s = 1;
        }
        public void lose1_cl()
        {
            final.Content = "Player 1 lose";
            s = 0;
            timer1.Stop();
        }
        public void lose2_cl()
        {
            final.Content = "Player 2 lose";
            s = 0;
            timer2.Stop();
        }

        private void btnsurrender1_Click(object sender, RoutedEventArgs e)
        {
            lose1_cl();
        }

        private void btnsurrender2_Click(object sender, RoutedEventArgs e)
        {
            lose2_cl();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            s3--;
            if (s3 == 0)
            {
                s3 = 60;
                s4--;
            }
            if (s4 == 0 && s3 == 0) lose1_cl();
            time1.Content = s4 + ":" + s3;
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            s5--;
            if (s5 == 0)
            {
                s5 = 60;
                s6--;
            }
            if (s6 == 0 && s5 == 0) lose2_cl();
            time2.Content = s6 + ":" + s5;
        }
        public void timer1_cl()
        {
            timer1.Stop();
            timer2.Start();
        }
        public void timer2_cl()
        {
            timer2.Stop();
            timer1.Start();
        }

        private void btnqb_Click(object sender, RoutedEventArgs e)
        {

            if (nqb > 0 && cb < 9 && cn == 11 && n % 2 == 1)
            {
                s2 = 51;
                nqb--;
                npb++;
                label6.Content = npb;
                label10.Content = nqb;
                bafoh_cl();
                m_void();
                timer2_cl();
                qb = cb;
                if (cb >= 1 && cb <= 8)
                {
                    Queen_B_cl();
                    stateMap[cb] = 51;
                }
            }
        }

        private void btnbb_Click(object sender, RoutedEventArgs e)
        {
            if (nbb > 0 && cb < 9 && cn == 11 && n % 2 == 1)
            {
                s2 = 41;
                nbb--;
                npb++;
                label6.Content = npb;
                label9.Content = nbb;
                bafoh_cl();
                m_void();
                timer2_cl();
                bb = cb;
                if (cb >= 1 && cb <= 8)
                {
                    Bishop_B_cl();
                    stateMap[cb] = 41;
                }
            }
        }

        private void btnkb_Click(object sender, RoutedEventArgs e)
        {
            if (nkb > 0 && cb < 9 && cn == 11 && n % 2 == 1)
            {
                s2 = 31;
                nkb--;
                npb++;
                label6.Content = npb;
                label8.Content = nkb;
                bafoh_cl();
                m_void();
                timer2_cl();
                kb = cb;
                if (cb >= 1 && cb <= 8)
                {
                    Knight_B_cl();
                    stateMap[cb] = 31;
                }
            }
        }

        private void btnrb_Click(object sender, RoutedEventArgs e)
        {
            if (nrb > 0 && cb < 9 && cn == 11 && n % 2 == 1)
            {
                s2 = 21;
                nrb--;
                npb++;
                label6.Content = npb;
                label7.Content = nrb;
                bafoh_cl();
                m_void();
                timer2_cl();
                rb = cb;
                if (cb >= 1 && cb <= 8)
                {
                    Rook_B_cl();
                    stateMap[cb] = 21;
                }
            }
        }

        private void btnqw_Click(object sender, RoutedEventArgs e)
        {
            if (nqw > 0 && cb > 56 && cn == 10 && n % 2 == 0)
            {
                s2 = 50;
                nqw--;
                npw++;
                label1.Content = npw;
                label5.Content = nqw;
                bafoh_cl();
                m_void();
                timer1_cl();
                qw = cb;
                if (cb >= 57 && cb <= 64)
                {
                    Queen_W_cl();
                    stateMap[cb] = 50;
                }
            }
        }

        private void btnbw_Click(object sender, RoutedEventArgs e)
        {
            if (nbw > 0 && cb > 56 && cn == 10 && n % 2 == 0)
            {
                s2 = 40;
                nbw--;
                npw++;
                label1.Content = npw;
                label4.Content = nbw;
                bafoh_cl();
                m_void();
                timer1_cl();
                bw = cb;
                if (cb >= 57 && cb <= 64)
                {
                    Bishop_W_cl();
                    stateMap[cb] = 40;
                }
            }
        }

        private void btnkw_Click(object sender, RoutedEventArgs e)
        {
            if (nkw > 0 && cb > 56 && cn == 10 && n % 2 == 0)
            {
                s2 = 30;
                nkw--;
                npw++;
                label1.Content = npw;
                label3.Content = nkw;
                bafoh_cl();
                m_void();
                timer1_cl();
                kw = cb;
                if (cb >= 57 && cb <= 64)
                {
                    Knight_W_cl();
                    stateMap[cb] = 30;
                }
            }
        }

        private void btnrw_Click(object sender, RoutedEventArgs e)
        {
            if (nrw > 0 && cb > 56 && cn == 10 && n % 2 == 0)
            {
                s2 = 20;
                nrw--;
                npw++;
                label1.Content = npw;
                label2.Content = nrw;
                bafoh_cl();
                m_void();
                timer1_cl();
                rw = cb;
                if (cb >= 57 && cb <= 64)
                {
                    Rook_W_cl();
                    stateMap[cb] = 20;
                }
            }
        }
        public void bafoh_cl()
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    bafo[row, col] = bafo[row + 1, col];
                }
            }
            bafo[4, 0] = cb;
            bafo[4, 1] = 10;
            bafo[4, 2] = cb;
            bafo[4, 3] = s2;
        }
        public void da_board()
        {
            if (s1 == 10) npw++;
            else if (s1 == 11) npb++;
            else if (s1 == 20) nrw++;
            else if (s1 == 21) nrb++;
            else if (s1 == 30) nkw++;
            else if (s1 == 31) nkb++;
            else if (s1 == 40) nbw++;
            else if (s1 == 41) nbb++;
            else if (s1 == 50) nqw++;
            else if (s1 == 51) nqb++;
            label1.Content = npw;
            label2.Content = nrw;
            label3.Content = nkw;
            label4.Content = nbw;
            label5.Content = nqw;
            label6.Content = npb;
            label7.Content = nrb;
            label8.Content = nkb;
            label9.Content = nbb;
            label10.Content = nqb;
        }
        public void de_board()
        {
            if (s1 == 10) npw--;
            else if (s1 == 11) npb--;
            else if (s1 == 20) nrw--;
            else if (s1 == 21) nrb--;
            else if (s1 == 30) nkw--;
            else if (s1 == 31) nkb--;
            else if (s1 == 40) nbw--;
            else if (s1 == 41) nbb--;
            else if (s1 == 50) nqw--;
            else if (s1 == 51) nqb--;
            label1.Content = npw;
            label2.Content = nrw;
            label3.Content = nkw;
            label4.Content = nbw;
            label5.Content = nqw;
            label6.Content = npb;
            label7.Content = nrb;
            label8.Content = nkb;
            label9.Content = nbb;
            label10.Content = nqb;
        }
        int s = 0;
        public void draw1_cl()
        {
            if (npw == 8 && nrw == 2 && nkw == 2 && nbw == 2 && nqw == 1 && npb == 8 && nrb == 2 && nkb == 2 && nbb == 2 && nqb == 1)
            {
                final.Content = "draw";
                s = 0;
            }
        }
        public void m_void()
        {
            cm = 0;
            n++;
            if (n % 2 == 0)
            {
                btnn1.Background = new SolidColorBrush(Colors.Green);
                btnn2.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                btnn2.Background = new SolidColorBrush(Colors.Green);
                btnn1.Background = new SolidColorBrush(Colors.Red);
            }
        }
        int y;
        public void Pawn_W_move_cl()
        {
            if (cbp % 8 == 0) y = 8 * (cbp / 8);
            else y = 8 * (cbp / 8 + 1);
            if ((cbp + 9) <= 64)
            {
                if (cbp >= 9 && cbp <= 16)
                {
                    if (stateMap[(cbp + 8)] == 0)
                    {
                        if (cb == (cbp + 8)) main_cl();
                        else if ((stateMap[(cbp + 16)] == 0) && (cb == (cbp + 16))) main_cl();
                    }
                    if ((stateMap[(cbp + 9)] % 2 == 1) && (cb == (cbp + 9)) && (cbp + 9) <= (y + 8)) main_cl();
                    if ((stateMap[(cbp + 7)] % 2 == 1) && (cb == (cbp + 7)) && (cbp + 7) > y) main_cl();
                }
                if (stateMap[(cbp + 8)] == 0 && cb == (cbp + 8)) main_cl();
                if ((stateMap[(cbp + 9)] % 2 == 1) && (cb == (cbp + 9)) && (cbp + 9) <= (y + 8)) main_cl();
                if ((stateMap[(cbp + 7)] % 2 == 1) && (cb == (cbp + 7)) && (cbp + 7) > y) main_cl();
            }
        }
        public void Pawn_B_move_cl()
        {
            if (cbp % 8 == 0) y = 8 * (cbp / 8);
            else y = 8 * (cbp / 8 + 1);
            if ((cbp - 9) >= 1)
            {
                if (cbp >= 49 && cbp <= 56)
                {
                    if (stateMap[(cbp - 8)] == 0)
                    {
                        if (cb == (cbp - 8)) main_cl();
                        else if ((stateMap[(cbp - 16)] == 0) && (cb == (cbp - 16))) main_cl();
                    }
                    if ((stateMap[(cbp - 9)] != 0) && (stateMap[(cbp - 9)] % 2 == 0) && (cb == (cbp - 9)) && (cbp - 9) > (y - 16)) main_cl();
                    if ((stateMap[(cbp - 7)] != 0) && (stateMap[(cbp - 7)] % 2 == 0) && (cb == (cbp - 7)) && (cbp - 7) <= (y - 8)) main_cl();
                }
                if (stateMap[(cbp - 8)] == 0 && cb == (cbp - 8)) main_cl();
                if ((stateMap[(cbp - 9)] != 0) && (stateMap[(cbp - 9)] % 2 == 0) && (cb == (cbp - 9)) && (cbp - 9) > (y - 16)) main_cl();
                if ((stateMap[(cbp - 7)] != 0) && (stateMap[(cbp - 7)] % 2 == 0) && (cb == (cbp - 7)) && (cbp - 7) <= (y - 8)) main_cl();
            }
        }
        public void Move_cl()
        {
            if (cm == 0)
            {

            }
            else if (cm > 0)
            {
                if (n % 2 == 0)
                {
                    if (cm == 10) Pawn_W_move_cl();
                    else if (cm == 20) Rook_W_main_cl();
                    else if (cm == 30) Knight_W_main_cl();
                    else if (cm == 40) Bishop_W_main_cl();
                    else if (cm == 50) Queen_W_main_cl();
                    else if (cm == 60) King_W_main_cl();
                }
                else if (n % 2 == 1)
                {
                    if (cm == 11) Pawn_B_move_cl();
                    else if (cm == 21) Rook_B_main_cl();
                    else if (cm == 31) Knight_B_main_cl();
                    else if (cm == 41) Bishop_B_main_cl();
                    else if (cm == 51) Queen_B_main_cl();
                    else if (cm == 61) King_B_main_cl();
                }
            }
        }
        int c = 0, m = 0;
        public void check1_main_cl()
        {
            c = 1;
            check1.Content = "Ckeck";
            m = stateMap[cb];
        }
        public void check2_main_cl()
        {
            c = 1;
            check2.Content = "Ckeck";
            m = stateMap[cb];
        }
        public void uncheck1_main_cl()
        {
            c = 0;
            check1.Content = "";
            m = 0;
        }
        public void uncheck2_main_cl()
        {
            c = 0;
            check2.Content = "";
            m = 0;
        }
        public void check_W_main_cl()
        {
            if (c == 0)
            {
                x2 = cb;
                h = 4;
                x3 = 61;
                if (m == 0)
                {
                    if (stateMap[cb] == 10)
                    {
                        left_cl();
                        if ((cb + 7) <= 64 && stateMap[cb + 7] == 61 && (cb + 7) > f) check2_main_cl();
                        if ((cb + 9) <= 64 && stateMap[cb + 9] == 61 && (cb + 9) <= f + 8) check2_main_cl();
                    }
                    else if (stateMap[cb] == 20)
                    {
                        dump_Rook_main_cl();
                    }
                    if (stateMap[cb] == 30)
                    {
                        left_cl();
                        if ((cb + 8 - 2) >= f && (cb + 8 - 2) <= 64 && stateMap[cb + 8 - 2] == 61) check2_main_cl();
                        if ((cb + 16 - 1) >= f + 8 && (cb + 16 - 1) <= 64 && stateMap[cb + 16 - 1] == 61) check2_main_cl();
                        if ((cb + 16 + 1) >= f + 8 && (cb + 16 + 1) <= 64 && stateMap[cb + 16 + 1] == 61) check2_main_cl();
                        if ((cb + 8 + 2) >= f && (cb + 8 + 2) <= 64 && stateMap[cb + 8 + 2] == 61) check2_main_cl();
                        if ((cb - 8 + 2) <= f - 8 && (cb - 8 + 2) >= 1 && stateMap[cb - 8 + 2] == 61) check2_main_cl();
                        if ((cb - 16 + 1) <= f - 16 && (cb - 16 + 1) >= 1 && stateMap[cb - 16 + 1] == 61) check2_main_cl();
                        if ((cb - 16 - 1) <= f - 16 && (cb - 16 - 1) >= 1 && stateMap[cb - 16 - 1] == 61) check2_main_cl();
                        if ((cb - 8 - 2) <= f - 8 && (cb - 8 - 2) >= 1 && stateMap[cb - 8 - 2] == 61) check2_main_cl();
                    }
                    if (stateMap[cb] == 40)
                    {
                        dump_Bishop_main_cl();
                    }
                    if (stateMap[cb] == 50)
                    {
                        dump_Rook_main_cl();
                        dump_Bishop_main_cl();
                    }
                }
            }
        }
        public void check_B_main_cl()
        {
            x2 = cb;
            h = 3;
            x3 = 60;
            if (c == 0)
            {
                if (m == 0)
                {
                    if (stateMap[cb] == 11)
                    {
                        left_cl();
                        if ((cb - 7) >= 1 && stateMap[cb - 7] == 60 && (cb - 7) <= f - 8) check1_main_cl();
                        if ((cb - 9) >= 1 && stateMap[cb - 9] == 60 && (cb - 9) > f - 16) check1_main_cl();
                    }
                    else if (stateMap[cb] == 21)
                    {
                        dump_Rook_main_cl();
                    }
                    if (stateMap[cb] == 31)
                    {
                        left_cl();
                        if ((cb + 8 - 2) >= f && (cb + 8 - 2) <= 64 && stateMap[cb + 8 - 2] == 60) check1_main_cl();
                        if ((cb + 16 - 1) >= f + 8 && (cb + 16 - 1) <= 64 && stateMap[cb + 16 - 1] == 60) check1_main_cl();
                        if ((cb + 16 + 1) >= f + 8 && (cb + 16 + 1) <= 64 && stateMap[cb + 16 + 1] == 60) check1_main_cl();
                        if ((cb + 8 + 2) >= f && (cb + 8 + 2) <= 64 && stateMap[cb + 8 + 2] == 60) check1_main_cl();
                        if ((cb - 8 + 2) <= f - 8 && (cb - 8 + 2) >= 1 && stateMap[cb - 8 + 2] == 60) check1_main_cl();
                        if ((cb - 16 + 1) <= f - 16 && (cb - 16 + 1) >= 1 && stateMap[cb - 16 + 1] == 60) check1_main_cl();
                        if ((cb - 16 - 1) <= f - 16 && (cb - 16 - 1) >= 1 && stateMap[cb - 16 - 1] == 60) check1_main_cl();
                        if ((cb - 8 - 2) <= f - 8 && (cb - 8 - 2) >= 1 && stateMap[cb - 8 - 2] == 60) check1_main_cl();
                    }
                    if (stateMap[cb] == 41)
                    {
                        dump_Bishop_main_cl();
                    }
                    if (stateMap[cb] == 51)
                    {
                        dump_Rook_main_cl();
                        dump_Bishop_main_cl();
                    }
                }
            }
        }
        int w;
        public void uncheck_W_main_cl()
        {
            h = 2;
            w = 0;
            for (int i = 1; i < 65; i++)
            {
                if (stateMap[i] == 60)
                {
                    x2 = i;
                    left_cl();
                    if (m == 11)
                    {
                        if ((i + 7) <= 64 && stateMap[i + 7] == 11 && (i + 7) > f - 8) w++;
                        else if ((i + 9) <= 64 && stateMap[i + 9] == 11 && (i + 9) <= f) w++;
                    }
                    if (m == 21)
                    {
                        x3 = 21;
                        dump_Rook_main_cl();
                    }
                    if (m == 31)
                    {
                        if ((i + 8 - 2) >= f && (i + 8 - 2) <= 64 && stateMap[i + 8 - 2] == 31) w++;
                        if ((i + 16 - 1) >= f + 8 && (i + 16 - 1) <= 64 && stateMap[i + 16 - 1] == 31) w++;
                        if ((i + 16 + 1) >= f + 8 && (i + 16 + 1) <= 64 && stateMap[i + 16 + 1] == 31) w++;
                        if ((i + 8 + 2) >= f && (i + 8 + 2) <= 64 && stateMap[i + 8 + 2] == 31) w++;
                        if ((i - 8 + 2) <= f - 8 && (i - 8 + 2) >= 1 && stateMap[i - 8 + 2] == 31) w++;
                        if ((i - 16 + 1) <= f - 16 && (i - 16 + 1) >= 1 && stateMap[i - 16 + 1] == 31) w++;
                        if ((i - 16 - 1) <= f - 16 && (i - 16 - 1) >= 1 && stateMap[i - 16 - 1] == 31) w++;
                        if ((i - 8 - 2) <= f - 8 && (i - 8 - 2) >= 1 && stateMap[i - 8 - 2] == 31) w++;
                    }
                    if (m == 41)
                    {
                        x3 = 41;
                        dump_Bishop_main_cl();
                    }
                    if (m == 51)
                    {
                        x3 = 51;
                        dump_Rook_main_cl();
                        dump_Bishop_main_cl();
                    }
                }
            }
            if (w == 0) uncheck1_main_cl();
        }
        int b;
        public void uncheck_B_main_cl()
        {
            h = 1;
            b = 0;
            if (c == 1)
            {
                for (int i = 1; i < 65; i++)
                {
                    if (stateMap[i] == 61)
                    {
                        x2 = i;
                        left_cl();
                        if ((i - 7) >= 1 && stateMap[i - 7] == 10 && (i - 7) <= f - 8) b++;
                        if ((i - 9) >= 1 && stateMap[i - 9] == 10 && (i - 9) > f - 16) b++;
                        x3 = 20;
                        dump_Rook_main_cl();
                        if ((i + 8 - 2) >= f && (i + 8 - 2) <= 64 && stateMap[i + 8 - 2] == 30) b++;
                        if ((i + 16 - 1) >= f + 8 && (i + 16 - 1) <= 64 && stateMap[i + 16 - 1] == 30) b++;
                        if ((i + 16 + 1) >= f + 8 && (i + 16 + 1) <= 64 && stateMap[i + 16 + 1] == 30) b++;
                        if ((i + 8 + 2) >= f && (i + 8 + 2) <= 64 && stateMap[i + 8 + 2] == 30) b++;
                        if ((i - 8 + 2) <= f - 8 && (i - 8 + 2) >= 1 && stateMap[i - 8 + 2] == 30) b++;
                        if ((i - 16 + 1) <= f - 16 && (i - 16 + 1) >= 1 && stateMap[i - 16 + 1] == 30) b++;
                        if ((i - 16 - 1) <= f - 16 && (i - 16 - 1) >= 1 && stateMap[i - 16 - 1] == 30) b++;
                        if ((i - 8 - 2) <= f - 8 && (i - 8 - 2) >= 1 && stateMap[i - 8 - 2] == 30) b++;
                        x3 = 40;
                        dump_Bishop_main_cl();
                        x3 = 50;
                        dump_Rook_main_cl();
                        dump_Bishop_main_cl();
                    }
                }
            }
            if (b == 0) uncheck2_main_cl();
        }
        int k = 0, g = 0;
        public void King_move_check_cl()
        {
            left_cl();
            h = 0;
            x2 = cb;
            if (n % 2 == 0)
            {
                if ((x2 - 1) >= 1 && stateMap[x2 - 1] == 61 && (x2 - 1) > f - 8) k++;
                if ((x2 + 7) <= 64 && stateMap[x2 + 7] == 61 && (x2 + 7) > f) k++;
                if ((x2 + 8) <= 64 && stateMap[x2 + 8] == 61 && (x2 + 8) > f) k++;
                if ((x2 + 9) <= 64 && stateMap[x2 + 9] == 61 && (x2 + 9) <= f + 8) k++;
                if ((x2 + 1) <= 64 && stateMap[x2 + 1] == 61 && (x2 + 1) <= f) k++;
                if ((x2 - 7) >= 1 && stateMap[x2 - 7] == 61 && (x2 - 7) <= f - 8) k++;
                if ((x2 - 8) >= 1 && stateMap[x2 - 8] == 61 && (x2 - 8) <= f - 8) k++;
                if ((x2 - 9) >= 1 && stateMap[x2 - 9] == 61 && (x2 - 9) > f - 16) k++;
                if ((x2 + 7) <= 64 && stateMap[x2 + 7] == 11 && (x2 + 7) > f - 8) g++;
                else if ((x2 + 9) <= 64 && stateMap[x2 + 9] == 11 && (x2 + 9) <= f) g++;
                x3 = 21;
                dump_Rook_main_cl();
                if ((x2 + 8 - 2) >= f && (x2 + 8 - 2) <= 64 && stateMap[x2 + 8 - 2] == 31) g++;
                if ((x2 + 16 - 1) >= f + 8 && (x2 + 16 - 1) <= 64 && stateMap[x2 + 16 - 1] == 31) g++;
                if ((x2 + 16 + 1) >= f + 8 && (x2 + 16 + 1) <= 64 && stateMap[x2 + 16 + 1] == 31) g++;
                if ((x2 + 8 + 2) >= f && (x2 + 8 + 2) <= 64 && stateMap[x2 + 8 + 2] == 31) g++;
                if ((x2 - 8 + 2) <= f - 8 && (x2 - 8 + 2) >= 1 && stateMap[x2 - 8 + 2] == 31) g++;
                if ((x2 - 16 + 1) <= f - 16 && (x2 - 16 + 1) >= 1 && stateMap[x2 - 16 + 1] == 31) g++;
                if ((x2 - 16 - 1) <= f - 16 && (x2 - 16 - 1) >= 1 && stateMap[x2 - 16 - 1] == 31) g++;
                if ((x2 - 8 - 2) <= f - 8 && (x2 - 8 - 2) >= 1 && stateMap[x2 - 8 - 2] == 31) g++;
                x3 = 41;
                dump_Bishop_main_cl();
                x3 = 51;
                dump_Rook_main_cl();
                dump_Bishop_main_cl();
            }
            else if (n % 2 == 1)
            {
                if ((x2 - 1) >= 1 && stateMap[x2 - 1] == 60 && (x2 - 1) > f - 8) k++;
                if ((x2 + 7) <= 64 && stateMap[x2 + 7] == 60 && (x2 + 7) > f) k++;
                if ((x2 + 8) <= 64 && stateMap[x2 + 8] == 60 && (x2 + 8) > f) k++;
                if ((x2 + 9) <= 64 && stateMap[x2 + 9] == 60 && (x2 + 9) <= f + 8) k++;
                if ((x2 + 1) <= 64 && stateMap[x2 + 1] == 60 && (x2 + 1) <= f) k++;
                if ((x2 - 7) >= 1 && stateMap[x2 - 7] == 60 && (x2 - 7) <= f - 8) k++;
                if ((x2 - 8) >= 1 && stateMap[x2 - 8] == 60 && (x2 - 8) <= f - 8) k++;
                if ((x2 - 9) >= 1 && stateMap[x2 - 9] == 60 && (x2 - 9) > f - 16) k++;
                if ((x2 + 7) <= 64 && stateMap[x2 + 7] == 10 && (x2 + 7) > f - 8) g++;
                else if ((x2 + 9) <= 64 && stateMap[x2 + 9] == 10 && (x2 + 9) <= f) g++;
                x3 = 20;
                dump_Rook_main_cl();
                if ((x2 + 8 - 2) >= f && (x2 + 8 - 2) <= 64 && stateMap[x2 + 8 - 2] == 30) g++;
                if ((x2 + 16 - 1) >= f + 8 && (x2 + 16 - 1) <= 64 && stateMap[x2 + 16 - 1] == 30) g++;
                if ((x2 + 16 + 1) >= f + 8 && (x2 + 16 + 1) <= 64 && stateMap[x2 + 16 + 1] == 30) g++;
                if ((x2 + 8 + 2) >= f && (x2 + 8 + 2) <= 64 && stateMap[x2 + 8 + 2] == 30) g++;
                if ((x2 - 8 + 2) <= f - 8 && (x2 - 8 + 2) >= 1 && stateMap[x2 - 8 + 2] == 30) g++;
                if ((x2 - 16 + 1) <= f - 16 && (x2 - 16 + 1) >= 1 && stateMap[x2 - 16 + 1] == 30) g++;
                if ((x2 - 16 - 1) <= f - 16 && (x2 - 16 - 1) >= 1 && stateMap[x2 - 16 - 1] == 30) g++;
                if ((x2 - 8 - 2) <= f - 8 && (x2 - 8 - 2) >= 1 && stateMap[x2 - 8 - 2] == 30) g++;
                x3 = 40;
                dump_Bishop_main_cl();
                x3 = 50;
                dump_Rook_main_cl();
                dump_Bishop_main_cl();
            }
        }
        public void King_W_main_cl()
        {
            h = 5;
            x1 = cb;
            x2 = cbp;
            x3 = 1;
            king_main_cl2();
        }
        public void King_B_main_cl()
        {
            h = 5;
            x1 = cb;
            x2 = cbp;
            x3 = 0;
            king_main_cl2();
        }
        public void Queen_W_main_cl()
        {
            x1 = cb;
            x2 = cbp;
            x3 = 1;
            Rook_main_cl();
            Bishop_main_cl();
        }
        public void Queen_B_main_cl()
        {
            x1 = cb;
            x2 = cbp;
            x3 = 0;
            Rook_main_cl();
            Bishop_main_cl();
        }
        public void Bishop_W_main_cl()
        {
            x1 = cb;
            x2 = cbp;
            x3 = 1;
            Bishop_main_cl();
        }
        public void Bishop_B_main_cl()
        {
            x1 = cb;
            x2 = cbp;
            x3 = 0;
            Bishop_main_cl();
        }
        public void Knight_W_main_cl()
        {
            x1 = cb;
            x2 = cbp;
            x3 = 1;
            Knight_main_cl();
        }
        public void Knight_B_main_cl()
        {
            x1 = cb;
            x2 = cbp;
            x3 = 0;
            Knight_main_cl();
        }
        public void Rook_W_main_cl()
        {
            x1 = cb;
            x2 = cbp;
            x3 = 1;
            Rook_main_cl();
        }
        public void Rook_B_main_cl()
        {
            x1 = cb;
            x2 = cbp;
            x3 = 0;
            Rook_main_cl();
        }
        int f;
        public void ChangeButtonBackground(int buttonNumber, ImageBrush newBackground)
        {
            if (buttonMap.TryGetValue(buttonNumber, out Button button))
            {
                button.Background = newBackground;
            }
            else
            {
                MessageBox.Show($"Button with number {buttonNumber} does not exist.");
            }
        }
        private void UpdateState(int stateNumber, int newState)
        {
            if (stateMap.ContainsKey(stateNumber))
            {
                stateMap[stateNumber] = newState;
                switch (stateNumber)
                {
                    case 1:
                        b1 = newState;
                        break;
                    case 2:
                        b2 = newState;
                        break;
                    case 3:
                        b3 = newState;
                        break;
                    case 4:
                        b4 = newState;
                        break;
                    case 5:
                        b5 = newState;
                        break;
                    case 6:
                        b6 = newState;
                        break;
                    case 7:
                        b7 = newState;
                        break;
                    case 8:
                        b8 = newState;
                        break;
                    case 9:
                        b9 = newState;
                        break;
                    case 10:
                        b10 = newState;
                        break;
                    case 11:
                        b11 = newState;
                        break;
                    case 12:
                        b12 = newState;
                        break;
                    case 13:
                        b13 = newState;
                        break;
                    case 14:
                        b14 = newState;
                        break;
                    case 15:
                        b15 = newState;
                        break;
                    case 16:
                        b16 = newState;
                        break;
                    case 17:
                        b17 = newState;
                        break;
                    case 18:
                        b18 = newState;
                        break;
                    case 19:
                        b19 = newState;
                        break;
                    case 20:
                        b20 = newState;
                        break;
                    case 21:
                        b21 = newState;
                        break;
                    case 22:
                        b22 = newState;
                        break;
                    case 23:
                        b23 = newState;
                        break;
                    case 24:
                        b24 = newState;
                        break;
                    case 25:
                        b25 = newState;
                        break;
                    case 26:
                        b26 = newState;
                        break;
                    case 27:
                        b27 = newState;
                        break;
                    case 28:
                        b28 = newState;
                        break;
                    case 29:
                        b29 = newState;
                        break;
                    case 30:
                        b30 = newState;
                        break;
                    case 31:
                        b31 = newState;
                        break;
                    case 32:
                        b32 = newState;
                        break;
                    case 33:
                        b33 = newState;
                        break;
                    case 34:
                        b34 = newState;
                        break;
                    case 35:
                        b35 = newState;
                        break;
                    case 36:
                        b36 = newState;
                        break;
                    case 37:
                        b37 = newState;
                        break;
                    case 38:
                        b38 = newState;
                        break;
                    case 39:
                        b39 = newState;
                        break;
                    case 40:
                        b40 = newState;
                        break;
                    case 41:
                        b41 = newState;
                        break;
                    case 42:
                        b42 = newState;
                        break;
                    case 43:
                        b43 = newState;
                        break;
                    case 44:
                        b44 = newState;
                        break;
                    case 45:
                        b45 = newState;
                        break;
                    case 46:
                        b46 = newState;
                        break;
                    case 47:
                        b47 = newState;
                        break;
                    case 48:
                        b48 = newState;
                        break;
                    case 49:
                        b49 = newState;
                        break;
                    case 50:
                        b50 = newState;
                        break;
                    case 51:
                        b51 = newState;
                        break;
                    case 52:
                        b52 = newState;
                        break;
                    case 53:
                        b53 = newState;
                        break;
                    case 54:
                        b54 = newState;
                        break;
                    case 55:
                        b55 = newState;
                        break;
                    case 56:
                        b56 = newState;
                        break;
                    case 57:
                        b57 = newState;
                        break;
                    case 58:
                        b58 = newState;
                        break;
                    case 59:
                        b59 = newState;
                        break;
                    case 60:
                        b60 = newState;
                        break;
                    case 61:
                        b61 = newState;
                        break;
                    case 62:
                        b62 = newState;
                        break;
                    case 63:
                        b63 = newState;
                        break;
                    case 64:
                        b64 = newState;
                        break;
                }
            }
        }
        public void main_cl()
        {
            if (s == 1)
            {
                if (cm == 10)
                {
                    if (c == 1)
                    {
                        UpdateState(cb, cm);
                        UpdateState(cbp, 0);
                        uncheck_W_main_cl();
                        UpdateState(cbp, cm);
                        UpdateState(cb, cn);
                    }
                    if (c == 0)
                    {
                        ImageBrush newBackground = new ImageBrush();
                        newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Pawn_W.png", UriKind.Relative));
                        ChangeButtonBackground(cb, newBackground);
                        ChangeButtonBackground(cbp, null);
                        bafo_cl();
                        UpdateState(cbp, 0);
                        s1 = cn;
                        da_board();
                        UpdateState(cb, cm);
                        m_void();
                        if (n % 2 == 0) timer2_cl();
                        else timer1_cl();
                        check_W_main_cl();
                        if (c == 1) mate_main_cl();
                        if (c == 0) move_checker();
                    }
                }
                else if (cm == 20)
                {
                    if (cn == 60)
                    {
                        if (cbp == 1 && cb == 4 && b2 == 0 && b3 == 0 && stateMap[cbp + 8] == 10 && stateMap[cbp + 9] == 10 && stateMap[cbp + 10] == 10)
                        {
                            ImageBrush newBackground = new ImageBrush();
                            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Rook_W.png", UriKind.Relative));
                            ChangeButtonBackground(3, newBackground);
                            ChangeButtonBackground(cbp, null);
                            bafo_cl();
                            UpdateState(cbp, 0);
                            UpdateState(3, cm);
                            ImageBrush newBackground2 = new ImageBrush();
                            newBackground2.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\King_W.png", UriKind.Relative));
                            ChangeButtonBackground(2, newBackground2);
                            ChangeButtonBackground(cbp, null);
                            UpdateState(cb, 0);
                            UpdateState(2, cn);
                            m_void();
                            if (n % 2 == 0) timer2_cl();
                            else timer1_cl();
                        }
                        if (cbp == 8 && cb == 4 && b5 == 0 && b6 == 0 && b7 == 0 && stateMap[cbp + 8] == 10 && stateMap[cbp + 7] == 10 && stateMap[cbp + 6] == 10)
                        {
                            ImageBrush newBackground = new ImageBrush();
                            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Rook_W.png", UriKind.Relative));
                            ChangeButtonBackground(6, newBackground);
                            ChangeButtonBackground(cbp, null);
                            bafo_cl();
                            UpdateState(cbp, 0);
                            UpdateState(6, cm);
                            ImageBrush newBackground2 = new ImageBrush();
                            newBackground2.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\King_W.png", UriKind.Relative));
                            ChangeButtonBackground(7, newBackground2);
                            ChangeButtonBackground(cbp, null);
                            UpdateState(cb, 0);
                            UpdateState(7, cn);
                            m_void();
                            if (n % 2 == 0) timer2_cl();
                            else timer1_cl();
                        }
                    }
                    if (c == 1)
                    {
                        UpdateState(cb, cm);
                        UpdateState(cbp, 0);
                        uncheck_W_main_cl();
                        UpdateState(cbp, cm);
                        UpdateState(cb, cn);
                    }
                    if (c == 0)
                    {
                        ImageBrush newBackground = new ImageBrush();
                        newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Rook_W.png", UriKind.Relative));
                        ChangeButtonBackground(cb, newBackground);
                        ChangeButtonBackground(cbp, null);
                        bafo_cl();
                        UpdateState(cbp, 0);
                        s1 = cn;
                        da_board();
                        UpdateState(cb, cm);
                        m_void();
                        if (n % 2 == 0) timer2_cl();
                        else timer1_cl();
                        check_W_main_cl();
                        if (c == 1) mate_main_cl();
                        if (c == 0) move_checker();
                    }
                }
                else if (cm == 30)
                {
                    if (c == 1)
                    {
                        UpdateState(cb, cm);
                        UpdateState(cbp, 0);
                        uncheck_W_main_cl();
                        UpdateState(cbp, cm);
                        UpdateState(cb, cn);
                    }
                    if (c == 0)
                    {
                        ImageBrush newBackground = new ImageBrush();
                        newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Knight_W.png", UriKind.Relative));
                        ChangeButtonBackground(cb, newBackground);
                        ChangeButtonBackground(cbp, null);
                        bafo_cl();
                        UpdateState(cbp, 0);
                        s1 = cn;
                        da_board();
                        UpdateState(cb, cm);
                        m_void();
                        if (n % 2 == 0) timer2_cl();
                        else timer1_cl();
                        check_W_main_cl();
                        if (c == 1) mate_main_cl();
                        if (c == 0) move_checker();
                    }
                }
                else if (cm == 40)
                {
                    if (c == 1)
                    {
                        UpdateState(cb, cm);
                        UpdateState(cbp, 0);
                        uncheck_W_main_cl();
                        UpdateState(cbp, cm);
                        UpdateState(cb, cn);
                    }
                    if (c == 0)
                    {
                        ImageBrush newBackground = new ImageBrush();
                        newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Bishop_W.png", UriKind.Relative));
                        ChangeButtonBackground(cb, newBackground);
                        ChangeButtonBackground(cbp, null);
                        bafo_cl();
                        UpdateState(cbp, 0);
                        s1 = cn;
                        da_board();
                        UpdateState(cb, cm);
                        m_void();
                        if (n % 2 == 0) timer2_cl();
                        else timer1_cl();
                        check_W_main_cl();
                        if (c == 1) mate_main_cl();
                        if (c == 0) move_checker();
                    }
                }
                else if (cm == 50)
                {
                    if (c == 1)
                    {
                        UpdateState(cb, cm);
                        UpdateState(cbp, 0);
                        uncheck_W_main_cl();
                        UpdateState(cbp, cm);
                        UpdateState(cb, cn);
                    }
                    if (c == 0)
                    {
                        ImageBrush newBackground = new ImageBrush();
                        newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Queen_W.png", UriKind.Relative));
                        ChangeButtonBackground(cb, newBackground);
                        ChangeButtonBackground(cbp, null);
                        bafo_cl();
                        UpdateState(cbp, 0);
                        s1 = cn;
                        da_board();
                        UpdateState(cb, cm);
                        m_void();
                        if (n % 2 == 0) timer2_cl();
                        else timer1_cl();
                        check_W_main_cl();
                        if (c == 1) mate_main_cl();
                        if (c == 0) move_checker();
                    }
                }
                else if (cm == 60)
                {
                    if (cn == 20)
                    {
                        if (cbp == 4 && cb == 1 && b2 == 0 && b3 == 0 && stateMap[cbp + 8] == 10 && stateMap[cbp + 9] == 10 && stateMap[cbp + 10] == 10)
                        {
                            ImageBrush newBackground = new ImageBrush();
                            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Rook_W.png", UriKind.Relative));
                            ChangeButtonBackground(3, newBackground);
                            ChangeButtonBackground(cbp, null);
                            bafo_cl();
                            UpdateState(cbp, 0);
                            UpdateState(3, cn);
                            ImageBrush newBackground2 = new ImageBrush();
                            newBackground2.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\King_W.png", UriKind.Relative));
                            ChangeButtonBackground(2, newBackground2);
                            ChangeButtonBackground(cbp, null);
                            UpdateState(cb, 0);
                            UpdateState(2, cm);
                            m_void();
                            if (n % 2 == 0) timer2_cl();
                            else timer1_cl();
                        }
                        if (cbp == 8 && cb == 4 && b5 == 0 && b6 == 0 && b7 == 0 && stateMap[cbp + 8] == 10 && stateMap[cbp + 7] == 10 && stateMap[cbp + 6] == 10)
                        {
                            ImageBrush newBackground = new ImageBrush();
                            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Rook_W.png", UriKind.Relative));
                            ChangeButtonBackground(6, newBackground);
                            ChangeButtonBackground(cbp, null);
                            bafo_cl();
                            UpdateState(cbp, 0);
                            UpdateState(6, cn);
                            ImageBrush newBackground2 = new ImageBrush();
                            newBackground2.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\King_W.png", UriKind.Relative));
                            ChangeButtonBackground(7, newBackground2);
                            ChangeButtonBackground(cbp, null);
                            UpdateState(cb, 0);
                            UpdateState(7, cm);
                            m_void();
                            if (n % 2 == 0) timer2_cl();
                            else timer1_cl();
                        }
                    }
                    if (c == 1)
                    {
                        UpdateState(cb, cm);
                        UpdateState(cbp, 0);
                        uncheck_W_main_cl();
                        UpdateState(cbp, cm);
                        UpdateState(cb, cn);
                    }
                    if (c == 0)
                    {
                        ImageBrush newBackground = new ImageBrush();
                        newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\king_W.png", UriKind.Relative));
                        ChangeButtonBackground(cb, newBackground);
                        ChangeButtonBackground(cbp, null);
                        bafo_cl();
                        UpdateState(cbp, 0);
                        s1 = cn;
                        da_board();
                        UpdateState(cb, cm);
                        m_void();
                        if (n % 2 == 0) timer2_cl();
                        else timer1_cl();
                        check_W_main_cl();
                        if (c == 1) mate_main_cl();
                        if (c == 0) move_checker();
                    }
                }
                else if (cm == 11)
                {
                    if (c == 1)
                    {
                        UpdateState(cb, cm);
                        UpdateState(cbp, 0);
                        uncheck_B_main_cl();
                        UpdateState(cbp, cm);
                        UpdateState(cb, cn);
                    }
                    if (c == 0)
                    {
                        ImageBrush newBackground = new ImageBrush();
                        newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Pawn_B.png", UriKind.Relative));
                        ChangeButtonBackground(cb, newBackground);
                        ChangeButtonBackground(cbp, null);
                        bafo_cl();
                        UpdateState(cbp, 0);
                        s1 = cn;
                        da_board();
                        UpdateState(cb, cm);
                        m_void();
                        if (n % 2 == 0) timer2_cl();
                        else timer1_cl();
                        check_B_main_cl();
                        if (c == 1) mate_main_cl();
                        if (c == 0) move_checker();
                    }
                }
                else if (cm == 21)
                {
                    if (cn == 61)
                    {
                        if (cbp == 57 && cb == 60 && b58 == 0 && b59 == 0 && stateMap[cbp - 8] == 11 && stateMap[cbp - 7] == 11 && stateMap[cbp - 6] == 11)
                        {
                            ImageBrush newBackground = new ImageBrush();
                            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Rook_B.png", UriKind.Relative));
                            ChangeButtonBackground(59, newBackground);
                            ChangeButtonBackground(cbp, null);
                            bafo_cl();
                            UpdateState(cbp, 0);
                            UpdateState(59, cm);
                            ImageBrush newBackground2 = new ImageBrush();
                            newBackground2.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\King_B.png", UriKind.Relative));
                            ChangeButtonBackground(58, newBackground2);
                            ChangeButtonBackground(cbp, null);
                            UpdateState(cb, 0);
                            UpdateState(58, cn);
                            m_void();
                            if (n % 2 == 0) timer2_cl();
                            else timer1_cl();
                        }
                        if (cbp == 64 && cb == 60 && b63 == 0 && b62 == 0 && b61 == 0 && stateMap[cbp - 8] == 11 && stateMap[cbp - 9] == 11 && stateMap[cbp - 10] == 11)
                        {
                            ImageBrush newBackground = new ImageBrush();
                            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Rook_B.png", UriKind.Relative));
                            ChangeButtonBackground(62, newBackground);
                            ChangeButtonBackground(cbp, null);
                            bafo_cl();
                            UpdateState(cbp, 0);
                            UpdateState(62, cn);
                            ImageBrush newBackground2 = new ImageBrush();
                            newBackground2.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\King_B.png", UriKind.Relative));
                            ChangeButtonBackground(63, newBackground2);
                            ChangeButtonBackground(cbp, null);
                            UpdateState(cb, 0);
                            UpdateState(63, cm);
                            m_void();
                            if (n % 2 == 0) timer2_cl();
                            else timer1_cl();
                        }
                    }
                    if (c == 1)
                    {
                        UpdateState(cb, cm);
                        UpdateState(cbp, 0);
                        uncheck_B_main_cl();
                        UpdateState(cbp, cm);
                        UpdateState(cb, cn);
                    }
                    if (c == 0)
                    {
                        ImageBrush newBackground = new ImageBrush();
                        newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Rook_B.png", UriKind.Relative));
                        ChangeButtonBackground(cb, newBackground);
                        ChangeButtonBackground(cbp, null);
                        bafo_cl();
                        UpdateState(cbp, 0);
                        s1 = cn;
                        da_board();
                        UpdateState(cb, cm);
                        m_void();
                        if (n % 2 == 0) timer2_cl();
                        else timer1_cl();
                        check_B_main_cl();
                        if (c == 1) mate_main_cl();
                        if (c == 0) move_checker();
                    }
                }
                else if (cm == 31)
                {
                    if (c == 1)
                    {
                        UpdateState(cb, cm);
                        UpdateState(cbp, 0);
                        uncheck_B_main_cl();
                        UpdateState(cbp, cm);
                        UpdateState(cb, cn);
                    }
                    if (c == 0)
                    {
                        ImageBrush newBackground = new ImageBrush();
                        newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\knight_B.png", UriKind.Relative));
                        ChangeButtonBackground(cb, newBackground);
                        ChangeButtonBackground(cbp, null);
                        bafo_cl();
                        UpdateState(cbp, 0);
                        s1 = cn;
                        da_board();
                        UpdateState(cb, cm);
                        m_void();
                        if (n % 2 == 0) timer2_cl();
                        else timer1_cl();
                        check_B_main_cl();
                        if (c == 1) mate_main_cl();
                        if (c == 0) move_checker();
                    }
                }
                else if (cm == 41)
                {
                    if (c == 1)
                    {
                        UpdateState(cb, cm);
                        UpdateState(cbp, 0);
                        uncheck_B_main_cl();
                        UpdateState(cbp, cm);
                        UpdateState(cb, cn);
                    }
                    if (c == 0)
                    {
                        ImageBrush newBackground = new ImageBrush();
                        newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Bishop_B.png", UriKind.Relative));
                        ChangeButtonBackground(cb, newBackground);
                        ChangeButtonBackground(cbp, null);
                        bafo_cl();
                        UpdateState(cbp, 0);
                        s1 = cn;
                        da_board();
                        UpdateState(cb, cm);
                        m_void();
                        if (n % 2 == 0) timer2_cl();
                        else timer1_cl();
                        check_B_main_cl();
                        if (c == 1) mate_main_cl();
                        if (c == 0) move_checker();
                    }
                }
                else if (cm == 51)
                {
                    if (c == 1)
                    {
                        UpdateState(cb, cm);
                        UpdateState(cbp, 0);
                        uncheck_B_main_cl();
                        UpdateState(cbp, cm);
                        UpdateState(cb, cn);
                    }
                    if (c == 0)
                    {
                        ImageBrush newBackground = new ImageBrush();
                        newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Queen_B.png", UriKind.Relative));
                        ChangeButtonBackground(cb, newBackground);
                        ChangeButtonBackground(cbp, null);
                        bafo_cl();
                        UpdateState(cbp, 0);
                        s1 = cn;
                        da_board();
                        UpdateState(cb, cm);
                        m_void();
                        if (n % 2 == 0) timer2_cl();
                        else timer1_cl();
                        check_B_main_cl();
                        if (c == 1) mate_main_cl();
                        if (c == 0) move_checker();
                    }
                }
                else if (cm == 61)
                {
                    if (cn == 21)
                    {
                        if (cbp == 60 && cb == 57 && b58 == 0 && b59 == 0 && stateMap[cbp - 8] == 11 && stateMap[cbp - 7] == 11 && stateMap[cbp - 6] == 11)
                        {
                            ImageBrush newBackground = new ImageBrush();
                            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Rook_B.png", UriKind.Relative));
                            ChangeButtonBackground(59, newBackground);
                            ChangeButtonBackground(cbp, null);
                            bafo_cl();
                            UpdateState(cbp, 0);
                            UpdateState(59, cn);
                            ImageBrush newBackground2 = new ImageBrush();
                            newBackground2.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\King_B.png", UriKind.Relative));
                            ChangeButtonBackground(58, newBackground2);
                            ChangeButtonBackground(cbp, null);
                            UpdateState(cb, 0);
                            UpdateState(58, cm);
                            m_void();
                            if (n % 2 == 0) timer2_cl();
                            else timer1_cl();
                        }
                        if (cbp == 60 && cb == 64 && b63 == 0 && b62 == 0 && b61 == 0 && stateMap[cbp - 8] == 11 && stateMap[cbp - 9] == 11 && stateMap[cbp - 10] == 11)
                        {
                            ImageBrush newBackground = new ImageBrush();
                            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Rook_B.png", UriKind.Relative));
                            ChangeButtonBackground(62, newBackground);
                            ChangeButtonBackground(cbp, null);
                            bafo_cl();
                            UpdateState(cbp, 0);
                            UpdateState(62, cn);
                            ImageBrush newBackground2 = new ImageBrush();
                            newBackground2.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\King_B.png", UriKind.Relative));
                            ChangeButtonBackground(63, newBackground2);
                            ChangeButtonBackground(cbp, null);
                            UpdateState(cb, 0);
                            UpdateState(63, cm);
                            m_void();
                            if (n % 2 == 0) timer2_cl();
                            else timer1_cl();
                        }
                    }
                    if (c == 1)
                    {
                        UpdateState(cb, cm);
                        UpdateState(cbp, 0);
                        uncheck_B_main_cl();
                        UpdateState(cbp, cm);
                        UpdateState(cb, cn);
                    }
                    if (c == 0)
                    {
                        ImageBrush newBackground = new ImageBrush();
                        newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\king_B.png", UriKind.Relative));
                        ChangeButtonBackground(cb, newBackground);
                        ChangeButtonBackground(cbp, null);
                        bafo_cl();
                        UpdateState(cbp, 0);
                        s1 = cn;
                        da_board();
                        UpdateState(cb, cm);
                        m_void();
                        if (n % 2 == 0) timer2_cl();
                        else timer1_cl();
                        check_B_main_cl();
                        if (c == 1) mate_main_cl();
                        if (c == 0) move_checker();
                    }
                }
            }
        }
        public void bafo_cl()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    bafo[i, j] = bafo[i + 1, j];
                }
            }
            if (cm == 20 || cm == 60 && cn == 60 || cn == 20) { 
            }
            bafo[4, 0] = cbp;
            bafo[4, 1] = cm;
            bafo[4, 2] = cb;
            bafo[4, 3] = cn;
        }
        public void mainin_cl()
        {
            if (bafo[bf1, 1] == 10)
            {
                pw = bafo[bf1, 0];
                Pawn_W_cl();
                mainin_in_cl();
                UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                s1 = bafo[bf1, 3];
                if (bafo[bf1, 0] != bafo[bf1, 2]) de_board();
                if (bafo[bf1, 0] == bafo[bf1, 2]) da_board();
                UpdateState(bafo[bf1, 0], bafo[bf1, 1]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 20)
            {
                rw = bafo[bf1, 0];
                Rook_W_cl();
                mainin_in_cl();
                UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                if (bafo[bf1, 3] == 60)
                {

                }
                else
                {
                    s1 = bafo[bf1, 3];
                    if (bafo[bf1, 0] != bafo[bf1, 2]) de_board();
                    if (bafo[bf1, 0] == bafo[bf1, 2]) da_board();
                }
                UpdateState(bafo[bf1, 0], bafo[bf1, 1]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 30)
            {
                kw = bafo[bf1, 0];
                Knight_W_cl();
                mainin_in_cl();
                UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                s1 = bafo[bf1, 3];
                if (bafo[bf1, 0] != bafo[bf1, 2]) de_board();
                if (bafo[bf1, 0] == bafo[bf1, 2]) da_board();
                UpdateState(bafo[bf1, 0], bafo[bf1, 1]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 40)
            {
                bw = bafo[bf1, 0];
                Bishop_W_cl();
                mainin_in_cl();
                UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                s1 = bafo[bf1, 3];
                if (bafo[bf1, 0] != bafo[bf1, 2]) de_board();
                if (bafo[bf1, 0] == bafo[bf1, 2]) da_board();
                UpdateState(bafo[bf1, 0], bafo[bf1, 1]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 50)
            {
                qw = bafo[bf1, 0];
                Queen_W_cl();
                mainin_in_cl();
                UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                s1 = bafo[bf1, 3];
                if (bafo[bf1, 0] != bafo[bf1, 2]) de_board();
                if (bafo[bf1, 0] == bafo[bf1, 2]) da_board();
                UpdateState(bafo[bf1, 0], bafo[bf1, 1]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 60)
            {
                kiw = bafo[bf1, 0];
                King_W_cl();
                mainin_in_cl();
                UpdateState(bafo[bf1, 2], bafo[bf1, 3]); 
                if (bafo[bf1, 3] == 20)
                {

                }
                else
                {
                    s1 = bafo[bf1, 3];
                    if (bafo[bf1, 0] != bafo[bf1, 2]) de_board();
                    if (bafo[bf1, 0] == bafo[bf1, 2]) da_board();
                }
                UpdateState(bafo[bf1, 0], bafo[bf1, 1]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 11)
            {
                pb = bafo[bf1, 0];
                Pawn_B_cl();
                mainin_in_cl();
                s1 = bafo[bf1, 3];
                if (bafo[bf1, 0] != bafo[bf1, 2]) de_board();
                if (bafo[bf1, 0] == bafo[bf1, 2]) da_board();
                UpdateState(bafo[bf1, 0], bafo[bf1, 1]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 21)
            {
                rb = bafo[bf1, 0];
                Rook_B_cl();
                mainin_in_cl();
                UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                if (bafo[bf1, 3] == 61)
                {

                }
                else
                {
                    s1 = bafo[bf1, 3];
                    if (bafo[bf1, 0] != bafo[bf1, 2]) de_board();
                    if (bafo[bf1, 0] == bafo[bf1, 2]) da_board();
                }
                UpdateState(bafo[bf1, 0], bafo[bf1, 1]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 31)
            {
                kb = bafo[bf1, 0];
                Knight_B_cl();
                mainin_in_cl();
                UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                s1 = bafo[bf1, 3];
                if (bafo[bf1, 0] != bafo[bf1, 2]) de_board();
                if (bafo[bf1, 0] == bafo[bf1, 2]) da_board();
                UpdateState(bafo[bf1, 0], bafo[bf1, 1]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 41)
            {
                bb = bafo[bf1, 0];
                Bishop_B_cl();
                mainin_in_cl();
                UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                s1 = bafo[bf1, 3];
                if (bafo[bf1, 0] != bafo[bf1, 2]) de_board();
                if (bafo[bf1, 0] == bafo[bf1, 2]) da_board();
                UpdateState(bafo[bf1, 0], bafo[bf1, 1]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 51)
            {
                qb = bafo[bf1, 0];
                Queen_B_cl();
                mainin_in_cl();
                UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                s1 = bafo[bf1, 3];
                if (bafo[bf1, 0] != bafo[bf1, 2]) de_board();
                if (bafo[bf1, 0] == bafo[bf1, 2]) da_board();
                UpdateState(bafo[bf1, 0], bafo[bf1, 1]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 61)
            {
                kib = bafo[bf1, 0];
                King_B_cl();
                mainin_in_cl();
                UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                if (bafo[bf1, 3] == 21)
                {

                }
                else
                {
                    s1 = bafo[bf1, 3];
                    if (bafo[bf1, 0] != bafo[bf1, 2]) de_board();
                    if (bafo[bf1, 0] == bafo[bf1, 2]) da_board();
                }
                UpdateState(bafo[bf1, 0], bafo[bf1, 1]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            bf1--;
        }
        public void mainin_in_cl()
        {
            if (bafo[bf1, 0] != bafo[bf1, 2])
            {
                if (bafo[bf1, 3] == 0) ChangeButtonBackground(bafo[bf1, 2], null);
                else if (bafo[bf1, 3] == 10)
                {
                    pw = bafo[bf1, 2];
                    Pawn_W_cl();
                }
                else if (bafo[bf1, 3] == 20)
                {
                    rw = bafo[bf1, 2];
                    Rook_W_cl();
                }
                else if (bafo[bf1, 3] == 30)
                {
                    kw = bafo[bf1, 2];
                    Knight_W_cl();
                }
                else if (bafo[bf1, 3] == 40)
                {
                    bw = bafo[bf1, 2];
                    Bishop_W_cl();
                }
                else if (bafo[bf1, 3] == 50)
                {
                    qw = bafo[bf1, 2];
                    Queen_W_cl();
                }
                else if (bafo[bf1, 3] == 60)
                {
                    kiw = bafo[bf1, 2];
                    King_W_cl();
                }
                else if (bafo[bf1, 3] == 11)
                {
                    pb = bafo[bf1, 2];
                    Pawn_B_cl();
                }
                else if (bafo[bf1, 3] == 21)
                {
                    rb = bafo[bf1, 2];
                    Rook_B_cl();
                }
                else if (bafo[bf1, 3] == 31)
                {
                    kb = bafo[bf1, 2];
                    Knight_B_cl();
                }
                else if (bafo[bf1, 3] == 41)
                {
                    bb = bafo[bf1, 2];
                    Bishop_B_cl();
                }
                else if (bafo[bf1, 3] == 51)
                {
                    qb = bafo[bf1, 2];
                    Queen_B_cl();
                }
                else if (bafo[bf1, 3] == 61)
                {
                    kib = bafo[bf1, 2];
                    King_B_cl();
                }
            }
        }
        public void Pawn_W_cl()
        {
            ImageBrush newBackground = new ImageBrush();
            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Pawn_W.png", UriKind.Relative));
            ChangeButtonBackground(pw, newBackground);
        }
        public void Pawn_B_cl()
        {
            ImageBrush newBackground = new ImageBrush();
            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Pawn_B.png", UriKind.Relative));
            ChangeButtonBackground(pb, newBackground);
        }
        public void Rook_W_cl()
        {
            ImageBrush newBackground = new ImageBrush();
            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Rook_W.png", UriKind.Relative));
            ChangeButtonBackground(rw, newBackground);
        }
        public void Rook_B_cl()
        {
            ImageBrush newBackground = new ImageBrush();
            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Rook_B.png", UriKind.Relative));
            ChangeButtonBackground(rb, newBackground);
        }
        public void Knight_W_cl()
        {
            ImageBrush newBackground = new ImageBrush();
            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Knight_W.png", UriKind.Relative));
            ChangeButtonBackground(kw, newBackground);
        }
        public void Knight_B_cl()
        {
            ImageBrush newBackground = new ImageBrush();
            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Knight_B.png", UriKind.Relative));
            ChangeButtonBackground(kb, newBackground);
        }
        public void Bishop_W_cl()
        {
            ImageBrush newBackground = new ImageBrush();
            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Bishop_W.png", UriKind.Relative));
            ChangeButtonBackground(bw, newBackground);
        }
        public void Bishop_B_cl()
        {
            ImageBrush newBackground = new ImageBrush();
            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Bishop_B.png", UriKind.Relative));
            ChangeButtonBackground(bb, newBackground);
        }
        public void Queen_W_cl()
        {
            ImageBrush newBackground = new ImageBrush();
            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Queen_W.png", UriKind.Relative));
            ChangeButtonBackground(qw, newBackground);
        }
        public void Queen_B_cl()
        {
            ImageBrush newBackground = new ImageBrush();
            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\Queen_B.png", UriKind.Relative));
            ChangeButtonBackground(qb, newBackground);
        }
        public void King_W_cl()
        {
            ImageBrush newBackground = new ImageBrush();
            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\King_W.png", UriKind.Relative));
            ChangeButtonBackground(kiw, newBackground);
        }
        public void King_B_cl()
        {
            ImageBrush newBackground = new ImageBrush();
            newBackground.ImageSource = new BitmapImage(new Uri("C:\\Users\\saeed\\Desktop\\appc\\WpfApp1\\images\\King_B.png", UriKind.Relative));
            ChangeButtonBackground(kib, newBackground);
        }
        int bf1 = 4;
        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            if (bf1 < 5 && bf1 >= 0)
            {
                mainin_cl();
            }
            k = 0;
        }
        private void btne_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
        public void mainin2_in_cl()
        {
            if (bafo[bf1, 0] == bafo[bf1, 2])
            {
                if (bafo[bf1, 3] == 0) ChangeButtonBackground(bafo[bf1, 2], null);
                else if (bafo[bf1, 3] == 10)
                {
                    pw = bafo[bf1, 2];
                    Pawn_W_cl();
                }
                else if (bafo[bf1, 3] == 20)
                {
                    rw = bafo[bf1, 2];
                    Rook_W_cl();
                }
                else if (bafo[bf1, 3] == 30)
                {
                    kw = bafo[bf1, 2];
                    Knight_W_cl();
                }
                else if (bafo[bf1, 3] == 40)
                {
                    bw = bafo[bf1, 2];
                    Bishop_W_cl();
                }
                else if (bafo[bf1, 3] == 50)
                {
                    qw = bafo[bf1, 2];
                    Queen_W_cl();
                }
                else if (bafo[bf1, 3] == 60)
                {
                    kiw = bafo[bf1, 2];
                    King_W_cl();
                }
                else if (bafo[bf1, 3] == 11)
                {
                    pb = bafo[bf1, 2];
                    Pawn_B_cl();
                }
                else if (bafo[bf1, 3] == 21)
                {
                    rb = bafo[bf1, 2];
                    Rook_B_cl();
                }
                else if (bafo[bf1, 3] == 31)
                {
                    kb = bafo[bf1, 2];
                    Knight_B_cl();
                }
                else if (bafo[bf1, 3] == 41)
                {
                    bb = bafo[bf1, 2];
                    Bishop_B_cl();
                }
                else if (bafo[bf1, 3] == 51)
                {
                    qb = bafo[bf1, 2];
                    Queen_B_cl();
                }
                else if (bafo[bf1, 3] == 61)
                {
                    kib = bafo[bf1, 2];
                    King_B_cl();
                }
            }
            else ChangeButtonBackground(bafo[bf1, 0], null);
        }
        public void mainin2_cl()
        {
            if (bafo[bf1, 1] == 10)
            {
                pw = bafo[bf1, 2];
                Pawn_W_cl();
                mainin2_in_cl();
                UpdateState(bafo[bf1, 0], 0);
                s1 = bafo[bf1, 3];
                if (bafo[bf1, 0] == bafo[bf1, 2]) de_board();
                if (bafo[bf1, 0] != bafo[bf1, 2]) da_board();
                if (bafo[bf1, 0] != bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 1]);
                if (bafo[bf1, 0] == bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 20)
            {
                rw = bafo[bf1, 2];
                Rook_W_cl();
                mainin2_in_cl();
                UpdateState(bafo[bf1, 0], 0);
                if (bafo[bf1, 3] == 60)
                {

                }
                else
                {
                    s1 = bafo[bf1, 3];
                    if (bafo[bf1, 0] == bafo[bf1, 2]) de_board();
                    if (bafo[bf1, 0] != bafo[bf1, 2]) da_board();
                    if (bafo[bf1, 0] != bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 1]);
                    if (bafo[bf1, 0] == bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                }
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 30)
            {
                kw = bafo[bf1, 2];
                Knight_W_cl();
                mainin2_in_cl();
                UpdateState(bafo[bf1, 0], 0);
                s1 = bafo[bf1, 3];
                if (bafo[bf1, 0] == bafo[bf1, 2]) de_board();
                if (bafo[bf1, 0] != bafo[bf1, 2]) da_board();
                if (bafo[bf1, 0] != bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 1]);
                if (bafo[bf1, 0] == bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 40)
            {
                bw = bafo[bf1, 2];
                Bishop_W_cl();
                mainin2_in_cl();
                UpdateState(bafo[bf1, 0], 0);
                s1 = bafo[bf1, 3];
                if (bafo[bf1, 0] == bafo[bf1, 2]) de_board();
                if (bafo[bf1, 0] != bafo[bf1, 2]) da_board();
                if (bafo[bf1, 0] != bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 1]);
                if (bafo[bf1, 0] == bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 50)
            {
                qw = bafo[bf1, 2];
                Queen_W_cl();
                mainin2_in_cl();
                UpdateState(bafo[bf1, 0], 0);
                s1 = bafo[bf1, 3];
                if (bafo[bf1, 0] == bafo[bf1, 2]) de_board();
                if (bafo[bf1, 0] != bafo[bf1, 2]) da_board();
                if (bafo[bf1, 0] != bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 1]);
                if (bafo[bf1, 0] == bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 60)
            {
                kiw = bafo[bf1, 2];
                King_W_cl();
                mainin2_in_cl();
                UpdateState(bafo[bf1, 0], 0);
                if (bafo[bf1, 3] == 20)
                {

                }
                else
                {
                    s1 = bafo[bf1, 3];
                    if (bafo[bf1, 0] == bafo[bf1, 2]) de_board();
                    if (bafo[bf1, 0] != bafo[bf1, 2]) da_board();
                    if (bafo[bf1, 0] != bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 1]);
                    if (bafo[bf1, 0] == bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                }
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 11)
            {
                pb = bafo[bf1, 2];
                Pawn_B_cl();
                mainin2_in_cl();
                UpdateState(bafo[bf1, 0], 0);
                s1 = bafo[bf1, 3];
                if (bafo[bf1, 0] == bafo[bf1, 2]) de_board();
                if (bafo[bf1, 0] != bafo[bf1, 2]) da_board();
                if (bafo[bf1, 0] != bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 1]);
                if (bafo[bf1, 0] == bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 21)
            {
                rb = bafo[bf1, 2];
                Rook_B_cl();
                mainin2_in_cl();
                UpdateState(bafo[bf1, 0], 0);
                if (bafo[bf1, 3] == 61)
                {

                }
                else
                {
                    s1 = bafo[bf1, 3];
                    if (bafo[bf1, 0] == bafo[bf1, 2]) de_board();
                    if (bafo[bf1, 0] != bafo[bf1, 2]) da_board();
                    if (bafo[bf1, 0] != bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 1]);
                    if (bafo[bf1, 0] == bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                }
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 31)
            {
                kb = bafo[bf1, 2];
                Knight_B_cl();
                mainin2_in_cl();
                UpdateState(bafo[bf1, 0], 0);
                s1 = bafo[bf1, 3];
                if (bafo[bf1, 0] == bafo[bf1, 2]) de_board();
                if (bafo[bf1, 0] != bafo[bf1, 2]) da_board();
                if (bafo[bf1, 0] != bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 1]);
                if (bafo[bf1, 0] == bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 41)
            {
                bb = bafo[bf1, 2];
                Bishop_B_cl();
                mainin2_in_cl();
                UpdateState(bafo[bf1, 0], 0);
                s1 = bafo[bf1, 3];
                if (bafo[bf1, 0] == bafo[bf1, 2]) de_board();
                if (bafo[bf1, 0] != bafo[bf1, 2]) da_board();
                if (bafo[bf1, 0] != bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 1]);
                if (bafo[bf1, 0] == bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 51)
            {
                qb = bafo[bf1, 2];
                Queen_B_cl();
                mainin2_in_cl();
                UpdateState(bafo[bf1, 0], 0);
                s1 = bafo[bf1, 3];
                if (bafo[bf1, 0] == bafo[bf1, 2]) de_board();
                if (bafo[bf1, 0] != bafo[bf1, 2]) da_board();
                if (bafo[bf1, 0] != bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 1]);
                if (bafo[bf1, 0] == bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
            else if (bafo[bf1, 1] == 61)
            {
                kib = bafo[bf1, 2];
                King_B_cl();
                mainin2_in_cl();
                UpdateState(bafo[bf1, 0], 0);
                if (bafo[bf1, 3] == 21)
                {

                }
                else
                {
                    s1 = bafo[bf1, 3];
                    if (bafo[bf1, 0] == bafo[bf1, 2]) de_board();
                    if (bafo[bf1, 0] != bafo[bf1, 2]) da_board();
                    if (bafo[bf1, 0] != bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 1]);
                    if (bafo[bf1, 0] == bafo[bf1, 2]) UpdateState(bafo[bf1, 2], bafo[bf1, 3]);
                }
                m_void();
                if (n % 2 == 0) timer1_cl();
                else timer2_cl();
            }
        }
        private void btnforward_Click(object sender, RoutedEventArgs e)
        {
            bf1++;
            if (bf1 < 5 && bf1 >= 0)
            {
                mainin2_cl();
            }
            else bf1--;
            k = 0;
        }

        private void btns_Click(object sender, RoutedEventArgs e)
        {
            string processName = Process.GetCurrentProcess().ProcessName;
            Process.Start(processName);
            App.Current.Shutdown();
        }
        public void HandleButtonClick(int buttonIndex, int buttonValue)
        {
            cbp = cb;
            cn = buttonValue;
            cb = buttonIndex;
            Move_cl();
            cm = cn;
        }
        private void btn1_Click(object sender, RoutedEventArgs e) => HandleButtonClick(1, b1);
        private void btn2_Click(object sender, RoutedEventArgs e) => HandleButtonClick(2, b2);
        private void btn3_Click(object sender, RoutedEventArgs e) => HandleButtonClick(3, b3);
        private void btn4_Click(object sender, RoutedEventArgs e) => HandleButtonClick(4, b4);
        private void btn5_Click(object sender, RoutedEventArgs e) => HandleButtonClick(5, b5);
        private void btn6_Click(object sender, RoutedEventArgs e) => HandleButtonClick(6, b6);
        private void btn7_Click(object sender, RoutedEventArgs e) => HandleButtonClick(7, b7);
        private void btn8_Click(object sender, RoutedEventArgs e) => HandleButtonClick(8, b8);
        private void btn9_Click(object sender, RoutedEventArgs e) => HandleButtonClick(9, b9);
        private void btn10_Click(object sender, RoutedEventArgs e) => HandleButtonClick(10, b10);
        private void btn11_Click(object sender, RoutedEventArgs e) => HandleButtonClick(11, b11);
        private void btn12_Click(object sender, RoutedEventArgs e) => HandleButtonClick(12, b12);
        private void btn13_Click(object sender, RoutedEventArgs e) => HandleButtonClick(13, b13);
        private void btn14_Click(object sender, RoutedEventArgs e) => HandleButtonClick(14, b14);
        private void btn15_Click(object sender, RoutedEventArgs e) => HandleButtonClick(15, b15);
        private void btn16_Click(object sender, RoutedEventArgs e) => HandleButtonClick(16, b16);
        private void btn17_Click(object sender, RoutedEventArgs e) => HandleButtonClick(17, b17);
        private void btn18_Click(object sender, RoutedEventArgs e) => HandleButtonClick(18, b18);
        private void btn19_Click(object sender, RoutedEventArgs e) => HandleButtonClick(19, b19);
        private void btn20_Click(object sender, RoutedEventArgs e) => HandleButtonClick(20, b20);
        private void btn21_Click(object sender, RoutedEventArgs e) => HandleButtonClick(21, b21);
        private void btn22_Click(object sender, RoutedEventArgs e) => HandleButtonClick(22, b22);
        private void btn23_Click(object sender, RoutedEventArgs e) => HandleButtonClick(23, b23);
        private void btn24_Click(object sender, RoutedEventArgs e) => HandleButtonClick(24, b24);
        private void btn25_Click(object sender, RoutedEventArgs e) => HandleButtonClick(25, b25);
        private void btn26_Click(object sender, RoutedEventArgs e) => HandleButtonClick(26, b26);
        private void btn27_Click(object sender, RoutedEventArgs e) => HandleButtonClick(27, b27);
        private void btn28_Click(object sender, RoutedEventArgs e) => HandleButtonClick(28, b28);
        private void btn29_Click(object sender, RoutedEventArgs e) => HandleButtonClick(29, b29);
        private void btn30_Click(object sender, RoutedEventArgs e) => HandleButtonClick(30, b30);
        private void btn31_Click(object sender, RoutedEventArgs e) => HandleButtonClick(31, b31);
        private void btn32_Click(object sender, RoutedEventArgs e) => HandleButtonClick(32, b32);
        private void btn33_Click(object sender, RoutedEventArgs e) => HandleButtonClick(33, b33);
        private void btn34_Click(object sender, RoutedEventArgs e) => HandleButtonClick(34, b34);
        private void btn35_Click(object sender, RoutedEventArgs e) => HandleButtonClick(35, b35);
        private void btn36_Click(object sender, RoutedEventArgs e) => HandleButtonClick(36, b36);
        private void btn37_Click(object sender, RoutedEventArgs e) => HandleButtonClick(37, b37);
        private void btn38_Click(object sender, RoutedEventArgs e) => HandleButtonClick(38, b38);
        private void btn39_Click(object sender, RoutedEventArgs e) => HandleButtonClick(39, b39);
        private void btn40_Click(object sender, RoutedEventArgs e) => HandleButtonClick(40, b40);
        private void btn41_Click(object sender, RoutedEventArgs e) => HandleButtonClick(41, b41);
        private void btn42_Click(object sender, RoutedEventArgs e) => HandleButtonClick(42, b42);
        private void btn43_Click(object sender, RoutedEventArgs e) => HandleButtonClick(43, b43);
        private void btn44_Click(object sender, RoutedEventArgs e) => HandleButtonClick(44, b44);
        private void btn45_Click(object sender, RoutedEventArgs e) => HandleButtonClick(45, b45);
        private void btn46_Click(object sender, RoutedEventArgs e) => HandleButtonClick(46, b46);
        private void btn47_Click(object sender, RoutedEventArgs e) => HandleButtonClick(47, b47);
        private void btn48_Click(object sender, RoutedEventArgs e) => HandleButtonClick(48, b48);
        private void btn49_Click(object sender, RoutedEventArgs e) => HandleButtonClick(49, b49);
        private void btn50_Click(object sender, RoutedEventArgs e) => HandleButtonClick(50, b50);
        private void btn51_Click(object sender, RoutedEventArgs e) => HandleButtonClick(51, b51);
        private void btn52_Click(object sender, RoutedEventArgs e) => HandleButtonClick(52, b52);
        private void btn53_Click(object sender, RoutedEventArgs e) => HandleButtonClick(53, b53);
        private void btn54_Click(object sender, RoutedEventArgs e) => HandleButtonClick(54, b54);
        private void btn55_Click(object sender, RoutedEventArgs e) => HandleButtonClick(55, b55);
        private void btn56_Click(object sender, RoutedEventArgs e) => HandleButtonClick(56, b56);
        private void btn57_Click(object sender, RoutedEventArgs e) => HandleButtonClick(57, b57);
        private void btn58_Click(object sender, RoutedEventArgs e) => HandleButtonClick(58, b58);
        private void btn59_Click(object sender, RoutedEventArgs e) => HandleButtonClick(59, b59);
        private void btn60_Click(object sender, RoutedEventArgs e) => HandleButtonClick(60, b60);
        private void btn61_Click(object sender, RoutedEventArgs e) => HandleButtonClick(61, b61);
        private void btn62_Click(object sender, RoutedEventArgs e) => HandleButtonClick(62, b62);
        private void btn63_Click(object sender, RoutedEventArgs e) => HandleButtonClick(63, b63);
        private void btn64_Click(object sender, RoutedEventArgs e) => HandleButtonClick(64, b64);
        int x1, x2, x3, h, r;
        public void leon_main_cl()
        {
            if (h == 0)
            {
                g++;
            }
            else if (h == 1)
            {
                b++;
            }
            else if (h == 2)
            {
                w++;
            }
            else if (h == 3)
            {
                check1_main_cl();
            }
            else if (h == 4)
            {
                check2_main_cl();
            }
            else if (h == 5)
            {
                main_cl();
            }
            else if (h == 6)
            {
                r++;
            }
            else if (h == 7)
            {
                z++;
            }
        }
        public void Rook_main_cl()
        {
            left_cl();
            if (x1 > x2)
            {
                if ((x2 + 8 * 1) <= 64)
                {
                    if ((x2 + 8 * 1) <= 64 && stateMap[x2 + 8 * 1] == 0)
                    {
                        if (x1 == (x2 + 8 * 1)) main_cl();
                        else if ((x2 + 8 * 2) <= 64 && stateMap[x2 + 8 * 2] == 0)
                        {
                            if (x1 == (x2 + 8 * 2)) main_cl();
                            else if ((x2 + 8 * 3) <= 64 && stateMap[x2 + 8 * 3] == 0)
                            {
                                if (x1 == (x2 + 8 * 3)) main_cl();
                                else if ((x2 + 8 * 4) <= 64 && stateMap[x2 + 8 * 4] == 0)
                                {
                                    if (x1 == (x2 + 8 * 4)) main_cl();
                                    else if ((x2 + 8 * 5) <= 64 && stateMap[x2 + 8 * 5] == 0)
                                    {
                                        if (x1 == (x2 + 8 * 5)) main_cl();
                                        else if ((x2 + 8 * 6) <= 64 && stateMap[x2 + 8 * 6] == 0)
                                        {
                                            if (x1 == (x2 + 8 * 6)) main_cl();
                                            else if ((x2 + 8 * 7) <= 64 && stateMap[x2 + 8 * 7] == 0)
                                            {
                                                if (x1 == (x2 + 8 * 7)) main_cl();
                                            }
                                            else if ((x2 + 8 * 7) <= 64 && stateMap[x2 + 8 * 7] % 2 == x3 && x1 == (x2 + 8 * 7)) main_cl();
                                        }
                                        else if ((x2 + 8 * 6) <= 64 && stateMap[x2 + 8 * 6] % 2 == x3 && x1 == (x2 + 8 * 6)) main_cl();
                                    }
                                    else if ((x2 + 8 * 5) <= 64 && stateMap[x2 + 8 * 5] % 2 == x3 && x1 == (x2 + 8 * 5)) main_cl();
                                }
                                else if ((x2 + 8 * 4) <= 64 && stateMap[x2 + 8 * 4] % 2 == x3 && x1 == (x2 + 8 * 4)) main_cl();
                            }
                            else if ((x2 + 8 * 3) <= 64 && stateMap[x2 + 8 * 3] % 2 == x3 && x1 == (x2 + 8 * 3)) main_cl();
                        }
                        else if ((x2 + 8 * 2) <= 64 && stateMap[x2 + 8 * 2] % 2 == x3 && x1 == (x2 + 8 * 2)) main_cl();
                    }
                    else if ((x2 + 8 * 1) <= 64 && stateMap[x2 + 8 * 1] % 2 == x3 && x1 == (x2 + 8 * 1)) main_cl();
                }
                if (x2 % 8 != 0)
                {
                    if ((x2 + 1 * 1) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 1] == 0)
                    {
                        if (x1 == (x2 + 1 * 1)) main_cl();
                        else if ((x2 + 1 * 2) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 2] == 0)
                        {
                            if (x1 == (x2 + 1 * 2)) main_cl();
                            else if ((x2 + 1 * 3) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 3] == 0)
                            {
                                if (x1 == (x2 + 1 * 3)) main_cl();
                                else if ((x2 + 1 * 4) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 4] == 0)
                                {
                                    if (x1 == (x2 + 1 * 4)) main_cl();
                                    else if ((x2 + 1 * 5) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 5] == 0)
                                    {
                                        if (x1 == (x2 + 1 * 5)) main_cl();
                                        else if ((x2 + 1 * 6) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 6] == 0)
                                        {
                                            if (x1 == (x2 + 1 * 6)) main_cl();
                                            else if ((x2 + 1 * 7) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 7] == 0)
                                            {
                                                if (x1 == (x2 + 1 * 7)) main_cl();
                                            }
                                            else if ((x2 + 1 * 7) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 7] % 2 == x3 && x1 == (x2 + 1 * 7)) main_cl();
                                        }
                                        else if ((x2 + 1 * 6) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 6] % 2 == x3 && x1 == (x2 + 1 * 6)) main_cl();
                                    }
                                    else if ((x2 + 1 * 5) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 5] % 2 == x3 && x1 == (x2 + 1 * 5)) main_cl();
                                }
                                else if ((x2 + 1 * 4) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 4] % 2 == x3 && x1 == (x2 + 1 * 4)) main_cl();
                            }
                            else if ((x2 + 1 * 3) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 3] % 2 == x3 && x1 == (x2 + 1 * 3)) main_cl();
                        }
                        else if ((x2 + 1 * 2) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 2] % 2 == x3 && x1 == (x2 + 1 * 2)) main_cl();
                    }
                    else if ((x2 + 1 * 1) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 1] % 2 == x3 && x1 == (x2 + 1 * 1)) main_cl();
                }
            }
            else if (x1 < x2)
            {
                if ((x2 - 8 * 1) >= 1)
                {
                    if ((x2 - 8 * 1) >= 1 && stateMap[x2 - 8 * 1] == 0)
                    {
                        if (x1 == (x2 - 8 * 1)) main_cl();
                        else if ((x2 - 8 * 2) >= 1 && stateMap[x2 - 8 * 2] == 0)
                        {
                            if (x1 == (x2 - 8 * 2)) main_cl();
                            else if ((x2 - 8 * 3) >= 1 && stateMap[x2 - 8 * 3] == 0)
                            {
                                if (x1 == (x2 - 8 * 3)) main_cl();
                                else if ((x2 - 8 * 4) >= 1 && stateMap[x2 - 8 * 4] == 0)
                                {
                                    if (x1 == (x2 - 8 * 4)) main_cl();
                                    else if ((x2 - 8 * 5) >= 1 && stateMap[x2 - 8 * 5] == 0)
                                    {
                                        if (x1 == (x2 - 8 * 5)) main_cl();
                                        else if ((x2 - 8 * 6) >= 1 && stateMap[x2 - 8 * 6] == 0)
                                        {
                                            if (x1 == (x2 - 8 * 6)) main_cl();
                                            else if ((x2 - 8 * 7) >= 1 && stateMap[x2 - 8 * 7] == 0)
                                            {
                                                if (x1 == (x2 - 8 * 7)) main_cl();
                                            }
                                            else if ((x2 - 8 * 7) >= 1 && stateMap[x2 - 8 * 7] % 2 == x3 && x1 == (x2 - 8 * 7)) main_cl();
                                        }
                                        else if ((x2 - 8 * 6) >= 1 && stateMap[x2 - 8 * 6] % 2 == x3 && x1 == (x2 - 8 * 6)) main_cl();
                                    }
                                    else if ((x2 - 8 * 5) >= 1 && stateMap[x2 - 8 * 5] % 2 == x3 && x1 == (x2 - 8 * 5)) main_cl();
                                }
                                else if ((x2 - 8 * 4) >= 1 && stateMap[x2 - 8 * 4] % 2 == x3 && x1 == (x2 - 8 * 4)) main_cl();
                            }
                            else if ((x2 - 8 * 3) >= 1 && stateMap[x2 - 8 * 3] % 2 == x3 && x1 == (x2 - 8 * 3)) main_cl();
                        }
                        else if ((x2 - 8 * 2) >= 1 && stateMap[x2 - 8 * 2] % 2 == x3 && x1 == (x2 - 8 * 2)) main_cl();
                    }
                    else if ((x2 - 8 * 1) >= 1 && stateMap[x2 - 8 * 1] % 2 == x3 && x1 == (x2 - 8 * 1)) main_cl();
                }
                if (x2 % 8 != 1)
                {
                    if ((x2 - 1 * 1) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 1] == 0)
                    {
                        if (x1 == (x2 - 1 * 1)) main_cl();
                        else if ((x2 - 1 * 2) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 2] == 0)
                        {
                            if (x1 == (x2 - 1 * 2)) main_cl();
                            else if ((x2 - 1 * 3) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 3] == 0)
                            {
                                if (x1 == (x2 - 1 * 3)) main_cl();
                                else if ((x2 - 1 * 4) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 4] == 0)
                                {
                                    if (x1 == (x2 - 1 * 4)) main_cl();
                                    else if ((x2 - 1 * 5) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 5] == 0)
                                    {
                                        if (x1 == (x2 - 1 * 5)) main_cl();
                                        else if ((x2 - 1 * 6) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 6] == 0)
                                        {
                                            if (x1 == (x2 - 1 * 6)) main_cl();
                                            else if ((x2 - 1 * 7) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 7] == 0)
                                            {
                                                if (x1 == (x2 - 1 * 7)) main_cl();
                                            }
                                            else if ((x2 - 1 * 7) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 7] % 2 == x3 && x1 == (x2 - 1 * 7)) main_cl();
                                        }
                                        else if ((x2 - 1 * 6) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 6] % 2 == x3 && x1 == (x2 - 1 * 6)) main_cl();
                                    }
                                    else if ((x2 - 1 * 5) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 5] % 2 == x3 && x1 == (x2 - 1 * 5)) main_cl();
                                }
                                else if ((x2 - 1 * 4) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 4] % 2 == x3 && x1 == (x2 - 1 * 4)) main_cl();
                            }
                            else if ((x2 - 1 * 3) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 3] % 2 == x3 && x1 == (x2 - 1 * 3)) main_cl();
                        }
                        else if ((x2 - 1 * 2) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 2] % 2 == x3 && x1 == (x2 - 1 * 2)) main_cl();
                    }
                    else if ((x2 - 1 * 1) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 1] % 2 == x3 && x1 == (x2 - 1 * 1)) main_cl();
                }
            }
        }
        public void dump_Rook_main_cl()
        {
            if ((x2 + 8 * 1) <= 64)
            {
                if ((x2 + 8 * 1) <= 64 && stateMap[x2 + 8 * 1] == 0)
                {
                    if ((x2 + 8 * 2) <= 64 && stateMap[x2 + 8 * 2] == 0)
                    {
                        if ((x2 + 8 * 3) <= 64 && stateMap[x2 + 8 * 3] == 0)
                        {
                            if ((x2 + 8 * 4) <= 64 && stateMap[x2 + 8 * 4] == 0)
                            {
                                if ((x2 + 8 * 5) <= 64 && stateMap[x2 + 8 * 5] == 0)
                                {
                                    if ((x2 + 8 * 6) <= 64 && stateMap[x2 + 8 * 6] == 0)
                                    {
                                        if ((x2 + 8 * 7) <= 64 && stateMap[x2 + 8 * 7] == x3) leon_main_cl();
                                    }
                                    else if ((x2 + 8 * 6) <= 64 && stateMap[x2 + 8 * 6] == x3) leon_main_cl();
                                }
                                else if ((x2 + 8 * 5) <= 64 && stateMap[x2 + 8 * 5] == x3) leon_main_cl();
                            }
                            else if ((x2 + 8 * 4) <= 64 && stateMap[x2 + 8 * 4] == x3) leon_main_cl();
                        }
                        else if ((x2 + 8 * 3) <= 64 && stateMap[x2 + 8 * 3] == x3) leon_main_cl();
                    }
                    else if ((x2 + 8 * 2) <= 64 && stateMap[x2 + 8 * 2] == x3) leon_main_cl();
                }
                else if ((x2 + 8 * 1) <= 64 && stateMap[x2 + 8 * 1] == x3) leon_main_cl();
            }
            if (x2 % 8 != 0)
            {
                if ((x2 + 1 * 1) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 1] == 0)
                {
                    if ((x2 + 1 * 2) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 2] == 0)
                    {
                        if ((x2 + 1 * 3) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 3] == 0)
                        {
                            if ((x2 + 1 * 4) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 4] == 0)
                            {
                                if ((x2 + 1 * 5) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 5] == 0)
                                {
                                    if ((x2 + 1 * 6) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 6] == 0)
                                    {
                                        if ((x2 + 1 * 7) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 7] == x3) leon_main_cl();
                                    }
                                    else if ((x2 + 1 * 6) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 6] == x3) leon_main_cl();
                                }
                                else if ((x2 + 1 * 5) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 5] == x3) leon_main_cl();
                            }
                            else if ((x2 + 1 * 4) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 4] == x3) leon_main_cl();
                        }
                        else if ((x2 + 1 * 3) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 3] == x3) leon_main_cl();
                    }
                    else if ((x2 + 1 * 2) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 2] == x3) leon_main_cl();
                }
                else if ((x2 + 1 * 1) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 1] == x3) leon_main_cl();
            }
            if ((x2 - 8 * 1) >= 1)
            {
                if ((x2 - 8 * 1) >= 1 && stateMap[x2 - 8 * 1] == 0)
                {
                    if ((x2 - 8 * 2) >= 1 && stateMap[x2 - 8 * 2] == 0)
                    {
                        if ((x2 - 8 * 3) >= 1 && stateMap[x2 - 8 * 3] == 0)
                        {
                            if ((x2 - 8 * 4) >= 1 && stateMap[x2 - 8 * 4] == 0)
                            {
                                if ((x2 - 8 * 5) >= 1 && stateMap[x2 - 8 * 5] == 0)
                                {
                                    if ((x2 - 8 * 6) >= 1 && stateMap[x2 - 8 * 6] == 0)
                                    {
                                        if ((x2 - 8 * 7) >= 1 && stateMap[x2 - 8 * 7] == x3) leon_main_cl();
                                    }
                                    else if ((x2 - 8 * 6) >= 1 && stateMap[x2 - 8 * 6] == x3) leon_main_cl();
                                }
                                else if ((x2 - 8 * 5) >= 1 && stateMap[x2 - 8 * 5] == x3) leon_main_cl();
                            }
                            else if ((x2 - 8 * 4) >= 1 && stateMap[x2 - 8 * 4] == x3) leon_main_cl();
                        }
                        else if ((x2 - 8 * 3) >= 1 && stateMap[x2 - 8 * 3] == x3) leon_main_cl();
                    }
                    else if ((x2 - 8 * 2) >= 1 && stateMap[x2 - 8 * 2] == x3) leon_main_cl();
                }
                else if ((x2 - 8 * 1) >= 1 && stateMap[x2 - 8 * 1] == x3) leon_main_cl();
            }
            if (x2 % 8 != 1)
            {
                if ((x2 - 1 * 1) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 1] == 0)
                {
                    if ((x2 - 1 * 2) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 2] == 0)
                    {
                        if ((x2 - 1 * 3) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 3] == 0)
                        {
                            if ((x2 - 1 * 4) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 4] == 0)
                            {
                                if ((x2 - 1 * 5) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 5] == 0)
                                {
                                    if ((x2 - 1 * 6) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 6] == 0)
                                    {
                                        if ((x2 - 1 * 7) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 7] == x3) leon_main_cl();
                                    }
                                    else if ((x2 - 1 * 6) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 6] == x3) leon_main_cl();
                                }
                                else if ((x2 - 1 * 5) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 5] == x3) leon_main_cl();
                            }
                            else if ((x2 - 1 * 4) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 4] == x3) leon_main_cl();
                        }
                        else if ((x2 - 1 * 3) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 3] == x3) leon_main_cl();
                    }
                    else if ((x2 - 1 * 2) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 2] == x3) leon_main_cl();
                }
                else if ((x2 - 1 * 1) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 1] == x3) leon_main_cl();
            }
        }
        public void Knight_main_cl()
        {
            left_cl();
            if ((x2 + 8 - 2) >= f && (x2 + 8 - 2) <= 64 && stateMap[x2 + 8 - 2] % 2 == x3 && (x2 + 8 - 2) == x1) main_cl();
            else if ((x2 + 8 - 2) >= f && (x2 + 8 - 2) <= 64 && stateMap[x2 + 8 - 2] == 0 && (x2 + 8 - 2) == x1) main_cl();
            else if ((x2 + 16 - 1) >= f + 8 && (x2 + 16 - 1) <= 64 && stateMap[x2 + 16 - 1] % 2 == x3 && (x2 + 16 - 1) == x1) main_cl();
            else if ((x2 + 16 - 1) >= f + 8 && (x2 + 16 - 1) <= 64 && stateMap[x2 + 16 - 1] == 0 && (x2 + 16 - 1) == x1) main_cl();
            else if ((x2 + 16 + 1) >= f + 8 && (x2 + 16 + 1) <= 64 && stateMap[x2 + 16 + 1] % 2 == x3 && (x2 + 16 + 1) == x1) main_cl();
            else if ((x2 + 16 + 1) >= f + 8 && (x2 + 16 + 1) <= 64 && stateMap[x2 + 16 + 1] == 0 && (x2 + 16 + 1) == x1) main_cl();
            else if ((x2 + 8 + 2) >= f && (x2 + 8 + 2) <= 64 && stateMap[x2 + 8 + 2] % 2 == x3 && (x2 + 8 + 2) == x1) main_cl();
            else if ((x2 + 8 + 2) >= f && (x2 + 8 + 2) <= 64 && stateMap[x2 + 8 + 2] == 0 && (x2 + 8 + 2) == x1) main_cl();
            else if ((x2 - 8 + 2) <= f - 8 && (x2 - 8 + 2) >= 1 && stateMap[x2 - 8 + 2] % 2 == x3 && (x2 - 8 + 2) == x1) main_cl();
            else if ((x2 - 8 + 2) <= f - 8 && (x2 - 8 + 2) >= 1 && stateMap[x2 - 8 + 2] == 0 && (x2 - 8 + 2) == x1) main_cl();
            else if ((x2 - 16 + 1) <= f - 16 && (x2 - 16 + 1) >= 1 && stateMap[x2 - 16 + 1] % 2 == x3 && (x2 - 16 + 1) == x1) main_cl();
            else if ((x2 - 16 + 1) <= f - 16 && (x2 - 16 + 1) >= 1 && stateMap[x2 - 16 + 1] == 0 && (x2 - 16 + 1) == x1) main_cl();
            else if ((x2 - 16 - 1) <= f - 16 && (x2 - 16 - 1) >= 1 && stateMap[x2 - 16 - 1] % 2 == x3 && (x2 - 16 - 1) == x1) main_cl();
            else if ((x2 - 16 - 1) <= f - 16 && (x2 - 16 - 1) >= 1 && stateMap[x2 - 16 - 1] == 0 && (x2 - 16 - 1) == x1) main_cl();
            else if ((x2 - 8 - 2) <= f - 8 && (x2 - 8 - 2) >= 1 && stateMap[x2 - 8 - 2] % 2 == x3 && (x2 - 8 - 2) == x1) main_cl();
            else if ((x2 - 8 - 2) <= f - 8 && (x2 - 8 - 2) >= 1 && stateMap[x2 - 8 - 2] == 0 && (x2 - 8 - 2) == x1) main_cl();
        }
        public void Bishop_main_cl()
        {
            left_cl();
            if (x1 > x2)
            {
                if ((x2 + (8 * 1) - 1) >= f && (x2 + (8 * 1) - 1) <= 64 && stateMap[x2 + (8 * 1) - 1] == 0)
                {
                    if (x1 == (x2 + (8 * 1) - 1)) main_cl();
                    if ((x2 + (8 * 2) - 2) >= f && (x2 + (8 * 2) - 2) <= 64 && stateMap[x2 + (8 * 2) - 2] == 0)
                    {
                        if (x1 == (x2 + (8 * 2) - 2)) main_cl();
                        if ((x2 + (8 * 3) - 3) >= f && (x2 + (8 * 3) - 3) <= 64 && stateMap[x2 + (8 * 3) - 3] == 0)
                        {
                            if (x1 == (x2 + (8 * 3) - 3)) main_cl();
                            if ((x2 + (8 * 4) - 4) >= f && (x2 + (8 * 4) - 4) <= 64 && stateMap[x2 + (8 * 4) - 4] == 0)
                            {
                                if (x1 == (x2 + (8 * 4) - 4)) main_cl();
                                if ((x2 + (8 * 5) - 5) >= f && (x2 + (8 * 5) - 5) <= 64 && stateMap[x2 + (8 * 5) - 5] == 0)
                                {
                                    if (x1 == (x2 + (8 * 5) - 5)) main_cl();
                                    if ((x2 + (8 * 6) - 6) >= f && (x2 + (8 * 6) - 6) <= 64 && stateMap[x2 + (8 * 6) - 6] == 0)
                                    {
                                        if (x1 == (x2 + (8 * 6) - 6)) main_cl();
                                        if ((x2 + (8 * 7) - 7) >= f && (x2 + (8 * 7) - 7) <= 64 && stateMap[x2 + (8 * 7) - 7] == 0)
                                        {
                                            if (x1 == (x2 + (8 * 7) - 7)) main_cl();
                                        }
                                        else if ((x2 + (8 * 7) - 7) >= f && (x2 + (8 * 7) - 7) <= 64 && stateMap[x2 + (8 * 7) - 7] % 2 == x3 && x1 == (x2 + (8 * 7) - 7)) main_cl();
                                    }
                                    else if ((x2 + (8 * 6) - 6) >= f && (x2 + (8 * 6) - 6) <= 64 && stateMap[x2 + (8 * 6) - 6] % 2 == x3 && x1 == (x2 + (8 * 6) - 6)) main_cl();
                                }
                                else if ((x2 + (8 * 5) - 5) >= f && (x2 + (8 * 5) - 5) <= 64 && stateMap[x2 + (8 * 5) - 5] % 2 == x3 && x1 == (x2 + (8 * 5) - 5)) main_cl();
                            }
                            else if ((x2 + (8 * 4) - 4) >= f && (x2 + (8 * 4) - 4) <= 64 && stateMap[x2 + (8 * 4) - 4] % 2 == x3 && x1 == (x2 + (8 * 4) - 4)) main_cl();
                        }
                        else if ((x2 + (8 * 3) - 3) >= f && (x2 + (8 * 3) - 3) <= 64 && stateMap[x2 + (8 * 3) - 3] % 2 == x3 && x1 == (x2 + (8 * 3) - 3)) main_cl();
                    }
                    else if ((x2 + (8 * 2) - 2) >= f && (x2 + (8 * 2) - 2) <= 64 && stateMap[x2 + (8 * 2) - 2] % 2 == x3 && x1 == (x2 + (8 * 2) - 2)) main_cl();
                }
                else if ((x2 + (8 * 1) - 1) >= f && (x2 + (8 * 1) - 1) <= 64 && stateMap[x2 + (8 * 1) - 1] % 2 == x3 && x1 == (x2 + (8 * 1) - 1)) main_cl();
            }
            if (x1 > x2)
            {
                if ((x2 + (8 * 1) + 1) >= f && (x2 + (8 * 1) + 1) <= 64 && stateMap[x2 + (8 * 1) + 1] == 0)
                {
                    if (x1 == (x2 + (8 * 1) + 1)) main_cl();
                    if ((x2 + (8 * 2) + 2) >= f && (x2 + (8 * 2) + 2) <= 64 && stateMap[x2 + (8 * 2) + 2] == 0)
                    {
                        if (x1 == (x2 + (8 * 2) + 2)) main_cl();
                        if ((x2 + (8 * 3) + 3) >= f && (x2 + (8 * 3) + 3) <= 64 && stateMap[x2 + (8 * 3) + 3] == 0)
                        {
                            if (x1 == (x2 + (8 * 3) + 3)) main_cl();
                            if ((x2 + (8 * 4) + 4) >= f && (x2 + (8 * 4) + 4) <= 64 && stateMap[x2 + (8 * 4) + 4] == 0)
                            {
                                if (x1 == (x2 + (8 * 4) + 4)) main_cl();
                                if ((x2 + (8 * 5) + 5) >= f && (x2 + (8 * 5) + 5) <= 64 && stateMap[x2 + (8 * 5) + 5] == 0)
                                {
                                    if (x1 == (x2 + (8 * 5) + 5)) main_cl();
                                    if ((x2 + (8 * 6) + 6) >= f && (x2 + (8 * 6) + 6) <= 64 && stateMap[x2 + (8 * 6) + 6] == 0)
                                    {
                                        if (x1 == (x2 + (8 * 6) + 6)) main_cl();
                                        if ((x2 + (8 * 7) + 7) >= f && (x2 + (8 * 7) + 7) <= 64 && stateMap[x2 + (8 * 7) + 7] == 0)
                                        {
                                            if (x1 == (x2 + (8 * 7) + 7)) main_cl();
                                        }
                                        else if ((x2 + (8 * 7) + 7) >= f && (x2 + (8 * 7) + 7) <= 64 && stateMap[x2 + (8 * 7) + 7] % 2 == x3 && x1 == (x2 + (8 * 7) + 7)) main_cl();
                                    }
                                    else if ((x2 + (8 * 6) + 6) >= f && (x2 + (8 * 6) + 6) <= 64 && stateMap[x2 + (8 * 6) + 6] % 2 == x3 && x1 == (x2 + (8 * 6) + 6)) main_cl();
                                }
                                else if ((x2 + (8 * 5) + 5) >= f && (x2 + (8 * 5) + 5) <= 64 && stateMap[x2 + (8 * 5) + 5] % 2 == x3 && x1 == (x2 + (8 * 5) + 5)) main_cl();
                            }
                            else if ((x2 + (8 * 4) + 4) >= f && (x2 + (8 * 4) + 4) <= 64 && stateMap[x2 + (8 * 4) + 4] % 2 == x3 && x1 == (x2 + (8 * 4) + 4)) main_cl();
                        }
                        else if ((x2 + (8 * 3) + 3) >= f && (x2 + (8 * 3) + 3) <= 64 && stateMap[x2 + (8 * 3) + 3] % 2 == x3 && x1 == (x2 + (8 * 3) + 3)) main_cl();
                    }
                    else if ((x2 + (8 * 2) + 2) >= f && (x2 + (8 * 2) + 2) <= 64 && stateMap[x2 + (8 * 2) + 2] % 2 == x3 && x1 == (x2 + (8 * 2) + 2)) main_cl();
                }
                else if ((x2 + (8 * 1) + 1) >= f && (x2 + (8 * 1) + 1) <= 64 && stateMap[x2 + (8 * 1) + 1] % 2 == x3 && x1 == (x2 + (8 * 1) + 1)) main_cl();
            }
            if (x1 < x2)
            {
                if ((x2 - (8 * 1) - 1) <= f && (x2 - (8 * 1) - 1) >= 1 && stateMap[x2 - (8 * 1) - 1] == 0)
                {
                    if (x1 == (x2 - (8 * 1) - 1)) main_cl();
                    if ((x2 - (8 * 2) - 2) <= f && (x2 - (8 * 2) - 2) >= 1 && stateMap[x2 - (8 * 2) - 2] == 0)
                    {
                        if (x1 == (x2 - (8 * 2) - 2)) main_cl();
                        if ((x2 - (8 * 3) - 3) <= f && (x2 - (8 * 3) - 3) >= 1 && stateMap[x2 - (8 * 3) - 3] == 0)
                        {
                            if (x1 == (x2 - (8 * 3) - 3)) main_cl();
                            if ((x2 - (8 * 4) - 4) <= f && (x2 - (8 * 4) - 4) >= 1 && stateMap[x2 - (8 * 4) - 4] == 0)
                            {
                                if (x1 == (x2 - (8 * 4) - 4)) main_cl();
                                if ((x2 - (8 * 5) - 5) <= f && (x2 - (8 * 5) - 5) >= 1 && stateMap[x2 - (8 * 5) - 5] == 0)
                                {
                                    if (x1 == (x2 - (8 * 5) - 5)) main_cl();
                                    if ((x2 - (8 * 6) - 6) <= f && (x2 - (8 * 6) - 6) >= 1 && stateMap[x2 - (8 * 6) - 6] == 0)
                                    {
                                        if (x1 == (x2 - (8 * 6) - 6)) main_cl();
                                        if ((x2 - (8 * 7) - 7) <= f && (x2 - (8 * 7) - 7) >= 1 && stateMap[x2 - (8 * 7) - 7] == 0)
                                        {
                                            if (x1 == (x2 - (8 * 7) - 7)) main_cl();
                                        }
                                        else if ((x2 - (8 * 7) - 7) <= f && (x2 - (8 * 7) - 7) >= 1 && stateMap[x2 - (8 * 7) - 7] % 2 == x3 && x1 == (x2 - (8 * 7) - 7)) main_cl();
                                    }
                                    else if ((x2 - (8 * 6) - 6) <= f && (x2 - (8 * 6) - 6) >= 1 && stateMap[x2 - (8 * 6) - 6] % 2 == x3 && x1 == (x2 - (8 * 6) - 6)) main_cl();
                                }
                                else if ((x2 - (8 * 5) - 5) <= f && (x2 - (8 * 5) - 5) >= 1 && stateMap[x2 - (8 * 5) - 5] % 2 == x3 && x1 == (x2 - (8 * 5) - 5)) main_cl();
                            }
                            else if ((x2 - (8 * 4) - 4) <= f && (x2 - (8 * 4) - 4) >= 1 && stateMap[x2 - (8 * 4) - 4] % 2 == x3 && x1 == (x2 - (8 * 4) - 4)) main_cl();
                        }
                        else if ((x2 - (8 * 3) - 3) <= f && (x2 - (8 * 3) - 3) >= 1 && stateMap[x2 - (8 * 3) - 3] % 2 == x3 && x1 == (x2 - (8 * 3) - 3)) main_cl();
                    }
                    else if ((x2 - (8 * 2) - 2) <= f && (x2 - (8 * 2) - 2) >= 1 && stateMap[x2 - (8 * 2) - 2] % 2 == x3 && x1 == (x2 - (8 * 2) - 2)) main_cl();
                }
                else if ((x2 - (8 * 1) - 1) <= f && (x2 - (8 * 1) - 1) >= 1 && stateMap[x2 - (8 * 1) - 1] % 2 == x3 && x1 == (x2 - (8 * 1) - 1)) main_cl();
            }
            if (x1 < x2)
            {
                if ((x2 - (8 * 1) + 1) <= f && (x2 - (8 * 1) + 1) >= 1 && stateMap[x2 - (8 * 1) + 1] == 0)
                {
                    if (x1 == (x2 - (8 * 1) + 1)) main_cl();
                    if ((x2 - (8 * 2) + 2) <= f && (x2 - (8 * 2) + 2) >= 1 && stateMap[x2 - (8 * 2) + 2] == 0)
                    {
                        if (x1 == (x2 - (8 * 2) + 2)) main_cl();
                        if ((x2 - (8 * 3) + 3) <= f && (x2 - (8 * 3) + 3) >= 1 && stateMap[x2 - (8 * 3) + 3] == 0)
                        {
                            if (x1 == (x2 - (8 * 3) + 3)) main_cl();
                            if ((x2 - (8 * 4) + 4) <= f && (x2 - (8 * 4) + 4) >= 1 && stateMap[x2 - (8 * 4) + 4] == 0)
                            {
                                if (x1 == (x2 - (8 * 4) + 4)) main_cl();
                                if ((x2 - (8 * 5) + 5) <= f && (x2 - (8 * 5) + 5) >= 1 && stateMap[x2 - (8 * 5) + 5] == 0)
                                {
                                    if (x1 == (x2 - (8 * 5) + 5)) main_cl();
                                    if ((x2 - (8 * 6) + 6) <= f && (x2 - (8 * 6) + 6) >= 1 && stateMap[x2 - (8 * 6) + 6] == 0)
                                    {
                                        if (x1 == (x2 - (8 * 6) + 6)) main_cl();
                                        if ((x2 - (8 * 7) + 7) <= f && (x2 - (8 * 7) + 7) >= 1 && stateMap[x2 - (8 * 7) + 7] == 0)
                                        {
                                            if (x1 == (x2 - (8 * 7) + 7)) main_cl();
                                        }
                                        else if ((x2 - (8 * 7) + 7) <= f && (x2 - (8 * 7) + 7) >= 1 && stateMap[x2 - (8 * 7) + 7] % 2 == x3 && x1 == (x2 - (8 * 7) + 7)) main_cl();
                                    }
                                    else if ((x2 - (8 * 6) + 6) <= f && (x2 - (8 * 6) + 6) >= 1 && stateMap[x2 - (8 * 6) + 6] % 2 == x3 && x1 == (x2 - (8 * 6) + 6)) main_cl();
                                }
                                else if ((x2 - (8 * 5) + 5) <= f && (x2 - (8 * 5) + 5) >= 1 && stateMap[x2 - (8 * 5) + 5] % 2 == x3 && x1 == (x2 - (8 * 5) + 5)) main_cl();
                            }
                            else if ((x2 - (8 * 4) + 4) <= f && (x2 - (8 * 4) + 4) >= 1 && stateMap[x2 - (8 * 4) + 4] % 2 == x3 && x1 == (x2 - (8 * 4) + 4)) main_cl();
                        }
                        else if ((x2 - (8 * 3) + 3) <= f && (x2 - (8 * 3) + 3) >= 1 && stateMap[x2 - (8 * 3) + 3] % 2 == x3 && x1 == (x2 - (8 * 3) + 3)) main_cl();
                    }
                    else if ((x2 - (8 * 2) + 2) <= f && (x2 - (8 * 2) + 2) >= 1 && stateMap[x2 - (8 * 2) + 2] % 2 == x3 && x1 == (x2 - (8 * 2) + 2)) main_cl();
                }
                else if ((x2 - (8 * 1) + 1) <= f && (x2 - (8 * 1) + 1) >= 1 && stateMap[x2 - (8 * 1) + 1] % 2 == x3 && x1 == (x2 - (8 * 1) + 1)) main_cl();
            }
        }
        public void dump_Bishop_main_cl()
        {
            if ((x2 + (8 * 1) - 1) >= f && (x2 + (8 * 1) - 1) <= 64 && stateMap[x2 + (8 * 1) - 1] == 0)
            {
                if ((x2 + (8 * 2) - 2) >= f && (x2 + (8 * 2) - 2) <= 64 && stateMap[x2 + (8 * 2) - 2] == 0)
                {
                    if ((x2 + (8 * 3) - 3) >= f && (x2 + (8 * 3) - 3) <= 64 && stateMap[x2 + (8 * 3) - 3] == 0)
                    {
                        if ((x2 + (8 * 4) - 4) >= f && (x2 + (8 * 4) - 4) <= 64 && stateMap[x2 + (8 * 4) - 4] == 0)
                        {
                            if ((x2 + (8 * 5) - 5) >= f && (x2 + (8 * 5) - 5) <= 64 && stateMap[x2 + (8 * 5) - 5] == 0)
                            {
                                if ((x2 + (8 * 6) - 6) >= f && (x2 + (8 * 6) - 6) <= 64 && stateMap[x2 + (8 * 6) - 6] == 0)
                                {
                                    if ((x2 + (8 * 7) - 7) >= f && (x2 + (8 * 7) - 7) <= 64 && stateMap[x2 + (8 * 7) - 7] == x3) leon_main_cl();
                                }
                                else if ((x2 + (8 * 6) - 6) >= f && (x2 + (8 * 6) - 6) <= 64 && stateMap[x2 + (8 * 6) - 6] == x3) leon_main_cl();
                            }
                            else if ((x2 + (8 * 5) - 5) >= f && (x2 + (8 * 5) - 5) <= 64 && stateMap[x2 + (8 * 5) - 5] == x3) leon_main_cl();
                        }
                        else if ((x2 + (8 * 4) - 4) >= f && (x2 + (8 * 4) - 4) <= 64 && stateMap[x2 + (8 * 4) - 4] == x3) leon_main_cl();
                    }
                    else if ((x2 + (8 * 3) - 3) >= f && (x2 + (8 * 3) - 3) <= 64 && stateMap[x2 + (8 * 3) - 3] == x3) leon_main_cl();
                }
                else if ((x2 + (8 * 2) - 2) >= f && (x2 + (8 * 2) - 2) <= 64 && stateMap[x2 + (8 * 2) - 2] == x3) leon_main_cl();
            }
            else if ((x2 + (8 * 1) - 1) >= f && (x2 + (8 * 1) - 1) <= 64 && stateMap[x2 + (8 * 1) - 1] == x3) leon_main_cl();
            if ((x2 + (8 * 1) + 1) >= f && (x2 + (8 * 1) + 1) <= 64 && stateMap[x2 + (8 * 1) + 1] == 0)
            {
                if ((x2 + (8 * 2) + 2) >= f && (x2 + (8 * 2) + 2) <= 64 && stateMap[x2 + (8 * 2) + 2] == 0)
                {
                    if ((x2 + (8 * 3) + 3) >= f && (x2 + (8 * 3) + 3) <= 64 && stateMap[x2 + (8 * 3) + 3] == 0)
                    {
                        if ((x2 + (8 * 4) + 4) >= f && (x2 + (8 * 4) + 4) <= 64 && stateMap[x2 + (8 * 4) + 4] == 0)
                        {
                            if ((x2 + (8 * 5) + 5) >= f && (x2 + (8 * 5) + 5) <= 64 && stateMap[x2 + (8 * 5) + 5] == 0)
                            {
                                if ((x2 + (8 * 6) + 6) >= f && (x2 + (8 * 6) + 6) <= 64 && stateMap[x2 + (8 * 6) + 6] == 0)
                                {
                                    if ((x2 + (8 * 7) + 7) >= f && (x2 + (8 * 7) + 7) <= 64 && stateMap[x2 + (8 * 7) + 7] == x3) leon_main_cl();
                                }
                                else if ((x2 + (8 * 6) + 6) >= f && (x2 + (8 * 6) + 6) <= 64 && stateMap[x2 + (8 * 6) + 6] == x3) leon_main_cl();
                            }
                            else if ((x2 + (8 * 5) + 5) >= f && (x2 + (8 * 5) + 5) <= 64 && stateMap[x2 + (8 * 5) + 5] == x3) leon_main_cl();
                        }
                        else if ((x2 + (8 * 4) + 4) >= f && (x2 + (8 * 4) + 4) <= 64 && stateMap[x2 + (8 * 4) + 4] == x3) leon_main_cl();
                    }
                    else if ((x2 + (8 * 3) + 3) >= f && (x2 + (8 * 3) + 3) <= 64 && stateMap[x2 + (8 * 3) + 3] == x3) leon_main_cl();
                }
                else if ((x2 + (8 * 2) + 2) >= f && (x2 + (8 * 2) + 2) <= 64 && stateMap[x2 + (8 * 2) + 2] == x3) leon_main_cl();
            }
            else if ((x2 + (8 * 1) + 1) >= f && (x2 + (8 * 1) + 1) <= 64 && stateMap[x2 + (8 * 1) + 1] == x3) leon_main_cl();
            if ((x2 - (8 * 1) - 1) <= f && (x2 - (8 * 1) - 1) >= 1 && stateMap[x2 - (8 * 1) - 1] == 0)
            {
                if ((x2 - (8 * 2) - 2) <= f && (x2 - (8 * 2) - 2) >= 1 && stateMap[x2 - (8 * 2) - 2] == 0)
                {
                    if ((x2 - (8 * 3) - 3) <= f && (x2 - (8 * 3) - 3) >= 1 && stateMap[x2 - (8 * 3) - 3] == 0)
                    {
                        if ((x2 - (8 * 4) - 4) <= f && (x2 - (8 * 4) - 4) >= 1 && stateMap[x2 - (8 * 4) - 4] == 0)
                        {
                            if ((x2 - (8 * 5) - 5) <= f && (x2 - (8 * 5) - 5) >= 1 && stateMap[x2 - (8 * 5) - 5] == 0)
                            {
                                if ((x2 - (8 * 6) - 6) <= f && (x2 - (8 * 6) - 6) >= 1 && stateMap[x2 - (8 * 6) - 6] == 0)
                                {
                                    if ((x2 - (8 * 7) - 7) <= f && (x2 - (8 * 7) - 7) >= 1 && stateMap[x2 - (8 * 7) - 7] == x3) leon_main_cl();
                                }
                                else if ((x2 - (8 * 6) - 6) <= f && (x2 - (8 * 6) - 6) >= 1 && stateMap[x2 - (8 * 6) - 6] == x3) leon_main_cl();
                            }
                            else if ((x2 - (8 * 5) - 5) <= f && (x2 - (8 * 5) - 5) >= 1 && stateMap[x2 - (8 * 5) - 5] == x3) leon_main_cl();
                        }
                        else if ((x2 - (8 * 4) - 4) <= f && (x2 - (8 * 4) - 4) >= 1 && stateMap[x2 - (8 * 4) - 4] == x3) leon_main_cl();
                    }
                    else if ((x2 - (8 * 3) - 3) <= f && (x2 - (8 * 3) - 3) >= 1 && stateMap[x2 - (8 * 3) - 3] == x3) leon_main_cl();
                }
                else if ((x2 - (8 * 2) - 2) <= f && (x2 - (8 * 2) - 2) >= 1 && stateMap[x2 - (8 * 2) - 2] == x3) leon_main_cl();
            }
            else if ((x2 - (8 * 1) - 1) <= f && (x2 - (8 * 1) - 1) >= 1 && stateMap[x2 - (8 * 1) - 1] == x3) leon_main_cl();
            if ((x2 - (8 * 1) + 1) <= f && (x2 - (8 * 1) + 1) >= 1 && stateMap[x2 - (8 * 1) + 1] == 0)
            {
                if ((x2 - (8 * 2) + 2) <= f && (x2 - (8 * 2) + 2) >= 1 && stateMap[x2 - (8 * 2) + 2] == 0)
                {
                    if ((x2 - (8 * 3) + 3) <= f && (x2 - (8 * 3) + 3) >= 1 && stateMap[x2 - (8 * 3) + 3] == 0)
                    {
                        if ((x2 - (8 * 4) + 4) <= f && (x2 - (8 * 4) + 4) >= 1 && stateMap[x2 - (8 * 4) + 4] == 0)
                        {
                            if ((x2 - (8 * 5) + 5) <= f && (x2 - (8 * 5) + 5) >= 1 && stateMap[x2 - (8 * 5) + 5] == 0)
                            {
                                if ((x2 - (8 * 6) + 6) <= f && (x2 - (8 * 6) + 6) >= 1 && stateMap[x2 - (8 * 6) + 6] == 0)
                                {
                                    if ((x2 - (8 * 7) + 7) <= f && (x2 - (8 * 7) + 7) >= 1 && stateMap[x2 - (8 * 7) + 7] == x3) leon_main_cl();
                                }
                                else if ((x2 - (8 * 6) + 6) <= f && (x2 - (8 * 6) + 6) >= 1 && stateMap[x2 - (8 * 6) + 6] == x3) leon_main_cl();
                            }
                            else if ((x2 - (8 * 5) + 5) <= f && (x2 - (8 * 5) + 5) >= 1 && stateMap[x2 - (8 * 5) + 5] == x3) leon_main_cl();
                        }
                        else if ((x2 - (8 * 4) + 4) <= f && (x2 - (8 * 4) + 4) >= 1 && stateMap[x2 - (8 * 4) + 4] == x3) leon_main_cl();
                    }
                    else if ((x2 - (8 * 3) + 3) <= f && (x2 - (8 * 3) + 3) >= 1 && stateMap[x2 - (8 * 3) + 3] == x3) leon_main_cl();
                }
                else if ((x2 - (8 * 2) + 2) <= f && (x2 - (8 * 2) + 2) >= 1 && stateMap[x2 - (8 * 2) + 2] == x3) leon_main_cl();
            }
            else if ((x2 - (8 * 1) + 1) <= f && (x2 - (8 * 1) + 1) >= 1 && stateMap[x2 - (8 * 1) + 1] == x3) leon_main_cl();
        }
        int x4;
        public void dump_king()
        {
            if (n % 2 == 0)
            {
                if (x4 % 8 == 0) f = 8 * (x4 / 8);
                else f = 8 * (x4 / 8 + 1);
                if ((x4 - 1) >= 1 && stateMap[x4 - 1] == 61 && (x4 - 1) > f - 8) k++;
                if ((x4 + 7) <= 64 && stateMap[x4 + 7] == 61 && (x4 + 7) > f) k++;
                if ((x4 + 8) <= 64 && stateMap[x4 + 8] == 61 && (x4 + 8) > f) k++;
                if ((x4 + 9) <= 64 && stateMap[x4 + 9] == 61 && (x4 + 9) <= f + 8) k++;
                if ((x4 + 1) <= 64 && stateMap[x4 + 1] == 61 && (x4 + 1) <= f) k++;
                if ((x4 - 7) >= 1 && stateMap[x4 - 7] == 61 && (x4 - 7) <= f - 8) k++;
                if ((x4 - 8) >= 1 && stateMap[x4 - 8] == 61 && (x4 - 8) <= f - 8) k++;
                if ((x4 - 9) >= 1 && stateMap[x4 - 9] == 61 && (x4 - 9) > f - 16) k++;
            }
            if (n % 2 == 1)
            {
                if (x4 % 8 == 0) f = 8 * (x4 / 8);
                else f = 8 * (x4 / 8 + 1);
                if ((x4 - 1) >= 1 && stateMap[x4 - 1] == 60 && (x4 - 1) > f - 8) k++;
                if ((x4 + 7) <= 64 && stateMap[x4 + 7] == 60 && (x4 + 7) > f) k++;
                if ((x4 + 8) <= 64 && stateMap[x4 + 8] == 60 && (x4 + 8) > f) k++;
                if ((x4 + 9) <= 64 && stateMap[x4 + 9] == 60 && (x4 + 9) <= f + 8) k++;
                if ((x4 + 1) <= 64 && stateMap[x4 + 1] == 60 && (x4 + 1) <= f) k++;
                if ((x4 - 7) >= 1 && stateMap[x4 - 7] == 60 && (x4 - 7) <= f - 8) k++;
                if ((x4 - 8) >= 1 && stateMap[x4 - 8] == 60 && (x4 - 8) <= f - 8) k++;
                if ((x4 - 9) >= 1 && stateMap[x4 - 9] == 60 && (x4 - 9) > f - 16) k++;
            }
        }
        public void dump_King_move_check_cl()
        {
            left_cl();
            h = 0;
            if (n % 2 == 0)
            {
                x2 = x5;
                left_cl();
                if ((x2 + 7) <= 64 && stateMap[x2 + 7] == 11 && (x2 + 7) > f) g++;
                else if ((x2 + 9) <= 64 && stateMap[x2 + 9] == 11 && (x2 + 9) <= f + 8) g++;
                if ((x2 - 1) >= 1 && (x2 - 1) > f - 8)
                {
                    x4 = (x2 - 1);
                    dump_king();
                }
                left_cl();
                if ((x2 + 7) <= 64 && (x2 + 7) > f)
                {
                    x4 = (x2 + 7);
                    dump_king();
                }
                left_cl();
                if ((x2 + 8) <= 64 && (x2 + 8) > f)
                {
                    x4 = (x2 + 8);
                    dump_king();
                }
                if ((x2 + 9) <= 64 && (x2 + 9) <= f + 8)
                {
                    x4 = (x2 + 9);
                    dump_king();
                }
                left_cl();
                if ((x2 + 1) <= 64 && (x2 + 1) <= f)
                {
                    x4 = (x2 + 1);
                    dump_king();
                }
                left_cl();
                if ((x2 - 7) >= 1 && (x2 - 7) <= f - 8)
                {
                    x4 = (x2 - 7);
                    dump_king();
                }
                left_cl();
                if ((x2 - 8) >= 1 && (x2 - 8) <= f - 8)
                {
                    x4 = (x2 - 8);
                    dump_king();
                }
                left_cl();
                if ((x2 - 9) >= 1 && (x2 - 9) > f - 16)
                {
                    x4 = (x2 - 9);
                    dump_king();
                }
                left_cl();
                x3 = 21;
                dump_Rook_main_cl();
                if ((x2 + 8 - 2) >= f && (x2 + 8 - 2) <= 64 && stateMap[x2 + 8 - 2] == 31) g++;
                if ((x2 + 16 - 1) >= f + 8 && (x2 + 16 - 1) <= 64 && stateMap[x2 + 16 - 1] == 31) g++;
                if ((x2 + 16 + 1) >= f + 8 && (x2 + 16 + 1) <= 64 && stateMap[x2 + 16 + 1] == 31) g++;
                if ((x2 + 8 + 2) >= f && (x2 + 8 + 2) <= 64 && stateMap[x2 + 8 + 2] == 31) g++;
                if ((x2 - 8 + 2) <= f - 8 && (x2 - 8 + 2) >= 1 && stateMap[x2 - 8 + 2] == 31) g++;
                if ((x2 - 16 + 1) <= f - 16 && (x2 - 16 + 1) >= 1 && stateMap[x2 - 16 + 1] == 31) g++;
                if ((x2 - 16 - 1) <= f - 16 && (x2 - 16 - 1) >= 1 && stateMap[x2 - 16 - 1] == 31) g++;
                if ((x2 - 8 - 2) <= f - 8 && (x2 - 8 - 2) >= 1 && stateMap[x2 - 8 - 2] == 31) g++;
                x3 = 41;
                dump_Bishop_main_cl();
                x3 = 51;
                dump_Rook_main_cl();
                dump_Bishop_main_cl();
            }
            else if (n % 2 == 1)
            {
                x2 = x5;
                left_cl();
                if ((x2 - 7) >= 1 && stateMap[x2 - 7] == 10 && (x2 - 7) <= f - 8) g++;
                else if ((x2 - 9) >= 1 && stateMap[x2 - 9] == 10 && (x2 - 9) > f - 16) g++;
                if ((x2 - 1) >= 1 && (x2 - 1) > f - 8)
                {
                    x4 = (x2 - 1);
                    dump_king();
                }
                left_cl();
                if ((x2 + 7) <= 64 && (x2 + 7) > f)
                {
                    x4 = (x2 + 7);
                    dump_king();
                }
                left_cl();
                if ((x2 + 8) <= 64 && (x2 + 8) > f)
                {
                    x4 = (x2 + 8);
                    dump_king();
                }
                left_cl();
                if ((x2 + 9) <= 64 && (x2 + 9) <= f + 8)
                {
                    x4 = (x2 + 9);
                    dump_king();
                }
                left_cl();
                if ((x2 + 1) <= 64 && (x2 + 1) <= f)
                {
                    x4 = (x2 + 1);
                    dump_king();
                }
                left_cl();
                if ((x2 - 7) >= 1 && (x2 - 7) <= f - 8)
                {
                    x4 = (x2 - 7);
                    dump_king();
                }
                left_cl();
                if ((x2 - 8) >= 1 && (x2 - 8) <= f - 8)
                {
                    x4 = (x2 - 8);
                    dump_king();
                }
                left_cl();
                if ((x2 - 9) >= 1 && (x2 - 9) > f - 16)
                {
                    x4 = (x2 - 9);
                    dump_king();
                }
                left_cl();
                x3 = 20;
                dump_Rook_main_cl();
                if ((x2 + 8 - 2) >= f && (x2 + 8 - 2) <= 64 && stateMap[x2 + 8 - 2] == 30) g++;
                if ((x2 + 16 - 1) >= f + 8 && (x2 + 16 - 1) <= 64 && stateMap[x2 + 16 - 1] == 30) g++;
                if ((x2 + 16 + 1) >= f + 8 && (x2 + 16 + 1) <= 64 && stateMap[x2 + 16 + 1] == 30) g++;
                if ((x2 + 8 + 2) >= f && (x2 + 8 + 2) <= 64 && stateMap[x2 + 8 + 2] == 30) g++;
                if ((x2 - 8 + 2) <= f - 8 && (x2 - 8 + 2) >= 1 && stateMap[x2 - 8 + 2] == 30) g++;
                if ((x2 - 16 + 1) <= f - 16 && (x2 - 16 + 1) >= 1 && stateMap[x2 - 16 + 1] == 30) g++;
                if ((x2 - 16 - 1) <= f - 16 && (x2 - 16 - 1) >= 1 && stateMap[x2 - 16 - 1] == 30) g++;
                if ((x2 - 8 - 2) <= f - 8 && (x2 - 8 - 2) >= 1 && stateMap[x2 - 8 - 2] == 30) g++;
                x3 = 40;
                dump_Bishop_main_cl();
                x3 = 50;
                dump_Rook_main_cl();
                dump_Bishop_main_cl();
            }
        }
        int x5, n1, n2, n3, n4, n5; 
        public void king_main_cl2()
        {
            k = 0;
            g = 0;
            if (n % 2 == 1)
            {
                for (int i = 1; i <= 64; i++)
                {
                    if (stateMap[i] == 61)
                    {
                        n1 = i;
                        break;
                    }
                }
            }
            if (n % 2 == 0)
            {
                for (int i = 1; i <= 64; i++)
                {
                    if (stateMap[i] == 60)
                    {
                        n1 = i;
                        break;
                    }
                }
            }
            x2 = n1;
            left_cl();
            if (n % 2 == 1) x3 = 0;
            if (n % 2 == 0) x3 = 1;
            if ((x2 - 1) >= 1 && (x2 - 1) > f - 8)
            {
                x5 = (x2 - 1);
                dump_King_move_check_cl();
                x2 = n1;
                left_cl();
                if (n % 2 == 1) x3 = 0;
                if (n % 2 == 0) x3 = 1;
                h = 5;
                if ((x2 - 1) >= 1 && stateMap[x2 - 1] == 0 && (x2 - 1) > f - 8 && k == 0 && g == 0) leon_main_cl();
                else if ((x2 - 1) >= 1 && stateMap[x2 - 1] % 2 == x3 && (x2 - 1) > f - 8 && k == 0 && g == 0) leon_main_cl();
                k = 0;
                g = 0;
            }
            if ((x2 + 7) <= 64 && (x2 + 7) > f)
            {
                x5 = (x2 + 7);
                dump_King_move_check_cl();
                x2 = n1;
                left_cl();
                if (n % 2 == 1) x3 = 0;
                if (n % 2 == 0) x3 = 1;
                h = 5;
                if ((x2 + 7) <= 64 && stateMap[x2 + 7] == 0 && (x2 + 7) > f && k == 0 && g == 0) leon_main_cl();
                else if ((x2 + 7) <= 64 && stateMap[x2 + 7] % 2 == x3 && (x2 + 7) > f && k == 0 && g == 0) leon_main_cl();
                k = 0;
                g = 0;
            }
            if ((x2 + 8) <= 64 && (x2 + 8) > f)
            {
                x5 = (x2 + 8);
                dump_King_move_check_cl();
                x2 = n1;
                left_cl();
                if (n % 2 == 1) x3 = 0;
                if (n % 2 == 0) x3 = 1;
                h = 5;
                if ((x2 + 8) <= 64 && stateMap[x2 + 8] == 0 && (x2 + 8) > f && k == 0 && g == 0) leon_main_cl();
                else if ((x2 + 8) <= 64 && stateMap[x2 + 8] % 2 == x3 && (x2 + 8) > f && k == 0 && g == 0) leon_main_cl();
                k = 0;
                g = 0;
            }
            if ((x2 + 9) <= 64 && (x2 + 9) <= f + 8)
            {
                x5 = (x2 + 9);
                dump_King_move_check_cl();
                x2 = n1;
                left_cl();
                if (n % 2 == 1) x3 = 0;
                if (n % 2 == 0) x3 = 1;
                h = 5;
                if ((x2 + 9) <= 64 && stateMap[x2 + 9] == 0 && (x2 + 9) <= f + 8 && k == 0 && g == 0) leon_main_cl();
                else if ((x2 + 9) <= 64 && stateMap[x2 + 9] % 2 == x3 && (x2 + 9) <= f + 8 && k == 0 && g == 0) leon_main_cl();
                k = 0;
                g = 0;
            }
            if ((x2 + 1) <= 64 && (x2 + 1) <= f)
            {
                x5 = (x2 + 1);
                dump_King_move_check_cl();
                x2 = n1;
                left_cl();
                if (n % 2 == 1) x3 = 0;
                if (n % 2 == 0) x3 = 1;
                h = 5;
                if ((x2 + 1) <= 64 && stateMap[x2 + 1] == 0 && (x2 + 1) <= f && k == 0 && g == 0) leon_main_cl();
                else if ((x2 + 1) <= 64 && stateMap[x2 + 1] % 2 == x3 && (x2 + 1) <= f && k == 0 && g == 0) leon_main_cl();
                k = 0;
                g = 0;
            }
            if ((x2 - 7) >= 1 && (x2 - 7) <= f - 8)
            {
                x5 = (x2 - 7);
                dump_King_move_check_cl();
                x2 = n1;
                left_cl();
                if (n % 2 == 1) x3 = 0;
                if (n % 2 == 0) x3 = 1;
                h = 5;
                if ((x2 - 7) >= 1 && stateMap[x2 - 7] == 0 && (x2 - 7) <= f - 8 && k == 0 && g == 0) leon_main_cl();
                else if ((x2 - 7) >= 1 && stateMap[x2 - 7] % 2 == x3 && (x2 - 7) <= f - 8 && k == 0 && g == 0) leon_main_cl();
                k = 0;
                g = 0;
            }
            if ((x2 - 8) >= 1 && (x2 - 8) <= f - 8)
            {
                x5 = (x2 - 8);
                dump_King_move_check_cl();
                x2 = n1;
                left_cl();
                if (n % 2 == 1) x3 = 0;
                if (n % 2 == 0) x3 = 1;
                h = 5;
                if ((x2 - 8) >= 1 && stateMap[x2 - 8] == 0 && (x2 - 8) <= f - 8 && k == 0 && g == 0) leon_main_cl();
                else if ((x2 - 8) >= 1 && stateMap[x2 - 8] % 2 == x3 && (x2 - 8) <= f - 8 && k == 0 && g == 0) leon_main_cl();
                k = 0;
                g = 0;
            }
            if ((x2 - 9) >= 1 && (x2 - 9) > f - 16)
            {
                x5 = (x2 - 9);
                dump_King_move_check_cl();
                x2 = n1;
                left_cl();
                if (n % 2 == 1) x3 = 0;
                if (n % 2 == 0) x3 = 1;
                h = 5;
                if ((x2 - 9) >= 1 && stateMap[x2 - 9] == 0 && (x2 - 9) > f - 16 && k == 0 && g == 0) leon_main_cl();
                else if ((x2 - 9) >= 1 && stateMap[x2 - 9] % 2 == x3 && (x2 - 9) > f - 16 && k == 0 && g == 0) leon_main_cl();
                k = 0;
                g = 0;
            }
        }
        public void king_main_cl()
        {
            k = 0;
            g = 0;
            if (n % 2 == 1)
            {
                for (int i = 1; i <= 64; i++)
                {
                    if (stateMap[i] == 61)
                    {
                        n1 = i;
                        break;
                    }
                }
            }
            if (n % 2 == 0)
            {
                for (int i = 1; i <= 64; i++)
                {
                    if (stateMap[i] == 60)
                    {
                        n1 = i;
                        break;
                    }
                }
            }
            x2 = n1;
            left_cl();
            if (n % 2 == 1) x3 = 0;
            if (n % 2 == 0) x3 = 1;
            if ((x2 - 1) >= 1 && (x2 - 1) > f - 8)
            {
                x5 = (x2 - 1);
                dump_King_move_check_cl();
                x2 = n1;
                left_cl();
                if (n % 2 == 1) x3 = 0;
                if (n % 2 == 0) x3 = 1;
                h = 6;
                if ((x2 - 1) >= 1 && stateMap[x2 - 1] == 0 && (x2 - 1) > f - 8 && k == 0 && g == 0) leon_main_cl();
                else if ((x2 - 1) >= 1 && stateMap[x2 - 1] % 2 == x3 && (x2 - 1) > f - 8 && k == 0 && g == 0) leon_main_cl();
                k = 0;
                g = 0;
            }
            if ((x2 + 7) <= 64 && (x2 + 7) > f)
            {
                x5 = (x2 + 7);
                dump_King_move_check_cl();
                x2 = n1;
                left_cl();
                if (n % 2 == 1) x3 = 0;
                if (n % 2 == 0) x3 = 1;
                h = 6;
                if ((x2 + 7) <= 64 && stateMap[x2 + 7] == 0 && (x2 + 7) > f && k == 0 && g == 0) leon_main_cl();
                else if ((x2 + 7) <= 64 && stateMap[x2 + 7] % 2 == x3 && (x2 + 7) > f && k == 0 && g == 0) leon_main_cl();
                k = 0;
                g = 0;
            }
            if ((x2 + 8) <= 64 && (x2 + 8) > f)
            {
                x5 = (x2 + 8);
                dump_King_move_check_cl();
                x2 = n1;
                left_cl();
                if (n % 2 == 1) x3 = 0;
                if (n % 2 == 0) x3 = 1;
                h = 6;
                if ((x2 + 8) <= 64 && stateMap[x2 + 8] == 0 && (x2 + 8) > f && k == 0 && g == 0) leon_main_cl();
                else if ((x2 + 8) <= 64 && stateMap[x2 + 8] % 2 == x3 && (x2 + 8) > f && k == 0 && g == 0) leon_main_cl();
                k = 0;
                g = 0;
            }
            if ((x2 + 9) <= 64 && (x2 + 9) <= f + 8)
            {
                x5 = (x2 + 9);
                dump_King_move_check_cl();
                x2 = n1;
                left_cl();
                if (n % 2 == 1) x3 = 0;
                if (n % 2 == 0) x3 = 1;
                h = 6;
                if ((x2 + 9) <= 64 && stateMap[x2 + 9] == 0 && (x2 + 9) <= f + 8 && k == 0 && g == 0) leon_main_cl();
                else if ((x2 + 9) <= 64 && stateMap[x2 + 9] % 2 == x3 && (x2 + 9) <= f + 8 && k == 0 && g == 0) leon_main_cl();
                k = 0;
                g = 0;
            }
            if ((x2 + 1) <= 64 && (x2 + 1) <= f)
            {
                x5 = (x2 + 1);
                dump_King_move_check_cl();
                x2 = n1;
                left_cl();
                if (n % 2 == 1) x3 = 0;
                if (n % 2 == 0) x3 = 1;
                h = 6;
                if ((x2 + 1) <= 64 && stateMap[x2 + 1] == 0 && (x2 + 1) <= f && k == 0 && g == 0) leon_main_cl();
                else if ((x2 + 1) <= 64 && stateMap[x2 + 1] % 2 == x3 && (x2 + 1) <= f && k == 0 && g == 0) leon_main_cl();
                k = 0;
                g = 0;
            }
            if ((x2 - 7) >= 1 && (x2 - 7) <= f - 8)
            {
                x5 = (x2 - 7);
                dump_King_move_check_cl();
                x2 = n1;
                left_cl();
                if (n % 2 == 1) x3 = 0;
                if (n % 2 == 0) x3 = 1;
                h = 6;
                if ((x2 - 7) >= 1 && stateMap[x2 - 7] == 0 && (x2 - 7) <= f - 8 && k == 0 && g == 0) leon_main_cl();
                else if ((x2 - 7) >= 1 && stateMap[x2 - 7] % 2 == x3 && (x2 - 7) <= f - 8 && k == 0 && g == 0) leon_main_cl();
                k = 0;
                g = 0;
            }
            if ((x2 - 8) >= 1 && (x2 - 8) <= f - 8)
            {
                x5 = (x2 - 8);
                dump_King_move_check_cl();
                x2 = n1;
                left_cl();
                if (n % 2 == 1) x3 = 0;
                if (n % 2 == 0) x3 = 1;
                h = 6;
                if ((x2 - 8) >= 1 && stateMap[x2 - 8] == 0 && (x2 - 8) <= f - 8 && k == 0 && g == 0) leon_main_cl();
                else if ((x2 - 8) >= 1 && stateMap[x2 - 8] % 2 == x3 && (x2 - 8) <= f - 8 && k == 0 && g == 0) leon_main_cl();
                k = 0;
                g = 0;
            }
            if ((x2 - 9) >= 1 && (x2 - 9) > f - 16)
            {
                x5 = (x2 - 9);
                dump_King_move_check_cl();
                x2 = n1;
                left_cl();
                if (n % 2 == 1) x3 = 0;
                if (n % 2 == 0) x3 = 1;
                h = 6;
                if ((x2 - 9) >= 1 && stateMap[x2 - 9] == 0 && (x2 - 9) > f - 16 && k == 0 && g == 0) leon_main_cl();
                else if ((x2 - 9) >= 1 && stateMap[x2 - 9] % 2 == x3 && (x2 - 9) > f - 16 && k == 0 && g == 0) leon_main_cl();
                k = 0;
                g = 0;
            }
        }
        public void dump_king_main_cl()
        {
            if ((x2 - 1) >= 1 && stateMap[x2 - 1] == x3 && (x2 - 1) > f - 8) leon_main_cl();
            if ((x2 + 7) <= 64 && stateMap[x2 + 7] == x3 && (x2 + 7) > f) leon_main_cl();
            if ((x2 + 8) <= 64 && stateMap[x2 + 8] == x3 && (x2 + 8) > f) leon_main_cl();
            if ((x2 + 9) <= 64 && stateMap[x2 + 9] == x3 && (x2 + 9) <= f + 8) leon_main_cl();
            if ((x2 + 1) <= 64 && stateMap[x2 + 1] == x3 && (x2 + 1) <= f) leon_main_cl();
            if ((x2 - 7) >= 1 && stateMap[x2 - 7] == x3 && (x2 - 7) <= f - 8) leon_main_cl();
            if ((x2 - 8) >= 1 && stateMap[x2 - 8] == x3 && (x2 - 8) <= f - 8) leon_main_cl();
            if ((x2 - 9) >= 1 && stateMap[x2 - 9] == x3 && (x2 - 9) > f - 16) leon_main_cl();
        }
        int p1, p2, p3, p4, p5, p6, p7, z, a;
        public void dump_all_main_cl()
        {
            h = 7;
            left_cl();
            if (n % 2 == 1)
            {
                if ((x2 + 7) <= 64 && stateMap[x2 + 7] == 11 && (x2 + 7) > f) z++;
                else if ((x2 + 9) <= 64 && stateMap[x2 + 9] == 11 && (x2 + 9) <= f + 8) z++;
                x3 = 21;
                dump_Rook_main_cl();
                if ((x2 + 8 - 2) >= f && (x2 + 8 - 2) <= 64 && stateMap[x2 + 8 - 2] == 31) z++;
                if ((x2 + 16 - 1) >= f + 8 && (x2 + 16 - 1) <= 64 && stateMap[x2 + 16 - 1] == 31) z++;
                if ((x2 + 16 + 1) >= f + 8 && (x2 + 16 + 1) <= 64 && stateMap[x2 + 16 + 1] == 31) z++;
                if ((x2 + 8 + 2) >= f && (x2 + 8 + 2) <= 64 && stateMap[x2 + 8 + 2] == 31) z++;
                if ((x2 - 8 + 2) <= f - 8 && (x2 - 8 + 2) >= 1 && stateMap[x2 - 8 + 2] == 31) z++;
                if ((x2 - 16 + 1) <= f - 16 && (x2 - 16 + 1) >= 1 && stateMap[x2 - 16 + 1] == 31) z++;
                if ((x2 - 16 - 1) <= f - 16 && (x2 - 16 - 1) >= 1 && stateMap[x2 - 16 - 1] == 31) z++;
                if ((x2 - 8 - 2) <= f - 8 && (x2 - 8 - 2) >= 1 && stateMap[x2 - 8 - 2] == 31) z++;
                x3 = 41;
                dump_Bishop_main_cl();
                x3 = 51;
                dump_Rook_main_cl();
                dump_Bishop_main_cl();
                x3 = 61;
                dump_king_main_cl();
            }
            if (n % 2 == 0)
            {
                if ((x2 - 7) >= 1 && stateMap[x2 - 7] == 10 && (x2 - 7) <= f - 8) z++;
                else if ((x2 - 9) >= 1 && stateMap[x2 - 9] == 10 && (x2 - 9) > f - 16) z++;
                x3 = 20;
                dump_Rook_main_cl();
                if ((x2 + 8 - 2) >= f && (x2 + 8 - 2) <= 64 && stateMap[x2 + 8 - 2] == 30) z++;
                if ((x2 + 16 - 1) >= f + 8 && (x2 + 16 - 1) <= 64 && stateMap[x2 + 16 - 1] == 30) z++;
                if ((x2 + 16 + 1) >= f + 8 && (x2 + 16 + 1) <= 64 && stateMap[x2 + 16 + 1] == 30) z++;
                if ((x2 + 8 + 2) >= f && (x2 + 8 + 2) <= 64 && stateMap[x2 + 8 + 2] == 30) z++;
                if ((x2 - 8 + 2) <= f - 8 && (x2 - 8 + 2) >= 1 && stateMap[x2 - 8 + 2] == 30) z++;
                if ((x2 - 16 + 1) <= f - 16 && (x2 - 16 + 1) >= 1 && stateMap[x2 - 16 + 1] == 30) z++;
                if ((x2 - 16 - 1) <= f - 16 && (x2 - 16 - 1) >= 1 && stateMap[x2 - 16 - 1] == 30) z++;
                if ((x2 - 8 - 2) <= f - 8 && (x2 - 8 - 2) >= 1 && stateMap[x2 - 8 - 2] == 30) z++;
                x3 = 40;
                dump_Bishop_main_cl();
                x3 = 50;
                dump_Rook_main_cl();
                dump_Bishop_main_cl();
                x3 = 60;
                dump_king_main_cl();
            }
        }
        int kp;
        public void checkmate_main_checker()
        {

            if (n % 2 == 1)
            {
                for (int i = 1; i < 65; i++)
                {
                    if (stateMap[i] == 61) kp = i;
                }
            }
            if (n % 2 == 0)
            {
                for (int i = 1; i < 65; i++)
                {
                    if (stateMap[i] == 60) kp = i;
                }
            }
            if (m == 10 || m == 11)
            {
                a = 1;

                Updaterazor(1, cb); ;
            }
            if (m == 20 || m == 21)
            {
                if (cb > kp)
                {
                    if ((cb - kp) <= 8)
                    {
                        a = (cb - kp);
                        for (int i = 0; i < a; i++)
                        {
                            Updaterazor(i + 1, cb - i);
                        }
                    }
                    if ((cb - kp) >= 8)
                    {
                        a = (cb - kp) / 8;
                        for (int i = 0; i < a; i++)
                        {
                            Updaterazor(i + 1, cb - (8 * i));
                        }
                    }
                }
                if (cb < kp)
                {
                    if ((kp - cb) <= 8)
                    {
                        a = (kp - cb);
                        for (int i = 0; i < a; i++)
                        {
                            Updaterazor(i + 1, cb + i);
                        }
                    }
                    if ((kp - cb) >= 8)
                    {
                        a = (kp - cb) / 8;
                        for (int i = 0; i < a; i++)
                        {
                            Updaterazor(i + 1, cb + (8 * i));
                        }
                    }
                }
            }
            if (m == 30 || m == 31)
            {
                a = 1;
                Updaterazor( 1 , cb);
            }
            if (m == 40 || m == 41)
            {
                if (cb > kp)
                {
                    a = (cb - kp) / 8;
                    if ((cb - kp) <= kp + (8 * a))
                    {
                        for (int i = 0; i < a; i++)
                        {
                            Updaterazor(i + 1, cb - (8 * i) + i);
                        }
                    }
                    if ((cb - kp) >= kp + (8 * a))
                    {
                        for (int i = 0; i < a; i++)
                        {
                            Updaterazor(i + 1, cb - (8 * i) - i);
                        }
                    }
                }
                if (cb < kp)
                {
                    a = (kp - cb) / 8;
                    if ((kp - cb) <= kp - (8 * a))
                    {
                        for (int i = 0; i < a; i++)
                        {
                            Updaterazor(i + 1, cb + (8 * i) - i);
                        }
                    }
                    if ((kp - cb) >= kp - (8 * a))
                    {
                        for (int i = 0; i < a; i++)
                        {
                            Updaterazor(i + 1, cb + (8 * i) + i);
                        }
                    }
                }
            }
            if (m == 50 || m == 51)
            {
                if (cb > kp)
                {
                    if ((cb - kp) <= (((kp / 8) + 1) * 8))
                    {
                        a = (cb - kp);
                        for (int i = 0; i < a; i++)
                        {
                            Updaterazor(i + 1, cb - i);
                        }
                    }
                    if ((cb - kp) == kp + (8 * a))
                    {
                        a = (cb - kp) / 8;
                        for (int i = 0; i < a; i++)
                        {
                            Updaterazor(i + 1, cb - (8 * i));
                        }
                    }
                    a = (cb - kp) / 8;
                    if ((cb - kp) <= kp + (8 * a))
                    {
                        for (int i = 0; i < a; i++)
                        {
                            Updaterazor(i + 1, cb - (8 * i) + i);
                        }
                    }
                    if ((cb - kp) >= kp + (8 * a))
                    {
                        for (int i = 0; i < a; i++)
                        {
                            Updaterazor(i + 1, cb - (8 * i) - i);
                        }
                    }
                }
                if (cb < kp)
                {
                    if ((kp - cb) <= (((kp / 8) + 1) * 8))
                    {
                        a = (kp - cb);
                        for (int i = 0; i < a; i++)
                        {
                            Updaterazor(i + 1, cb + i);
                        }
                    }
                    if ((kp - cb) == kp + (8 * a))
                    {
                        a = (kp - cb) / 8;
                        for (int i = 0; i < a; i++)
                        {
                            Updaterazor(i + 1, cb + (8 * i));
                        }
                    }
                    a = (kp - cb) / 8;
                    if ((kp - cb) <= kp - (8 * a))
                    {
                        for (int i = 0; i < a; i++)
                        {
                            Updaterazor(i + 1, cb + (8 * i) - i);
                        }
                    }
                    if ((kp - cb) >= kp - (8 * a))
                    {
                        for (int i = 0; i < a; i++)
                        {
                            Updaterazor(i + 1, cb + (8 * i) + i);
                    }
                    }
                }
            }
        }
        public void mate_main_cl()
        {
            h = 6;
            if (n % 2 == 1) x3 = 0;
            if (n % 2 == 0) x3 = 1;
            r = 0;
            z = 0;
            king_main_cl();
            checkmate_main_checker();
            for (int i = 1; i <= a; i++)
            {
                x2 = razorMap[i];
                dump_all_main_cl();
            }
            if (r == 0 && z == 0)
            {
                if (n % 2 == 0)
                {
                    mate2.Content = "Check Mate";
                    lose1_cl();
                }
                if (n % 2 == 1)
                {
                    mate1.Content = "Check Mate";
                    lose2_cl();
                }
            }
            z = 0;
        }
        private void Updaterazor(int razorNumber, int newrazor)
        {
            if (razorMap.ContainsKey(razorNumber))
            {
                razorMap[razorNumber] = newrazor;
                switch (razorNumber)
                {
                    case 1:
                        p1 = newrazor;
                        break;
                    case 2:
                        p2 = newrazor;
                        break;
                    case 3:
                        p3 = newrazor;
                        break;
                    case 4:
                        p4 = newrazor;
                        break;
                    case 5:
                        p5 = newrazor;
                        break;
                    case 6:
                        p6 = newrazor;
                        break;
                    case 7:
                        p7 = newrazor;
                        break;
                }
            }
        }
        public void ada_main_cl()
        {
            if (l == 0)
            {
                o++;
            }
            if (l == 1)
            {
                q++;
            }
        }
        public void Rook_move_checker()
        {
            if ((x2 + 8 * 1) <= 64)
            {
                if ((x2 + 8 * 1) <= 64 && stateMap[x2 + 8 * 1] == 0)
                {
                    ada_main_cl();
                    if ((x2 + 8 * 2) <= 64 && stateMap[x2 + 8 * 2] == 0)
                    {
                        ada_main_cl();
                        if ((x2 + 8 * 3) <= 64 && stateMap[x2 + 8 * 3] == 0)
                        {
                            ada_main_cl();
                            if ((x2 + 8 * 4) <= 64 && stateMap[x2 + 8 * 4] == 0)
                            {
                                ada_main_cl();
                                if ((x2 + 8 * 5) <= 64 && stateMap[x2 + 8 * 5] == 0)
                                {
                                    ada_main_cl();
                                    if ((x2 + 8 * 6) <= 64 && stateMap[x2 + 8 * 6] == 0)
                                    {
                                        ada_main_cl();
                                        if ((x2 + 8 * 7) <= 64 && stateMap[x2 + 8 * 7] % 2 == x3) ada_main_cl();
                                    }
                                    else if ((x2 + 8 * 6) <= 64 && stateMap[x2 + 8 * 6] % 2 == x3) ada_main_cl();
                                }
                                else if ((x2 + 8 * 5) <= 64 && stateMap[x2 + 8 * 5] % 2 == x3) ada_main_cl();
                            }
                            else if ((x2 + 8 * 4) <= 64 && stateMap[x2 + 8 * 4] % 2 == x3) ada_main_cl();
                        }
                        else if ((x2 + 8 * 3) <= 64 && stateMap[x2 + 8 * 3] % 2 == x3) ada_main_cl();
                    }
                    else if ((x2 + 8 * 2) <= 64 && stateMap[x2 + 8 * 2] % 2 == x3) ada_main_cl();
                }
                else if ((x2 + 8 * 1) <= 64 && stateMap[x2 + 8 * 1] % 2 == x3) ada_main_cl();
            }
            if (x2 % 8 != 0)
            {
                if ((x2 + 1 * 1) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 1] == 0)
                {
                    ada_main_cl();
                    if ((x2 + 1 * 2) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 2] == 0)
                    {
                        ada_main_cl();
                        if ((x2 + 1 * 3) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 3] == 0)
                        {
                            ada_main_cl();
                            if ((x2 + 1 * 4) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 4] == 0)
                            {
                                ada_main_cl();
                                if ((x2 + 1 * 5) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 5] == 0)
                                {
                                    ada_main_cl();
                                    if ((x2 + 1 * 6) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 6] == 0)
                                    {
                                        ada_main_cl();
                                        if ((x2 + 1 * 7) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 7] % 2 == x3) ada_main_cl();
                                    }
                                    else if ((x2 + 1 * 6) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 6] % 2 == x3) ada_main_cl();
                                }
                                else if ((x2 + 1 * 5) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 5] % 2 == x3) ada_main_cl();
                            }
                            else if ((x2 + 1 * 4) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 4] % 2 == x3) ada_main_cl();
                        }
                        else if ((x2 + 1 * 3) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 3] % 2 == x3) ada_main_cl();
                    }
                    else if ((x2 + 1 * 2) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 2] % 2 == x3) ada_main_cl();
                }
                else if ((x2 + 1 * 1) <= (8 * (x2 / 8 + 1)) && stateMap[x2 + 1 * 1] % 2 == x3) ada_main_cl();
            }
            if ((x2 - 8 * 1) >= 1)
            {
                if ((x2 - 8 * 1) >= 1 && stateMap[x2 - 8 * 1] == 0)
                {
                    ada_main_cl();
                    if ((x2 - 8 * 2) >= 1 && stateMap[x2 - 8 * 2] == 0)
                    {
                        ada_main_cl();
                        if ((x2 - 8 * 3) >= 1 && stateMap[x2 - 8 * 3] == 0)
                        {
                            ada_main_cl();
                            if ((x2 - 8 * 4) >= 1 && stateMap[x2 - 8 * 4] == 0)
                            {
                                ada_main_cl();
                                if ((x2 - 8 * 5) >= 1 && stateMap[x2 - 8 * 5] == 0)
                                {
                                    ada_main_cl();
                                    if ((x2 - 8 * 6) >= 1 && stateMap[x2 - 8 * 6] == 0)
                                    {
                                        ada_main_cl();
                                        if ((x2 - 8 * 7) >= 1 && stateMap[x2 - 8 * 7] % 2 == x3) ada_main_cl();
                                    }
                                    else if ((x2 - 8 * 6) >= 1 && stateMap[x2 - 8 * 6] % 2 == x3) ada_main_cl();
                                }
                                else if ((x2 - 8 * 5) >= 1 && stateMap[x2 - 8 * 5] % 2 == x3) ada_main_cl();
                            }
                            else if ((x2 - 8 * 4) >= 1 && stateMap[x2 - 8 * 4] % 2 == x3) ada_main_cl();
                        }
                        else if ((x2 - 8 * 3) >= 1 && stateMap[x2 - 8 * 3] % 2 == x3) ada_main_cl();
                    }
                    else if ((x2 - 8 * 2) >= 1 && stateMap[x2 - 8 * 2] % 2 == x3) ada_main_cl();
                }
                else if ((x2 - 8 * 1) >= 1 && stateMap[x2 - 8 * 1] % 2 == x3) ada_main_cl();
            }
            if (x2 % 8 != 1)
            {
                if ((x2 - 1 * 1) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 1] == 0)
                {
                    ada_main_cl();
                    if ((x2 - 1 * 2) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 2] == 0)
                    {
                        ada_main_cl();
                        if ((x2 - 1 * 3) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 3] == 0)
                        {
                            ada_main_cl();
                            if ((x2 - 1 * 4) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 4] == 0)
                            {
                                ada_main_cl();
                                if ((x2 - 1 * 5) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 5] == 0)
                                {
                                    ada_main_cl();
                                    if ((x2 - 1 * 6) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 6] == 0)
                                    {
                                        ada_main_cl();
                                        if ((x2 - 1 * 7) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 7] % 2 == x3) ada_main_cl();
                                    }
                                    else if ((x2 - 1 * 6) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 6] % 2 == x3) ada_main_cl();
                                }
                                else if ((x2 - 1 * 5) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 5] % 2 == x3) ada_main_cl();
                            }
                            else if ((x2 - 1 * 4) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 4] % 2 == x3) ada_main_cl();
                        }
                        else if ((x2 - 1 * 3) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 3] % 2 == x3) ada_main_cl();
                    }
                    else if ((x2 - 1 * 2) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 2] % 2 == x3) ada_main_cl();
                }
                else if ((x2 - 1 * 1) >= ((8 * (f)) + 1) && stateMap[x2 - 1 * 1] % 2 == x3) ada_main_cl();
            }
        }
        public void Knight_move_checker()
        {
            if ((x2 + 8 - 2) >= f && (x2 + 8 - 2) <= 64 && stateMap[x2 + 8 - 2] % 2 == x3) ada_main_cl();
            else if ((x2 + 8 - 2) >= f && (x2 + 8 - 2) <= 64 && stateMap[x2 + 8 - 2] == 0) ada_main_cl();
            else if ((x2 + 16 - 1) >= f + 8 && (x2 + 16 - 1) <= 64 && stateMap[x2 + 16 - 1] % 2 == x3) ada_main_cl();
            else if ((x2 + 16 - 1) >= f + 8 && (x2 + 16 - 1) <= 64 && stateMap[x2 + 16 - 1] == 0) ada_main_cl();
            else if ((x2 + 16 + 1) >= f + 8 && (x2 + 16 + 1) <= 64 && stateMap[x2 + 16 + 1] % 2 == x3) ada_main_cl();
            else if ((x2 + 16 + 1) >= f + 8 && (x2 + 16 + 1) <= 64 && stateMap[x2 + 16 + 1] == 0) ada_main_cl();
            else if ((x2 + 8 + 2) >= f && (x2 + 8 + 2) <= 64 && stateMap[x2 + 8 + 2] % 2 == x3) ada_main_cl();
            else if ((x2 + 8 + 2) >= f && (x2 + 8 + 2) <= 64 && stateMap[x2 + 8 + 2] == 0) ada_main_cl();
            else if ((x2 - 8 + 2) <= f - 8 && (x2 - 8 + 2) >= 1 && stateMap[x2 - 8 + 2] % 2 == x3) ada_main_cl();
            else if ((x2 - 8 + 2) <= f - 8 && (x2 - 8 + 2) >= 1 && stateMap[x2 - 8 + 2] == 0) ada_main_cl();
            else if ((x2 - 16 + 1) <= f - 16 && (x2 - 16 + 1) >= 1 && stateMap[x2 - 16 + 1] % 2 == x3) ada_main_cl();
            else if ((x2 - 16 + 1) <= f - 16 && (x2 - 16 + 1) >= 1 && stateMap[x2 - 16 + 1] == 0) ada_main_cl();
            else if ((x2 - 16 - 1) <= f - 16 && (x2 - 16 - 1) >= 1 && stateMap[x2 - 16 - 1] % 2 == x3) ada_main_cl();
            else if ((x2 - 16 - 1) <= f - 16 && (x2 - 16 - 1) >= 1 && stateMap[x2 - 16 - 1] == 0) ada_main_cl();
            else if ((x2 - 8 - 2) <= f - 8 && (x2 - 8 - 2) >= 1 && stateMap[x2 - 8 - 2] % 2 == x3) ada_main_cl();
            else if ((x2 - 8 - 2) <= f - 8 && (x2 - 8 - 2) >= 1 && stateMap[x2 - 8 - 2] == 0) ada_main_cl();
        }
        public void Bishop_move_checker()
        {
            if ((x2 + (8 * 1) - 1) >= f && (x2 + (8 * 1) - 1) <= 64 && stateMap[x2 + (8 * 1) - 1] == 0)
            {
                ada_main_cl();
                if ((x2 + (8 * 2) - 2) >= f && (x2 + (8 * 2) - 2) <= 64 && stateMap[x2 + (8 * 2) - 2] == 0)
                {
                    ada_main_cl();
                    if ((x2 + (8 * 3) - 3) >= f && (x2 + (8 * 3) - 3) <= 64 && stateMap[x2 + (8 * 3) - 3] == 0)
                    {
                        ada_main_cl();
                        if ((x2 + (8 * 4) - 4) >= f && (x2 + (8 * 4) - 4) <= 64 && stateMap[x2 + (8 * 4) - 4] == 0)
                        {
                            ada_main_cl();
                            if ((x2 + (8 * 5) - 5) >= f && (x2 + (8 * 5) - 5) <= 64 && stateMap[x2 + (8 * 5) - 5] == 0)
                            {
                                ada_main_cl();
                                if ((x2 + (8 * 6) - 6) >= f && (x2 + (8 * 6) - 6) <= 64 && stateMap[x2 + (8 * 6) - 6] == 0)
                                {
                                    ada_main_cl();
                                    if ((x2 + (8 * 7) - 7) >= f && (x2 + (8 * 7) - 7) <= 64 && stateMap[x2 + (8 * 7) - 7] % 2 == x3) ada_main_cl();
                                }
                                else if ((x2 + (8 * 6) - 6) >= f && (x2 + (8 * 6) - 6) <= 64 && stateMap[x2 + (8 * 6) - 6] % 2 == x3) ada_main_cl();
                            }
                            else if ((x2 + (8 * 5) - 5) >= f && (x2 + (8 * 5) - 5) <= 64 && stateMap[x2 + (8 * 5) - 5] % 2 == x3) ada_main_cl();
                        }
                        else if ((x2 + (8 * 4) - 4) >= f && (x2 + (8 * 4) - 4) <= 64 && stateMap[x2 + (8 * 4) - 4] % 2 == x3) ada_main_cl();
                    }
                    else if ((x2 + (8 * 3) - 3) >= f && (x2 + (8 * 3) - 3) <= 64 && stateMap[x2 + (8 * 3) - 3] % 2 == x3) ada_main_cl();
                }
                else if ((x2 + (8 * 2) - 2) >= f && (x2 + (8 * 2) - 2) <= 64 && stateMap[x2 + (8 * 2) - 2] % 2 == x3) ada_main_cl();
            }
            else if ((x2 + (8 * 1) - 1) >= f && (x2 + (8 * 1) - 1) <= 64 && stateMap[x2 + (8 * 1) - 1] % 2 == x3) ada_main_cl();
            if ((x2 + (8 * 1) + 1) >= f && (x2 + (8 * 1) + 1) <= 64 && stateMap[x2 + (8 * 1) + 1] == 0)
            {
                ada_main_cl();
                if ((x2 + (8 * 2) + 2) >= f && (x2 + (8 * 2) + 2) <= 64 && stateMap[x2 + (8 * 2) + 2] == 0)
                {
                    ada_main_cl();
                    if ((x2 + (8 * 3) + 3) >= f && (x2 + (8 * 3) + 3) <= 64 && stateMap[x2 + (8 * 3) + 3] == 0)
                    {
                        ada_main_cl();
                        if ((x2 + (8 * 4) + 4) >= f && (x2 + (8 * 4) + 4) <= 64 && stateMap[x2 + (8 * 4) + 4] == 0)
                        {
                            ada_main_cl();
                            if ((x2 + (8 * 5) + 5) >= f && (x2 + (8 * 5) + 5) <= 64 && stateMap[x2 + (8 * 5) + 5] == 0)
                            {
                                ada_main_cl();
                                if ((x2 + (8 * 6) + 6) >= f && (x2 + (8 * 6) + 6) <= 64 && stateMap[x2 + (8 * 6) + 6] == 0)
                                {
                                    ada_main_cl();
                                    if ((x2 + (8 * 7) + 7) >= f && (x2 + (8 * 7) + 7) <= 64 && stateMap[x2 + (8 * 7) + 7] % 2 == x3) ada_main_cl();
                                }
                                else if ((x2 + (8 * 6) + 6) >= f && (x2 + (8 * 6) + 6) <= 64 && stateMap[x2 + (8 * 6) + 6] % 2 == x3) ada_main_cl();
                            }
                            else if ((x2 + (8 * 5) + 5) >= f && (x2 + (8 * 5) + 5) <= 64 && stateMap[x2 + (8 * 5) + 5] % 2 == x3) ada_main_cl();
                        }
                        else if ((x2 + (8 * 4) + 4) >= f && (x2 + (8 * 4) + 4) <= 64 && stateMap[x2 + (8 * 4) + 4] % 2 == x3) ada_main_cl();
                    }
                    else if ((x2 + (8 * 3) + 3) >= f && (x2 + (8 * 3) + 3) <= 64 && stateMap[x2 + (8 * 3) + 3] % 2 == x3) ada_main_cl();
                }
                else if ((x2 + (8 * 2) + 2) >= f && (x2 + (8 * 2) + 2) <= 64 && stateMap[x2 + (8 * 2) + 2] % 2 == x3) ada_main_cl();
            }
            else if ((x2 + (8 * 1) + 1) >= f && (x2 + (8 * 1) + 1) <= 64 && stateMap[x2 + (8 * 1) + 1] % 2 == x3) ada_main_cl();
            if ((x2 - (8 * 1) - 1) <= f && (x2 - (8 * 1) - 1) >= 1 && stateMap[x2 - (8 * 1) - 1] == 0)
            {
                ada_main_cl();
                if ((x2 - (8 * 2) - 2) <= f && (x2 - (8 * 2) - 2) >= 1 && stateMap[x2 - (8 * 2) - 2] == 0)
                {
                    ada_main_cl();
                    if ((x2 - (8 * 3) - 3) <= f && (x2 - (8 * 3) - 3) >= 1 && stateMap[x2 - (8 * 3) - 3] == 0)
                    {
                        ada_main_cl();
                        if ((x2 - (8 * 4) - 4) <= f && (x2 - (8 * 4) - 4) >= 1 && stateMap[x2 - (8 * 4) - 4] == 0)
                        {
                            ada_main_cl();
                            if ((x2 - (8 * 5) - 5) <= f && (x2 - (8 * 5) - 5) >= 1 && stateMap[x2 - (8 * 5) - 5] == 0)
                            {
                                ada_main_cl();
                                if ((x2 - (8 * 6) - 6) <= f && (x2 - (8 * 6) - 6) >= 1 && stateMap[x2 - (8 * 6) - 6] == 0)
                                {
                                    ada_main_cl();
                                    if ((x2 - (8 * 7) - 7) <= f && (x2 - (8 * 7) - 7) >= 1 && stateMap[x2 - (8 * 7) - 7] % 2 == x3) ada_main_cl();
                                }
                                else if ((x2 - (8 * 6) - 6) <= f && (x2 - (8 * 6) - 6) >= 1 && stateMap[x2 - (8 * 6) - 6] % 2 == x3) ada_main_cl();
                            }
                            else if ((x2 - (8 * 5) - 5) <= f && (x2 - (8 * 5) - 5) >= 1 && stateMap[x2 - (8 * 5) - 5] % 2 == x3) ada_main_cl();
                        }
                        else if ((x2 - (8 * 4) - 4) <= f && (x2 - (8 * 4) - 4) >= 1 && stateMap[x2 - (8 * 4) - 4] % 2 == x3) ada_main_cl();
                    }
                    else if ((x2 - (8 * 3) - 3) <= f && (x2 - (8 * 3) - 3) >= 1 && stateMap[x2 - (8 * 3) - 3] % 2 == x3) ada_main_cl();
                }
                else if ((x2 - (8 * 2) - 2) <= f && (x2 - (8 * 2) - 2) >= 1 && stateMap[x2 - (8 * 2) - 2] % 2 == x3) ada_main_cl();
            }
            else if ((x2 - (8 * 1) - 1) <= f && (x2 - (8 * 1) - 1) >= 1 && stateMap[x2 - (8 * 1) - 1] % 2 == x3) ada_main_cl();
            if ((x2 - (8 * 1) + 1) <= f && (x2 - (8 * 1) + 1) >= 1 && stateMap[x2 - (8 * 1) + 1] == 0)
            {
                ada_main_cl();
                if ((x2 - (8 * 2) + 2) <= f && (x2 - (8 * 2) + 2) >= 1 && stateMap[x2 - (8 * 2) + 2] == 0)
                {
                    ada_main_cl();
                    if ((x2 - (8 * 3) + 3) <= f && (x2 - (8 * 3) + 3) >= 1 && stateMap[x2 - (8 * 3) + 3] == 0)
                    {
                        ada_main_cl();
                        if ((x2 - (8 * 4) + 4) <= f && (x2 - (8 * 4) + 4) >= 1 && stateMap[x2 - (8 * 4) + 4] == 0)
                        {
                            ada_main_cl();
                            if ((x2 - (8 * 5) + 5) <= f && (x2 - (8 * 5) + 5) >= 1 && stateMap[x2 - (8 * 5) + 5] == 0)
                            {
                                ada_main_cl();
                                if ((x2 - (8 * 6) + 6) <= f && (x2 - (8 * 6) + 6) >= 1 && stateMap[x2 - (8 * 6) + 6] == 0)
                                {
                                    ada_main_cl();
                                    if ((x2 - (8 * 7) + 7) <= f && (x2 - (8 * 7) + 7) >= 1 && stateMap[x2 - (8 * 7) + 7] % 2 == x3) ada_main_cl();
                                }
                                else if ((x2 - (8 * 6) + 6) <= f && (x2 - (8 * 6) + 6) >= 1 && stateMap[x2 - (8 * 6) + 6] % 2 == x3) ada_main_cl();
                            }
                            else if ((x2 - (8 * 5) + 5) <= f && (x2 - (8 * 5) + 5) >= 1 && stateMap[x2 - (8 * 5) + 5] % 2 == x3) ada_main_cl();
                        }
                        else if ((x2 - (8 * 4) + 4) <= f && (x2 - (8 * 4) + 4) >= 1 && stateMap[x2 - (8 * 4) + 4] % 2 == x3) ada_main_cl();
                    }
                    else if ((x2 - (8 * 3) + 3) <= f && (x2 - (8 * 3) + 3) >= 1 && stateMap[x2 - (8 * 3) + 3] % 2 == x3) ada_main_cl();
                }
                else if ((x2 - (8 * 2) + 2) <= f && (x2 - (8 * 2) + 2) >= 1 && stateMap[x2 - (8 * 2) + 2] % 2 == x3) ada_main_cl();
            }
            else if ((x2 - (8 * 1) + 1) <= f && (x2 - (8 * 1) + 1) >= 1 && stateMap[x2 - (8 * 1) + 1] % 2 == x3) ada_main_cl();
        }
        int o, q, l;
        public void move_checker()
        {
            q = 0;
            o = 0;
            for (int i = 1; i <= 64; i++)
            {
                if (stateMap[i] == 10)
                {
                    left_cl();
                    if ((i + 9) <= 64)
                    {
                        if (i >= 9 && i <= 16)
                        {
                            if (stateMap[(i + 8)] == 0)
                            {
                                o++;
                                if ((stateMap[(i + 16)] == 0) && (cb == (i + 16))) o++;
                            }
                            if ((stateMap[(i + 9)] % 2 == 1) && (i + 9) <= (f + 8)) o++;
                            if ((stateMap[(i + 7)] % 2 == 1) && (i + 7) > f) o++;
                        }
                        if (stateMap[(i + 8)] == 0 && cb == (i + 8)) o++;
                        if ((stateMap[(i + 9)] % 2 == 1) && (i + 9) <= (f + 8)) o++;
                        if ((stateMap[(i + 7)] % 2 == 1) && (i + 7) > f) o++;
                    }
                }
                if (stateMap[i] == 11)
                {
                    left_cl();
                    if ((i - 9) >= 1)
                    {
                        if (i >= 49 && i <= 56)
                        {
                            if (stateMap[(i - 8)] == 0)
                            {
                                q++;
                                if ((stateMap[(i - 16)] == 0) && (cb == (i - 16))) q++;
                            }
                            if ((stateMap[(i - 9)] != 0) && (stateMap[(i - 9)] % 2 == 0) && (i - 9) > (f - 16)) q++;
                            if ((stateMap[(i - 7)] != 0) && (stateMap[(i - 7)] % 2 == 0) && (i - 7) <= (f - 8)) q++;
                        }
                        if (stateMap[(i - 8)] == 0 && cb == (i - 8)) q++;
                        if ((stateMap[(i - 9)] != 0) && (stateMap[(i - 9)] % 2 == 0) && (i - 9) > (f - 16)) q++;
                        if ((stateMap[(i - 7)] % 2 == 0) && (stateMap[(i - 7)] % 2 == 0) && (i - 7) <= (f - 8)) q++;
                    }
                }
                if (stateMap[i] == 20)
                {
                    l = 0;
                    left_cl();
                    x3 = 1;
                    x2 = i;
                    Rook_move_checker();
                }
                if (stateMap[i] == 21)
                {
                    l = 1;
                    left_cl();
                    x3 = 0;
                    x2 = i;
                    Rook_move_checker();
                }
                if (stateMap[i] == 30)
                {
                    l = 0;
                    left_cl();
                    x3 = 1;
                    x2 = i;
                    Knight_move_checker();
                }
                if (stateMap[i] == 31)
                {
                    l = 1;
                    left_cl();
                    x3 = 0;
                    x2 = i;
                    Knight_move_checker();
                }
                if (stateMap[i] == 40)
                {
                    l = 0;
                    left_cl();
                    x3 = 1;
                    x2 = i;
                    Bishop_move_checker();
                }
                if (stateMap[i] == 41)
                {
                    l = 1;
                    left_cl();
                    x3 = 0;
                    x2 = i;
                    Bishop_move_checker();
                }
                if (stateMap[i] == 50)
                {
                    l = 0;
                    left_cl();
                    x3 = 1;
                    x2 = i;
                    Rook_move_checker();
                    Bishop_move_checker();
                }
                if (stateMap[i] == 51)
                {
                    l = 1;
                    left_cl();
                    x3 = 0;
                    x2 = i;
                    Rook_move_checker();
                    Bishop_move_checker();
                }
                if (stateMap[i] == 60)
                {
                    l = 0;
                    left_cl();
                    x3 = 1;
                    x2 = i;
                    King_move_ckecker();
                }
                if (stateMap[i] == 61)
                {
                    l = 1;
                    left_cl();
                    x3 = 0;
                    x2 = i;
                    King_move_ckecker();
                }
            }
            if (o == 0)
            {
                final.Content = "draw";
                s = 0;
            }
            if (q == 0)
            {
                final.Content = "draw";
                s = 0;
            }
        }
        public void King_move_ckecker()
        {
            King_move_check_cl();
            left_cl();
            if (x1 == (x2 - 1) && (x2 - 1) >= 1 && stateMap[x2 - 1] == 0 && (x2 - 1) > f - 8 && k == 0 && g == 0) ada_main_cl();
            else if (x1 == (x2 - 1) && (x2 - 1) >= 1 && stateMap[x2 - 1] % 2 == x3 && (x2 - 1) > f - 8 && k == 0 && g == 0) ada_main_cl();
            else if (x1 == (x2 + 7) && (x2 + 7) <= 64 && stateMap[x2 + 7] == 0 && (x2 + 7) > f && k == 0 && g == 0) ada_main_cl();
            else if (x1 == (x2 + 7) && (x2 + 7) <= 64 && stateMap[x2 + 7] % 2 == x3 && (x2 + 7) > f && k == 0 && g == 0) ada_main_cl();
            else if (x1 == (x2 + 8) && (x2 + 8) <= 64 && stateMap[x2 + 8] == 0 && (x2 + 8) > f && k == 0 && g == 0) ada_main_cl();
            else if (x1 == (x2 + 8) && (x2 + 8) <= 64 && stateMap[x2 + 8] % 2 == x3 && (x2 + 8) > f && k == 0 && g == 0) ada_main_cl();
            else if (x1 == (x2 + 9) && (x2 + 9) <= 64 && stateMap[x2 + 9] == 0 && (x2 + 9) <= f + 8 && k == 0 && g == 0) ada_main_cl();
            else if (x1 == (x2 + 9) && (x2 + 9) <= 64 && stateMap[x2 + 9] % 2 == x3 && (x2 + 9) <= f + 8 && k == 0 && g == 0) ada_main_cl();
            else if (x1 == (x2 + 1) && (x2 + 1) <= 64 && stateMap[x2 + 1] == 0 && (x2 + 1) <= f && k == 0 && g == 0) ada_main_cl();
            else if (x1 == (x2 + 1) && (x2 + 1) <= 64 && stateMap[x2 + 1] % 2 == x3 && (x2 + 1) <= f && k == 0 && g == 0) ada_main_cl();
            else if (x1 == (x2 - 7) && (x2 - 7) >= 1 && stateMap[x2 - 7] == 0 && (x2 - 7) <= f - 8 && k == 0 && g == 0) ada_main_cl();
            else if (x1 == (x2 - 7) && (x2 - 7) >= 1 && stateMap[x2 - 7] % 2 == x3 && (x2 - 7) <= f - 8 && k == 0 && g == 0) ada_main_cl();
            else if (x1 == (x2 - 8) && (x2 - 8) >= 1 && stateMap[x2 - 8] == 0 && (x2 - 8) <= f - 8 && k == 0 && g == 0) ada_main_cl();
            else if (x1 == (x2 - 8) && (x2 - 8) >= 1 && stateMap[x2 - 8] % 2 == x3 && (x2 - 8) <= f - 8 && k == 0 && g == 0) ada_main_cl();
            else if (x1 == (x2 - 9) && (x2 - 9) >= 1 && stateMap[x2 - 9] == 0 && (x2 - 9) > f - 16 && k == 0 && g == 0) ada_main_cl();
            else if (x1 == (x2 - 9) && (x2 - 9) >= 1 && stateMap[x2 - 9] % 2 == x3 && (x2 - 9) > f - 16 && k == 0 && g == 0) ada_main_cl();
            k = 0;
            g = 0;
        }
    }
}
//written by Saeed Solymany => Saeed Paya
