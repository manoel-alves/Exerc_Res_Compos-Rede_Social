using Exerc_Resolvido_2_Composicao.entities;
using System;
using System.Collections.Generic;

namespace Exerc_Resolvido_2_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime moment = DateTime.Now;
            List<Post> posts = new List<Post>();

            int Choice = 9;
            while (Choice != 0)
            {
                Console.WriteLine("Add New Post: (1)");
                Console.WriteLine("Add a Comment: (2)");
                Console.WriteLine("Like a post: (3)");
                Console.WriteLine("Resume: (4)");
                Console.WriteLine("Close Program: (0)");
                Console.Write("=> ");
                Choice = int.Parse(Console.ReadLine());
                
                Console.WriteLine("=========================");
                Console.WriteLine();

                switch (Choice)
                {
                    case 1:
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Content: ");
                        string content = Console.ReadLine();
                        int likes = 0;
                        Post newPost = new Post(moment, title, content, likes);
                        posts.Add(newPost);
                        Console.WriteLine();
                        break;
                    case 2:
                        int count = -1;
                        foreach (Post obj in posts)
                        {
                            count++;
                            Console.WriteLine("'" + obj.Title + "'" + " - " + count);
                        }
                        if (count == -1)
                        {
                            Console.WriteLine("No posts to comment yet :/");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("-------------------------");
                            Console.Write("Which post will you comment? ");
                            int postIndex = int.Parse(Console.ReadLine());
                            Console.Write("Comment: ");
                            string comment = Console.ReadLine();
                            posts[postIndex].AddComment(comment);
                        }
                        break;
                    case 3:
                        int countL = -1;
                        foreach (Post obj in posts)
                        {
                            countL++;
                            Console.WriteLine("'" + obj.Title + "'" + " - " + countL);
                        }
                        if (countL == -1)
                        {
                            Console.WriteLine("No posts to like yet :/");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("-------------------------");
                            Console.Write("Which post will you like? ");
                            int postIndex = int.Parse(Console.ReadLine());
                            posts[postIndex].Likes += 1;
                            Console.WriteLine(">>>Like Adicionado<<<");
                        }
                        break;
                    case 4:
                        foreach (Post obj in posts)
                        {
                            Console.WriteLine("-------------------------");
                            Console.WriteLine(obj);
                            Console.WriteLine("-------------------------");
                            Console.WriteLine();
                        }
                        break;
                }

                if (Choice != 0)
                {
                    Console.WriteLine("=========================");
                    Console.WriteLine();
                }

            }

            Console.WriteLine("Até a próxima! :)");
            Console.WriteLine();
            Console.WriteLine("=========================");

        }
    }
}
