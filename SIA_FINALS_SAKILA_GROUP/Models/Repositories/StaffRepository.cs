namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public class StaffRepository : BaseRepository<Staff>, IStaffRepository
    {
        public StaffRepository(sakila2021Context context) : base(context)
        {
        }
    }
}
