using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectWithEnginTeacher
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==01985 && gamer.FirstName=="ENGİN" 
                && gamer.LastName=="DEMİROĞ" && gamer.IdentityNumber==12345)
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
