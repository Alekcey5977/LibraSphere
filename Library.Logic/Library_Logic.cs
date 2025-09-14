using Library.Model;
using Npgsql;

namespace Library.Logic
{
    public class Library_Logic
    {
        private readonly PostgresContext _context;

        public Library_Logic()
        {
            var connectionString = "Host=localhost;Port=5432;Database=Library_DB;Username=postgres;Password=admin";
            _context = new PostgresContext(connectionString);

        }

        public Book CreateBook(string title, string description, string author, int numberOfPages, int yearCreate, int categoryId)
        {
            using var conn = _context.GetConnection();
            using var cmd = new NpgsqlCommand(@"
                INSERT INTO books (title, description, author, number_of_pages, year_create, category_id)
                VALUES (@title, @description, @author, @number_of_pages, @year_create, @category_id)
                RETURNING id", conn);

            cmd.Parameters.AddWithValue("title", title);
            cmd.Parameters.AddWithValue("description", description);
            cmd.Parameters.AddWithValue("author", author);
            cmd.Parameters.AddWithValue("number_of_pages", numberOfPages);
            cmd.Parameters.AddWithValue("year_create", yearCreate);
            cmd.Parameters.AddWithValue("category_id", categoryId);

            var id = Convert.ToInt32(cmd.ExecuteScalar());

            return new Book
            {
                Id = id,
                Title = title,
                Description = description,
                Author = author,
                Number_of_pages = numberOfPages,
                Year_Create = yearCreate,
                CategoryId = categoryId
            };
        }

        public Category CreateCategory(string title)
        {
            using var conn = _context.GetConnection();
            using var cmd = new NpgsqlCommand(@"
                INSERT INTO categories (title)
                VALUES (@title)
                RETURNING id", conn);

            cmd.Parameters.AddWithValue("title", title);

            var id = Convert.ToInt32(cmd.ExecuteScalar());

            return new Category
            {
                Id = id,
                Title = title,
            };
        }
    }
}