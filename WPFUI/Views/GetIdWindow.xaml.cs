using BLL.DTO;
using System.Collections.ObjectModel;
using System.Windows;

namespace WPFUI.Views
{
    /// <summary>
    /// Логика взаимодействия для DeleteWindow.xaml
    /// </summary>
    public partial class GetIdWindow : Window
    {
        public ObservableCollection<object> TableData { get; set; }

        public int InputId { get; private set; }

        public GetIdWindow(ObservableCollection<object> tableData)
        {
            InitializeComponent();
            TableData = tableData;
            EntitiesDataGrid.ItemsSource = TableData;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string idInput = FirstNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(idInput))
            {
                MessageBox.Show("Введите ID для удаления.");
                return;
            }

            if (int.TryParse(idInput, out int id))
            {
                //var itemToDelete = TableData.OfType<PassengerDTO>().FirstOrDefault(p => p.Id == id);
                //if (itemToDelete != null)
                //{
                    InputId = id;
                    DialogResult = true;
                    this.Close();
                //}
            } 
        }
    }
}
