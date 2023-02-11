using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UserAppBeta
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        AppContext db;
        public Window1()
        {
            InitializeComponent();
            db= new AppContext();
            List<User> users = db.Users.ToList();
            string str = "";
            foreach (User user in users)
            {
                str += "Name: " + user.names + "number_phone: " + user.number_phone + "___";
            }
            exampleText.Text = str; 
        }

        private void Button_Click_voi(object sender, RoutedEventArgs e)
        {
           
          
            MainWindow mainWindow= new MainWindow();
            mainWindow.Show();
            Hide();

           

        }

        private void TextBoxNumber_Phone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Register_Program_Click(object sender, RoutedEventArgs e)
        {
            int number_phone = Convert.ToInt32(TextBoxNumber_Phone.Text.Length);
            string names = TextBoxNames.Text.Trim();
            string password = TextBoxPassword.Password.Trim();
            string password_2 = TextBoxPssword2.Password.Trim();

           if(number_phone == 0||number_phone==11)
            {
                TextBoxNumber_Phone.ToolTip = "Це поле введено не коректно!";
                TextBoxNumber_Phone.Background = Brushes.Red;
            } 
           else if(names.Length<8)
            {
                TextBoxNames.ToolTip = "Це поле введено не коректно";
                TextBoxNames.Background= Brushes.Red;

            }
            else if (password.Length < 6)
            {
                TextBoxPassword.ToolTip = "Це поле введено не коректно";
                TextBoxPassword.Background = Brushes.Red;
            }
           else if(password!=password_2)
            {
                TextBoxPssword2.ToolTip = "Це поле введено не коректно";
                TextBoxPssword2.Background= Brushes.Red;

            }
           else
            {
                TextBoxNames.ToolTip = " ";
                TextBoxNames.Background= Brushes.Transparent;
                TextBoxNumber_Phone.ToolTip= " ";
                TextBoxNumber_Phone.Background= Brushes.Transparent;
                TextBoxPassword.ToolTip= " ";
                TextBoxPassword.Background= Brushes.Transparent;
                TextBoxPssword2.ToolTip= " ";
                TextBoxPssword2.Background = Brushes.Transparent;
                MessageBox.Show("Vse ok!!!");
            }
           

            User user = new User(number_phone, names, password);
            db.Users.Add(user);
            db.SaveChanges();
            //MessageBox.Show("Реєстрація успішна!");
        }
    }
}
