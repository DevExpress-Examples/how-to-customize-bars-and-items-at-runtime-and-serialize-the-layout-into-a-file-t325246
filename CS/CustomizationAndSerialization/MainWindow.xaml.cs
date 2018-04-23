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

namespace CustomizationAndSerialization
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

        private void OnSaveBarManagerLayout(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            barManager.SaveLayoutToXml("layout.xaml");
        }

        private void OnLoadBarManagerLayout(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            barManager.RestoreLayoutFromXml("layout.xaml");
        }
    }
}
