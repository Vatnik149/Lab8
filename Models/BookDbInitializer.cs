using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookStore.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        // Переопределяем метод Seed для добавления начальных данных в базу данных
        protected override void Seed(BookContext db)
        {
            // Добавляем начальные данные (три книги) в базу данных
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л. Толстой", Price = 220, ImageUrl = "/Content/img/1.jpg" });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев", Price = 180,  ImageUrl = "/Content/img/2.jpg" });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов", Price = 150,  ImageUrl = "/Content/img/3.jpg" });

            // Вызываем базовый метод Seed для завершения процесса инициализации
            base.Seed(db);
        }
    }
}
