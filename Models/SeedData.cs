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
                        Image = "bestpocket knives1.jpeg"
                    },



                    new Knife
                    {
                        Name = "Stamped",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Medium Tip",
                        Image = "bestpocket knives2.jpeg"
                    },

                     new Knife
                     {
                         Name = "Gerber",
                         Price = 2.49M,
                         Type = "Felt ",
                         Colour = "Black",
                         Size = "Small",
                         Image = "gerber.jpeg"
                     },
                    new Knife
                    {
                        Name = "Knife3",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Brown",
                        Size = "Small",
                        Image = "knife3.jpeg"
                    },
                    new Knife
                    {
                        Name = "Knifeblades",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Small",
                        Image = "knifeblades.jpeg"
                    },
                     new Knife
                     {
                         Name = "Knifeplanet",
                         Price = 4.49M,
                         Type = "Felt ",
                         Colour = "White",
                         Size = "Small",
                         Image = "knifeplanet.jpeg"
                     },
                    new Knife
                    {
                        Name = "Popular",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Small",
                        Image = "popular.jpeg"
                    },

                    new Knife
                    {
                        Name = "Rollerknife",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Small",
                        Image = "rollerknife.jpeg"
                    },

                    new Knife
                    {
                        Name = "Stanely",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Small",
                        Image = "stanely.jpeg"
                    },

                     new Knife
                     {
                         Name = "Strange",
                         Price = 2.49M,
                         Type = "Felt ",
                         Colour = "Black",
                         Size = "Small",
                         Image = "strange.jpeg"
                     },



                     new Knife
                     {
                         Name = "Forged",
                         Price = 2.49M,
                         Type = "Felt ",
                         Colour = "Black",
                         Size = "Small",
                         Image = "knifeblades.jpeg"
                     },



                    new Knife
                    {
                        Name = "Forged",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Small",
                        Image = "stanely.jpeg"
                    }


                );
                context.SaveChanges();
            }
        }
    }
}

