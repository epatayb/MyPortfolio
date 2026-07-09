namespace MyPortfolio.DAL.Entities
{
    public class Experience
    {
        public int Id { get; set; }
        public string Head { get; set; }
        public string Title { get; set; }
        public string StartDate { get; set; }
        public string? EndDate { get; set; }
        public string Description { get; set; }
    }
}
