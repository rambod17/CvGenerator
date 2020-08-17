using CG.Core.Person.Commands;
using CG.Core.Person.Handlers;
using CG.Core.Person.Queries;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CG.Core.Tests.Handlers
{
    public class PersonHandlersTests
    {
        private readonly Mock<IRepository<Domain.Entities.Person>> _personRepositoryMock;
        private readonly Mock<IRepository<Domain.Entities.Country>> _countryRepositoryMock;

        public PersonHandlersTests()
        {
            _personRepositoryMock = new Mock<IRepository<Domain.Entities.Person>>();
            _countryRepositoryMock = new Mock<IRepository<Domain.Entities.Country>>();
        }

        [Fact]
        public async Task NewPersonShouldBeAddedAsync()
        {
            var handler = new AddNewPersonHandler(_personRepositoryMock.Object, _countryRepositoryMock.Object);
            var request = new AddNewPersonCommand
            {
                CountryId = 1
            };

            _countryRepositoryMock.Setup(x => x.GetById(It.IsAny<int>())).Returns(Task.FromResult(GetMockedCountry()));

            await handler.Handle(request, CancellationToken.None);

            _countryRepositoryMock.Verify(x => x.GetById(It.IsAny<int>()));
            _personRepositoryMock.Verify(x => x.Add(It.IsAny<Domain.Entities.Person>()), Times.Once);
            _personRepositoryMock.Verify(x => x.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task GetByIdShouldBeExecutedAsync()
        {
            var handler = new GetPersonByIdHandler(_personRepositoryMock.Object);
            var request = new GetPersonByIdQuery(1);

            _personRepositoryMock.Setup(x => x.GetById(It.IsAny<int>())).Returns(Task.FromResult(GetMockedPerson()));

            var person = await handler.Handle(request, CancellationToken.None);

            Assert.NotNull(person);
            _personRepositoryMock.Verify(x => x.GetById(It.IsAny<int>()), Times.Once);
        }

        #region Mocked Objects
        private Domain.Entities.Person GetMockedPerson()
        {
            return new Domain.Entities.Person
            {
                Id = 1,
                Birthdate = new DateTime(1995, 1, 21),
                FirstName = "Foo",
                LastName = "Bar",
                Email = "foo@bar.com",
                PhoneNumber = "123",
                CellNumber = "456",
                Country = GetMockedCountry()
            };
        }

        private Domain.Entities.Country GetMockedCountry()
        {
            return new Domain.Entities.Country
            {
                Id = 1,
                Name = "Argentina"
            };
        }
        #endregion
    }
}
