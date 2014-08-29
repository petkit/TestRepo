using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWeb.Models
{
	public class TestModel
	{
		private IList<TestItem> _testItems = new List<TestItem>()
		{
			new TestItem() {Name = "FirstItem", Id = 1, Description = "Descrition of first item."},
			new TestItem() {Name = "SecondItem", Id = 2, Description = "Descrition of second item."},
			new TestItem() {Name = "ThirdItem", Id = 3, Description = "Descrition of third item."}
		};

		public IList<TestItem> Items { get { return _testItems; } }
	}
}