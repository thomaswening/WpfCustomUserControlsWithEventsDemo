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

namespace WpfCustomUserControlsWithEventsDemo.UserControls
{
    /// <summary>
    /// Interaction logic for GreetingUC.xaml
    /// </summary>
    public partial class GreetingUC : UserControl
    { 
        public GreetingUC()
        {
            InitializeComponent();
        }

        public void MakeGreeting(string pName, string pAge)
        {
            if (string.IsNullOrEmpty(pName)) pName = "_____";
            if (string.IsNullOrEmpty(pAge)) pAge = "__";

            txtGreeting.Text = $"Hello {pName}! You are {pAge} years old.";
        }
    }
}
