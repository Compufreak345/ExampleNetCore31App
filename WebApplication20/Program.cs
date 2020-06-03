using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebApplication20
{
	public class Program
	{
		public static void Main(string[] args)
		{
			File.AppendAllText("log.txt", $"{DateTime.Now.ToLongTimeString()}:Starting\r\n");
			/*try
			{*/
				CreateWebHostBuilder(args).Build().Run();
			/*}
			catch (Exception)
			{
				File.AppendAllText("log.txt", $"{DateTime.Now.ToLongTimeString()}:Exiting\r\n");
				Environment.Exit(-1);
			}*/
		}

		public static IHostBuilder CreateWebHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder( args )
				.ConfigureWebHostDefaults( webBuilder =>
				{
					webBuilder
						.UseStartup<Startup>();
				} );
	}
}