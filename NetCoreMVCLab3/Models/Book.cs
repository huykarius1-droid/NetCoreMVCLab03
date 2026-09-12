using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;



namespace NetCoreMVCLab3.Models
{
    public class Book
    {
        public int Id { get; set; } 
        public string Title { get; set; } 
        public int AuthorId { get; set; }
        public int GenreId { get; set; }    
        public string Image {  get; set; } 
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; } 

        //Dánh sách các cuốn sách
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                 new Book()
                 {
                     Id = 1,
                     Title = "Chí Phèo",
                     AuthorId = 1,
                     GenreId = 1,
                     Image = "/images/products/b1.jpg",
                     Price = 500000,
                     Sumary = "",
                     TotalPage = 250
                 },
                 new Book()
                 {
                     Id = 2,
                     Title = "Tắt đèn",
                     AuthorId = 2,
                     GenreId = 2,
                     Image = "/images/products/b1.jpg",
                     Price = 450000,
                     Sumary = "",
                     TotalPage = 500
                 },
                 new Book()
                 {
                     Id = 3,
                     Title = "Đất nước",
                     AuthorId = 3,
                     GenreId = 3,
                     Image = "/images/products/b1.jpg",
                     Price = 400000,
                     Sumary = "",
                     TotalPage = 100
                 },
                 new Book()
                 {
                     Id = 4,
                     Title = "Thám tử lừng danh Conan",
                     AuthorId = 4,
                     GenreId = 4,
                     Image = "/images/products/b1.jpg",
                     Price = 600000,
                     Sumary = "",
                     TotalPage = 1000
                 }
            };

            return books;
        }
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }
        // SelectListItem Authors (using Microsoft.AspNetCore.Mvc.Rendering)
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value="1", Text="Nam cao"},
            new SelectListItem {Value="2", Text="Ngô Tất Tố"},
            new SelectListItem {Value="3", Text="Nguyễn Khoa Diềm"},
            new SelectListItem {Value="4", Text="Thiền sư Thích Nhất Hạnh"}
        };

        // SelectListItem Genres
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1", Text="Truyện tranh"},
            new SelectListItem{Value="2", Text="Văn học đương đại"},
            new SelectListItem{Value="3", Text="Phật học phổ thông"},
            new SelectListItem{Value="4", Text="Truyện cười"}
        };
    }
}
