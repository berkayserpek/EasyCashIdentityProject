using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class AccountProcessManager : IAccountProcessService
    {
        private readonly IAccountProcessDAL _accountProcessDAL;

        public AccountProcessManager(IAccountProcessDAL accountProcessDAL)
        {
            _accountProcessDAL = accountProcessDAL;
        }

        public void TDelete(AccountProcess entity)
        {
            _accountProcessDAL.Delete(entity);
        }

        public List<AccountProcess> TGetAll()
        {
            return _accountProcessDAL.GetAll();
        }

        public AccountProcess TGetByID(int id)
        {
            return _accountProcessDAL.GetByID(id);
        }

        public void TInsert(AccountProcess entity)
        {
            _accountProcessDAL.Insert(entity);
        }

        public void TUpdate(AccountProcess entity)
        {
            _accountProcessDAL.Update(entity);
        }
    }
}
