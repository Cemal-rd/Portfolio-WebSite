using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContactManager:IContactService
    { 
        IContactDal _dal;

        public ContactManager(IContactDal dal)
        {
            _dal = dal;
        }

        public void TAdd(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetList()
        {
            return _dal.GetList();
        }

        public Contact TGetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
