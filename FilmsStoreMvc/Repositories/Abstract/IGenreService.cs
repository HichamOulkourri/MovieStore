using FilmsStoreMvc.Models.Domain;
using FilmsStoreMvc.Models.DTO;

namespace FilmsStoreMvc.Repositories.Abstract
{
    public interface IGenreService
    {
        bool Add(Genre model);
        bool Update(Genre model);
        Genre GetById(int id);
        bool Delete(int id);
        IQueryable<Genre> List();

    }
}
