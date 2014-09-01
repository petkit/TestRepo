using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestWeb.Models
{
	public class TestDb : DbContext
	{
		public TestDb() : base("name=DefaultConnection")
		{
			
		}

		public DbSet<TestItem> Items { set; get; }
		public DbSet<TestSubItem> SubItems { set; get; }
	}
}