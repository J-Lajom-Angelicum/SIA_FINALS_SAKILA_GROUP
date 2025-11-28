using Microsoft.EntityFrameworkCore;

namespace SIA_FINALS_SAKILA_GROUP.Models.Repositories
{
    public class FilmTextRepository : BaseRepository<FilmText>, IFilmTextRepository
    {
        public FilmTextRepository(sakila2021Context context) : base(context)
        {
        }

        // Override GetByIdAsync specifically for FilmText
        public override async Task<FilmText?> GetByIdAsync(int id)
        {
            // Cast int to short because FilmId is short
            return await _context.FilmTexts.FindAsync((short)id);
        }

        // Override DeleteAsync for FilmText
        public override async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.FilmTexts.FindAsync((short)id);
            if (entity == null) return false;

            _context.FilmTexts.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        
    }
}
