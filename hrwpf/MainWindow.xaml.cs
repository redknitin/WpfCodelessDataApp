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

namespace hrwpf
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            hrwpf.hrDataSet hrDataSet = ((hrwpf.hrDataSet)(this.FindResource("hrDataSet")));
            // Load data into the table dept. You can modify this code as needed.
            hrwpf.hrDataSetTableAdapters.deptTableAdapter hrDataSetdeptTableAdapter = new hrwpf.hrDataSetTableAdapters.deptTableAdapter();
            hrDataSetdeptTableAdapter.Fill(hrDataSet.dept);
            System.Windows.Data.CollectionViewSource deptViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("deptViewSource")));
            deptViewSource.View.MoveCurrentToFirst();
            // Load data into the table emp. You can modify this code as needed.
            hrwpf.hrDataSetTableAdapters.empTableAdapter hrDataSetempTableAdapter = new hrwpf.hrDataSetTableAdapters.empTableAdapter();
            hrDataSetempTableAdapter.Fill(hrDataSet.emp);
            System.Windows.Data.CollectionViewSource empViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("empViewSource")));
            empViewSource.View.MoveCurrentToFirst();
        }
    }
}
