using RihalApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihalApp.Domain.Repositories
{
    public interface IGetCountriesUseCaseRepository
    {
        Task<List<Country>> GetCountriesAsync(CancellationToken cancellationToken);
    }
}
