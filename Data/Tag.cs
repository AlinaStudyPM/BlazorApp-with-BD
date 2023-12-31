﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MovieBlazor5.Data
{
    public class Tag
    {
        public string Code { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public HashSet<Movie>? Movies { get; set; }

        public Tag(string code, string name)
        {
            Code = code;
            Name = name;
        }
        public void AddMovie(Movie movie)
        {
            if (Movies != null)
            {
                Movies.Add(movie);
            }
            else
            {
                Movies = new HashSet<Movie> { movie };
            }
        }

        public void Print()
        {
            Console.WriteLine(Name);
            Console.Write("Фильмы : |");
            foreach (Movie movie in Movies)
            {
                Console.Write(" " + movie.MainTitle + " |");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
