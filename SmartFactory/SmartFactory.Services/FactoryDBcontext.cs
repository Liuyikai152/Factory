using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
namespace SmartFactory.Services
{
    public class FactoryDBcontext : DbContext
    {
        public FactoryDBcontext() : base("FactoryDBcontext")
        {

        }
       
    }
}
