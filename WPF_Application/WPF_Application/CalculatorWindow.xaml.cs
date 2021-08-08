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
using System.Windows.Shapes;
using Calculator_Model;


namespace WPF_Application
{
    /// <summary>
    /// Interaction logic for CalculatorWindow.xaml
    /// </summary>
    


    public partial class CalculatorWindow : Window
    {
        private Calculator _calculator;
        public CalculatorWindow()
        {
            InitializeComponent();
            _calculator = new Calculator(); 
        }

        // SETTING NUM1 & NUM2 

        public void tbxNum1_TextChanged(object sender, TextChangedEventArgs e) 
        {
            var success = double.TryParse(tbxNum1.Text, out double num1);

            if (success)
            {
                _calculator.Num1 = num1;
            }
            else 
            {
                lblResult.Content = "Invalid Input";
            }
        }

        public void tbxNum2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var success = double.TryParse(tbxNum2.Text, out double num2);

            if (success)
            {
                _calculator.Num2 = num2;
            }
            else 
            {
                lblResult.Content = "Invalid Input";
            }
        }


        // OPERATIONS 


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = _calculator.Add();
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = _calculator.Divide();
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = _calculator.Multiply();
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = _calculator.Subtract();
        }

        private void btnMod_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = _calculator.Modulo();
        }

        private void btnRes_Click(object sender, RoutedEventArgs e)
        {

            tbxNum1.Text = $"";
            tbxNum2.Text = $"";
            lblResult.Content = $"INSERT NEW DATA";

        }
    }
}
