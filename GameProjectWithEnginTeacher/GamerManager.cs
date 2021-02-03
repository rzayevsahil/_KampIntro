using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectWithEnginTeacher
{
    //MikroService
    class GamerManager : IGamerService
    {
        //bir manager sınıfı içinde başka bir manager sınfı kullanacaksan asla onu newleme onun yerine constructor kullan
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
