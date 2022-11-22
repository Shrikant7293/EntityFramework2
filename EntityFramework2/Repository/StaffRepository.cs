using EntityFramework2.DataLayer;
using EntityFramework2.Models;

namespace EntityFramework2.Repository
{
	public class StaffRepository : IStaffRepository
	{
		public void Add(StaffViewModel staffVM)
		{
			BrightDb3Context db= new BrightDb3Context();

			Staff staff = new Staff();
			staff.Id = staffVM.Id;
			staff.Name = staffVM.Name;
			staff.Position = staffVM.Position;
			staff.Salary = staffVM.Salary;

			db.Staff.Add(staff);

			
		}

	}
}
