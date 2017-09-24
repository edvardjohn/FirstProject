using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{


    public class Program
    {
        MainWindow _mainWindow;
        public Program(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
        }

        public void buttonPressed()
        {
            _mainWindow.writeInTextBox("Normal press");
        }

        public void OnButtonPressed(object source, EventArgs e)
        {
            _mainWindow.writeInTextBox("Event Press");
        }
    }
}
