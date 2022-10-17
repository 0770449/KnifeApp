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
                        Image = ""
                    },



                    new Knife
                    {
                        Name = "Stamped",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Medium Tip",
                        Image = ""
                    },

                     new Knife
                     {
                         Name = "Forged",
                         Price = 2.49M,
                         Type = "Felt ",
                         Colour = "Black",
                         Size = "Small",
                         Image = ""
                     },
                    new Knife
                    {
                        Name = "Forged",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Small",
                        Image = ""
                    },
                    new Knife
                    {
                        Name = "Forged",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Small",
                        Image = ""
                    },
                     new Knife
                     {
                         Name = "Forged",
                         Price = 2.49M,
                         Type = "Felt ",
                         Colour = "Black",
                         Size = "Small",
                         Image = ""
                     },
                    new Knife
                    {
                        Name = "Forged",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Small",
                        Image = ""
                    },

                    new Knife
                    {
                        Name = "Forged",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Small",
                        Image = ""
                    },

                    new Knife
                    {
                        Name = "Forged",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Small",
                        Image = ""
                    },

                     new Knife
                     {
                         Name = "Forged",
                         Price = 2.49M,
                         Type = "Felt ",
                         Colour = "Black",
                         Size = "Small",
                         Image = ""
                     },



                     new Knife
                     {
                         Name = "Forged",
                         Price = 2.49M,
                         Type = "Felt ",
                         Colour = "Black",
                         Size = "Small",
                         Image = ""
                     },



                    new Knife
                    {
                        Name = "Forged",
                        Price = 2.49M,
                        Type = "Felt ",
                        Colour = "Black",
                        Size = "Small",
                        Image = ""
                    }


                );
                context.SaveChanges();
            }
        }
    }
}

