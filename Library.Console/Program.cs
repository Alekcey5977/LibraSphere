using Library.Logic;
using Library.Model;

namespace Library.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("🧪 Запуск базового теста библиотеки...");
        Console.WriteLine("========================================\n");

        TestLibraryLogic();

        Console.WriteLine("\n✅ Тест завершён. Нажмите любую клавишу...");
        Console.ReadKey();
    }

    static void TestLibraryLogic()
    {
        try
        {
            var logic = new Library_Logic();

            // 1. Создаём категорию
            Console.WriteLine("1️⃣ Создаём категорию 'Фантастика'...");
            var category = logic.CreateCategory("Фантастика");
            Console.WriteLine($"→ Создана категория: {category.Title} (ID: {category.Id})\n");

            // 2. Создаём книгу
            Console.WriteLine("2️⃣ Создаём книгу...");
            var book = logic.CreateBook(
                title: "451 градус по Фаренгейту",
                description: "Роман-антиутопия Рея Бредбери.",
                author: "Рэй Бредбери",
                numberOfPages: 256,
                yearCreate: 1953,
                categoryId: category.Id
            );
            Console.WriteLine($"→ Создана книга: {book.Title} (ID: {book.Id})\n");

            // 3. Читаем книгу по ID
            Console.WriteLine("3️⃣ Читаем книгу по ID...");
            var readBook = logic.GetBookById(book.Id);
            if (readBook != null)
                Console.WriteLine($"→ Прочитано: {readBook.Title} — {readBook.Author}, {readBook.Year_Create} г.");
            else
                Console.WriteLine("❌ Книга не найдена!");
            Console.WriteLine();

            // 4. Обновляем книгу
            Console.WriteLine("4️⃣ Обновляем название и год...");
            var updated = logic.UpdateBook(book.Id, title: "Изменённое название", yearCreate: 2025);
            Console.WriteLine(updated ? "→ ✅ Книга обновлена." : "→ ❌ Не удалось обновить.\n");

            // Перечитываем обновлённую книгу
            var updatedBook = logic.GetBookById(book.Id);
            if (updatedBook != null)
                Console.WriteLine($"→ После обновления: {updatedBook.Title}, {updatedBook.Year_Create} г.\n");

            // 5. Фильтруем книги по году
            Console.WriteLine("5️⃣ Ищем книги по году 2025...");
            var booksByYear = logic.GetBooksByYearRange(2025); // У тебя метод принимает int data → фильтр по году
            if (booksByYear.Count > 0)
            {
                foreach (var b in booksByYear)
                    Console.WriteLine($"→ Найдено: {b.Title} ({b.Year_Create} г.)");
            }
            else
                Console.WriteLine("→ 📭 Нет книг за 2025 год.");
            Console.WriteLine();

            // 6. Получаем все книги категории
            Console.WriteLine("6️⃣ Получаем все книги категории...");
            var booksByCategory = logic.GetCategoryByTitle(category.Id); // странное название метода, но работает
            if (booksByCategory.Count > 0)
            {
                foreach (var b in booksByCategory)
                    Console.WriteLine($"→ Книга в категории: {b.Title}");
            }
            else
                Console.WriteLine("→ 📭 Нет книг в категории.");
            Console.WriteLine();

            // 7. Удаляем книгу
            Console.WriteLine("7️⃣ Удаляем книгу...");
            var deleted = logic.DeleteBook(book.Id);
            Console.WriteLine(deleted ? "→ ✅ Книга удалена." : "→ ❌ Не удалось удалить.");
            Console.WriteLine();

            // 8. Проверяем, что книга действительно удалена
            Console.WriteLine("8️⃣ Проверяем, что книга удалена...");
            var checkDeleted = logic.GetBookById(book.Id);
            Console.WriteLine(checkDeleted == null ? "→ ✅ Книга не найдена — успешно удалена." : "→ ❌ Книга всё ещё существует!");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ ОШИБКА: {ex.Message}");
            Console.WriteLine(ex.StackTrace);
        }
    }
}