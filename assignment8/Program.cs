namespace assignment8
{
    internal class Program
    {
       
    
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            string[] album = new string[100];  
            int nymofAlbums = 0;  

            while (true)
            {
                Console.WriteLine("Your favorite albums are: ");
                DisplayAlbums(album, nymofAlbums);  

                Console.WriteLine("Do you want to add another album? (yes/no)");
                string answer = Console.ReadLine().ToLower();

                if (answer == "no")
                {
                    break;  
                }
                else if (answer == "yes")
                {
                    Console.WriteLine($"Enter the name of album {nymofAlbums + 1}: ");
                    album[nymofAlbums] = Console.ReadLine();  
                    nymofAlbums++;  
                }
                else
                {
                    Console.WriteLine("Please enter 'yes' or 'no'.");  
                }
            }

            Console.WriteLine("Enter the name of the album that you want to search: ");
            string searchAlbum = Console.ReadLine();

            
            if (FindAlbum(album, nymofAlbums, searchAlbum))
            {
                Console.WriteLine($"The album \"{searchAlbum}\" is in your list!");
            }
            else
            {
                Console.WriteLine($"The album \"{searchAlbum}\" is not in your list.");
            }
        }

       
        void DisplayAlbums(string[] albums, int numberOfAlbums)
        {
            if (numberOfAlbums == 0)
            {
                Console.WriteLine("You haven't added any albums yet.");
            }
            else
            {
                for (int i = 0; i < numberOfAlbums; i++)
                {
                    Console.WriteLine($"{i + 1}. {albums[i]}");
                }
            }
        }

        
        bool FindAlbum(string[] albums, int numberOfAlbums, string searchAlbum)
        {
            for (int i = 0; i < numberOfAlbums; i++)
            {

                if (FindAlbum(albums, numberOfAlbums, searchAlbum))
                {
                    Console.WriteLine($"The album {searchAlbum} is in your list!");
                }

                else
                {
                    Console.WriteLine($"The album {searchAlbum} is not in your list.");
                }
                    
            }
            return false;
        }
    }

}

