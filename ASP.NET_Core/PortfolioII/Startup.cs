﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace PortfolioII
{
    public class Startup{
        public void ConfigureServices(IServiceCollection services){services.AddMvc();}
        public void Configure(IApplicationBuilder app, IHostingEnvironment env){if (env.IsDevelopment()){app.UseDeveloperExceptionPage();}app.UseMvc();}
        public Startup(IHostingEnvironment env){
            Console.WriteLine(env.ContentRootPath);
            Console.WriteLine(env.IsDevelopment());
        }
    }
}