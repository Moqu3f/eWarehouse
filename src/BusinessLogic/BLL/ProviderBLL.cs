using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using DataAccess.Context;
using DataAccess.Interfaces;
using eWarehouse.DataAccess.DAO;
using Models;

namespace BusinessLogic.BLL
{
    public class ProviderBLL : IProviderBLL
    {
        private readonly IProviderDAO _providerDAO;

        public ProviderBLL(IProviderDAO providerDAO)
        {
            _providerDAO = providerDAO;
        }

        public void CreateProvider(Provider provider)
        {
            try
            {
                _providerDAO.Create(provider);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw ex;
            }
        }

        public Provider GetProviderById(long id)
        {
            try
            {
                return _providerDAO.GetById(id);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw ex;
            }
        }

        public List<Provider> GetAllProviders()
        {
            try
            {
                return _providerDAO.GetAll();
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw ex;
            }
        }

        public void UpdateProvider(Provider provider)
        {
            try
            {
                _providerDAO.Update(provider);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw ex;
            }
        }

        public void DeleteProvider(long id)
        {
            try
            {
                _providerDAO.Delete(id);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw ex;
            }
        }
    }

}
