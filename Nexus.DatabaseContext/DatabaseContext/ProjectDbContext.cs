using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Nexus.Model.Model;

namespace Nexus.DatabaseContext.DatabaseContext
{
  public  class ProjectDbContext:DbContext
    {
      public  DbSet<Customer> Customers { set; get; }

    }
}
