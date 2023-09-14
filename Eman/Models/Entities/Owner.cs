namespace Eman.Models.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Repo { get; set; }
        public List<Issue>? Issues { get; set; }
    }
}
