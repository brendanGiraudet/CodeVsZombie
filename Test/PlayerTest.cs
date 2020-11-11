
using Xunit;
using System.Collections.Generic;

namespace CodeVsZombie.Tests
{
    public class PlayerTest
    {
        [Fact]
        public void ShouldHaveTheNearestZombie()
        {
            // Arrange
            var me = new Human {
                Latitude = 0,
                Longitude = 0
            };
            var expectedZombie = new Zombie {
                NextLatitude = 5,
                NextLongitude = 8
            };
            var zombies = new List<Zombie>{
                new Zombie{
                    NextLatitude = 10,
                    NextLongitude = 10
                },
                expectedZombie
            };

            // Act
            var theNearestZombie = Player.GetTheNearestZombie(me, zombies);

            // Assert
            Assert.Equal(expectedZombie.Latitude, theNearestZombie.Latitude);
            Assert.Equal(expectedZombie.Longitude, theNearestZombie.Longitude);
        }

        [Fact]
        public void ShouldHaveTheNearestHuman()
        {
            // Arrange
            var me = new Human {
                Latitude = 0,
                Longitude = 0
            };
            var expectedHuman = new Human {
                Latitude = 5,
                Longitude = 8
            };
            var humans = new List<Human>{
                new Human{
                    Latitude = 10,
                    Longitude = 10
                },
                expectedHuman
            };

            // Act
            var theNearestHuman = Player.GetTheNearestHuman(me, humans);

            // Assert
            Assert.Equal(expectedHuman.Latitude, theNearestHuman.Latitude);
            Assert.Equal(expectedHuman.Longitude, theNearestHuman.Longitude);
        }

        [Fact]
        public void ShouldHaveTheNearestHumanInDanger()
        {
            // Arrange
            var me = new Human {
                Latitude = 0,
                Longitude = 0
            };
            
            var zombies = new List<Zombie>{
                new Zombie{
                    NextLatitude = 10,
                    NextLongitude = 10
                },
                new Zombie {
                    NextLatitude = 5,
                    NextLongitude = 8
                }
            };

            var expectedHuman = new Human {
                Latitude = 7,
                Longitude = 7
            };
            var humans = new List<Human>{
                new Human{
                    Latitude = 2,
                    Longitude = 2
                },
                expectedHuman
            };

            // Act
            var theNearestHuman = Player.GetTheNearestHumanInDanger(me, zombies, humans);

            // Assert
            Assert.Equal(expectedHuman.Latitude, theNearestHuman.Latitude);
            Assert.Equal(expectedHuman.Longitude, theNearestHuman.Longitude);
        }
    }
}
