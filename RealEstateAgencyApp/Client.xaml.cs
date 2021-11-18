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

namespace RealEstateAgencyApp
{
    /// <summary>
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Window
    {
        public Client()
        {
            InitializeComponent();
            ClientGrid.ItemsSource = RealEstateAgencyEntities.GetContext().clients.ToList();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            AddClient addclient = new AddClient();
            addclient.Show();
            this.Close();
        }
    }
}
