using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccess.Interfaces
{
   
        public interface IProviderDAO
        {
            void Create(Provider provider);
            Provider GetById(long id);
            List<Provider> GetAll();
            void Update(Provider provider);
            void Delete(long id);
        }
    
}
