/**
 * I, Simrit Waraich 000774535, certify that this material is my original
 * work. No other person's work has been used without due acknowledgement and I have
 * not made my work available to anyone else.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3A
{
    /// <summary>
    /// The Purpose of this class is to contain the main menu of the program and the ReadData() functinoality of this program
    /// this program reads a text database of media and decrypts it to than be presented to the user depening on what the user wants
    /// </summary>
    class Program
    {
        //initalizing variables 
        private static int choice = 0;
        private static Media[] myMediaList = new Media[100];
        private static Book[] myBook = new Book[100];
        private static Song[] mySong = new Song[100];
        private static Movie[] myMovie = new Movie[100];
        /// <summary>
        /// This function sends the user to the menu
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            Menu();

        }
        /// <summary>
        /// This function reads all the data from the file, and see's what type of media it is, it than takes that media puts it into a corresponding array and than that array is put into
        /// a array of all the media from the file, this function is so where the decryption method is called and where the summary is added to the media 
        /// </summary>
        public static void ReadData()
        {


            int count = 0;


            try
            {
                StreamReader myReader = new StreamReader("Data.txt");   //creating a reader for the file 

                while (!myReader.EndOfStream) //checking to see if the file is not empty
                {
                    string[] items = myReader.ReadLine().Split('|');    //spliting the file at | and storying it into a array to see the data types
                    if(items[0] == "BOOK")
                    {
                        myBook[count] = new Book(items[1], int.Parse(items[2])); //adding the tital and year
                        myBook[count].Author = items[3];
                        do
                        {
                            string summary = myReader.ReadLine();

                            DecryptData decrypt = new DecryptData(summary); //creating a decrtpy 

                            String decryptedSummary = decrypt.Decrypt();    //sending a decrypt

                            myBook[count].Summary = decryptedSummary;   //saving the decrypted 

                        } while (myReader.ReadLine() != "-----");   //do while the reader is reading the summary and not the information on the media

                        myMediaList[count] = myBook[count];
                        count++;
                    }
                    /**
                     * Adding the split information into the song array and than adding to the main array same functionality as above
                     */
                    else if (items[0] == "SONG")
                    {
                        mySong[count] = new Song(items[1], int.Parse(items[2]));
                        mySong[count].Album = items[3];
                        mySong[count].Artist = items[4];
                        myMediaList[count] = mySong[count];
                        count++;
                    }
                    /**
                     * Adding the split information into the movie array and than adding to the main array same functionality as the BOOK function
                     */
                    else if (items[0] == "MOVIE")
                    {
                        myMovie[count] = new Movie(items[1], int.Parse(items[2]));
                        myMovie[count].Director = items[3];
                        do
                        {
                            string summary = myReader.ReadLine();

                            DecryptData decrypt = new DecryptData(summary);

                            String decryptedSummary = decrypt.Decrypt();

                            myMovie[count].Summary = decryptedSummary;

                        } while (myReader.ReadLine() != "-----");
                        myMediaList[count] = myMovie[count];
                        count++;
                    }
                }
                myReader.Close();
            }
            catch( Exception ex)
            {
                Console.WriteLine($"Exception.{ex.Message}");

            }

            Array.Resize(ref myMediaList, count);       //resizing the array to remove all empty compentens
            for (int i = 0; i < myMediaList.Length; i++)
            {
                if (choice == 1)
                {
                    if (myMediaList[i] is Book)
                    {
                        Console.WriteLine(myMediaList[i].ToString() + "\n");
                    }
                }
                else if (choice == 2)
                {
                    if(myMediaList[i] is Movie)
                    {
                        Console.WriteLine(myMediaList[i].ToString() + "\n");
                    }
                }
                else if (choice == 3)
                {
                    if (myMediaList[i] is Song)
                    {
                        Console.WriteLine(myMediaList[i].ToString() + "\n");
                    }
                }
                else if (choice == 4)
                {
                    
                    Console.WriteLine(myMediaList[i].ToString() + "\n");
                }
            }
        }
        /// <summary>
        /// Main menu system where the user navigates to what they want
        /// </summary>
        public static void Menu()
        {
            
            //do while the user decides not to close the application
            do
            {
                Console.WriteLine($"1. List All Books\n" +
                    $"2. List All Movies\n" +
                    $"3. List All Songs\n" +
                    $"4. List All Media\n" +
                    $"5. Search All Media by Title\n\n" +
                    $"6. Exit Program\n\n" +
                    $"Enter Choice: ");
                //check to see if a integer is entered
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\nError Incorect Input");
                    

                }
                //switch based of input
                switch (choice)
                {
                    case 1:
                        ReadData();
                        break;
                    case 2:
                        ReadData();
                        break;
                    case 3:
                        ReadData();
                        break;
                    case 4:
                        ReadData();
                        break;
                    case 5:
                        ReadData();
                        Console.WriteLine("\nEnter a search string: "); 
                        String searchString = Console.ReadLine();   //create a searcg string
                        for (int i = 0; i < myMediaList.Length; i++)
                        {
                            if (myMediaList[i].Search(searchString) is true)    //check if the search string returns true
                            {
                                //Print if it is a song, book, or movie, and the summart if needed.
                                if (myMediaList[i] is Song)
                                {
                                    Console.WriteLine(myMediaList[i].ToString());
                                }
                                else if (myMediaList[i] is Book)
                                {
                                    Console.WriteLine(myMediaList[i].ToString() + "\n" + myBook[i].Summary + "\n");
                                }
                                else if (myMediaList[i] is Movie)
                                {
                                    Console.WriteLine(myMediaList[i].ToString() + "\n" + myMovie[i].Summary + "\n");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Nothing could be found");
                            }
                        }
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("\nPlease Enter A Number Between 1 and 6\n");
                        break;
                }
            } while (choice != 6);
            
        }

    }
}
