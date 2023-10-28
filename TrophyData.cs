using System.Collections.Generic;
using System.Linq;

namespace Trophy_IRL
{
    internal class TrophyData
    {
        public static List<Trophy> Trophies { get; private set; }

        static TrophyData()
        {
            var temp = new List<Trophy>();
            AddTrophy(temp);
            Trophies = temp.ToList();
        }

        static void AddTrophy(List<Trophy> trophies){
            trophies.Add(new Trophy()
            {
                Icon = Resource.Drawable.bronze,
                Title = "Survivor",
                Description = "Still Alive till this very day.",
            }); ;
        }
    }
}