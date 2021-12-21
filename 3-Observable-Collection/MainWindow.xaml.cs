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
using _3_Observable_Collection.Model;
using System.Collections.ObjectModel;

namespace _3_Observable_Collection
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Student> Students = new ObservableCollection<Student>();

        public MainWindow()
        {
            InitializeComponent();
            InitStudents();
            StudentsList.ItemsSource = Students;
        }

        private void InitStudents()
        {
            Students.Add(new Student()
            {
                Icon = "Assets/01.png",
                FirstName = "Ruslan",
                Completion = 20
            });
            Students.Add(new Student()
            {
                Icon = "Assets/02.png",
                FirstName = "Henry",
                Completion = 80
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Form form = (Form)DataContext;

            Students.Add(new Student()
            {
                Icon = form.Icon,
                FirstName = form.FirstName,
                Completion = Convert.ToInt32(form.Completion)
            });
        }


        private void RadioButton1_Icon_Checked(object sender, RoutedEventArgs e)
        {
            Form form = (Form)DataContext;
            form.Icon = "1";
        }

        private void RadioButton2_Icon_Checked(object sender, RoutedEventArgs e)
        {
            Form form = (Form)DataContext;
            form.Icon = "2";
        }
        private void RadioButton3_Icon_Checked(object sender, RoutedEventArgs e)
        {
            Form form = (Form)DataContext;
            form.Icon = "3";
        }
    }
}
