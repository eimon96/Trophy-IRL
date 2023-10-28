using Android.Graphics.Drawables;
using System.Collections.Generic;
using System.Linq;

namespace Trophy_IRL
{
    internal class TrophyData
    {
        public static List<Trophy> Trophies = new List<Trophy>();

        public static void AddTrophy(string type, string title, string description){
            int typeId = getTypeId(type);
            Trophies.Add(new Trophy()
            {
                Icon = typeId,
                Title = title,
                Description = description,
            });
        }

        private static int getTypeId(string type){
            switch (type){
                case ("bronze"):
                    return Resource.Drawable.bronze;
                case ("silver"):
                    return Resource.Drawable.silver;
                case ("gold"):
                    return Resource.Drawable.gold;
                case ("platinum"):
                    return Resource.Drawable.platinum;
                default: 
                    return 0;
            }
        }
    }
}