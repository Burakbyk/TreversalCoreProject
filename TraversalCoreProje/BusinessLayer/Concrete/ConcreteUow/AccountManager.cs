using BusinessLayer.Abstract.AbstactUow;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ConcreteUow
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUowDal _uowaDal;

        public AccountManager(IAccountDal accountDal, IUowDal uowaDal)
        {
            _accountDal = accountDal;
            _uowaDal = uowaDal;
        }

        public Account TGetByID(int id)
        {
           return _accountDal.GetById(id);
        }

        public void TInsert(Account t)
        {
            _accountDal.Insert(t);
            _uowaDal.Save();
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountDal.MultiUpdate(t);
            _uowaDal.Save();
        }

        public void TUpdate(Account t)
        {
           _accountDal.Update(t);
            _uowaDal.Save();
        }
    }
}
