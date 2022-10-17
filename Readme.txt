//Name: Kamaljeet Kaur
//Student Number: 0770449
//WEB452
//Professor name:Andrew Steele
Assignment: KnifeApp

Intitally I created the project by its correct name. Tested it successfully. Created readme file.
Pushed all files on github.
Then, I added a model in models folder and gave it name of Knife.cs. I added seven properties of Knife.
Following this, there was no need for adding NuGet packages but i checked all of the required packages for the given project.
Then I Create a database context class namely KnifeAppContext in the data folder.
Registered the database context by adding following statements in the Startup.cs file.
     using MvcMovie.Data;
     using Microsoft.EntityFrameworkCore;
And made changes in Startup.ConfigureServices in same file.
Add a connection string to the appsettings.json file:
 "KnifeAppContext": "Server=(localdb)\\mssqllocaldb;Database=aspnet-WEB452_Assignment1_Knife-DD398EDB-9164-4DF4-9C1F-E86E689FA190;Trusted_Connection=True;MultipleActiveResultSets=true"},
Then I decided to test the given project and when I tested it showed following error:

Fix : No Service for Type Microsoft.AspNetCore.Identity.UserManager has been registered
I stuck here for long time  then in order to remove this i added following code in the Startup.cs file
 
 options.UseSqlServer(
                    Configuration.GetConnectionString("KnifeAppContext")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)

                .AddEntityFrameworkStores<ApplicationDbContext>();
Then my project started running smoothly.
Following this, I did scaffolding to produce Create, Read, Update, and Delete (CRUD) pages for the movie model.
Then I added the file of SeedData.cs in model folder and put minimum 10 entries.
Made changes in Program.cs file to Add the seed initializer
Then i tested it.

Part 6, controller methods and views in ASP.NET Core
Open the Models/Knife.cs and added some data annotations

Then i tested it

Following this I Examine all the files of Knives like index.cshtml,Edit.cshtml,Create.cshtml
Processed the POST Request

Part 7, added search 

Add Search by types. For this I Add the  KnifeTypeViewModel class to the Models folder along with its propesties

Add search by Types to the Index view.For this I Update Index.cshtml found in Views/Movies

Part 8, I forget to add Rating properity in the knife.cs file
For this I update the [Bind] attribute for both the Create and Edit action methods to include the Rating property
Update the view templates in order to display, create, and edit the new Rating property


Finally,Part 9, add validation to the KnifeApp.
For this I added following
[RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]

 [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]

At the end i examine All  Details and Delete methods of KnifeApp 

Then I decided the layout of my Company and named it Navigator Knife Co.
I added some images, links, paragraphs related to this Company in Index.cshtml inside View/Home.
And also A About Us page which is displaying the information regarding the employees their contact info. and many more.

I forget to take the pictures of kinves.
For this purpose i downloaded some pictures and added all of the images in the wwwrootfolder under image folder


