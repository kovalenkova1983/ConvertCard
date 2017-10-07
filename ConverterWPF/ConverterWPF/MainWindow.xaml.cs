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

namespace ConverterWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            int left = Convert.ToInt32(textBox.Text);


            string str = Convert.ToString(left, 16);           //переводит цыфры в 16-ричный код

            int len = str.Length;   // подсчет количество символов

            if (len == 6)
            {

                string str1 = str.Remove(2);   // запоминает первые 2 символа
                string str2 = str.Substring(2);  //удаляет первые 2 символа

                int decAgain = Int32.Parse(str1, System.Globalization.NumberStyles.AllowHexSpecifier);
                int decAgain2 = Int32.Parse(str2, System.Globalization.NumberStyles.AllowHexSpecifier);

                if (decAgain2 <= 99999)
                {
                    label3.Content = decAgain.ToString() + " , " + decAgain2.ToString();

                }
                else
                {
                    MessageBox.Show("Эта Карточка неподходит!!!");
                    label3.Content = "Error";
                }
            }

            if (len == 5)
            {

                string str1 = str.Remove(1);   // запоминает первые 2 символа
                string str2 = str.Substring(1);  //удаляет первые 2 символа

                int decAgain = Int32.Parse(str1, System.Globalization.NumberStyles.AllowHexSpecifier);
                int decAgain2 = Int32.Parse(str2, System.Globalization.NumberStyles.AllowHexSpecifier);

                if (decAgain2 <= 99999)
                {
                    label3.Content = decAgain.ToString() + " , " + decAgain2.ToString();

                }
                else
                {
                    MessageBox.Show("Эта Карточка неподходит!!!");
                    label3.Content = "Error";
                }
            }
           // 14551411
               else if (len >= 7 || len <= 4)
            {
                   MessageBox.Show("Эта Карточка неподходит!!!");
                   label3.Content = "Error";
               }

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            string hex = null;
            double num = 0;
            int leftOperand = Convert.ToInt32(textBox.Text);
  
                hex = Convert.ToString(leftOperand, 16);
                label2.Content = hex;

                

            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            new Help().ShowDialog();

        }
        
    }
}
