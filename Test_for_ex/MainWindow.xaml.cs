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
using System.Windows.Threading;

namespace Test_for_ex
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer time = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            time.Tick += UpdateData;
            time.Start();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Human NewHuman = new Human()
            {
                id = Convert.ToInt32(txtid.Text),
                surname = txtsurname.Text,
                name = txtname.Text,
                patronymic = txtpatronymic.Text
            };
            human.Add(NewHuman);
        }
        List<Human> human = new List<Human>();
        public void UpdateData(object sender, object e)
        {
            ListV.ItemsSource = human;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int id = ((Human)ListV.SelectedItem).id;
            var DeletHuman = human.Where(x => x.id == id).First();
            human.Remove(DeletHuman);
        }
    }
    public class Human
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
    }
}
