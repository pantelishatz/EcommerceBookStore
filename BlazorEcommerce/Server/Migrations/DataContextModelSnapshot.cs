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

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

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

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Description = "Το μοναδικό ανέκδοτο έργο του Νίκου Καζαντζάκη. Ο μεγάλος Έλληνας λογοτέχνης γράφει με ένταση και αγωνία υπαρξιακή, αναλογιζόμενος όλα τα μεγάλα ερωτήματα, που ταλανίζουν τους ανθρώπους μέχρι και σήμερα.",
                            ImageUrl = "https://www.dioptra.gr/Cache/Photos/ac6a19676b8a98d09ab782bc15660274.png",
                            Price = 19.99m,
                            Title = "Ο Ανήφορος"
                        },
                        new
                        {
                            id = 2,
                            Description = "Το μεγαλύτερο θαύμα στον κόσμο προσφέρει μια ανεκτίμητη σοφία σε όσους ψάχνουν για ένα ανώτερο μήνυμα και σκοπό στη ζωή τους. Το νέο best seller του Ογκ Μαντίνο είναι μια μαγευτική αφήγηση που αποκαλύπτει εντυπωσιακά μυστικά για προσωπική ευτυχία και επαγγελματική επιτυχία, και περιλαμβάνει ένα διαχρονικό μήνυμα… Ανακαλύψτε τον Σάιμον Πότερ, έναν καταπληκτικό ρακοσυλλέκτη, που σώζει ανθρώπους που έχουν απελπιστεί από τη ζωή και μάθετε τους τέσσερις απλούς κανόνες που θα σας επιτρέψουν να πραγματοποιήσετε ένα θαύμα στη δική σας ζωή.",
                            ImageUrl = "https://www.dioptra.gr/Cache/Photos/5aa101be928429da388563300ace701d.png",
                            Price = 20.00m,
                            Title = "Το μεγαλύτερο θαύμα στον κόσμο"
                        },
                        new
                        {
                            id = 3,
                            Description = "Ένα απρόσμενο λάθος από τις Μοίρες αλλάζει τη ζωή ενός κοριτσιού. Κινούμενου στο χώρο του μαγικού ρεαλισμού και της και της φανταστικής λογοτεχνίας, το βιβλίο συνυφαίνει την πορεία της ηρωίδας με τη δύναμη του πεπρωμένου. Στην πλοκή στροβιλίζονται η σκληρότητα του πατέρα, οι δισταγμοί της μάνας, η εχθρότητα ενός χωριού και ο έρωτας της κόρης. Μπορεί κανείς άραγε ν` αλλάξει τη μοίρα του",
                            ImageUrl = "https://www.lavyrinthos.net/images/products/ext/osd_1094481.jpg",
                            Price = 17.99m,
                            Title = "Τα πράσινα, τα καστανά και τα μαύρα μάτια!"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
