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

namespace First_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // DONT DELETE IT
            InitializeComponent();
        }

        private void btnDisplayFullName_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            string fullName = firstName + " " + lastName;

            txtFullName.Text = fullName;



        } // btnDisplayFullName_Click
    }
}
