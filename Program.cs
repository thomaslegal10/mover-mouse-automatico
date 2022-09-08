using System;

namespace Mover_mouse_automático
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigConsole.SetFullScreen();
            Console.WriteLine("\nMeu app de mover mouse iniciado!\n");

            const int quantidadeMaxExecucoes = 500;
            
            int cont = 0;
            bool executar = true;

            while(cont < quantidadeMaxExecucoes && executar) 
            {
                for (int i = 1200; i < 1800 && executar; i = i + 10) 
                {
                    for (int j = 500; j < 1000 && executar; j = j + 10) 
                    {
                        VirtualMouse.SetCursorPosition(i, j);
                        Console.WriteLine($"\nPosição i: {i} | Posição j: {j} | Contador: {cont}\n");
                        Thread.Sleep(50);

                        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape) {
                            executar = false;
                            break;
                        }
                    }

                    VirtualMouse.LeftClick();
                    VirtualTeclado.PressKey(VirtualKeyCodes.VK_UP);
                }
                cont++;
            }
        }
    }
}