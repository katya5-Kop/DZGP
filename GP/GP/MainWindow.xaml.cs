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

namespace GP
{
    class Pass
    {
        public string Password ()
        {
            int[] PArr = new int[15];
            Random r = new Random();
            string Passd = "";
            for (int i = 0; i < PArr.Length; i++)
            {
                PArr[i] = r.Next(5, 95);
                Passd += (char)PArr[i];
            }
            return Passd;
        }
        private void button_Click(object sender, EventArgs e)
        {
            Pass P = new Pass();
            string password1 = P.Password();
            TextBox.Text = password1;
        }

      }
    }
    class Program
    {
        static void Main()
        {

        }
    }

    
   