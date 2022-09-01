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

using WpfCustomUserControlsWithEventsDemo.UserControls;

namespace WpfCustomUserControlsWithEventsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window // This class is the subscriber for the custom event
    {
        public MainWindow()
        {
            InitializeComponent();
            NameAgeTab.OnButtonClick += MakeGreeting; // subscribe
        }

        // Event handling method passes the custom event argument on to the other custom UC for display
        internal void MakeGreeting(object? sender, CustomArgs args) => GreetingTab.MakeGreeting(args.Name, args.Age);
    }
}
