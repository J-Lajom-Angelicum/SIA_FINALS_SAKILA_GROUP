namespace SIA_FINALS_SAKILA_GROUP.Models.DTOS.FilmActor
{
    public class FilmActorUpdateDTO
    {
        public int ActorId { get; set; }

        public int FilmId { get; set; }

        public DateTime LastUpdate { get; set; }
    }
}
