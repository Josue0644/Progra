using System;

namespace Estampas_2
{
    class Program
    {
        static Album album;

        static void marcarEstampa(string codigo)
        {
            int i = album.buscarEstampa(codigo);
            
            if (i >= 0)
            {
                album.estampas[i].marcar();
            } else
            {
                Console.WriteLine("Estampa no encontrada");
            }

        }

        static void marcarEstampaFaltante(string codigo)
        {
            int i = album.buscarEstampa(codigo);

            if (i >= 0)
            {
                album.estampas[i].faltar();
            }
            else
            {
                Console.WriteLine("Estampa no encontrada");
            }

        }

        static void marcarEstampaRepetida(string codigo)
        {
            int i = album.buscarEstampa(codigo);

            if (i >= 0)
            {
                album.estampas[i].repetir();
            }
            else
            {
                Console.WriteLine("Estampa no encontrada");
            }

        }

        static void Main(string[] args)
        {
            int opcion=0;
            string codigo = "";

            album = new Album();

        MENU:

            Console.Clear();
            //Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("MENÚ PRINCIPAL");
            Console.WriteLine("");            
            Console.WriteLine("1. Marcar estampas.");
            Console.WriteLine("2. Marcar estampa faltante.");
            Console.WriteLine("3. Marcar estampa repetida.");
            Console.WriteLine("");
            opcion = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione una opcion de arriba: ");
            switch (opcion)
            {

                case 1:
                    Console.Write("Ingrese código de estampa a marcar:  ");
                    codigo = Console.ReadLine();
                    marcarEstampa(codigo);
                    album.mostrarMarcadas();
                    break;
                case 2:
                    Console.Write("Ingrese código de estampa faltante:  ");
                    codigo = Console.ReadLine();
                    marcarEstampaFaltante(codigo);
                    album.mostrarFaltantes();
                    break;
                case 3:
                    Console.Write("Ingrese código de estampa repetida:  ");
                    codigo = Console.ReadLine();
                    marcarEstampaRepetida(codigo);
                    album.mostrarRepetidas();
                    break;

            }

            
            Console.ReadLine();

            goto MENU;
        }
    }
}
