/*
 * Peter McEwen
 * May 22, 2019
 * Converts intigers to binary
 */
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

namespace U5_Binary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Input = 75;
        int NumberOfNumbers = 0;//how long binary number is
        
        public MainWindow()
        {
            InitializeComponent();
            int lengthChecker = 1;
            int previousChecker = 1;
            int multiplier = 1;
            int Output = 0;

            while (lengthChecker < Input)//finds length of binary number by finding smallest doubled number
            {
                previousChecker = lengthChecker;
                lengthChecker = lengthChecker * 2;
                NumberOfNumbers++;
            }

            int tempChecker = 1;
            for (int i = 0; i < NumberOfNumbers - 1; i++)
            {
                multiplier = multiplier * 10;
            }

            while (Input != 0)
            {
                if (Input >= previousChecker / tempChecker)
                {
                    Input = Input - previousChecker / tempChecker;
                    Output += multiplier;
                }
                tempChecker = tempChecker * 2;
                multiplier = multiplier / 10;
            }
            MessageBox.Show(Output.ToString());
        }
    }
}
