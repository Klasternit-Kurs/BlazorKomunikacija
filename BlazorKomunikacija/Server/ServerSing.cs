using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorKomunikacija.Server
{
	public class ServerSing
	{
		private int _nekiBroj;
		public int NekiBroj 
		{ 
			get => _nekiBroj;
			set 
			{
				_nekiBroj = value;
				Promena?.Invoke();
			} 
		}

		public event Action Promena;
	}
}
