namespace Villasor_FunRun.Models.Entities
{
    public class Participant
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public string PNumber { get; set; }
        public int distance { get; set; }
    }
}
