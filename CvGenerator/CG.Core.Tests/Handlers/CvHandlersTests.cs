using CG.Core.Cv.Commands;
using CG.Core.Cv.Handlers;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CG.Core.Tests.Handlers
{
    public class CvHandlersTests
    {
        private readonly Mock<IRepository<Domain.Entities.Cv>> _cvRepositoryMock;

        public CvHandlersTests()
        {
            _cvRepositoryMock = new Mock<IRepository<Domain.Entities.Cv>>();
        }

        [Fact]
        public async Task NewCvShouldBeAddedAsync()
        {
            var handler = new AddNewCvHandler(_cvRepositoryMock.Object);
            var request = new AddNewCvCommand
            {
                Name = "Foo"
            };

            await handler.Handle(request, CancellationToken.None);

            _cvRepositoryMock.Verify(x => x.Add(It.IsAny<Domain.Entities.Cv>()), Times.Once);
            _cvRepositoryMock.Verify(x => x.SaveChangesAsync(), Times.Once);
        }
    }
}
