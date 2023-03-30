﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IProviderBLL
    {
        //TODO: FIND KEYWORD PRODUCT

        //TODO: CLASS CUSTOMER /BLL DAO LAYER
        //TODO: CUSTOMER FIND KEYWORD

        //TODO: PROJECT NUNIT TEST
        void CreateProvider(Provider provider);
        Provider GetProviderById(long id);
        List<Provider> GetAllProviders();
        void UpdateProvider(Provider provider);
        void DeleteProvider(long id);
    }
}
