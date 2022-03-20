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
using System.Xml;
using System.Data;

namespace WpfXMLReader01
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

        private void ButtonXmlRead_Click(object sender, RoutedEventArgs e)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create("Bookstore.xml", new XmlReaderSettings());
            DataSet ds = new DataSet();
            ds.ReadXml(xmlFile);
            
            for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
               ListaXml.Items.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString() + "  " + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "  " + ds.Tables[0].Rows[i].ItemArray[2].ToString() + "  " + ds.Tables[0].Rows[i].ItemArray[3].ToString());
                
            }
        }

        private void close_app_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_data_grid_Click(object sender, RoutedEventArgs e)
        {
            WindowDataGrid windowDataGrid = new WindowDataGrid();
            windowDataGrid.Show();
        }
    }
}
