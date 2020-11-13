using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2003-2-1"),
                        Genre = "Spiritual Comedy",
                        Price = 7.99M,
                        Rating = "PUBG"
                    },

                    new Movie
                    {
                        Title = "The Singles Ward ",
                        ReleaseDate = DateTime.Parse("2002-3-1"),
                        Genre = "Romantic Comedy",
                        Price = 8.99M,
                        Rating = "PUBG"
                    },

                    new Movie
                    {
                        Title = "Mobsters and Mormons",
                        ReleaseDate = DateTime.Parse("2005-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "PUBG"
                    },

                    new Movie
                    {
                        Title = "A Christmas Wish",
                        ReleaseDate = DateTime.Parse("2007-4-15"),
                        Genre = "Spiritual",
                        Price = 3.99M,
                        Rating = "PUBG"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}