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

namespace APlusBudgetsProto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HideEverything();
            this.Welcome_Screen.Visibility = Visibility.Visible;

            // add events
            this.FoodCategory.AddExpenseButton.Click += OnAddExpenseButtonClick;
            this.RentCategory.AddExpenseButton.Click += OnAddExpenseButtonClick;
            this.TuitionCategory.AddExpenseButton.Click += OnAddExpenseButtonClick;
            this.ClothingCategory.AddExpenseButton.Click += OnAddExpenseButtonClick;
            this.CarCategory.AddExpenseButton.Click += OnAddExpenseButtonClick;

            // set category button names
            this.FoodCategory.Category.Content = "Food";
            this.RentCategory.Category.Content = "Rent";
            this.TuitionCategory.Category.Content = "Tuition";
            this.ClothingCategory.Category.Content = "Clothing";
            this.CarCategory.Category.Content = "Car";
        }


        private void OnAddExpenseButtonClick(object sender, RoutedEventArgs e)
        {
            this.AddExpenseWindow.Visibility = Visibility.Visible;
        }

        private void OnSignInClick(object sender, RoutedEventArgs e)
        {
            this.Welcome_Screen.Visibility = Visibility.Hidden;
            this.SignInScreen.Visibility = Visibility.Visible;

        }

        private void OnSignUpClick(object sender, RoutedEventArgs e)
        {
            this.Welcome_Screen.Visibility = Visibility.Hidden;
            this.SignUpScreen.Visibility = Visibility.Visible;
        }

        private void OnLogInClick(object sender, RoutedEventArgs e)
        {
            this.AddExpenseWindow.Visibility = Visibility.Hidden;
            this.SignInScreen.Visibility = Visibility.Hidden;
            this.MainScreen.Visibility = Visibility.Visible;
            this.Banner.Visibility = Visibility.Visible;
        }

        private void OnCreateAccountClick(object sender, RoutedEventArgs e)
        {
            this.SignUpScreen.Visibility = Visibility.Hidden;
            this.SetUpScreen.Visibility = Visibility.Visible;
        }

        private void OnConfirmExpenseClick(object sender, RoutedEventArgs e)
        {
            this.AddExpenseWindow.Visibility = Visibility.Hidden;
        }

        private void OnCancelAddExpenseClick(object sender, RoutedEventArgs e)
        {
            this.AddExpenseWindow.Visibility = Visibility.Hidden;
        }

        private void OnConfirmSignOutClick(object sender, RoutedEventArgs e)
        {
            HideEverything();
            this.Welcome_Screen.Visibility = Visibility.Visible;
        }

        private void OnCancelSignOutClick(object sender, RoutedEventArgs e)
        {
            this.SignOutWindow.Visibility = Visibility.Hidden;
        }

        private void OnHBSignOutClick(object sender, RoutedEventArgs e)
        {
            this.SignOutWindow.Visibility = Visibility.Visible;
        }

        private void OnHBMainMenuClick(object sender, RoutedEventArgs e)
        {
            HideEverything();
            this.MainScreen.Visibility = Visibility.Visible;
            this.Banner.Visibility = Visibility.Visible;
        }

        private void HideEverything()
        {
            this.Welcome_Screen.Visibility = Visibility.Hidden;
            this.SignInScreen.Visibility = Visibility.Hidden;
            this.SignUpScreen.Visibility = Visibility.Hidden;
            this.MainScreen.Visibility = Visibility.Hidden;
            this.GraphScreen.Visibility = Visibility.Hidden;
            this.SignOutWindow.Visibility = Visibility.Hidden;
            this.Banner.Visibility = Visibility.Hidden;
            this.SettingsScreen.Visibility = Visibility.Hidden;
            this.EditProfileScreen.Visibility = Visibility.Hidden;
            this.NotificationsScreen.Visibility = Visibility.Hidden;
            this.SetUpScreen.Visibility = Visibility.Hidden;
            this.AddCategoryWindow.Visibility = Visibility.Hidden;
            this.SetUpBudgetScreen.Visibility = Visibility.Hidden;
            this.AddExpenseWindow.Visibility = Visibility.Hidden;
            this.EditBudgetScreen.Visibility = Visibility.Hidden;
        }

        private void OnHBSetGoalsClick(object sender, RoutedEventArgs e)
        {
            HideEverything();
            this.Banner.Visibility = Visibility.Visible;
            this.SetGoalsScreen.Visibility = Visibility.Visible;
        }

        private void OnHBSettingsClick(object sender, RoutedEventArgs e)
        {
            HideEverything();
            this.Banner.Visibility = Visibility.Visible;
            this.SettingsScreen.Visibility = Visibility.Visible;
            this.SettingsStackPanel.Visibility = Visibility.Visible;
        }

        private void OnUpdateProfileClick(object sender, RoutedEventArgs e)
        {
            this.EditProfileScreen.Visibility = Visibility.Hidden;
            this.SettingsStackPanel.Visibility = Visibility.Visible;
        }

        private void OnEditProfileClick(object sender, RoutedEventArgs e)
        {
            this.SettingsStackPanel.Visibility = Visibility.Hidden;
            this.EditProfileScreen.Visibility = Visibility.Visible;
        }

        private void OnNotificationsClick(object sender, RoutedEventArgs e)
        {
            this.SettingsStackPanel.Visibility = Visibility.Hidden;
            this.NotificationsScreen.Visibility = Visibility.Visible;
        }

        private void OnSetUpCategoryClick(object sender, RoutedEventArgs e)
        {
            this.AddCategoryWindow.Visibility = Visibility.Visible;
        }

        private void OnCategoryCancelClick(object sender, RoutedEventArgs e)
        {
            this.AddCategoryWindow.Visibility = Visibility.Hidden;
        }

        private void OnCategoryConfirmClick(object sender, RoutedEventArgs e)
        {
            this.AddCategoryWindow.Visibility = Visibility.Hidden;
        }

        private void OnSetUpNextClick(object sender, RoutedEventArgs e)
        {
            this.SetUpScreen.Visibility = Visibility.Hidden;
            this.SetUpBudgetScreen.Visibility = Visibility.Visible;
        }

        private void OnSetUpDoneClick(object sender, RoutedEventArgs e)
        {
            this.SetUpBudgetScreen.Visibility = Visibility.Hidden;
            this.MainScreen.Visibility = Visibility.Visible;
            this.Banner.Visibility = Visibility.Visible;
        }

        private void OnEditBudgetDoneClick(object sender, RoutedEventArgs e)
        {
            this.EditBudgetScreen.Visibility = Visibility.Hidden;
            this.SettingsScreen.Visibility = Visibility.Visible;
        }

        private void OnEditBudgetClick(object sender, RoutedEventArgs e)
        {
            this.SettingsScreen.Visibility = Visibility.Hidden;
            this.EditBudgetScreen.Visibility = Visibility.Visible;
        }
    }
}
