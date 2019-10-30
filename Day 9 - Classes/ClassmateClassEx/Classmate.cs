using System;
using System.Collections.Generic;
using System.Text;

namespace ClassmateClassEx
{
    class Classmate
    {
        #region fields
        private string name;
        private string homeTown;
        private string favoriteFood;
        private string favoriteHobby;
        private double favoriteNumber;
        #endregion

        #region properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string HomeTown
        {
            get { return homeTown; }
            set { homeTown = value; }
        }
        public string FavoriteFood
        {
            get { return favoriteFood; }
            set { favoriteFood = value; }
        }
        public string FavoriteHobby
        {
            get { return favoriteHobby; }
            set { favoriteHobby = value; }
        }
        public double FavoriteNumber
        {
            get { return favoriteNumber; }
            set { favoriteNumber = value; }
        }
        #endregion

        #region Methods
        public Classmate()
        {

        }

        public Classmate(string _name, string _hometown, string _favFood, string _favHob, double _favNum)
        {
            name = _name;
            homeTown = _hometown;
            favoriteFood = _favFood;
            favoriteHobby = _favHob;
            favoriteNumber = _favNum;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Classmate: " + Name);
            Console.WriteLine($"Hometown: {HomeTown}");
            Console.WriteLine($"Favorite Food: {FavoriteFood}");
            Console.WriteLine($"Favorite Hobby: {FavoriteHobby}");
            Console.WriteLine($"Favorite Number: {FavoriteNumber}");
        }

        public double SquareFavNumber()
        {
            return favoriteNumber * favoriteNumber;
        }
        #endregion
    }
}
