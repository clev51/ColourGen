using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RandomColorGen.Test
{
	[TestClass]
	public class ColorGenTest
	{
		[TestMethod]
		public void When_generating_a_color_a_color_is_returned()
		{
			ColourGen c = new ColourGen();
			string color = c.Generate();
			Assert.IsTrue(color=="Red");
		}
	}
}
