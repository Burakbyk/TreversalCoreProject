using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        private readonly UserManager<AppUser> _userManager;


        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [Route("Admin/Role/Index")]
        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();

            return View(values);
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
           

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            AppRole role = new AppRole()
            {
                Name = model.RoleName
            };
            var result = await _roleManager.CreateAsync(role);
            if(result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
           
        }

        public async Task<IActionResult> DeleteRole(int id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x=>x.Id==id);
            if(value==null)
            {
                return View();
            }
            else
            {
                await _roleManager.DeleteAsync(value);
                return RedirectToAction("Index");
            }
                               
        }

        [HttpGet]
        public async Task<IActionResult> UpdateRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x=>x.Id==id);

            UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel()
            {
                RoleID = id,
                RoleName = values.Name
            };


            return View(updateRoleViewModel);

        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel model)
        {
            var value = _roleManager.Roles.FirstOrDefault(x=>x.Id == model.RoleID);
            if(value==null)
            {
                return View();
            
            }
            else
            {
                value.Name = model.RoleName;
                await _roleManager.UpdateAsync(value);
                return RedirectToAction("Index");
            }


           
        }

        [Route("Admin/Role/UserList")]
        public IActionResult UserList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }

        [HttpGet]        
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x=>x.Id==id);
            TempData["UserId"] = user.Id;
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
            List<AssignRoleViewModel> listAssignRoles = new List<AssignRoleViewModel>();        
            foreach (var item in roles)
            {
                AssignRoleViewModel model = new AssignRoleViewModel();
                model.RoleId = item.Id;
                model.RoleName = item.Name;
                model.RoleExist = userRoles.Contains(item.Name);
                listAssignRoles.Add(model);
            
            }
           
                return View(listAssignRoles);
            
          
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(List<AssignRoleViewModel> model)
        {
            var userId = (int)TempData["UserId"];
            var user = _userManager.Users.FirstOrDefault(x=>x.Id==userId);
            foreach (var item in model)
            {
                if(item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user,item.RoleName);

                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user,item.RoleName);
                }
            
            }

            return RedirectToAction("UserList");
        }
       
    }
}
