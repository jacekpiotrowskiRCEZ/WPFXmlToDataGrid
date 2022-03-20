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
using System.Windows.Shapes;
using System.Xml;
using System.Data;

namespace WpfXMLReader01
{
    /// <summary>
    /// Logika interakcji dla klasy WindowDataGrid.xaml
    /// </summary>
    public partial class WindowDataGrid : Window
    {
        public WindowDataGrid()
        {
            InitializeComponent();
        }

        private void close_app_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonXmlRead_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                XmlReader xmlFile;
                xmlFile = XmlReader.Create("Bookstore.xml", new XmlReaderSettings());
                DataSet ds = new DataSet();
                ds.ReadXml(xmlFile);
              XmlDataGrid.ItemsSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
