using MusicPlayer.Genres;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicPlayer
{
    class Program
    {
        static public List<Genre> genres = new List<Genre>();

        static void Main(string[] args)
        {
            Genre genre;
            Player player = new Player();

            genres.Add(new Country());
            genres.Add(new Disco());
            genres.Add(new Pop());
            genres.Add(new Rap());
            genres.Add(new Soul());

            do
            {
                Console.WriteLine("Podaj nazwę utworu:");
                string title = Console.ReadLine();

                Console.WriteLine("Podaj nazwę wykonawcy:");
                string contractor = Console.ReadLine();

                Console.WriteLine("Wybierz gatunek:");
                ShowGenres();

                int id = int.Parse(Console.ReadLine());
                genre = genres.ElementAt(id - 1);

                player.Add(new Song(genre, title, contractor));

                Console.WriteLine("Czy chcesz dodać kolejną? [tak/nie]");
                string choice = Console.ReadLine();

                if(string.Equals(choice, "nie"))
                {
                    break;
                }

                Console.Clear();
                
            }
            while (true);

            Console.WriteLine("Odtwarzam ...");

            foreach (Song song in player.songs)
            {
                Console.WriteLine(song.Play());
            }

            Console.ReadKey();
        }

        static void ShowGenres()
        {
            int key = 0;
            foreach (Genre genre in genres)
            {
                key++;
                Console.WriteLine("{0}. {1}", key.ToString(), genre.getName());
            }
        }
    }
}
