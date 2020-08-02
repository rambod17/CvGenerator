using MediatR;

namespace CG.Core.Cv.Commands
{
    public class AddNewCvCommand : IRequest
    {
        public string Name { get; set; }
    }
}
