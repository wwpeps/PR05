using System;
using System.Collections.Generic;
using System.Windows;

namespace PR05
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] ite = new string[3] { "pelmeni", "makaroni", "ris" };
        

        public MainWindow()
        {
            InitializeComponent();
            lia.Items.Add("pelmeni");
            lia.Items.Add("makaroni");
            lia.Items.Add("ris");
            
        }

        private void bc_Click(object sender, RoutedEventArgs e)
        {
            Array.Resize(ref ite, ite.Length + 1);
            ite[ite.Length-1] = ta.Text;
            lia.Items.Add(ta.Text);
        }

        private void ba_Click(object sender, RoutedEventArgs e)
        {
            for (int i=0; i < ite.Length; i++) 
            {
                if (ite[i] == ta.Text) 
                {
                    ite[i] = tb.Text;
                    lia.Items.RemoveAt(i);
                    lia.Items.Add(tb.Text);
                }
            }
        }

        private void bb_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < ite.Length; i++)
            {
                if (ite[i] == ta.Text)
                {
                    Array.Resize(ref ite, ite.Length - 1);
                    lia.Items.RemoveAt(i);
                }
            }
        }

        private void lia_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if(lia.SelectedItem != null)
            ta.Text =  lia.SelectedItem.ToString();
        }
    }
}
