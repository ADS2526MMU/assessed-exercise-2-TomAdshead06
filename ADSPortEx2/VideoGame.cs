using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx2
{
    //Film class implementation for Assessed Exercise 2

    class VideoGame : IComparable
    {
        public string gameTitle;
        public string gameDeveloper;
        public int gameReleaseYear;


        public VideoGame()
        {
            throw new NotImplementedException();
        }

        public VideoGame(string title, string developer, int releaseyear)
        {
            Title = title;
            Developer = developer;
            gameReleaseYear = releaseyear;
        }

        public string Title
        {
            get { return gameTitle; }
            set { gameTitle = value; }
        }

        public string Developer
        {
            get { return gameDeveloper; }
            set { gameDeveloper = value; }
        }

        public int Releaseyear
        {
            get { return gameReleaseYear; }
            set { gameReleaseYear = value; }
        }

        public int CompareTo(object obj)
        {
            VideoGame other = (VideoGame)obj;
            return Title.CompareTo(other.Title);
        }

    }// End of class
}
