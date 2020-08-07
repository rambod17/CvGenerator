using CG.Core.Cv.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CG.Core.Cv.Handlers
{
    public class AddNewCvHandler : IRequestHandler<AddNewCvCommand>
    {
        private readonly IRepository<Domain.Entities.Cv> _cvRepository;

        public AddNewCvHandler(IRepository<Domain.Entities.Cv> cvRepository)
        {
            _cvRepository = cvRepository;
        }

        public async Task<Unit> Handle(AddNewCvCommand request, CancellationToken cancellationToken)
        {
            var cv = new Domain.Entities.Cv
            {
                Name = request.Name
            };

            await _cvRepository.Add(cv);
            await _cvRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
