using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            BSTree<VideoGame> tree = new BSTree<VideoGame>();

            while (loop)
            {
                Console.WriteLine("1 - Add to tree\n2 - Display height\n3 - In order\n4 - Pre order\n5 - Post order\n6 - Earliest game\n7 - Count\n8 - Find and update node\n9 - Quit");
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        Console.WriteLine("Enter a game name");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter game developer");
                        string gameDev = Console.ReadLine();
                        Console.WriteLine("Year released");
                        int year = int.Parse(Console.ReadLine());
                        VideoGame game = new VideoGame(title, gameDev, year);
                        tree.InsertItem(game);
                        
                    }
                    else if (input == 2)
                    {
                        Console.WriteLine(tree.Height());
                    }
                    else if (input == 3)
                    {
                        string buffer = "";
                        tree.InOrder(ref buffer);
                        Console.WriteLine(buffer);
                    }
                    else if (input == 4)
                    {
                        string buffer = "";
                        tree.PreOrder(ref buffer);
                        Console.WriteLine(buffer);
                    }
                    else if (input == 5)
                    {
                        string buffer = "";
                        tree.PostOrder(ref buffer);
                        Console.WriteLine(buffer);
                    }
                    else if (input == 6)
                    {
                        
                    }
                    else if (input == 7)
                    {
                        Console.WriteLine(tree.Count());
                    }
                    else if (input == 8)
                    {
                        Console.WriteLine("Enter a game name");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter game developer");
                        string gameDev = Console.ReadLine();
                        Console.WriteLine("Year released");
                        int year = int.Parse(Console.ReadLine());
                        VideoGame game = new VideoGame(title, gameDev, year);
                        tree.Update(game);

                    }
                    else if (input == 9)
                    {
                        loop = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("error");
                    loop = true;
                }
            }

            Console.ReadLine();
            
        }
    }
}
