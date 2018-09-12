using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;

namespace StoreBaeltBilletLibrary
{
	public class Bil : BilletLibrary.Bil
	{
		public override decimal Pris()
		{
			decimal price = base.Pris();
			// Check if weekend
			if (Dato.DayOfWeek == DayOfWeek.Saturday ||
			    Dato.DayOfWeek == DayOfWeek.Sunday)
			{
				price = price * 0.8m;
			}

			return price;
		}
	}
}
