using Library.Logic;
using Library.Model;
class Program
{
    private static Library_Logic libraryLogic = new Library_Logic();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== БИБЛИОТЕКА ===");
            Console.WriteLine("1. Показать все книги");
            Console.WriteLine("2. Показать все категории");
            Console.WriteLine("3. Добавить книгу");
            Console.WriteLine("4. Добавить категорию");
            Console.WriteLine("5. Найти книгу по ID");
            Console.WriteLine("6. Найти книги по году");
            Console.WriteLine("7. Найти книги по категории");
            Console.WriteLine("8. Обновить книгу");
            Console.WriteLine("9. Удалить книгу");
            Console.WriteLine("0. Выход");
            Console.Write("Выберите действие: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowAllBooks();
                    break;
                case "2":
                    ShowAllCategories();
                    break;
                case "3":
                    AddBook();
                    break;
                case "4":
                    AddCategory();
                    break;
                case "5":
                    FindBookById();
                    break;
                case "6":
                    FindBooksByYear();
                    break;
                case "7":
                    FindBooksByCategory();
                    break;
                case "8":
                    UpdateBook();
                    break;
                case "9":
                    DeleteBook();
                    break;
                case "0":
                    Console.WriteLine("До свидания!");
                    return;
                default:
                    Console.WriteLine("Неверный выбор!");
                    Exit();
                    break;
            }
        }
    }

    static void ShowAllBooks()
    {
        Console.Clear();
        Console.WriteLine("=== ВСЕ КНИГИ ===\n");

        var books = libraryLogic.GetAllBook();
        if (books.Count == 0)
        {
            Console.WriteLine("Книги не найдены.");
        }
        else
        {
            foreach (var book in books)
            {
                PrintBook(book);
                Console.WriteLine();
            }
        }
        Exit();
    }

    static void ShowAllCategories()
    {
        Console.Clear();
        Console.WriteLine("=== ВСЕ КАТЕГОРИИ ===\n");

        var categories = libraryLogic.GetAllCategories();
        if (categories.Count == 0)
        {
            Console.WriteLine("Категории не найдены.");
        }
        else
        {
            foreach (var category in categories)
            {
                Console.WriteLine($"ID: {category.Id}, Название: {category.Title}");
            }
        }
        Exit();
    }

    static void AddBook()
    {
        Console.Clear();
        Console.WriteLine("=== ДОБАВИТЬ КНИГУ ===\n");

        Console.Write("Название: ");
        var title = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(title))
        {
            Console.WriteLine("Название не может быть пустым!");
            Exit();
            return;
        }

        Console.Write("Описание: ");
        var description = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(description))
        {
            Console.WriteLine("Описание не может быть пустым!");
            Exit();
            return;
        }

        Console.Write("Автор: ");
        var author = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(author))
        {
            Console.WriteLine("Автор не может быть пустым!");
            Exit();
            return;
        }

        Console.Write("Количество страниц: ");
        if (!int.TryParse(Console.ReadLine(), out int pages) || pages <= 0)
        {
            Console.WriteLine("Некорректное количество страниц!");
            Exit();
            return;
        }

        Console.Write("Год издания: ");
        if (!int.TryParse(Console.ReadLine(), out int year) || year < 1000 || year > DateTime.Now.Year + 1)
        {
            Console.WriteLine("Некорректный год издания!");
            Exit();
            return;
        }

        Console.Write("ID категории: ");
        if (!int.TryParse(Console.ReadLine(), out int categoryId) || categoryId <= 0)
        {
            Console.WriteLine("Некорректный ID категории!");
            Exit();
            return;
        }

        try
        {
            var book = libraryLogic.CreateBook(title, description, author, pages, year, categoryId);
            Console.WriteLine("\nКнига добавлена!");
            PrintBook(book);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nОшибка при добавлении книги: {ex.Message}");
        }
        Exit();
    }

    static void AddCategory()
    {
        Console.Clear();
        Console.WriteLine("=== ДОБАВИТЬ КАТЕГОРИЮ ===\n");

        Console.Write("Название категории: ");
        var title = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(title))
        {
            Console.WriteLine("Название категории не может быть пустым!");
            Exit();
            return;
        }

        try
        {
            var category = libraryLogic.CreateCategory(title);
            Console.WriteLine($"\nКатегория добавлена! ID: {category.Id}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nОшибка при добавлении категории: {ex.Message}");
        }
        Exit();
    }

    static void FindBookById()
    {
        Console.Clear();
        Console.WriteLine("=== НАЙТИ КНИГУ ПО ID ===\n");

        Console.Write("Введите ID книги: ");
        if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
        {
            Console.WriteLine("Некорректный ID книги!");
            Exit();
            return;
        }

        var book = libraryLogic.GetBookById(id);
        if (book != null)
        {
            PrintBook(book);
        }
        else
        {
            Console.WriteLine("Книга не найдена!");
        }
        Exit();
    }

    static void FindBooksByYear()
    {
        Console.Clear();
        Console.WriteLine("=== НАЙТИ КНИГИ ПО ГОДУ ===\n");

        Console.Write("Введите год: ");
        if (!int.TryParse(Console.ReadLine(), out int year) || year < 1000 || year > DateTime.Now.Year + 1)
        {
            Console.WriteLine("Некорректный год!");
            Exit();
            return;
        }

        var books = libraryLogic.GetBooksByYearRange(year);
        Console.WriteLine($"\nНайдено книг: {books.Count}");

        if (books.Count > 0)
        {
            foreach (var book in books)
            {
                PrintBook(book);
                Console.WriteLine();
            }
        }
        Exit();
    }

    static void FindBooksByCategory()
    {
        Console.Clear();
        Console.WriteLine("=== НАЙТИ КНИГИ ПО КАТЕГОРИИ ===\n");

        Console.Write("Введите ID категории: ");
        if (!int.TryParse(Console.ReadLine(), out int categoryId) || categoryId <= 0)
        {
            Console.WriteLine("Некорректный ID категории!");
            Exit();
            return;
        }

        var books = libraryLogic.GetCategoryByTitle(categoryId);
        Console.WriteLine($"\nНайдено книг: {books.Count}");

        if (books.Count > 0)
        {
            foreach (var book in books)
            {
                PrintBook(book);
                Console.WriteLine();
            }
        }
        Exit();
    }

    static void UpdateBook()
    {
        Console.Clear();
        Console.WriteLine("=== ОБНОВИТЬ КНИГУ ===\n");

        Console.Write("Введите ID книги для обновления: ");
        if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
        {
            Console.WriteLine("Некорректный ID книги!");
            Exit();
            return;
        }

        Console.WriteLine("\nОставьте поле пустым, если не хотите менять значение:");

        Console.Write("Новое название: ");
        var title = Console.ReadLine();
        if (string.IsNullOrEmpty(title)) title = null;

        Console.Write("Новое описание: ");
        var description = Console.ReadLine();
        if (string.IsNullOrEmpty(description)) description = null;

        Console.Write("Новый автор: ");
        var author = Console.ReadLine();
        if (string.IsNullOrEmpty(author)) author = null;

        int? pages = null;
        Console.Write("Новое количество страниц: ");
        var pagesStr = Console.ReadLine();
        if (!string.IsNullOrEmpty(pagesStr))
        {
            if (!int.TryParse(pagesStr, out int tempPages) || tempPages <= 0)
            {
                Console.WriteLine("Некорректное количество страниц!");
                Exit();
                return;
            }
            pages = tempPages;
        }

        int? year = null;
        Console.Write("Новый год издания: ");
        var yearStr = Console.ReadLine();
        if (!string.IsNullOrEmpty(yearStr))
        {
            if (!int.TryParse(yearStr, out int tempYear) || tempYear < 1000 || tempYear > DateTime.Now.Year + 1)
            {
                Console.WriteLine("Некорректный год издания!");
                Exit();
                return;
            }
            year = tempYear;
        }

        int? categoryId = null;
        Console.Write("Новый ID категории: ");
        var categoryStr = Console.ReadLine();
        if (!string.IsNullOrEmpty(categoryStr))
        {
            if (!int.TryParse(categoryStr, out int tempCategoryId) || tempCategoryId <= 0)
            {
                Console.WriteLine("Некорректный ID категории!");
                Exit();
                return;
            }
            categoryId = tempCategoryId;
        }

        var success = libraryLogic.UpdateBook(id, title, description, author, pages, year, categoryId);
        if (success)
        {
            Console.WriteLine("\nКнига обновлена!");
        }
        else
        {
            Console.WriteLine("\nНе удалось обновить книгу!");
        }
        Exit();
    }

    static void DeleteBook()
    {
        Console.Clear();
        Console.WriteLine("=== УДАЛИТЬ КНИГУ ===\n");

        Console.Write("Введите ID книги для удаления: ");
        if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
        {
            Console.WriteLine("Некорректный ID книги!");
            Exit();
            return;
        }

        var success = libraryLogic.DeleteBook(id);
        if (success)
        {
            Console.WriteLine("Книга удалена!");
        }
        else
        {
            Console.WriteLine("Не удалось удалить книгу!");
        }
        Exit();
    }

    static void PrintBook(Book book)
    {
        Console.WriteLine($"ID: {book.Id}");
        Console.WriteLine($"Название: {book.Title}");
        Console.WriteLine($"Автор: {book.Author}");
        Console.WriteLine($"Год: {book.Year_Create}");
        Console.WriteLine($"Количество страниц: {book.Number_of_pages}");
        Console.WriteLine($"Описание: {book.Description}");
        Console.WriteLine($"ID категории: {book.CategoryId}");
    }

    static void Exit()
    {
        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
        Console.ReadKey();
    }
}