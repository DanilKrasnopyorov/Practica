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
    /// Логика взаимодействия для Agent.xaml
    /// </summary>
    public partial class Agent : Window
    {
        public Agent()
        {
            InitializeComponent();
            //AgentGrid.ItemsSource = RealEstateAgencyEntities.GetContext().agents.ToList();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            AddAgent addagent = new AddAgent();
            addagent.Show();
            this.Close();
        }

        private void back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void delete(object sender, RoutedEventArgs e)
        {

        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                RealEstateAgencyEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                AgentGrid.ItemsSource = RealEstateAgencyEntities.GetContext().agents.ToList();
            }
        }
    }
}
