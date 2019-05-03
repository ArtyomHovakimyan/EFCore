using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Mic.Volo.PFMCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {

            using (PFMDbContext db = new PFMDbContext())
            {
                Category[] categories = new Category[10];
                for (int i = 0; i < categories.Length; i++)
                {
                    categories[i] = new Category
                    {
                        
                        Title = "Title" + i.ToString(),
                        Description = "Desc" + i.ToString(),

                    };
                    db.Categories.Add(categories[i]);
                }
                db.SaveChanges();
            }

            //using (var db = new PFMDbContext())
            //{
            //    var categories = new Category[]
            //    {
            //        new Category
            //        {
            //            Title = "Cat 1"
            //        },
            //        new Category
            //        {
            //            Title = "Cat 2",
            //            Description = "Dummy desc"
            //        }
            //    };

            //    db.Categories.AddRange(categories);

            //    db.SaveChanges();

            //    var cat1 = db.Categories.FirstOrDefault(cat => cat.Title == "Cat 1");

            //    db.Wallets.Add(new Wallet
            //    {
            //        Amount = 50,
            //        Category = cat1,
            //        Date = DateTime.UtcNow
            //    });

            //    db.SaveChanges();

            //    var wallet1 = db.Wallets.Include(wallet => wallet.Category).First();

            //    var category = db.Categories.Include(cat => cat.Wallets).First();

            //    var target = db.Wallets.SingleOrDefault(p => p.WalletId == 1);

            //    if (target != null)
            //    {
            //        db.Wallets.Remove(target);
            //        db.SaveChanges();
            //    }

        }
    }
}

