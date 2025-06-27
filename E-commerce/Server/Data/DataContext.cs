using E_commerce.Client.Services.ProductService;
using E_commerce.Shared;
using Microsoft.EntityFrameworkCore;


namespace E_commerce.Server.Data
{
    public class DataContext: DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product>Products {  get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Stats> Stats { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p =>new {p.ProductId,p.EditionId});
            modelBuilder.Entity<Category>().HasData(
                 new Category { Id = 1, Name = "Books", Url = "books", Icon = "book" },
             new Category { Id = 2, Name = "Electronics", Url = "electronics", Icon = "camera-slr" },
             new Category { Id = 3, Name = "video Games", Url = "video-games", Icon = "aperture" }
             );
            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     CategoryId = 1,
                     Title = "The Hitchhiker's Guide to the Galaxy",
                     Description = "The ........ somtiles referred to as HG2G, HHGTTG djjehfkfhkeh fhefhke fefhk fbhg fhzfvbzbzhvb hzfhzfbhzf vzvfzvfzvfzvfv fvzvzbvfzbv nzvfnzvfvzfnzvnv vfznvfnzbvfnzvfvzfnvzfnzbvfvzbzfvzfnzvfnzvfz",
                     Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    
                     DateCreated = new DateTime(2024,4,18) ,

                 },

              new Product
              {

                  Id = 2,
                  CategoryId = 3,
                  Title = "Half-life 2",
                  Description = "Half-life is 2004 fkejfnjkefnejfehfbhebefb bhfbefbebf bebfe,nfbenb enfbebfne,fben,fbe,n fbe,nfbe,nfbe,nbf;enfn;afn;anffn; n;efbb eanbfneafaefneafneakfmk ,fa,f,afmkae mkfkea fnanfanef;aefn ;,aenf;,aefn ;,anf;,anz; fna;zn ;fn;,f n;fa",
                  Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
               
                  DateCreated = new DateTime(2024, 4, 18),
              },

               new Product
               {
                   Id = 3,
                   CategoryId = 1,
                   Title = "nineteen forty-four",
                   Description = "Nineteen Eighty-Four: A Novel, often published as 1984, is a dystopian social science fiction novel by English novelist",
                   Image = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",            
                   DateCreated = new DateTime(2024, 4, 18),

               },
  new Product
  {

      Id = 4,
      CategoryId = 2,
      Title = "The Pentax Spotmatic",
      Description = "The Pentax Spotmatic refers to a family of 35mm single-lens reflex cameras manufactured by the Asahi Optical Co. Ltd..",
      Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
      
      DateCreated = new DateTime(2024, 4, 18),
  },
   new Product
   {
       Id = 8,
       CategoryId = 3,
       Title = "Diablo II",
       Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by",
       Image = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
       
       DateCreated = new DateTime(2024, 4, 18),

   },
    new Product
    {
        Id = 9,
        CategoryId = 3,
        Title = "Day of the Tentacle",
        Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed",
        Image = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.ipg",
     
        DateCreated = new DateTime(2024, 4, 18),

    }
                );

            modelBuilder.Entity<Edition>().HasData(
                new Edition { Id = 1, Name = "Default" },
               new Edition {Id=2, Name= "Paperback" },
                new Edition { Id = 3, Name = "E-Book" },
                 new Edition { Id = 4, Name = "Audiobook" },
                 new Edition { Id = 5, Name = "pc" },
                 new Edition { Id = 6, Name = "PlayStation" },
                new Edition { Id = 7, Name = "xbox" }
               );

            //modelBuilder.SharedTypeEntity<Dictionary<string, object>>("EditionProduct", b =>
            //{
            //    b.Property<int>("EditionsId"); // Explicitly define property type
            //    b.Property<int>("ProductsId"); // Explicitly define property type
            //    b.HasKey("EditionsId", "ProductsId"); // Define composite key
            //});

            //// Seed EditionProduct (Join Table)
            //modelBuilder.SharedTypeEntity<Dictionary<string, object>>("EditionProduct").HasData(
            //    new { EditionsId = 1, ProductsId = 1 },
            //    new { EditionsId = 2, ProductsId = 1 },
            //    new { EditionsId = 3, ProductsId = 1 },
            //    new { EditionsId = 1, ProductsId = 2 },
            //    new { EditionsId = 2, ProductsId = 2 },
            //    new { EditionsId = 4, ProductsId = 7 },
            //    new { EditionsId = 5, ProductsId = 7 },
            //    new { EditionsId = 6, ProductsId = 7 }
            //);

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 2,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 3,
                    Price = 7.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 4,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 2,
                    Price = 7.99m,
                    OriginalPrice = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 2,
                    Price = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 1,
                    Price = 166.66m,
                    OriginalPrice = 249.00m
                },
                
        
               
                new ProductVariant
                {
                    ProductId = 8,
                    EditionId = 6,
                    Price = 69.99m
                },
                
                new ProductVariant
                {
                    ProductId = 8,
                    EditionId = 5,
                    Price = 9.99m,
                    OriginalPrice = 24.99m,
                },
                new ProductVariant
                {
                    ProductId = 9,
                    EditionId = 5,
                    Price = 14.99m
                }
            );

        }
    }
}
