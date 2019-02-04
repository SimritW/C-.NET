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

namespace Lab3A
{
    /// <summary>
    /// creats a song object inside a media object
    /// </summary>
    public class Song: Media 
    {
        public string Album { get; set; }
        public string Artist { get; set; }
        /// <summary>
        /// creating a constructor
        /// </summary>
        /// <param name="title"></param>
        /// <param name="year"></param>
        public Song(string title, int year) : base(title, year)
        {
            String Title = title;
            int Year = year;
        }
        /// <summary>
        /// Override the ToString for the desired print statement
        /// </summary>
        /// <returns>The print statement</returns>
        public override String ToString()
        {
            return ("----------------------------\nSong Title: " + Title + " (" + Year) + ")" + "\nAlbum: " + Album + " Artist: " + Artist;
        /// <summary>
        /// If the title contains the search parameter return true or false
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns>a boolean that is true or false if the title contains the corresponding search param</returns>
        public new bool Search(string searchString)
        {
            bool searchBool;

            if (Title.Contains(searchString))
            {
                searchBool = true;
            }
            else
            {
                searchBool = false;
            }

            return searchBool;
        }
    }
}
