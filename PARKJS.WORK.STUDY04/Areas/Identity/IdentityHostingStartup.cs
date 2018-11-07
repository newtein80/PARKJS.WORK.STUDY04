using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PARKJS.WORK.STUDY04.Data;
using PARKJS.WORK.STUDY04.Models.CustomIdentityModel;

[assembly: HostingStartup(typeof(PARKJS.WORK.STUDY04.Areas.Identity.IdentityHostingStartup))]
namespace PARKJS.WORK.STUDY04.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}