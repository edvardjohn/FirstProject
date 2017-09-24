using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Program _program;
        public ButtonPresser _buttonPresser;

        public Randomizer _Randomizer;
        public Thread oThread;
            
        public MainWindow()
        {
            InitializeComponent();
            _program = new Program(this);
            _buttonPresser = new ButtonPresser();
            _Randomizer = new Randomizer(this, _buttonPresser);

            _buttonPresser.ButtonPressed += _program.OnButtonPressed;

            oThread = new Thread(new ThreadStart(_Randomizer.Randoming));

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            _program.buttonPressed();
        }

        public void writeInTextBox(string info)
        {
            ButtonTextBox.Text += info;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _buttonPresser.PressingButton();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            oThread.Start();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            oThread.Abort();
        }
    }
}
