using System.Collections.Generic;

namespace Trophy_IRL
{
    internal class TrophyData
    {
        public static List<Trophy> Trophies = new List<Trophy>();

        public static void AddTrophy(string type, string title, string description){
            int typeId = GetTypeId(type);
            Trophies.Add(new Trophy()
            {
                Icon = typeId,
                Title = title,
                Description = description,
            });
        }

        public static void RemoveTrophy(int position){
            Trophies.RemoveAt(position);
        }

        private static int GetTypeId(string type){
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