
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PrototypeA.Models;

namespace WebApplication1.Controllers
{
    
    public class AdminController : Controller
    {
        private readonly Microsoft.AspNetCore.Identity.RoleManager<IdentityRole> roleManager;
        public AdminController(Microsoft.AspNetCore.Identity.RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
            public IActionResult Index()
        {
            return View();

        }
        public IActionResult Create()
        { 
            return View(); 
        
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProjectRole role)
        {
            var roleExist = await roleManager.RoleExistsAsync(role.RoleName);
            if (!roleExist) { var result = await roleManager.CreateAsync(new IdentityRole(role.RoleName)); }
            return View();

        }
    }
}
