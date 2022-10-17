using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using KnifeApp.Data;
using System;
using System.Linq;

namespace KnifeApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new KnifeAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<KnifeAppContext>>()))
            {
                // Look for any knives.
                if (context.Knife.Any())
                {
                    return;   // DB has been seeded
                }

                context.Knife.AddRange(
                    new Knife
                    {
                        Name = "Forged",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Small",
                        Rating = "R",
                        Image = "bestpocket knives1.jpeg"

                    },



                    new Knife
                    {
                        Name = "Stamped",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Medium Tip",
                        Rating = "R",
                        Image = "bestpocket knives2.jpeg"
                    },

                     new Knife
                     {
                         Name = "Gerber",
                         Price = 2.49M,
                         Type = "Felt ",
                         Colour = "Black",
                         Size = "Small",
                         Rating = "R",
                         Image = "gerber.jpeg"
                     },
                    new Knife
                    {
                        Name = "Knife3",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Brown",
                        Size = "Small",
                        Rating = "R",
                        Image = "knife3.jpeg"
                    },
                    new Knife
                    {
                        Name = "Knifeblades",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Small",
                        Rating = "R",
                        Image = "knifeblades.jpeg"
                    },
                     new Knife
                     {
                         Name = "Knifeplanet",
                         Price = 4.49M,
                         Type = "Felt ",
                         Colour = "White",
                         Size = "Small",
                         Rating = "R",
                         Image = "knifeplanet.jpeg"
                     },
                    new Knife
                    {
                        Name = "Popular",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Small",
                        Rating = "R",
                        Image = "popular.jpeg"
                    },

                    new Knife
                    {
                        Name = "Rollerknife",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Small",
                        Rating = "R",
                        Image = "rollerknife.jpeg"
                    },

                    new Knife
                    {
                        Name = "Stanely",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Small",
                        Rating = "R",
                        Image = "stanely.jpeg"
                    },

                     new Knife
                     {
                         Name = "Strange",
                         Price = 2.49M,
                         Type = "Felt ",
                         Colour = "Black",
                         Size = "Small",
                         Rating = "R",
                         Image = "strange.jpeg"
                     },



                     new Knife
                     {
                         Name = "Forged",
                         Price = 2.49M,
                         Type = "Felt ",
                         Colour = "Black",
                         Size = "Small",
                         Rating = "R",
                         Image = "knifeblades.jpeg"
                     },



                    new Knife
                    {
                        Name = "Forged",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Small",
                        Rating = "R",
                        Image = "stanely.jpeg"
                    }


                );
                context.SaveChanges();
            }
        }
    }
}

