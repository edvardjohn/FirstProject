using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class ButtonPresser
    {
        public event EventHandler ButtonPressed;

        public void PressingButton()
        {
            Console.WriteLine("Pressing Button");
            OnButtonPressed();

        }

        protected virtual void OnButtonPressed()
        {
            if (ButtonPressed != null)
            {
                ButtonPressed(this, EventArgs.Empty);
            }
        }

    }
}
