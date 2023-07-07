using Microsoft.EntityFrameworkCore;
using RazorPagesMusic.Data;

namespace RazorPagesMusic.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMusicContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMusicContext>>()))
            {
                if (context == null || context.Music == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMusicContext");
                }

                // Look for any songs
                if (context.Music.Any())
                {
                    return; //DB has been seeded
                }

                context.Music.AddRange(
                new Music
                {
                    Title = "Me and Your Mama",
                    Artist = "Childish Gambino",
                    Genre = "R&B/Soul",
                    ReleaseDate = DateTime.Parse("2016-12-2"),
                    Rating = "Awesome"
                },
                new Music
                {
                    Title = "Faithfully",
                    Artist = "Journey",
                    Genre = "Soft Rock",
                    ReleaseDate = DateTime.Parse("1983-04-16"),
                    Rating = "Amazing"
                },
                new Music
                {
                    Title = "Toxicity",
                    Artist = "System of a Down",
                    Genre = "Progressive Metal",
                    ReleaseDate = DateTime.Parse("2001-09-2"),
                    Rating = "Epic"
                },
                new Music
                {
                    Title = "Suede",
                    Artist = "NxWorries",
                    Genre = "Hip Hop",
                    ReleaseDate = DateTime.Parse("2014-02-10"),
                    Rating = "Dope"
                }
            );
            context.SaveChanges();

            }
        }
    }
}
