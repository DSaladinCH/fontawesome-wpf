using DSaladin.FontAwesome.WPF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace demo_testing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private FontAwesomeIcon testIcon;

        public FontAwesomeIcon TestIcon
        {
            get { return testIcon; }
            set
            {
                testIcon = value;
                NotifyPropertyChanged();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            TestIcon = FontAwesomeIcon.BrandsGg;
            //lblIcon.SetRotation(90);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
