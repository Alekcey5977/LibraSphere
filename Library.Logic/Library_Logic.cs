using Library.Model;
using Npgsql;
using System.Data;

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

        public bool DeleteBook(int id)
        {
            using var conn = _context.GetConnection();
            using var cmd = new NpgsqlCommand("DELETE FROM books WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("id", id);
            return cmd.ExecuteNonQuery() > 0;
        }

        public Book? GetBookById(int id)
        {
            using var conn = _context.GetConnection();
            using var cmd = new NpgsqlCommand("SELECT * FROM books WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return MapBook(reader);
            }
            return null;
        }

        public List<Book> GetAllBook()
        {
            var book = new List<Book>();
            using var conn = _context.GetConnection();
            using var cmd = new NpgsqlCommand("SELECT * FROM books", conn);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                book.Add(MapBook(reader));
            }

            return book;
        }

        public List<Book> GetBooksByYearRange(int year_create)
        {
            var book = new List<Book>();
            using var conn = _context.GetConnection();
            using var cmd = new NpgsqlCommand("SELECT * FROM books WHERE year_create = @year_create", conn);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                book.Add(MapBook(reader));
            }

            return book;
        }

        public List<Book> GetCategoryByTitle(int id)
        {
            var book = new List<Book>();
            using var conn = _context.GetConnection();
            using var cmd = new NpgsqlCommand("SELECT * FROM books WHERE category_id = @id", conn);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                book.Add(MapBook(reader));
            }

            return book;
        }

        public List<Category> GetAllCategories()
        {
            var category = new List<Category>();
            using var conn = _context.GetConnection();
            using var cmd = new NpgsqlCommand("SELECT * FROM categories", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                category.Add(MapCategory(reader));
            }
            return category;
        }

        public Book MapBook(NpgsqlDataReader reader)
        {
            return new Book
            {
                Id = reader.GetInt32("id"),
                Title = reader.GetString("title"),
                Description = reader.GetString("description"),
                Author = reader.GetString("author"),
                Number_of_pages = reader.GetInt32("number_of_pages"),
                Year_Create = reader.GetInt32("year_create"),
                CategoryId = reader.GetInt32("category_id"),
            };
        }

        public Category MapCategory(NpgsqlDataReader reader)
        {
            return new Category
            {
                Id = reader.GetInt32("id"),
                Title = reader.GetString("title")
            };
        }

        public bool UpdateBook(int id,
            string? title = null,
            string? description = null,
            string? author = null,
            int? numberOfPages = null,
            int? yearCreate = null,
            int? categoryId = null)
        {
            using var conn = _context.GetConnection();

            var sql = "UPDATE books SET ";
            var parameters = new List<NpgsqlParameter>();
            var setParts = new List<string>();

            if (title != null)
            {
                setParts.Add("title = @title");
                parameters.Add(new NpgsqlParameter("title", title));
            }
            if (description != null)
            {
                setParts.Add("description = @description");
                parameters.Add(new NpgsqlParameter("description", description));
            }
            if (author != null)
            {
                setParts.Add("author = @author");
                parameters.Add(new NpgsqlParameter("author", author));
            }
            if (numberOfPages != null)
            {
                setParts.Add("number_of_pages = @number_of_pages");
                parameters.Add(new NpgsqlParameter("number_of_pages", numberOfPages.Value));
            }
            if (yearCreate != null)
            {
                setParts.Add("year_create = @year_create");
                parameters.Add(new NpgsqlParameter("year_create", yearCreate.Value));
            }
            if (categoryId != null)
            {
                setParts.Add("category_id = @category_id");
                parameters.Add(new NpgsqlParameter("category_id", categoryId.Value));
            }

            if (setParts.Count == 0) return false;

            sql += string.Join(", ", setParts) + " WHERE id = @id";
            parameters.Add(new NpgsqlParameter("id", id));

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddRange(parameters.ToArray());

            return cmd.ExecuteNonQuery() > 0;
        }

        
    }
}