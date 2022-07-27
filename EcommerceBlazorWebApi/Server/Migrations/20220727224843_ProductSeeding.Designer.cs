﻿// <auto-generated />
using EcommerceBlazorWebApi.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceBlazorWebApi.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220727224843_ProductSeeding")]
    partial class ProductSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EcommerceBlazorWebApi.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "It Ends with Us focuses on Lily Bloom, a young college graduate who moves to Boston and opens her own floral business. She develops feelings for surgeon Ryle Kincaid, who is initially reluctant toward having a serious relationship with her. As their relationship blossoms, Lily has a sudden encounter with her first love Atlas Corrigan. This reintroduction of Atlas threatens her relationship with Ryle, and forces her to come to terms with the trauma of her past and present. Lily is forced to make a difficult decision between her two loves and what is the best for her life. In the novel's conclusion, Lily ends up with Atlas after Ryle abuses her like her father abused her mother.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/e4/It_Ends_with_Us_%28Colleen_Hoover%29.png?20220211120153",
                            Price = 17.99m,
                            Title = "IT ENDS WITH US"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Every day without fail, Travis Devine puts on a cheap suit, grabs his faux-leather briefcase, and boards the 6:20 commuter train to Manhattan, where he works as an entry-level analyst at the city's most prestigious investment firm. In the mornings, he gazes out the train window at the lavish homes of the uberwealthy, dreaming about joining their ranks. In the evenings, he listens to the fiscal news on his phone, already preparing for the next grueling day in the cutthroat realm of finance. Then one morning Devine's tedious routine is shattered by an anonymous email: She is dead.",
                            ImageUrl = "data:image/jpeg;base64,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",
                            Price = 11.99m,
                            Title = "THE 6:20 MAN"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Behind a smokescreen of “preparing students for the new industrial economy,” early progressives had political control in mind. America’s original schools didn’t just make kids memorize facts or learn skills; they taught them to think freely and arrive at wisdom. They assigned the classics, inspired love of God and country, and raised future citizens that changed the world forever. ",
                            ImageUrl = "data:image/jpeg;base64,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",
                            Price = 13.64m,
                            Title = "BATTLE FOR THE AMERICAN MIND"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
