using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Threading.Tasks;

namespace WpfApp5
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        string str1 = "";
        Queue<string> str = new Queue<string>();
        public MainWindow()
        {
            InitializeComponent();

        }
        public void openwin(object sender)
        {
            Button btn = (Button)sender;
            string i1 = "a" + (int.Parse(btn.Tag.ToString()) - 1);
            string u1 = "a" + (int.Parse(btn.Tag.ToString()) - 5);
            string e1 = "a" + (int.Parse(btn.Tag.ToString()) + 1);
            string o1 = "a" + (int.Parse(btn.Tag.ToString()) + 5);
            System.Console.WriteLine(btn.Tag.ToString());
            System.Console.WriteLine(i1);

            Button btn1 = FindName(i1) as Button;
            Button btn2 = FindName(u1) as Button;
            Button btn3 = FindName(e1) as Button;
            Button btn4 = FindName(o1) as Button;

            string[,] src = { 
                { "あ", "い", "う", "え", "お" }, 
                { "か", "き", "く", "け", "こ" }, 
                { "さ", "し", "す", "せ", "そ" }, 
                { "た", "ち", "つ", "て", "と" }, 
                { "な", "に", "ぬ", "ね", "の" }, 
                { "は", "ひ", "ふ", "へ", "ほ" }, 
                { "ま", "み", "む", "め", "も" }, 
                { "や", " ", "ゆ", " ", "よ" }, 
                { "ら", "り", "る", "れ", "ろ" },
            };


            int row = 0;
            if (btn.Tag.ToString() == "7")
            {
               
                row = 0;
            }
            if (btn.Tag.ToString() == "8")
            {
              
                row = 1;
            }
            if (btn.Tag.ToString() == "9")
            {
                
                row = 2;
            }
            if (btn.Tag.ToString() == "12")
            {
                row = 3;
            }
            if (btn.Tag.ToString() == "13")
            {
                row = 4;
            }
            if (btn.Tag.ToString() == "14")
            {
                row = 5;
            }
            if (btn.Tag.ToString() == "17")
            {
                row = 6;
            }
            if (btn.Tag.ToString() == "18")
            {
                row = 7;
            }
            if (btn.Tag.ToString() == "19")
            {
                row = 8;
            }



            btn.Content = src[row, 0];
            btn1.Content = src[row,1];
            btn2.Content = src[row, 2]; 
            btn3.Content = src[row, 3]; 
            btn4.Content = src[row, 4]; 

            btn1.Visibility = Visibility.Visible;
            btn2.Visibility = Visibility.Visible;
            btn3.Visibility = Visibility.Visible;
            btn4.Visibility = Visibility.Visible;
        }
      
        public void closewin(object sender)
        {
            Button btn = (Button)sender;
            string i1 = "a" + (int.Parse(btn.Tag.ToString()) - 1);
            string u1 = "a" + (int.Parse(btn.Tag.ToString()) - 5);
            string e1 = "a" + (int.Parse(btn.Tag.ToString()) + 1);
            string o1 = "a" + (int.Parse(btn.Tag.ToString()) + 5);
            System.Console.WriteLine(btn.Tag.ToString());
            System.Console.WriteLine(i1);
//buttonを探す
            Button btn1 = FindName(i1) as Button;
            Button btn2 = FindName(u1) as Button;
            Button btn3 = FindName(e1) as Button;
            Button btn4 = FindName(o1) as Button;
            if(btn1!=null)
                btn1.Visibility = Visibility.Hidden;
            if (btn2 != null)
                btn2.Visibility = Visibility.Hidden;
            if (btn3 != null)
                btn3.Visibility = Visibility.Hidden;
            if (btn4 != null)
                btn4.Visibility = Visibility.Hidden;
            a7.Visibility = Visibility.Visible;
            a8.Visibility = Visibility.Visible;
            a9.Visibility = Visibility.Visible;
            a12.Visibility = Visibility.Visible;
            a13.Visibility = Visibility.Visible;
            a14.Visibility = Visibility.Visible;
            a17.Visibility = Visibility.Visible;
            a18.Visibility = Visibility.Visible;
            a19.Visibility = Visibility.Visible;

            a1.Visibility = Visibility.Hidden;
            a2.Visibility = Visibility.Hidden;
            a3.Visibility = Visibility.Hidden;
            a4.Visibility = Visibility.Hidden;
            a5.Visibility = Visibility.Hidden;
            a6.Visibility = Visibility.Hidden;
            a10.Visibility = Visibility.Hidden;
            a11.Visibility = Visibility.Hidden;
            a15.Visibility = Visibility.Hidden;
            a16.Visibility = Visibility.Hidden;
            a20.Visibility = Visibility.Hidden;
            a21.Visibility = Visibility.Hidden;
            a22.Visibility = Visibility.Hidden;
            a23.Visibility = Visibility.Hidden;
            a24.Visibility = Visibility.Hidden;
            a25.Visibility = Visibility.Hidden;
            a7.Content = "あ";
            a8.Content = "か";
            a9.Content = "さ";
            a12.Content = "た";
            a13.Content = "な";
            a14.Content = "は";
            a17.Content = "ま";
            a18.Content = "や";
            a19.Content = "ら";
        }


        private void MouseDownあ(object sender, MouseEventArgs e)
        {
            openwin(sender);
            //closewin(sender);
            Button btn = (Button)sender;
            string i1 = "a" + (int.Parse(btn.Tag.ToString()) - 1);
            string u1 = "a" + (int.Parse(btn.Tag.ToString()) - 5);
            string e1 = "a" + (int.Parse(btn.Tag.ToString()) +1);
            string o1 = "a" + (int.Parse(btn.Tag.ToString()) +5);
            System.Console.WriteLine(btn.Tag.ToString());
            System.Console.WriteLine(i1);
            Button btn1 =  FindName(i1) as Button; 
            Button btn2 = FindName(u1) as Button;
            Button btn3 = FindName(e1) as Button;
            Button btn4 = FindName(o1) as Button;
            Button btn5 = new Button();
            //btn5.Name= "a" + (int.Parse(btn.Tag.ToString()) - 1);
           
            //btn1.Visibility = Visibility.Hidden;
            //btn2.Visibility = Visibility.Hidden;
            //btn3.Visibility = Visibility.Hidden;
            //btn4.Visibility = Visibility.Hidden;
            //// btn5.Visibility = Visibility.Hidden;
            //a7.Visibility = Visibility.Visible;
            //a8.Visibility = Visibility.Visible;
            //a9.Visibility = Visibility.Visible;
            //a12.Visibility = Visibility.Visible;
            //a13.Visibility = Visibility.Visible;
            //a14.Visibility = Visibility.Visible;
            //a17.Visibility = Visibility.Visible;
            //a18.Visibility = Visibility.Visible;
            //a19.Visibility = Visibility.Visible;
        }
        private void MouseUpあ(object sender, MouseEventArgs e)
        {
            
            MessageBox.Show("あ");
            //い.Visibility = Visibility.Hidden;
            //う.Visibility = Visibility.Hidden;
            //え.Visibility = Visibility.Hidden;
            //お.Visibility = Visibility.Hidden;
            //か.Visibility = Visibility.Visible;
        }
        private void MouseUpい(object sender, MouseEventArgs e)
        {
            MessageBox.Show("い");
            //い.Visibility = Visibility.Hidden;
            //う.Visibility = Visibility.Hidden;
            //え.Visibility = Visibility.Hidden;
            //お.Visibility = Visibility.Hidden;
            //か.Visibility = Visibility.Visible;
        }
        private void MouseUpう(object sender, MouseEventArgs e)
        {
            MessageBox.Show("う");
            //い.Visibility = Visibility.Hidden;
            //う.Visibility = Visibility.Hidden;
            //え.Visibility = Visibility.Hidden;
            //お.Visibility = Visibility.Hidden;
            //か.Visibility = Visibility.Visible;
        }
        private void MouseUpえ(object sender, MouseEventArgs e)
        {
            MessageBox.Show("え");
            //い.Visibility = Visibility.Hidden;
            //う.Visibility = Visibility.Hidden;
            //え.Visibility = Visibility.Hidden;
            //お.Visibility = Visibility.Hidden;
            //か.Visibility = Visibility.Visible;
        }
        private void MouseUpお(object sender, MouseEventArgs e)
        {
            MessageBox.Show("お");
            //い.Visibility = Visibility.Hidden;
            //う.Visibility = Visibility.Hidden;
            //え.Visibility = Visibility.Hidden;
            //お.Visibility = Visibility.Hidden;
            //か.Visibility = Visibility.Visible;
        }
        private void MouseDownか(object sender, MouseEventArgs e)
        {
            //き.Visibility = Visibility.Visible;
            //く.Visibility = Visibility.Visible;
            //け.Visibility = Visibility.Visible;
            //こ.Visibility = Visibility.Visible;
            //あ.Visibility = Visibility.Hidden;
        }
        private void MouseUpか(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("か");
            //き.Visibility = Visibility.Hidden;
            //く.Visibility = Visibility.Hidden;
            //け.Visibility = Visibility.Hidden;
            //こ.Visibility = Visibility.Hidden;
            //あ.Visibility = Visibility.Visible;
        }
        private void MouseUpき(object sender, MouseEventArgs e)
        {
            MessageBox.Show("き");
            //き.Visibility = Visibility.Hidden;
            //く.Visibility = Visibility.Hidden;
            //け.Visibility = Visibility.Hidden;
            //こ.Visibility = Visibility.Hidden;
            //あ.Visibility = Visibility.Visible;
        }
        private void MouseUpく(object sender, MouseEventArgs e)
        {
            MessageBox.Show("く");
            //き.Visibility = Visibility.Hidden;
            //く.Visibility = Visibility.Hidden;
            //け.Visibility = Visibility.Hidden;
            //こ.Visibility = Visibility.Hidden;
            //あ.Visibility = Visibility.Visible;
        }
        private void MouseUpけ(object sender, MouseEventArgs e)
        {
            MessageBox.Show("け");
            //き.Visibility = Visibility.Hidden;
            //く.Visibility = Visibility.Hidden;
            //け.Visibility = Visibility.Hidden;
            //こ.Visibility = Visibility.Hidden;
            //あ.Visibility = Visibility.Visible;
        }
        private void MouseUpこ(object sender, MouseEventArgs e)
        {
            MessageBox.Show("こ");
            //き.Visibility = Visibility.Hidden;
            //く.Visibility = Visibility.Hidden;
            //け.Visibility = Visibility.Hidden;
            //こ.Visibility = Visibility.Hidden;
            //あ.Visibility = Visibility.Visible;
        }
        int i = 7,count=0;
            private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
            {
            //現在地を取得
            Double leftPosition = Canvas.GetLeft(this.pointer);
            Double topPosition = Canvas.GetTop(this.pointer);
             

            //入力された方向キーの方向へ移動
                if (e.Key == Key.Up)
            {
                Canvas.SetTop(this.pointer, topPosition - 100);
                //Canvas.SetTop(this.a6, Canvas.GetLeft(this.a6) - 50);
                //Canvas.SetTop(this.a6, Canvas.GetLeft(this.a6) - 50);
                i -= 5;

            }
            else if (e.Key == Key.Down)
            {
                Canvas.SetTop(this.pointer, topPosition + 100);
                i +=5 ;
            }
            else if (e.Key == Key.Left)
            {
                Canvas.SetLeft(this.pointer, leftPosition - 100);
                i -= 1;
            }
            else if (e.Key == Key.Right)
            {
                Canvas.SetLeft(this.pointer, leftPosition + 100);
                i += 1;
            }
            
            if (e.Key == Key.Enter&&count==0)
            {
                Button btn1 = FindName("a" + (i - 1)) as Button;
                Button btn2 = FindName("a" + (i - 5)) as Button;
                Button btn3 = FindName("a" + (i + 1)) as Button;
                Button btn4 = FindName("a" + (i + 5)) as Button;
                if (btn1.Visibility == Visibility.Hidden | btn2.Visibility == Visibility.Hidden | btn3.Visibility == Visibility.Hidden | btn4.Visibility == Visibility.Hidden)
                {

                }
                Button btn6 = FindName("a" + i) as Button;
                System.Console.WriteLine(btn6.Content.ToString() + "open");
                openwin(btn6);
                count = 1;

            }
            else if (e.Key == Key.Enter && count == 1)
            {
                Button btn1 = FindName("a" + (i - 1)) as Button;
                Button btn2 = FindName("a" + (i - 5)) as Button;
                Button btn3 = FindName("a" + (i + 1)) as Button;
                Button btn4 = FindName("a" + (i + 5)) as Button;
                //if (btn1.Visibility == Visibility.Hidden | btn2.Visibility == Visibility.Hidden | btn3.Visibility == Visibility.Hidden | btn4.Visibility == Visibility.Hidden)
                //{

                //}
                Button btn6 = FindName("a" + i) as Button;
                MessageBox.Show(btn6.Content.ToString());
                System.Console.WriteLine(btn6.Content.ToString() + "close");
                str.Enqueue(btn6.Content.ToString());
                
                str1=str1 + btn6.Content.ToString();
                b.Text = str1;
                count = 0;
                closewin(btn6);
            }

            //        //////////////////////////////////////////////////////////////////////////

            //        if (e.Key == Key.Enter && き.Visibility == Visibility.Hidden)
            //        {

            //        }
            //        if (e.Key == Key.Enter && き.Visibility == Visibility.Hidden)
            //        {
            //            if (topPosition == 95)
            //            {
            //                if (leftPosition == 95)
            //                {
            //                    い.Visibility = Visibility.Visible;
            //                    う.Visibility = Visibility.Visible;
            //                    か.Content = "え";
            //                    た.Content = "お";


            //                }
            //            }
            //        }
            //        if (e.Key == Key.Enter && い.Visibility == Visibility.Hidden)
            //        {
            //            if (topPosition == 95)
            //            {
            //                if (leftPosition == 195)
            //                {
            //                    き.Visibility = Visibility.Visible;
            //                    く.Visibility = Visibility.Visible;
            //                    け.Visibility = Visibility.Visible;
            //                    こ.Visibility = Visibility.Visible;
            //                    あ.Visibility = Visibility.Hidden;



            //                }
            //            }
            //        }
            //        if (い.Visibility == Visibility.Visible)
            //        {
            //            if (topPosition == 95)
            //            {
            //                if (leftPosition == -5)
            //                {
            //                    if (e.Key == Key.Enter)
            //                    {
            //                        MessageBox.Show("い");
            //                        い.Visibility = Visibility.Hidden;
            //                        う.Visibility = Visibility.Hidden;
            //                        え.Visibility = Visibility.Hidden;
            //                        か.Content = "か";
            //                        た.Content = "た";
            //                    }
            //                }
            //            }
            //        }
            //        if (え.Visibility == Visibility.Visible)
            //        {
            //            if (topPosition == 95)
            //            {
            //                if (leftPosition == 195)
            //                {
            //                    if (e.Key == Key.Enter)
            //                    {
            //                        MessageBox.Show("え");
            //                        い.Visibility = Visibility.Hidden;
            //                        う.Visibility = Visibility.Hidden;
            //                        え.Visibility = Visibility.Hidden;
            //                        か.Content = "か";
            //                        た.Content = "た";
            //                    }
            //                }
            //            }
            //        }
            //        ////////////////////////////////////////////////////////////////////////////////

            //        if (き.Visibility == Visibility.Visible)
            //        {
            //            if (topPosition == 95)
            //            {
            //                if (leftPosition == 95)
            //                {
            //                    if (e.Key == Key.Enter)
            //                    {
            //                        MessageBox.Show("き");
            //                        き.Visibility = Visibility.Hidden;
            //                        く.Visibility = Visibility.Hidden;
            //                        け.Visibility = Visibility.Hidden;
            //                        こ.Visibility = Visibility.Hidden;
            //                        あ.Visibility = Visibility.Visible;
            //                    }
            //                }
            //            }
            //        }
        }

        private void さ_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }

}
