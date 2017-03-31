using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace TetrisCarGame
{
    class Game
    {
        static void Main(string[] args)
        {
            WindowMaximaizer.Maximize();
            Console.WindowWidth = Console.LargestWindowWidth;
            Console.Title = @"TetrisCarGame";

            //

            int widthInAuto = 40;//ширина поля в автомобилях 
            int heightInAuto=10;//высота...
            double machinesAtOneLine=0.5;//количество машин генерируемых на одну линию
            int playerSpeed=3;//скорость игрока
            int loopDelay=100;//пауза между тактами игры, влияет на скорость врагов
            GameLogic gl = new GameLogic( widthInAuto,  heightInAuto,  machinesAtOneLine, playerSpeed, loopDelay);
            gl.StartGame();
            Console.Clear();

            //

            Console.ReadLine();
            
        }
    }

    class WindowMaximaizer
    {
        [DllImport("user32.dll")]
        static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);
        public static void Maximize()
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3); //SW_MAXIMIZE = 3
        }
    }
}
