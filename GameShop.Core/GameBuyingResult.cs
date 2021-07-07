using System;
using System.Collections.Generic;

namespace GameShop.Core
{
    public class GameBuyingResult
    {
        public GameBuyingResult()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public bool IsStatusOk { get; set; }
        public List<string> Errors { get; set; }
        
    }

    public class GameBuyingRequestProcessor
    {
        public GameBuyingResult BuyGame(GameBuyingRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            
            var result = new GameBuyingResult();

            result.FirstName = request.FirstName;
            result.LastName = request.LastName;
            result.Date = request.Date;
            result.Email = request.Email;
            result.IsStatusOk = true;
            result.Errors = new List<string>();

            return result;
        }
    }
    
}

