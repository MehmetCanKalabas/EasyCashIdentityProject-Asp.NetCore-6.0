using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Repositories;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Entity_Framework
{
    public class EfCustomerAccountProcessDal : GenericRepository<CustomerAccountProcess>,ICustomerAccountProcessDal
    {
    }
}
