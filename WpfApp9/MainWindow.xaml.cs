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

namespace WpfApp9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

     
            List<User> users = new List<User>
            {
                new User { LastName = "Комарова", FirstName = "Анна", MiddleName = "Николаевна", BirthDate = new DateTime(2008, 12, 23) },
                new User { LastName = "Прусакова", FirstName = "Марина", MiddleName = "Владимировна", BirthDate = new DateTime(2008, 7, 12) },
                new User { LastName = "Лепихова", FirstName = "Алиса", MiddleName = "Денисовна", BirthDate = new DateTime(2008, 2, 24) }
            };

        
            UsersList.ItemsSource = users;
        }
    }
}