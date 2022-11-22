using EntityFramework2.Models;
using EntityFramework2.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework2.Controllers
{
	public class StaffController : Controller
	{
		private readonly IStaffRepository staffRepository;

		public StaffController(IStaffRepository _staffRepository)
		{
			staffRepository = _staffRepository; 
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Registration()
		{
			
			return View(staffVM);
		}

		[HttpPost]

		public IActionResult Registration(StaffViewModel staffVM)
		{
			
			staffRepository.Add(staffVM);
			return View();
		}
	}
}
