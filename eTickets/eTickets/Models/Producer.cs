using eTickets.Data.Base;

namespace eTickets.Models
{
    public class Producer : IEntityBase
    {
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        //Movies
        List<Producer> Producers { get; set; }

    }
}
