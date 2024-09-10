using MVVMDemo.Pages.Employees.Dtos;

namespace MVVMDemo.Pages.Employees.ViewModels
{
    public class EmployeeFormViewModel
    {
        private readonly EmployeeListViewModel _employeeListViewModel;
        public EmployeeFormViewModel(EmployeeListViewModel employeeListViewModel)
        {
            _employeeListViewModel = employeeListViewModel;
        }

        public Employee Employee { get; set; } = new();

        public bool IsUpdate { get; set; }

        public void SaveEmployee()
        {
            if (!IsUpdate)
            {
                _employeeListViewModel.Employees.Add(Employee);
                return;
            }

            var index = _employeeListViewModel.Employees.IndexOf(Employee);
            _employeeListViewModel.Employees[index] = Employee;
        }
    }
}
