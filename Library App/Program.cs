using System.ComponentModel;
using static System.Net.WebRequestMethods;

namespace Library_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bookList = new List<Book>()
            {
                new Book("The Tower", "Novel about roman soldiers in 70AD","Valerio Mssimo Manfredi",304),
                new Book("Pippi Langstrømpe", "Bok om verdens sterkeste jente ","Astrid Lindgren",151),
                new Book("The Left Hand of God", "Thomas Cale, The Redeemers and God", "Paul Hoffman",448 )

            };

            var movieList = new List<Movie>()
            {
                new Movie("Lord of the Rings: The Fellowship of the ring","Movie about swords and orcs and wizards", "Peter Jackson", 178),
                new Movie("The Lord of the Rings: The Two Towers","Movie about swords and orcs and wizards", "Peter Jackson", 179),
                new Movie("The Lord of the Rings: The Return of the King","Movie about swords and orcs and wizards", "Peter Jackson", 201),
                new Movie("Studio 666","Movie about the foo fighters fighting demons", "BJ McDonnell", 106),
            };

            int choice;
            bool gameIsActive = true;

            while (gameIsActive)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the library \n What section of the library would you like to visit: ");
                Console.WriteLine("1. Books");
                Console.WriteLine("2. Movies");
                Console.WriteLine("3. Add book");
                Console.WriteLine("4. Add movie");
                Console.WriteLine("5. Exit");

                string input = Console.ReadLine();


                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Welcome to the Book section");
                            ShowBooks();
                            Console.ReadKey(true);
                            break;
                        case 2:
                            Console.WriteLine("Welcome to the Movie section");
                            ShowMovies();
                            Console.ReadKey(true);
                            break;
                        case 3:
                            AddBook();
                            Console.ReadKey(true);
                            ; break;
                        case 4:
                            AddMovie();
                            Console.ReadKey(true);
                            ; break;
                        case 5:
                            Console.WriteLine("Have a nice day! Welcome back.");
                            gameIsActive = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("invalid input. Please enter a numnber corresponding with the list of choices.");

                }
            }


            void ShowMovies()
            {
                foreach (var movie in movieList)
                {
                    Console.WriteLine($"Title: {movie.Title}, ");
                    Console.WriteLine($"Description{movie.Description}");
                    Console.WriteLine($"Author: {movie.Director},");
                    Console.WriteLine($"Number of pages: {movie.MovieLength}");
                }
            }

            void ShowBooks()
            {
                foreach (var book in bookList)
                {
                    Console.WriteLine($"Title: {book.Title}, ");
                    Console.WriteLine($"Description{book.Description}");
                    Console.WriteLine($"Author: {book.Author},");
                    Console.WriteLine($"Number of pages: {book.NumberOfPages}");
                }

            }

            void AddBook()
            {
                Console.WriteLine("Adding a new book...");
                Console.WriteLine("Enter the title of the new book:");
                string title = Console.ReadLine();
                Console.WriteLine("Enter the description of the new book:");
                string description = Console.ReadLine();
                Console.WriteLine("Enter the author of the new book:");
                string author = Console.ReadLine();
                Console.WriteLine("Enter the number of pages in the new book:");
                int numberOfPages = int.Parse(Console.ReadLine());
                bookList.Add(new Book(title, description, author, numberOfPages));
                Console.WriteLine("New book added successfully!");

            }  
            
            void AddMovie()
            {
                Console.WriteLine("Adding a new movie...");
                Console.WriteLine("Enter the title of the new movie:");
                string title = Console.ReadLine();
                Console.WriteLine("Enter the description of the new movie:");
                string description = Console.ReadLine();
                Console.WriteLine("Enter the director of the new movie:");
                string director = Console.ReadLine();
                Console.WriteLine("Enter the length of your movie in minutes:");
                int movieLength = int.Parse(Console.ReadLine());
                movieList.Add(new Movie(title, description, director, movieLength));
                Console.WriteLine("New movie added successfully!");
            }



            



        }



    }

}