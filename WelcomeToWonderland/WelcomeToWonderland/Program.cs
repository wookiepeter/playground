using SFML;
using SFML.Audio;
using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeToWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            RenderWindow window = new RenderWindow(new VideoMode(900, 900), "LoL");

            while (window.IsOpen())
            {
                window.Clear(Color.Cyan);
                window.DispatchEvents();
                window.Closed += (object sender, EventArgs e) => { (sender as Window).Close(); };
            }
        }
    }
}
