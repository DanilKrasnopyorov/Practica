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
    /// Логика взаимодействия для AddAgent.xaml
    /// </summary>
    public partial class AddAgent : Window
    {
        private agents _currentagent = new agents();
        public AddAgent()
        {
            InitializeComponent();
            DataContext = _currentagent;
        }

        private void back(object sender, RoutedEventArgs e)
        {
            Agent agent = new Agent();
            agent.Show();
            this.Close();
        }

        private void save(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentagent.FirstName))
                errors.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_currentagent.MiddleName))
                errors.AppendLine("Укажите имя");
            if (string.IsNullOrWhiteSpace(_currentagent.LastName))
                errors.AppendLine("Укажите отчество");
            if (_currentagent.DealShare < 0 || _currentagent.DealShare > 100)
                errors.AppendLine("Укажите долю в сделке");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentagent.Id == 0)
                RealEstateAgencyEntities.GetContext().agents.Add(_currentagent);
            try
            {
                RealEstateAgencyEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Agent agent = new Agent();
                agent.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
