using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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

namespace WpfApp7
{

    /// <(Я не смог реализовать создание и удаление заметок. Я сделал заметки для определенных дат(с 11 по 17 февраля 2024). 
    /// Ещё почему-то после выбора заметки, при переходе на другую дату программа вылетает)>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void qwe_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime date = Convert.ToDateTime(qwe.Text);
            DateTime date1 = new DateTime(2024, 02, 11);
            DateTime date2 = new DateTime(2024, 02, 12);
            DateTime date3 = new DateTime(2024, 02, 13);
            DateTime date4 = new DateTime(2024, 02, 14);
            DateTime date5 = new DateTime(2024, 02, 15);
            DateTime date6 = new DateTime(2024, 02, 16);
            DateTime date7 = new DateTime(2024, 02, 17);
            if (date == date1)
            {

                string[] items = new string[] { "Магазин", "Поездка", "Кино" };
                Exa.ItemsSource = items;


            }
            else if (date == date2)
            {
                string[] items1 = new string[] { "Уборка", "Уборка 2" };
                Exa.ItemsSource = items1;
               
            }
            else if (date == date3)
            {
                string[] items2 = new string[] { "Учеба" };
                Exa.ItemsSource = items2;
            }
            else if (date == date4)
            {
                string[] items3 = new string[] { "МФЦ", "День Рождения" };
                Exa.ItemsSource = items3;
            }
            else if (date == date5)
            {
                string[] items4 = new string[] { "Книги", "Фильмы", "Игры" };
                Exa.ItemsSource = items4;
            }
            else if (date == date6)
            {
                string[] items5 = new string[] { "Спидран"};
                Exa.ItemsSource = items5;

            }
            else if (date == date7)
            {

                string[] items6 = new string[] { "Ресторан", "Аквапарк" };
                Exa.ItemsSource = items6;
                
            }
            else if (date != date7 || date != date1 || date != date2 || date != date3 || date != date4 || date != date5 || date != date6)
            {

                MessageBox.Show("На эту дату нет заметок");

            }
        }

        private void Exa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            


                string selected = Exa.SelectedItem.ToString();
                N.Text = selected;
                if (N.Text == "Магазин")
                {

                    O.Text = "Купить молоко, яйца";

                }
                else if (N.Text == "Поездка")
                {

                    O.Text = "Навестить друзей";

                }
                else if (N.Text == "Кино")
                {

                    O.Text = "Сходить на новый фильм";

                }
                else if (N.Text == "Уборка")
                {

                    O.Text = "Убраться в комнате";

                }
                else if (N.Text == "Уборка 2")
                {

                    O.Text = "Убраться в коридоре";

                }
                else if (N.Text == "Учеба")
                {

                    O.Text = "Сделать практическую";

                }
                else if (N.Text == "МФЦ")
                {

                    O.Text = "Подать документы";

                }
                else if (N.Text == "День Рождения")
                {

                    O.Text = "Поздравить маму";

                }
                else if (N.Text == "Книги")
                {

                    O.Text = "Почитать \"Властелин колец\"";

                }
                else if (N.Text == "Фильмы")
                {

                    O.Text = "Посмотреть \"Титаник\"";

                }
                else if (N.Text == "Игры")
                {

                    O.Text = "Начать проходить \"Киберпанк\"";

                }
                else if (N.Text == "Спидран")
                {

                    O.Text = "Пройти \"Киберпанк\"";

                }
                else if (N.Text == "Ресторан")
                {

                    O.Text = "Поесть как следует";

                }
                else if (N.Text == "Аквапарк")
                {

                    O.Text = "Покататься на горках";

                }
           
        }

    
    }
}
