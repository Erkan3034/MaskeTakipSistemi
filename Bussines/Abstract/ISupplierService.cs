using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
    public interface ISupplierService //dağıtıcı servis
    {
        void GiveMask(Person person);
    }
}
