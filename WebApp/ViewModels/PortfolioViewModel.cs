using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels
{
    public class PortfolioViewModel
    {
        public Guid Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile File { get; set; } //IFormFile tomathil el milafat el kadima f http request
    }
}
