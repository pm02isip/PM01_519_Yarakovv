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

namespace PM01_519_Yarakov.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutoPage.xaml
    /// </summary>
    public partial class AutoPage : Page
    {
		public AutoPage()
		{
			InitializeComponent();
		}

		private void ButtonEnter_OnClick(object sender, RoutedEventArgs e)
		{
            var Password = Pass.Password.ToString();
            var Logi = Logins.Text.ToString();

            Error.Visibility = Error.Visibility == Visibility.Hidden ? Visibility.Collapsed : Visibility.Hidden;

            if (Logi == "1")
            {
                if (Password == "1")
                {
                    NavigationService.Navigate(new Juri());
                    Error.Visibility = Error.Visibility == Visibility.Hidden ? Visibility.Collapsed : Visibility.Hidden;
                }
                Error.Visibility = Error.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
            }

            if (Logi == "2")
            {
                if (Password == "2")
                {
                    NavigationService.Navigate(new Creator());
                    Error.Visibility = Error.Visibility == Visibility.Hidden ? Visibility.Collapsed : Visibility.Hidden;
                }
                Error.Visibility = Error.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
            }

            if (Logi == "3")
            {
                if (Password == "3")
                {
                    NavigationService.Navigate(new Member());
                    Error.Visibility = Error.Visibility == Visibility.Hidden ? Visibility.Collapsed : Visibility.Hidden;
                }
                Error.Visibility = Error.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
            }

            if (Logi == "4")
            {
                if (Password == "4")
                {
                    NavigationService.Navigate(new Moderator());
                    Error.Visibility = Error.Visibility == Visibility.Hidden ? Visibility.Collapsed : Visibility.Hidden;
                }
                Error.Visibility = Error.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
            }
            else
            {
                Error.Visibility = Error.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Registration());
        }
    }
}