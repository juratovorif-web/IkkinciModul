namespace lesson_2.Models;

internal class Book
{
    public Guid BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public DateTime Created { get; set; }
    public string Genre { get; set; }
    public int PageCount { get; set; }

}
