using AutoMapper;

namespace LCH.MercedesBenz.Api.Models.Application.FechaCierres
{
    public class FechaCierreRepository : BaseRepository<FechaCierre>, IFechaCierreRepository
    {
        private readonly IMapper _mapper;

        public FechaCierreRepository(
            ApplicationDbContext context,
            IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

    }
}
