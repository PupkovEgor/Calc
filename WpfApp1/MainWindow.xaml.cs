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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        private double sum = 0;
        private List<String> schet = new List<String>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // random
        {
            Random rnd = new Random();
            string value = Convert.ToString(rnd.Next(0, 10));
            textbox1.Text = value;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // Button "1"
        {
            textBox2.Text += 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) // Button "2"
        {
            textBox2.Text += 2;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) // Button "3"
        {
            textBox2.Text += 3;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) // Button "+"
        {
            Plus();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) // Button "="
        {
            Summa();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e) // Button "-"
        {
            Minus();
        }


        private void Button_Click_7(object sender, RoutedEventArgs e) // Button "Clean"
        {
            textBox2.Text = "";
            i = 0;
            sum = 0;
            schet.Clear();
        }


        private void Button_Click_9(object sender, RoutedEventArgs e) // Button "4"
        {
            textBox2.Text += 4;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e) // Button "5"
        {
            textBox2.Text += 5;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e) // Button "6"
        {
            textBox2.Text += 6;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e) // Button "7"
        {
            textBox2.Text += 7;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e) // Button "8"
        {
            textBox2.Text += 8;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e) // Button "9"
        {
            textBox2.Text += 9;
        }

        private void Button_Click_15(object sender, RoutedEventArgs e) // Button "0"
        {
            textBox2.Text += 0;
        }

        private void Button_Click_16(object sender, RoutedEventArgs e) // Button "*"
        {
            Multiplication();
        }

        private void Button_Click_17(object sender, RoutedEventArgs e) // Button "/"
        {
            Division();
        }

        private void Button_Click_18(object sender, RoutedEventArgs e) //"+/-"
        {
            Swich();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
   
            try
            {
                int last = textBox2.Text.LastIndexOf("");
                textBox2.Text = textBox2.Text.Remove(last, 1);
            }
            catch
            {
              
            }
            

        }

        public void Summa()
        {
            schet.Add(textBox2.Text);
            try
            {
                sum = Convert.ToDouble(schet[0]);
            }
            catch { }
            for (i = 1; i < schet.Count; i += 2)
            {
                if (schet[i] == "+")
                {
                    try
                    {
                        sum += Convert.ToDouble(schet[i + 1]);
                    }
                    catch { }
                }
                else if (schet[i] == "-")
                {
                    try
                    {
                        sum -= Convert.ToDouble(schet[i + 1]);
                    }
                    catch { }
                }
                else if (schet[i] == "*")
                {
                    try
                    {
                        sum *= Convert.ToDouble(schet[i + 1]);
                    }
                    catch { }
                }
                else if (schet[i] == "/")
                {
                    try
                    {
                        sum /= Convert.ToDouble(schet[i + 1]);
                    }
                    catch { }
                }

            }
            textBox2.Text = sum.ToString();
            schet.Clear();
        }

        public void Plus()
        {
            schet.Add(textBox2.Text);
            textBox2.Text = "";
            schet.Add("+");
        }

        public void Minus()
        {
            schet.Add(textBox2.Text);
            textBox2.Text = "";
            schet.Add("-");
        }

        public void Multiplication()
        {
            schet.Add(textBox2.Text);
            textBox2.Text = "";
            schet.Add("*");
        }

        public void Division()
        {
            schet.Add(textBox2.Text);
            textBox2.Text = "";
            schet.Add("/");
        }

        public void Swich()
        {
            int first = textBox2.Text.IndexOf("-");
            if (first == 0)
            {
                textBox2.Text = textBox2.Text.Remove(first, 1);
            }
            else
            {
                textBox2.Text = String.Concat("-", textBox2.Text);
            }
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            textBox2.Text += ",";
        }
    }
}    
