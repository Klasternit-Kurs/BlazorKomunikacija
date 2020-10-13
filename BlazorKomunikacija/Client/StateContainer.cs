using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorKomunikacija.Client
{
	public class StateContainer
	{
		private int _broj;
		public int Broj 
		{ 
			get => _broj; 
			set
			{
				_broj = value;
				DosloDoPromene?.Invoke();
			}
		}
		private string _nekiString;
		public string NekiString 
		{ 
			get => _nekiString; 
			set
			{
				_nekiString = value;
				DosloDoPromene?.Invoke();
			}
		}

		public event Action DosloDoPromene;
	}
}
