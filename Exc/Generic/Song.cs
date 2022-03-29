using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic
{
    public enum Genre{
        Rock,
        Pop,
        HipHop,
        Techno,
        Classical

    }
    public class Song
    {
        public string Title { get; set; }
        public int Length { get; set; }
         public  Genre Genre { get; set; }

        public Song(string title, int length,Genre genre)
        {
            Title = title;
            Length = length;
            Genre = genre;
        }
    }
    public  class PersoN
    {


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; } =new List<Song>();
        public PersoN(int id, string firstName, string lastName, int age, Genre favoriteMusicType,List<Song>favoriteSongs)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusicType;
            FavoriteSongs = favoriteSongs;
        }
        public void  getFavSongs()
        {
            if (FavoriteSongs.Count == 0)
            {
                Console.WriteLine("This person hates Music");
            }
            else
            {
                List<string> songList =FavoriteSongs.Where(song => song.Genre ==Genre.HipHop)
                    .Select(song => song.Title).ToList();
                    songList.ForEach(Console.WriteLine);
            }
          
        }
    }
}
