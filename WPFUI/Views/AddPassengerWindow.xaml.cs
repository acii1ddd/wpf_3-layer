using BLL.DTO;
using System.Windows;

namespace WPFUI.Views
{
    /// <summary>
    /// Логика взаимодействия для AddPassengerWindow.xaml
    /// </summary>
    public partial class AddPassengerWindow : Window    
    {
        public PassengerDTO newPassenger { get; private set; }

        public AddPassengerWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                MessageBox.Show("Введите имя.");
                return;
            }

            if (string.IsNullOrWhiteSpace(SecondNameTextBox.Text))
            {
                MessageBox.Show("Введите фамилию.");
                return;
            }

            newPassenger = new PassengerDTO
            {
                FirstName = FirstNameTextBox.Text,
                SecondName = SecondNameTextBox.Text
            };

            DialogResult = true;
            this.Close();
        }
    }
}
