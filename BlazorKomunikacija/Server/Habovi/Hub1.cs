using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorKomunikacija.Server.Habovi
{
	
	public class Hub1 : Hub
	{
		private readonly ServerSing _br;
		public Hub1(ServerSing br)
		{
			_br = br;
		}

		public void Inc1()
		{
			_br.NekiBroj++;
			Clients.Caller.SendAsync("broj", _br.NekiBroj);
		}

		public void GetVal()
		{
			Clients.Caller.SendAsync("broj", _br.NekiBroj);
		}

	}
}
