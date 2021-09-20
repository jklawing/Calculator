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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Permanent Members
        double number1 = 0;
        double number2 = 0;
        double result = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Number Button Click Events
        // Number 0 Button
        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                displayBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                displayBox.Text = number2.ToString();
            }
        }

        // Number 1 Button
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                displayBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                displayBox.Text = number2.ToString();
            }
        }

        // Number 2 Button
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                displayBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                displayBox.Text = number2.ToString();
            }
        }

        // Number 3 Button
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                displayBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                displayBox.Text = number2.ToString();
            }
        }

        // Number 4 Button
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                displayBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                displayBox.Text = number2.ToString();
            }
        }

        // Number 5 Button
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                displayBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                displayBox.Text = number2.ToString();
            }
        }

        // Number 6 Button
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                displayBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                displayBox.Text = number2.ToString();
            }
        }

        // Number 7 Button
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                displayBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                displayBox.Text = number2.ToString();
            }
        }

        // Number 8 Button
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                displayBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                displayBox.Text = number2.ToString();
            }
        }

        // Number 9 Button
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                displayBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                displayBox.Text = number2.ToString();
            }
        }
        #endregion

        #region Operation Button Click Events
        // Add Button
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            displayBox.Text = "+";
        }

        // Subtract Button
        private void buttonSubtract_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            displayBox.Text = "-";
        }

        // Multiply Button
        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            displayBox.Text = "*";
        }

        // Divide Button
        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            displayBox.Text = "/";
        }

        // Equals Button
        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            switch(operation)
            {
                case "+":
                    result = number1 + number2;
                    displayBox.Text = result.ToString();
                    break;
                case "-":
                    displayBox.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    displayBox.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    displayBox.Text = (number1 / number2).ToString();
                    break;
            }
        }
        #endregion

        #region Other Button Click Events
        // Clear Entry Button
        private void buttonCE_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            displayBox.Text = "0";
        }

        // Clear Button
        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            displayBox.Text = "0";
        }

        // Backspace Button
        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                displayBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                displayBox.Text = number2.ToString();
            }
        }

        // Positive/Negative Button
        private void buttonPosNeg_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                displayBox.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                displayBox.Text = number2.ToString();
            }
        }
        #endregion

    }
}
