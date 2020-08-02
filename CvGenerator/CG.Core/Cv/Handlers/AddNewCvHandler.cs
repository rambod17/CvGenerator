using CG.Core.Cv.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CG.Core.Cv.Handlers
{
    public class AddNewCvHandler : IRequestHandler<AddNewCvCommand>
    {
        private readonly IRepository<Domain.Entities.Cv> _context;

        public AddNewCvHandler(IRepository<Domain.Entities.Cv> context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(AddNewCvCommand request, CancellationToken cancellationToken)
        {
            var cv = new Domain.Entities.Cv
            {
                Name = request.Name
            };

            await _context.Add(cv);
            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
