using System;
using System.Linq;
using Xunit;

namespace Pets.Presentation.Tests
{
    public class PetViewModelTests
    {
        [Fact]
        public void OnRefreshPetsIsPopulated()
        {
            // arrange
            var reader = new FakeReader();
            var vm = new PetsViewModel(reader);

            // act
            vm.RefreshPets();

            // assert
            Assert.NotNull(vm.Pets);
            Assert.Equal(2, vm.Pets.Count());
        }

        [Fact]
        public void OnClearPetsIsEmpty()
        {
            // arrange
            var reader = new FakeReader();
            var vm = new PetsViewModel(reader);
            vm.RefreshPets();
            Assert.NotEmpty(vm.Pets);

            // act
            vm.ClearPets();

            // assert
            Assert.Empty(vm.Pets);
        }
    }
}
