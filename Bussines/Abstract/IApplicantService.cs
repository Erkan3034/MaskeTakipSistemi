using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
    public interface IApplicantService
    {
        //metot imzaları
        void ApplyForMask(Person person);

        List<Person> GetList();
        bool CheckPerson(Person person); //Mernise bağlanıp Doğru bir adam mı diye kontrol sağlayacak

    }
}
