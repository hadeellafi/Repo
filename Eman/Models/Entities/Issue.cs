namespace Eman.Models.Entities
{
    public class Issue
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime CreatedDate { get; set;}

        public int OwnerId { get; set; }
        public Owner? owner { get; set; }
    }
   
}
