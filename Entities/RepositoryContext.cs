using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
  public  class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

    }
}
