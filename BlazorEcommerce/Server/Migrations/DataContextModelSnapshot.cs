﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcommerce.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Movies",
                            Url = "movies"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Video Games",
                            Url = "video-games"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            id = 1,
                            CategoryId = 1,
                            Description = "Το μοναδικό ανέκδοτο έργο του Νίκου Καζαντζάκη. Ο μεγάλος Έλληνας λογοτέχνης γράφει με ένταση και αγωνία υπαρξιακή, αναλογιζόμενος όλα τα μεγάλα ερωτήματα, που ταλανίζουν τους ανθρώπους μέχρι και σήμερα.",
                            ImageUrl = "https://www.dioptra.gr/Cache/Photos/ac6a19676b8a98d09ab782bc15660274.png",
                            Price = 19.99m,
                            Title = "Ο Ανήφορος"
                        },
                        new
                        {
                            id = 2,
                            CategoryId = 1,
                            Description = "Το μεγαλύτερο θαύμα στον κόσμο προσφέρει μια ανεκτίμητη σοφία σε όσους ψάχνουν για ένα ανώτερο μήνυμα και σκοπό στη ζωή τους. Το νέο best seller του Ογκ Μαντίνο είναι μια μαγευτική αφήγηση που αποκαλύπτει εντυπωσιακά μυστικά για προσωπική ευτυχία και επαγγελματική επιτυχία, και περιλαμβάνει ένα διαχρονικό μήνυμα… Ανακαλύψτε τον Σάιμον Πότερ, έναν καταπληκτικό ρακοσυλλέκτη, που σώζει ανθρώπους που έχουν απελπιστεί από τη ζωή και μάθετε τους τέσσερις απλούς κανόνες που θα σας επιτρέψουν να πραγματοποιήσετε ένα θαύμα στη δική σας ζωή.",
                            ImageUrl = "https://www.dioptra.gr/Cache/Photos/5aa101be928429da388563300ace701d.png",
                            Price = 20.00m,
                            Title = "Το μεγαλύτερο θαύμα στον κόσμο"
                        },
                        new
                        {
                            id = 3,
                            CategoryId = 1,
                            Description = "Ένα απρόσμενο λάθος από τις Μοίρες αλλάζει τη ζωή ενός κοριτσιού. Κινούμενου στο χώρο του μαγικού ρεαλισμού και της και της φανταστικής λογοτεχνίας, το βιβλίο συνυφαίνει την πορεία της ηρωίδας με τη δύναμη του πεπρωμένου. Στην πλοκή στροβιλίζονται η σκληρότητα του πατέρα, οι δισταγμοί της μάνας, η εχθρότητα ενός χωριού και ο έρωτας της κόρης. Μπορεί κανείς άραγε ν` αλλάξει τη μοίρα του",
                            ImageUrl = "https://www.lavyrinthos.net/images/products/ext/osd_1094481.jpg",
                            Price = 17.99m,
                            Title = "Τα πράσινα, τα καστανά και τα μαύρα μάτια!"
                        },
                        new
                        {
                            id = 4,
                            CategoryId = 2,
                            Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                            Price = 0m,
                            Title = "The Matrix"
                        },
                        new
                        {
                            id = 5,
                            CategoryId = 2,
                            Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                            Price = 0m,
                            Title = "Back to the Future"
                        },
                        new
                        {
                            id = 6,
                            CategoryId = 2,
                            Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
                            Price = 0m,
                            Title = "Toy Story"
                        },
                        new
                        {
                            id = 7,
                            CategoryId = 3,
                            Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                            Price = 0m,
                            Title = "Half-Life 2"
                        },
                        new
                        {
                            id = 8,
                            CategoryId = 3,
                            Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                            Price = 0m,
                            Title = "Diablo II"
                        },
                        new
                        {
                            id = 9,
                            CategoryId = 3,
                            Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                            Price = 0m,
                            Title = "Day of the Tentacle"
                        },
                        new
                        {
                            id = 10,
                            CategoryId = 3,
                            Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                            Price = 0m,
                            Title = "Xbox"
                        },
                        new
                        {
                            id = 11,
                            CategoryId = 3,
                            Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                            Price = 0m,
                            Title = "Super Nintendo Entertainment System"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.HasOne("BlazorEcommerce.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
