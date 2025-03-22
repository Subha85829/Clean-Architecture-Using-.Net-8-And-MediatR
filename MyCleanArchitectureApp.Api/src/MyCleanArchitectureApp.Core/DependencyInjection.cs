﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCleanArchitectureApp.Core
{
	/// <summary>
	/// Dependency Injection for Core
	/// </summary>
	public static class DependencyInjection
	{
		/// <summary>
		/// Add Core DI
		/// </summary>
		/// <param name="services"></param>
		/// <returns></returns>
		public static IServiceCollection AddCoreDI(this IServiceCollection services)
		{
			return services;
		}
	}
}
