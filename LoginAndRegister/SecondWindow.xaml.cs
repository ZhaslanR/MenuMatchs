﻿using System;
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

namespace LoginAndRegister
{
    /// <summary>
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
            Person person = new Person();
            person.Name = nameBox.Text;
            person.Surname = surnameBox.Text;
            person.Country = countryBox.Text;
            person.City = cityBox.Text;
            person.DateOfBirth = dateOfBirthBox.Text;
            person.Login = loginRegisterBox.Text;
            person.Password = passwordRegisterBox.Text;
        }

        private void signUp_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
