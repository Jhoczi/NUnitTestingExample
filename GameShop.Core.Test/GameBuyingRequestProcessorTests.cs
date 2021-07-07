using System;
using NUnit.Framework;

namespace GameShop.Core.Test
{
    [TestFixture]
    public class GameBuyingRequestProcessorTests
    {
        private GameBuyingRequestProcessor _processor;

        public GameBuyingRequestProcessorTests()
        {
            _processor = new GameBuyingRequestProcessor();
        }
        [Test]
        public void ShouldReturnGameBuyingResultWithRequestValues()
        {
            
            // Arrange
            var request = new GameBuyingRequest()
            {
                FirstName = "Cezary",
                LastName = "Walenciuk",
                Email = "walenciukc@gmail.com",
                Date = DateTime.Now
            };
            
            // Act
            GameBuyingResult result = _processor.BuyGame(request);
            
            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(request.FirstName, result.FirstName);
            Assert.AreEqual(request.LastName, result.LastName);
            Assert.AreEqual(request.Email, result.Email);
            Assert.AreEqual(request.Date, result.Date);
        }

        [Test]
        public void ShouldThrowExceptionIfRequestIsNull()
        {

            var exception = Assert.Throws<ArgumentNullException>(
                () =>  _processor.BuyGame(null)
                );

            Assert.AreEqual("request",exception.ParamName);
        }

        [Test]
        public void ShouldReturnStatusTrueWhenSendedCorrectValues()
        {
            var request = new GameBuyingRequest()
            {
                FirstName = "Cezary",
                LastName = "Walenciuk",
                Email = "walenciukc@gmail.com",
                Date = DateTime.Now
            };

            GameBuyingResult result = _processor.BuyGame(request);
            
            Assert.AreEqual(true,result.IsStatusOk);
            Assert.AreEqual(0, result.Errors.Count);
        }
        
    }
    
}