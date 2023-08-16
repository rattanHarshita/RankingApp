namespace RankingApp.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ImageId { get; set; }
        public int Ranking { get; set; }
        //Movie-1; Album - 2
        public int ItemType { get; set; }
    }
}
