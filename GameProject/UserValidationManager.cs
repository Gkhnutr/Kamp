using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
         IUserValidationService _userValidationService;

        public UserValidationManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public bool Validate(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
