﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCleanArchitectureApp.Infrastructure
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfraDI(this IServiceCollection services)
		{
			return services;
		}
	}
}
