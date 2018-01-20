using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace WpfApp1
{
    public class Randomizer
    {
        private MainWindow _mainWindow;
        private Program _program;
        private ButtonPresser _buttonPresser;

        public Randomizer(MainWindow mainWindow, ButtonPresser buttonPresser)
        {

            _mainWindow = mainWindow;
            _buttonPresser = buttonPresser;
            var program = new Program(_mainWindow);

        }

        public void Randoming()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 10);

            int i = 0; 

            while (i < 10)
            {
                Thread.Sleep(500);
                dice = rnd.Next(1, 10);

                if (dice > 5)
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        _buttonPresser.PressingButton();
                    });


                }

                //i++;
            }
        }
    }
}
