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
    public class AccountManager : IAccountService
    {
        private readonly IAccountDAL _accountDAL;

        public AccountManager(IAccountDAL accountDAL)
        {
            _accountDAL = accountDAL;
        }

        public void TDelete(Account entity)
        {
            _accountDAL.Delete(entity);
        }

        public List<Account> TGetAll()
        {
            return _accountDAL.GetAll();
        }

        public Account TGetByID(int id)
        {
            return _accountDAL.GetByID(id);
        }

        public void TInsert(Account entity)
        {
            _accountDAL.Insert(entity);
        }

        public void TUpdate(Account entity)
        {
            _accountDAL.Update(entity);
        }
    }
}
