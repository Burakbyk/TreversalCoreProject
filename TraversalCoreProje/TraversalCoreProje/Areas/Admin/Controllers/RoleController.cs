using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
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
    }
}
