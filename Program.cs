using System.Text;

namespace ManagementBook;

internal class Program
{
	static List<Book> books = new List<Book>();
	static int lastId = 0;
	static void Main(string[] args)
	{
		Console.Title = "ІС \"Книгарня\"";
		Console.InputEncoding = Encoding.UTF8;
		Console.OutputEncoding = Encoding.UTF8;

		while (true) 
		{
			Console.BackgroundColor = ConsoleColor.DarkYellow;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("            Інформаційна система            ");
			Console.WriteLine("                 КНИГАРНЯ                   ");
			Console.WriteLine();
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("\t\t Головне меню ");
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("┌────────────┬─────────────────────────────┐");
			Console.WriteLine("│    Дiї     │          Пояснення          │");
			Console.WriteLine("├───┬────────┼─────────────────────────────┤");
			Console.WriteLine("│ 1 │ CREATE │ Додання книги               │");
			Console.WriteLine("│ 2 │ READ   │ Відображення всіх книг      │");
			Console.WriteLine("│ 3 │ UPDATE │ Оновлення книги             │");
			Console.WriteLine("│ 4 │ DELETE │ Видалення книги             │");
			Console.WriteLine("│ 5 │ EXIT   │ Вихід                       │");
			Console.WriteLine("└───┴────────┴─────────────────────────────┘");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.Write(" ОБЕРІТЬ НОМЕР ДІЇ: ");
			Console.ForegroundColor = ConsoleColor.White;
			string? choice = Console.ReadLine();
			switch (choice) 
			{
				case "1": CreateBook(); break;
				case "2": ReadAllBooks(); break;
				case "3": UpdateBook(); break;
				case "4": DeleteBook(); break;
				case "5": Environment.Exit(0); break;
				default: Error(); break;
			}
		}
	}
	static public void CreateBook()
	{
		Console.Clear();
		Console.BackgroundColor = ConsoleColor.DarkYellow;
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("            Інформаційна система            ");
		Console.WriteLine("                 КНИГАРНЯ                   ");
		Console.WriteLine();
		Console.BackgroundColor = ConsoleColor.Blue;
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("\t\t Додання книги ");
		Console.BackgroundColor = ConsoleColor.Black;

		Console.ForegroundColor = ConsoleColor.DarkYellow;
		Console.Write("\nВведіть назву книги: ");
		Console.ForegroundColor = ConsoleColor.White;
		string? name = Console.ReadLine();

		Console.ForegroundColor = ConsoleColor.DarkYellow;
		Console.Write("Додайте авторів книги: ");
		Console.ForegroundColor = ConsoleColor.White;
		string? author = Console.ReadLine();

		Console.ForegroundColor = ConsoleColor.DarkYellow;
		Console.Write("Вкажіть видавництво книги: ");
		Console.ForegroundColor = ConsoleColor.White;
		string? publisher = Console.ReadLine();

		Console.ForegroundColor = ConsoleColor.DarkYellow;
		Console.Write("Вкажіть рік випуску книги: ");
		Console.ForegroundColor = ConsoleColor.White;
		int year = Convert.ToInt32(Console.ReadLine());

		Console.ForegroundColor = ConsoleColor.DarkYellow;
		Console.Write("Введіть кількість сторінок: ");
		Console.ForegroundColor = ConsoleColor.White;
		int quantity = Convert.ToInt32(Console.ReadLine());

		lastId++;
		books.Add(new Book { Id = lastId, Name = name, Author = author, Publisher = publisher, Year = year, Quantity = quantity });

		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("\nКнигу успішно додано!");
		Console.WriteLine("\nДля повернення на головне меню натисніть \nбудь-яку клавішу...");
		Console.ReadKey();
		Console.Clear();
	}
	static public void ReadAllBooks()
	{
	}
	static public void UpdateBook()
	{
	}
	static public void DeleteBook()
	{
	}
	static public void Error()
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("\n Неправильний вибір. Спробуйте ще раз...");
		Thread.Sleep(1500);
		Console.Clear();
	}
}
class Book {
	public int Id { get; set; }
	public string? Name { get; set; }
	public string? Author { get; set; }
	public string? Publisher { get; set; }
	public int Year { get; set; }
	public int Quantity { get; set; }
}