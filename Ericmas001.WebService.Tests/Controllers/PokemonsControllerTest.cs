using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ericmas001.WebService.Controllers;
using Ericmas001.WebService.DataAccess;
using Ericmas001.WebService.Tests.DataAccess;
using OmgPokedex.DataTypes;
using OmgPokedex.DataTypes.BasicImplementations;

namespace Ericmas001.WebService.Tests.Controllers
{
    [TestClass]
    public class PokemonsControllerTest
    {

        [TestMethod]
        public void Get()
        {
            // Arrange
            PokemonsController controller = new PokemonsController(GetDbMock());

            // Act
            IEnumerable<IPokemon> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            var pokemons = result as IPokemon[] ?? result.ToArray();
            Assert.AreEqual(m_Pokemons.Length, pokemons.Length);
            foreach(var rp in pokemons)
            {
                Assert.IsNotNull(rp);
                var p = m_Pokemons.SingleOrDefault(x => x.Id == rp.Id);
                Assert.IsNotNull(p);
                ComparePokemon(p, rp);
            }
        }

        [TestMethod]
        public void GetByValidId()
        {
            // Arrange
            PokemonsController controller = new PokemonsController(GetDbMock());

            // Act
            IPokemon result = controller.Get(25);

            // Assert
            Assert.IsNotNull(result);
            var p = m_Pokemons.SingleOrDefault(x => x.Id == result.Id);
            Assert.IsNotNull(p);
            ComparePokemon(p, result);
        }

        [TestMethod]
        public void GetByInvalidId()
        {
            // Arrange
            PokemonsController controller = new PokemonsController(GetDbMock());

            // Act
            IPokemon result = controller.Get(42);

            // Assert
            Assert.IsNotNull(result);
            var p = m_Pokemons.SingleOrDefault(x => x.Id == result.Id);
            Assert.IsNull(p);
            ComparePokemon(new UnknownPokemon(result.Id), result);
        }

        //[TestMethod]
        //public void Post()
        //{
        //    // Arrange
        //    ValuesController controller = new ValuesController();

        //    // Act
        //    controller.Post("value");

        //    // Assert
        //}

        //[TestMethod]
        //public void Put()
        //{
        //    // Arrange
        //    ValuesController controller = new ValuesController();

        //    // Act
        //    controller.Put(5, "value");

        //    // Assert
        //}

        //[TestMethod]
        //public void Delete()
        //{
        //    // Arrange
        //    ValuesController controller = new ValuesController();

        //    // Act
        //    controller.Delete(5);

        //    // Assert
        //}
        private static readonly IPokemon[] m_Pokemons = {
                new Pokemon {Id = 25, Name = "Pikachu", Generation = "Generation I", Type = "Electric", Photo = "http://www.pokemonimages.com/Pikachu.png"},
                new Pokemon() {Id = 152, Name = "Chikorita", Generation = "Generation II", Type = "Grass", Photo = "http://www.pikachu.com/Chikorita.png"}
            };

        private static IPokemonDb GetDbMock()
        {
            return new PokemonDbMock(m_Pokemons);
        }

        private void ComparePokemon(IPokemon expected, IPokemon result)
        {
            Assert.AreEqual(expected.Id, result.Id);
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Generation, result.Generation);
            Assert.AreEqual(expected.Type, result.Type);
            Assert.AreEqual(expected.Photo, result.Photo);
        }
    }
}
