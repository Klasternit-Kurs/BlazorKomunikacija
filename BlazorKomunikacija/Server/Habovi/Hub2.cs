using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorKomunikacija.Server.Habovi
{
	public class Hub2 : Hub
	{
		private readonly ServerSing _br;
		public Hub2(ServerSing br)
		{
			_br = br;
		}

		public void Inc2()
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
