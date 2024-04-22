using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class MovieOperations
    {
        static MovieCrudeOperation[] movies = new MovieCrudeOperation[10];
        static int moviecount;
        static void Main(string[] args)
        {
            bool continueLoop = true;

            while (continueLoop)

            {
                Console.WriteLine("Choose an Option ");
                Console.WriteLine("1.Insert ");
                Console.WriteLine("2.Update ");
                Console.WriteLine("3.Delete");
                Console.WriteLine("4.Dispaly All Movie");
                Console.WriteLine("5.Serach Movie By Name");
                Console.WriteLine("6 . Search Movie By ID");
                Console.WriteLine("7.Exit");
                Console.WriteLine("Enter your Choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InsertMovie();
                        break;
                    case 2:
                        UpdateMovie(); 
                        break;
                    case 3:
                        DeleteMovie(); 
                        break;
                    case 4:
                        DisplayAllMovies(); 
                        break;
                    case 5: 
                        SerachMovieByName();
                        break;
                    case 6:
                        SerachMovieById();
                        break;  
                    case 7:
                        continueLoop= false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice ");
                        break;
                            

                }
            }
        }
        static void InsertMovie()
        {
            Console.WriteLine("Enter Movie Details :");
            Console.Write("Movie ID :");
            int id =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Movie Name");
            string name = Console.ReadLine();
            Console.WriteLine("Ticket cost :");
            double cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Producer Name :");
            string producer = Console.ReadLine();
            MovieCrudeOperation newMovie =new MovieCrudeOperation(id, name, cost, producer);
            movies[moviecount++] = newMovie;
            Console.WriteLine("Movie insrted Succefully");
        }
        static void UpdateMovie()
        {
            Console.WriteLine("Enter movie Id to update");
            int id =Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i<moviecount; i++)
            {
                if (movies[i].MovieId == id)
                {
                    Console.WriteLine("Enter New Details :");
                    Console.WriteLine("Movie Name :");
                    movies[i].MovieName=Console.ReadLine();
                    Console.WriteLine("Enter Ticket Cost");
                    movies[i].TicketCost = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Producer Name");
                    movies[i].ProducerName=Console.ReadLine();
                    Console.WriteLine("Movie Updated Succefully");
                    return;
                }
            }
            Console.WriteLine("Movie not found ");

        }
        static void DeleteMovie()
        {
            Console.WriteLine("Enter movie ID to deleted ");
            int id =Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<moviecount; i++)
            {
                if (movies[i].MovieId== id)
                {
                    for(int j=i; j<moviecount-1; j++) 
                    {
                        movies[j] = movies[j+1];
                    }
                    moviecount--;
                    Console.WriteLine("Movie Deleted Succefully");
                    return;
                }
                
                
            }
            Console.WriteLine("Movie not found");
        }
        static void SerachMovieByName()
        {
            Console.WriteLine("Enter movie to search");
            string searchmovie = Console.ReadLine();
            bool found = false;
            for(int i = 0; i<moviecount; i++)
            {
                if (movies[i].MovieName==searchmovie)
                {
                    found = true;
                    break;

                }
            }
            if (found)
            {
                Console.WriteLine("The Movie " + searchmovie + " Was found in the array");

            }
            else
            {
                Console.WriteLine("The Movie " + searchmovie + " Was Not found in the array");
            }
        }
        static void SerachMovieById()
        {
            Console.WriteLine("Enter movie Id to search");
            int id = Convert.ToInt32( Console.ReadLine());
            bool found = false;
            for (int i = 0; i < moviecount; i++)
            {
                if (movies[i].MovieId == id)
                {
                    found = true;
                    break;

                }
            }
            if (found)
            {
                Console.WriteLine("The Movie  Was found in the array");

            }
            else
            {
                Console.WriteLine("The Movie  Was Not found in the array");
            }
        }
        static void DisplayAllMovies()
        {
            if(moviecount==0)
            {
                Console.WriteLine("No Movie Avilable");
                return;
            }
            Console.WriteLine("All Movies");
            for(int i=0; i<moviecount;i++)
            {
                Console.WriteLine("Movie Id :"+movies[i].MovieId);
                Console.WriteLine("Movie Name :"+movies[i].MovieName);
                Console.WriteLine("Cost :"+movies[i].TicketCost);
                Console.WriteLine("Producer Name :"+movies[i].ProducerName);
                Console.WriteLine("------------------");
            }
        }

    }
}
