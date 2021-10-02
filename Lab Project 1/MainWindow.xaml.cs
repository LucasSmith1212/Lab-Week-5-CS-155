/// Week 5 Lab 1
/// File Name: week5lab1.cs
/// Author: Lucas Smith
/// Date:  October 2, 2021
///
/// Problem Statement: Get the speed and speed limit, then calculate whether or not the driver is speeding, speeding with penalty, or not speeding.
/// 
/// 
/// Overall Plan:
/// 1) Create boxes that allow the user to enter in the speed limit and their speed.
/// 2) If their speed is more than 5mph over the speed limit, they are speeding with penalty.
/// 3) If their speed is 5mph or less over the speed limit, they are speeding with no penalty.
/// 4) If their speed matches the speed limit, they are not speeding. If they are below the speed limit, the else statement prints.
/// 5) Prints a message box with the result, and changes the color of the button accordingly (I couldn't find the right command to change the whole background's color)
///

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

namespace Lab_Project_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick (object sender, EventArgs e)
        {
            int speed = Convert.ToInt32(Speed.Text);
            int speedLimit = Convert.ToInt32(SpeedLimit.Text);
            int topLegalSpeed = speedLimit + 5;

            if (speed == speedLimit)
            {
                GetInfo.Background = Brushes.Green;
                MessageBox.Show("Legal Speed");
            } else if (speed <= topLegalSpeed && speed > speedLimit)
            {
                GetInfo.Background = Brushes.Yellow;
                MessageBox.Show("Speeding No Penalty");
            } else if (speed > topLegalSpeed)
            {
                GetInfo.Background = Brushes.Red;
                MessageBox.Show("Speeding With Penalty");
            } else
            {
                GetInfo.Background = Brushes.Blue;
                MessageBox.Show("You are going below the speed limit. Speed up!");
            }
        }
    }
}
