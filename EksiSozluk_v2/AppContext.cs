
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EksiSozluk_v2
{
    public class AppDbContext : DbContext
    {
        public DbSet<Entities> Entities { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Details> Details { get; set; }
        public DbSet<Comments> Comments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder

         optionBuilder)
        {
            //DESKTOP - S0CBLLS\SQLEXPRESS
            optionBuilder.UseSqlServer(@"server=.\SQLEXPRESS;Database=eksisozluk_v2;uid=sa;pwd=123");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<Entities>().ToTable("Girisler"); 
            modelBuilder.Entity<Users>().ToTable("Kullanıcılar");
            modelBuilder.Entity<Details>().ToTable("Ayrıntılar");
            modelBuilder.Entity<Comments>().ToTable("Yorumlar"); 

            //Entities Tablosu
            modelBuilder.Entity<Entities>().HasKey(c => c.ID); 
            modelBuilder.Entity<Entities>().Property(c => c.Name)
                .HasMaxLength(100) 
                .IsRequired() 
                .HasColumnName("Baslik");
            modelBuilder.Entity<Entities>().Property(c => c.Details_)
             .HasMaxLength(300) 
             .HasColumnName("DetayID");
            modelBuilder.Entity<Entities>().Property(c => c.Users_)
               .HasMaxLength(300)
               .HasColumnName("KullanıcıID");
            modelBuilder.Entity<Entities>().Property(c => c.Comments_)
              .HasMaxLength(300) 
              .HasColumnName("YorumID");
            modelBuilder.Entity<Entities>().Property(c => c.CreationDate)
              .HasColumnName("Olusturulma_Tarihi");

            //Users Tablosu
            modelBuilder.Entity<Users>().HasKey(c => c.UserID); 
            modelBuilder.Entity<Users>().Property(c => c.Name)
                .HasMaxLength(100) 
                .IsRequired() 
                .HasColumnName("AdSoyad");
            modelBuilder.Entity<Users>().Property(c => c.Gender)
               .HasMaxLength(1) 
               .HasColumnName("Cinsiyet");
            modelBuilder.Entity<Users>().Property(c => c.RegisterDate)
                .HasColumnName("Kayit_Tarihi");


            //Details Tablosu
            modelBuilder.Entity<Details>().HasKey(c => c.DetailsID); 
            modelBuilder.Entity<Details>().Property(c => c.Description)
                .HasMaxLength(300) 
                .IsRequired() 
                .HasColumnName("Aciklama");
            modelBuilder.Entity<Details>().Property(c => c.Date)
            .HasColumnName("Tarih");

            //Comments Tablosu
            modelBuilder.Entity<Comments>().HasKey(c => c.CommentsID); 
            modelBuilder.Entity<Comments>().Property(c => c.Description)
                .HasMaxLength(300) 
                .IsRequired() 
                .HasColumnName("Aciklama");
            modelBuilder.Entity<Comments>().Property(c => c.PostDate)
            .HasColumnName("Yorum_Tarihi");


            // Relation...

            modelBuilder.Entity<Entities>()
                .HasMany(c => c.Users_)
                .WithOne(c => c.Entities1)
                .HasForeignKey(c => c.UserID);


            modelBuilder.Entity<Entities>()
                .HasMany(c => c.Details_)
                .WithOne(c => c.Entities2)
                .HasForeignKey(c => c.DetailsID);

            modelBuilder.Entity<Entities>()
              .HasMany(c => c.Comments_)
              .WithOne(c => c.Entities3)
              .HasForeignKey(c => c.CommentsID);



            // modelBuilder.Entity<FluentApi_Kitap>().HasOne(a => a.FluentApi_KitapDetay).WithOne(a => a.FluentApi_Kitap).HasForeignKey<FluentApi_Kitap>("KitapDetay_Id");

            /* // Relation...
             modelBuilder.Entity<Products>()
                 .HasOne(c => c.Categories)
                 .WithMany(c => c.Products)
                 .HasForeignKey(c => c.KatId);
            */

        }
    }
}
