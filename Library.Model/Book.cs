namespace Library.Model
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;
         
        public int Number_of_pages { get; set; }

        public int Year_Create { get; set; }

        public int CategoryId { get; set; }
    }
}
