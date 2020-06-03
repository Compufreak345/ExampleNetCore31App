using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication20
{
	public class ThrowingStartupFilter : IStartupFilter
	{
		public Action<IApplicationBuilder> Configure( Action<IApplicationBuilder> next )
		{
			return builder =>
			{
				//throw new Exception();
				next( builder );
			};
		}
	}
}
