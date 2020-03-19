using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kateoriler = new List<Category>()
            {
                new Category()
                {
                    Name = "Kamera",
                    Description = "Kamera Ürünleri",

                },
                new Category()
                {
                    Name = "Bilgisayar",
                    Description = "Bilgisayar Ürünleri",
                },
                new Category()
                {
                    Name = "Elektronik",
                    Description = "Elektronik Ürünleri",
                },
                new Category()
                {
                    Name = "Telefon",
                    Description = "Telefon Ürünleri",
                },
                new Category()
                {
                    Name = "Beyaz Eşya",
                    Description = "Beyaz Eşya Ürünleri",
                },
            };

            foreach (var kategori in kateoriler)
            {
                context.Categories.Add(kategori);
            }

            context.SaveChanges();

            List<Product> urunler = new List<Product>()
            {
                new Product()
                {
                    Name = "Case 4U GoPro Sjcam Xiaomi Eken Aksiyon Kamerası Aksesuar Seti",
                    Price = 129.41,
                    Stock = 20,
                    IsApproved = false,
                    CategoryId = 1,
                    Description = "Lenovo V330-15IKB Intel Core i5 8250U 8GB 1TB + 240GB SSD Radeon 530 Freedos 15.6 FHD Taşınabilir Bilgisayar 81AX00DQTXF Full HD ekran çözünürlüğüyle muhteşem netlikte görüntüleme deneyimi sunan model, 15.6 inç büyüklüğündeki ekran paneliyle kullanıcılarına alışılmışın dışında bir işlevsellik sağlıyor. Ev konforunda eğlenceli içeriklerin tadını çıkarmanıza yardımcı olan aygıt, şık tasarımıyla da görenleri kendisine hayran bırakmayı başarıyor. Lenovo V ailesinin en gözde modeli olarak ön planda yer alan ve popülaritesini artırarak korumayı başaran taşınabilir bilgisayar yansımasız ekranı sayesinde oldukça kaliteli bir performans sergiliyor. Birçok yönden kullanıcılarına ayrıcalık tanıyan ve alışılmışın dışında bir kullanım deneyimi sunan model, çeşitli özellikleri ile kullanıcılarına bambaşka bir kullanım vadediyor.",
                    IsHome = true,
                    Image = "1.jpg"
                },
                new Product()
                {
                    Name = "Piranha Aksiyon Kamerası 12 Mp Hd Video Kayıt Su Geçirmez Kasa",
                    Price =118.80,
                    Stock = 30,
                    IsApproved = true,
                    CategoryId = 1,
                    Description = "Lenovo V330-15IKB Intel Core i5 8250U 8GB 1TB + 240GB SSD Radeon 530 Freedos 15.6 FHD Taşınabilir Bilgisayar 81AX00DQTXF Full HD ekran çözünürlüğüyle muhteşem netlikte görüntüleme deneyimi sunan model, 15.6 inç büyüklüğündeki ekran paneliyle kullanıcılarına alışılmışın dışında bir işlevsellik sağlıyor. Ev konforunda eğlenceli içeriklerin tadını çıkarmanıza yardımcı olan aygıt, şık tasarımıyla da görenleri kendisine hayran bırakmayı başarıyor. Lenovo V ailesinin en gözde modeli olarak ön planda yer alan ve popülaritesini artırarak korumayı başaran taşınabilir bilgisayar yansımasız ekranı sayesinde oldukça kaliteli bir performans sergiliyor. Birçok yönden kullanıcılarına ayrıcalık tanıyan ve alışılmışın dışında bir kullanım deneyimi sunan model, çeşitli özellikleri ile kullanıcılarına bambaşka bir kullanım vadediyor.",
                    IsHome = true,
                    Image = "1.jpg"

                },
                new Product()
                {
                    Name = "Hello 1080P Hd Dijital Suya Dayanıklı Aksiyon Kamera",
                    Price = 170.42,
                    Stock = 12,
                    IsApproved = false,
                    CategoryId = 1,
                    Description = "Lenovo V330-15IKB Intel Core i5 8250U 8GB 1TB + 240GB SSD Radeon 530 Freedos 15.6 FHD Taşınabilir Bilgisayar 81AX00DQTXF Full HD ekran çözünürlüğüyle muhteşem netlikte görüntüleme deneyimi sunan model, 15.6 inç büyüklüğündeki ekran paneliyle kullanıcılarına alışılmışın dışında bir işlevsellik sağlıyor. Ev konforunda eğlenceli içeriklerin tadını çıkarmanıza yardımcı olan aygıt, şık tasarımıyla da görenleri kendisine hayran bırakmayı başarıyor. Lenovo V ailesinin en gözde modeli olarak ön planda yer alan ve popülaritesini artırarak korumayı başaran taşınabilir bilgisayar yansımasız ekranı sayesinde oldukça kaliteli bir performans sergiliyor. Birçok yönden kullanıcılarına ayrıcalık tanıyan ve alışılmışın dışında bir kullanım deneyimi sunan model, çeşitli özellikleri ile kullanıcılarına bambaşka bir kullanım vadediyor.",
                    Image = "1.jpg"

                },
                new Product()
                {
                    Name = "SJCAM SJ4000 Air 4K Wifi Aksiyon Kamerası",
                    Price = 300.50,
                    Stock = 80,
                    IsApproved = true,
                    CategoryId = 1,
                    Description = "Lenovo V330-15IKB Intel Core i5 8250U 8GB 1TB + 240GB SSD Radeon 530 Freedos 15.6 FHD Taşınabilir Bilgisayar 81AX00DQTXF Full HD ekran çözünürlüğüyle muhteşem netlikte görüntüleme deneyimi sunan model, 15.6 inç büyüklüğündeki ekran paneliyle kullanıcılarına alışılmışın dışında bir işlevsellik sağlıyor. Ev konforunda eğlenceli içeriklerin tadını çıkarmanıza yardımcı olan aygıt, şık tasarımıyla da görenleri kendisine hayran bırakmayı başarıyor. Lenovo V ailesinin en gözde modeli olarak ön planda yer alan ve popülaritesini artırarak korumayı başaran taşınabilir bilgisayar yansımasız ekranı sayesinde oldukça kaliteli bir performans sergiliyor. Birçok yönden kullanıcılarına ayrıcalık tanıyan ve alışılmışın dışında bir kullanım deneyimi sunan model, çeşitli özellikleri ile kullanıcılarına bambaşka bir kullanım vadediyor.",
                    Image = "2.jpg"

                },
                new Product()
                {
                    Name = "Gplus EKEN Aksiyon Kamera Uyumlu Kafa Bandı ve Göğüs Kemeri Aksesuar Seti",
                    Price = 1200.30,
                    Stock = 48,
                    IsApproved = false,
                    CategoryId = 1,
                    Description = "Lenovo V330-15IKB Intel Core i5 8250U 8GB 1TB + 240GB SSD Radeon 530 Freedos 15.6 FHD Taşınabilir Bilgisayar 81AX00DQTXF Full HD ekran çözünürlüğüyle muhteşem netlikte görüntüleme deneyimi sunan model, 15.6 inç büyüklüğündeki ekran paneliyle kullanıcılarına alışılmışın dışında bir işlevsellik sağlıyor. Ev konforunda eğlenceli içeriklerin tadını çıkarmanıza yardımcı olan aygıt, şık tasarımıyla da görenleri kendisine hayran bırakmayı başarıyor. Lenovo V ailesinin en gözde modeli olarak ön planda yer alan ve popülaritesini artırarak korumayı başaran taşınabilir bilgisayar yansımasız ekranı sayesinde oldukça kaliteli bir performans sergiliyor. Birçok yönden kullanıcılarına ayrıcalık tanıyan ve alışılmışın dışında bir kullanım deneyimi sunan model, çeşitli özellikleri ile kullanıcılarına bambaşka bir kullanım vadediyor.",
                    IsHome = true,
                    Image = "3.jpg"

                },

                new Product()
                {
                    Name = "Samsung Galaxy A50 2019 64 GB (Samsung Türkiye Garantili)",
                    Price = 2229.89,
                    Stock = 60,
                    IsApproved = true,
                    CategoryId = 4,
                    Description = "Lenovo V330-15IKB Intel Core i5 8250U 8GB 1TB + 240GB SSD Radeon 530 Freedos 15.6 FHD Taşınabilir Bilgisayar 81AX00DQTXF Full HD ekran çözünürlüğüyle muhteşem netlikte görüntüleme deneyimi sunan model, 15.6 inç büyüklüğündeki ekran paneliyle kullanıcılarına alışılmışın dışında bir işlevsellik sağlıyor. Ev konforunda eğlenceli içeriklerin tadını çıkarmanıza yardımcı olan aygıt, şık tasarımıyla da görenleri kendisine hayran bırakmayı başarıyor. Lenovo V ailesinin en gözde modeli olarak ön planda yer alan ve popülaritesini artırarak korumayı başaran taşınabilir bilgisayar yansımasız ekranı sayesinde oldukça kaliteli bir performans sergiliyor. Birçok yönden kullanıcılarına ayrıcalık tanıyan ve alışılmışın dışında bir kullanım deneyimi sunan model, çeşitli özellikleri ile kullanıcılarına bambaşka bir kullanım vadediyor.",
                    Image = "4.jpg"

                },
                new Product()
                {
                    Name = "Huawei Mate 20 Lite 64 GB (Huawei Türkiye Garantili)",
                    Price = 2144.00,
                    Stock = 102,
                    IsApproved = false,
                    CategoryId = 4,
                    Description = "Lenovo V330-15IKB Intel Core i5 8250U 8GB 1TB + 240GB SSD Radeon 530 Freedos 15.6 FHD Taşınabilir Bilgisayar 81AX00DQTXF Full HD ekran çözünürlüğüyle muhteşem netlikte görüntüleme deneyimi sunan model, 15.6 inç büyüklüğündeki ekran paneliyle kullanıcılarına alışılmışın dışında bir işlevsellik sağlıyor. Ev konforunda eğlenceli içeriklerin tadını çıkarmanıza yardımcı olan aygıt, şık tasarımıyla da görenleri kendisine hayran bırakmayı başarıyor. Lenovo V ailesinin en gözde modeli olarak ön planda yer alan ve popülaritesini artırarak korumayı başaran taşınabilir bilgisayar yansımasız ekranı sayesinde oldukça kaliteli bir performans sergiliyor. Birçok yönden kullanıcılarına ayrıcalık tanıyan ve alışılmışın dışında bir kullanım deneyimi sunan model, çeşitli özellikleri ile kullanıcılarına bambaşka bir kullanım vadediyor.",
                    Image = "2.jpg"
                },

                new Product()
                {
                    Name = "Xiaomi Redmi Note 6 Pro 64 GB (İthalatçı Garantili)",
                    Price = 1499.00,
                    Stock = 200,
                    IsApproved = false,
                    CategoryId = 4,
                    Description = "Lenovo V330-15IKB Intel Core i5 8250U 8GB 1TB + 240GB SSD Radeon 530 Freedos 15.6 FHD Taşınabilir Bilgisayar 81AX00DQTXF Full HD ekran çözünürlüğüyle muhteşem netlikte görüntüleme deneyimi sunan model, 15.6 inç büyüklüğündeki ekran paneliyle kullanıcılarına alışılmışın dışında bir işlevsellik sağlıyor. Ev konforunda eğlenceli içeriklerin tadını çıkarmanıza yardımcı olan aygıt, şık tasarımıyla da görenleri kendisine hayran bırakmayı başarıyor. Lenovo V ailesinin en gözde modeli olarak ön planda yer alan ve popülaritesini artırarak korumayı başaran taşınabilir bilgisayar yansımasız ekranı sayesinde oldukça kaliteli bir performans sergiliyor. Birçok yönden kullanıcılarına ayrıcalık tanıyan ve alışılmışın dışında bir kullanım deneyimi sunan model, çeşitli özellikleri ile kullanıcılarına bambaşka bir kullanım vadediyor.",
                    IsHome = true,
                    Image = "3.jpg"
                },
                new Product()
                {
                    Name = "Huawei P Smart 2019 64 GB (Huawei Türkiye Garantili)",
                    Price = 1658.00,
                    Stock = 83,
                    IsApproved = true,
                    CategoryId = 4,
                    Description = "Lenovo V330-15IKB Intel Core i5 8250U 8GB 1TB + 240GB SSD Radeon 530 Freedos 15.6 FHD Taşınabilir Bilgisayar 81AX00DQTXF Full HD ekran çözünürlüğüyle muhteşem netlikte görüntüleme deneyimi sunan model, 15.6 inç büyüklüğündeki ekran paneliyle kullanıcılarına alışılmışın dışında bir işlevsellik sağlıyor. Ev konforunda eğlenceli içeriklerin tadını çıkarmanıza yardımcı olan aygıt, şık tasarımıyla da görenleri kendisine hayran bırakmayı başarıyor. Lenovo V ailesinin en gözde modeli olarak ön planda yer alan ve popülaritesini artırarak korumayı başaran taşınabilir bilgisayar yansımasız ekranı sayesinde oldukça kaliteli bir performans sergiliyor. Birçok yönden kullanıcılarına ayrıcalık tanıyan ve alışılmışın dışında bir kullanım deneyimi sunan model, çeşitli özellikleri ile kullanıcılarına bambaşka bir kullanım vadediyor.",
                    IsHome = true,
                    Image = "4.jpg"
                },

                new Product()
                {
                    Name = "Asus FX505GD-BQ108 Intel Core i5 8300H 8GB 256GB SSD GTX1050 Freedos 15.6",
                    Price = 5525.00,
                    Stock = 83,
                    IsApproved = true,
                    CategoryId = 2,
                    Description = "Lenovo V330-15IKB Intel Core i5 8250U 8GB 1TB + 240GB SSD Radeon 530 Freedos 15.6 FHD Taşınabilir Bilgisayar 81AX00DQTXF Full HD ekran çözünürlüğüyle muhteşem netlikte görüntüleme deneyimi sunan model, 15.6 inç büyüklüğündeki ekran paneliyle kullanıcılarına alışılmışın dışında bir işlevsellik sağlıyor. Ev konforunda eğlenceli içeriklerin tadını çıkarmanıza yardımcı olan aygıt, şık tasarımıyla da görenleri kendisine hayran bırakmayı başarıyor. Lenovo V ailesinin en gözde modeli olarak ön planda yer alan ve popülaritesini artırarak korumayı başaran taşınabilir bilgisayar yansımasız ekranı sayesinde oldukça kaliteli bir performans sergiliyor. Birçok yönden kullanıcılarına ayrıcalık tanıyan ve alışılmışın dışında bir kullanım deneyimi sunan model, çeşitli özellikleri ile kullanıcılarına bambaşka bir kullanım vadediyor.",
                    Image = "5.jpg"
                },
                new Product()
                {
                    Name = "Dell Inspiron 3585 AMD Ryzen 3 2200U 4GB 1TB Linux 15.6 HD Taşınabilir Bilgisayar ",
                    Price = 1499.00,
                    Stock = 200,
                    IsApproved = false,
                    CategoryId = 2,
                    Description = "Lenovo V330-15IKB Intel Core i5 8250U 8GB 1TB + 240GB SSD Radeon 530 Freedos 15.6 FHD Taşınabilir Bilgisayar 81AX00DQTXF Full HD ekran çözünürlüğüyle muhteşem netlikte görüntüleme deneyimi sunan model, 15.6 inç büyüklüğündeki ekran paneliyle kullanıcılarına alışılmışın dışında bir işlevsellik sağlıyor. Ev konforunda eğlenceli içeriklerin tadını çıkarmanıza yardımcı olan aygıt, şık tasarımıyla da görenleri kendisine hayran bırakmayı başarıyor. Lenovo V ailesinin en gözde modeli olarak ön planda yer alan ve popülaritesini artırarak korumayı başaran taşınabilir bilgisayar yansımasız ekranı sayesinde oldukça kaliteli bir performans sergiliyor. Birçok yönden kullanıcılarına ayrıcalık tanıyan ve alışılmışın dışında bir kullanım deneyimi sunan model, çeşitli özellikleri ile kullanıcılarına bambaşka bir kullanım vadediyor.",
                    IsHome = true,
                    Image = "3.jpg"
                },
                new Product()
                {
                    Name = "Asus FX505DT-BQ190 AMD Ryzen 5 3550H 8GB 1TB + 256GB SSD GTX1650 Freedos",
                    Price = 1499.00,
                    Stock = 200,
                    IsApproved = true,
                    CategoryId = 2,
                    Description = "Lenovo V330-15IKB Intel Core i5 8250U 8GB 1TB + 240GB SSD Radeon 530 Freedos 15.6 FHD Taşınabilir Bilgisayar 81AX00DQTXF Full HD ekran çözünürlüğüyle muhteşem netlikte görüntüleme deneyimi sunan model, 15.6 inç büyüklüğündeki ekran paneliyle kullanıcılarına alışılmışın dışında bir işlevsellik sağlıyor. Ev konforunda eğlenceli içeriklerin tadını çıkarmanıza yardımcı olan aygıt, şık tasarımıyla da görenleri kendisine hayran bırakmayı başarıyor. Lenovo V ailesinin en gözde modeli olarak ön planda yer alan ve popülaritesini artırarak korumayı başaran taşınabilir bilgisayar yansımasız ekranı sayesinde oldukça kaliteli bir performans sergiliyor. Birçok yönden kullanıcılarına ayrıcalık tanıyan ve alışılmışın dışında bir kullanım deneyimi sunan model, çeşitli özellikleri ile kullanıcılarına bambaşka bir kullanım vadediyor.",
                    Image = "2.jpg"
                },
                new Product()
                {
                    Name = "Dell Inspiron 3580 Intel Core i5 8265U 8GB 1TB Radeon 520 Linux15.6 FHD Taşınabilir ",
                    Price = 1499.00,
                    Stock = 200,
                    IsApproved = true,
                    CategoryId = 2,
                    Description = "Lenovo V330-15IKB Intel Core i5 8250U 8GB 1TB + 240GB SSD Radeon 530 Freedos 15.6 FHD Taşınabilir Bilgisayar 81AX00DQTXF Full HD ekran çözünürlüğüyle muhteşem netlikte görüntüleme deneyimi sunan model, 15.6 inç büyüklüğündeki ekran paneliyle kullanıcılarına alışılmışın dışında bir işlevsellik sağlıyor. Ev konforunda eğlenceli içeriklerin tadını çıkarmanıza yardımcı olan aygıt, şık tasarımıyla da görenleri kendisine hayran bırakmayı başarıyor. Lenovo V ailesinin en gözde modeli olarak ön planda yer alan ve popülaritesini artırarak korumayı başaran taşınabilir bilgisayar yansımasız ekranı sayesinde oldukça kaliteli bir performans sergiliyor. Birçok yönden kullanıcılarına ayrıcalık tanıyan ve alışılmışın dışında bir kullanım deneyimi sunan model, çeşitli özellikleri ile kullanıcılarına bambaşka bir kullanım vadediyor.",
                    IsHome = true,
                    Image = "4.jpg"
                },

                new Product()
                {
                    Name = "Lenovo Ideapad S145-14IWL Intel Celeron 4205U 4GB 128GB SSD Freedos 14 ",
                    Price = 1499.00,
                    Stock = 200,
                    IsApproved = true,
                    CategoryId = 2,
                    Description = "Lenovo V330-15IKB Intel Core i5 8250U 8GB 1TB + 240GB SSD Radeon 530 Freedos 15.6 FHD Taşınabilir Bilgisayar 81AX00DQTXF Full HD ekran çözünürlüğüyle muhteşem netlikte görüntüleme deneyimi sunan model, 15.6 inç büyüklüğündeki ekran paneliyle kullanıcılarına alışılmışın dışında bir işlevsellik sağlıyor. Ev konforunda eğlenceli içeriklerin tadını çıkarmanıza yardımcı olan aygıt, şık tasarımıyla da görenleri kendisine hayran bırakmayı başarıyor. Lenovo V ailesinin en gözde modeli olarak ön planda yer alan ve popülaritesini artırarak korumayı başaran taşınabilir bilgisayar yansımasız ekranı sayesinde oldukça kaliteli bir performans sergiliyor. Birçok yönden kullanıcılarına ayrıcalık tanıyan ve alışılmışın dışında bir kullanım deneyimi sunan model, çeşitli özellikleri ile kullanıcılarına bambaşka bir kullanım vadediyor.",
                    Image = "1.jpg"

                },
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();
            base.Seed(context);
        }
    }
}