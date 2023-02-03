using eTickets.Data.Base;

namespace eTickets.Models
{
    public class Cinema : IEntityBase
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //Movies
        List<Movie> Movies { get; set; }

    }
}
