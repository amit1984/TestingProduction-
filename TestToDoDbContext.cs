using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Production.DAL;
using System.Configuration;

namespace UnitTestProduction
{
    class TestToDoDbContext : BusContext
    {
        public TestToDoDbContext()
            : base("Data Source=AMIT-PC;Initial Catalog=test2;User ID=sa;Password=tima0176")
        { }
    }
}
