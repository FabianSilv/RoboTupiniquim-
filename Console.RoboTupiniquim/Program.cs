using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RoboTupiiquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o tamanho da tabela x" );
            int tamanhox = int.Parse( Console.ReadLine() );
            Console.WriteLine("Insira o tamanho da tabela y");
            int tamanhoy = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Informe a posicao inicial e a direcao do robo");
                string[] inicial = Console.ReadLine().ToUpper().Split( ' ' );
                int x = int.Parse(inicial[0]);
                int y = int.Parse(inicial[1]);
                char direcao = char.Parse(inicial[2]);
                Console.WriteLine("informe os comandos D = direita E = esquerda M = mover");
                string[] comandos_entrada = Console.ReadLine().ToUpper().Split(' ');
                string  comando_saida = comandos_entrada[0];
                
                foreach(char comando in comando_saida) {
                switch(comando)
                    {
                        case 'M':
                            switch(direcao)
                            {
                                case 'N':
                                    y++;
                                    break;

                                case 'S':
                                    y--;
                                    break;

                                case 'L':
                                    x++;
                                    break;

                                case 'O':
                                    x--;
                                    break;
                            }   break;
                        case 'E':
                            switch (direcao)
                            {
                                case 'N': direcao = 'O'; break;
                                case 'S': direcao = 'L'; break;
                                case 'L': direcao = 'N'; break;
                                case 'O': direcao = 'S'; break;
                            }break;
                        case 'D':
                            switch (direcao)
                            {
                                case 'N': direcao = 'L'; break;
                                case 'S': direcao = 'O'; break;
                                case 'L': direcao = 'S'; break;
                                case 'O': direcao = 'N'; break;
                            }break;


                    }
                    }
                Console.WriteLine(x+" "+y+" "+direcao);
                Console.WriteLine("Deseja continuar S/N?");
                string resposta = Console.ReadLine();
                if (resposta != "S" && resposta != "s") break;
            }



        }
    }
}