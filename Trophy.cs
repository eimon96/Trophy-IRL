using SQLite;

namespace Trophy_IRL{
    public class Trophy{

        [PrimaryKey, AutoIncrement, NotNull]
        public int Id { get; set; }

        public int Icon {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}