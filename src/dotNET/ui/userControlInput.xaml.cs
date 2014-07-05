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

namespace Decent.dotNET.ui
{
    /// <summary>
    /// Interaction logic for userControlInput.xaml
    /// </summary>
    public partial class userControlInput : UserControl
    {
        public userControlInput()
        {
            InitializeComponent();
        }

        public void sendContent()
        {

        }

        protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseLeftButtonDown(e);

            Console.WriteLine(UIElementTextBox.SelectedText);
        }
    }
}
