using System.Collections.Generic;
using System.Threading.Tasks;
using Xfw.Models;

namespace Xfw.Repositories
{
    internal interface IMovieRepository
    {
        Task<(string error, List<Movie>)> GetUpcoming();
    }
}