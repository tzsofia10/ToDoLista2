using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoLista
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Kilepes_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Hozzaadas_Click(object sender, RoutedEventArgs e)
        {

            list1.Items.Add(textbox.Text);
            textbox.Clear();
        }

        private void torles_Click(object sender, RoutedEventArgs e)
        {
            list1.Items.Remove(list1.SelectedItem);
            
        }

        private void modositas_Click(object sender, RoutedEventArgs e)
        {
            string csere = string.Empty;
            string txtCsere=textbox.Text;

            foreach (ListBoxItem item in list1.SelectedItems)
            {
                csere += item.Content.ToString();
                if (txtCsere == csere)
                {
                    MessageBox.Show("Ugyan az a szöveget írtad be!", "Save error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    item.Content = txtCsere;
                }
            }

        }

        private void masolas_Click(object sender, RoutedEventArgs e)
        {
           string copyContent=string.Empty;
           foreach(ListBoxItem item in list1.SelectedItems)
            {
                copyContent += item.Content.ToString();
            }
           list2.Items.Add(copyContent);
        }
    }
}