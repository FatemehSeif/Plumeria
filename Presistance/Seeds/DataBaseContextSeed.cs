using Domain.Catalogs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presistance.Seeds
{
    public class DataBaseContextSeed
    {
        public static void CatalogSeed(ModelBuilder modelBuilder)
        {
            foreach (var catalog in GetCatalogTypes())
            {
                modelBuilder.Entity<CatalogType>().HasData(catalog);
            }
            foreach (var brand in GetCatalogBrands())
            {
                modelBuilder.Entity<CatalogBrand>().HasData(brand);
            }
        }


        private static IEnumerable<CatalogType> GetCatalogTypes()
        {
            return new List<CatalogType>()
            {
                 new CatalogType() { Id=1, Type="محصولات تراست"},

                 new CatalogType() {Id = 2, Type = "مراقبت از مو",ParentCatalogTypeId=1},

                 new CatalogType() { Id= 3, Type="مراقبت از بدن",ParentCatalogTypeId=1 },

                 new CatalogType() { Id= 4, Type="عطر و آرایشی", ParentCatalogTypeId = 1},

                 new CatalogType() { Id= 5, Type="مراقبت از دهان و دندان" , ParentCatalogTypeId = 1},

                 new CatalogType() { Id=6, Type="مراقبت از پوست", ParentCatalogTypeId = 1},

                

      new CatalogType() { Id=7, Type="پن"},

      new CatalogType() { Id=8, Type="صابون"},

      new CatalogType() { Id=9, Type="کرم"},

      new CatalogType() { Id=10, Type="بالم لب"},

      new CatalogType() { Id=11, Type="ضدآقتاب"},

      new CatalogType() { Id=12, Type="ماسک صورت"},

      new CatalogType() { Id=13, Type="ناحیه چشم"},

      new CatalogType() { Id=14, Type="سرم و روغن"},

      new CatalogType() { Id=15, Type="کیت ها"},



       new CatalogType() { Id=16, Type="شامپو"},

       new CatalogType() { Id=17, Type="ماسک مو"},

       new CatalogType() { Id=18, Type="تونیک"},

       new CatalogType() { Id=19, Type="سرم مو"},

       new CatalogType() { Id=20, Type="روغن مو"},

       new CatalogType() { Id=21, Type="کیت رویش مجدد موی سر"},



       new CatalogType() { Id=22, Type="شامپو بدن"},

       new CatalogType() { Id=23, Type="کرم"},

       new CatalogType() { Id=24, Type="روغن و لوسیون"},

       new CatalogType() { Id=25, Type="خوشبو کننده و ضد تعریق"},

       new CatalogType() { Id=26, Type="مایع دستشویی"},



         new CatalogType() { Id=27, Type="کرمBB"},

         new CatalogType() { Id=28, Type="کرمCC"},

         new CatalogType() { Id=29, Type="کرمDD"},

         new CatalogType() { Id=30, Type="کانسیلر"},

         new CatalogType() { Id=31, Type="پرفیوم و ادوپرفیوم"},

         new CatalogType() { Id=32, Type="بادی میست"},





          new CatalogType() { Id=33, Type="خمیر دندان"},

          new CatalogType() { Id=34, Type="دهانشویه"},

          new CatalogType() { Id=35, Type="خوشبو کننده دهان"},

            new CatalogType() { Id=36, Type="محصولات تراست"},

           new CatalogType() { Id=37, Type="خوشبو کننده هوا"},

             new CatalogType() { Id=38, Type="پاک‌کننده و شوینده"},

            };

        }



        private static IEnumerable<CatalogBrand> GetCatalogBrands()

        {

            return new List<CatalogBrand>()

            {

     new CatalogBrand() { Id=1, Brand = "تراست پروفشنال" },

     new CatalogBrand() { Id=2, Brand = "تراست اسمارت" },

     new CatalogBrand() { Id=3, Brand = "لایف گارد" },

     new CatalogBrand() { Id=4, Brand = "کلاس یک" },



            };

        }

    }
}
