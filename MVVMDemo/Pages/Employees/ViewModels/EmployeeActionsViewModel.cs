using Microsoft.AspNetCore.Components;
using MVVMDemo.Pages.Employees.Dtos;

namespace MVVMDemo.Pages.Employees.ViewModels
{
    public class EmployeeActionsViewModel
    {
        private readonly NavigationManager _navigationManager;
        private readonly EmployeeFormViewModel _employeeFormViewModel;

        public EmployeeActionsViewModel(NavigationManager navigationManager,
            EmployeeFormViewModel employeeFormViewModel)
        {
            _navigationManager = navigationManager;
            _employeeFormViewModel = employeeFormViewModel;
            Initialize();
        }

        public Action CreateEmployeeAction { get; set; }

        public Action<Employee> UpdateEmployeeAction { get; set; }

        public void Initialize()
        {
            CreateEmployeeAction = () =>
            {
                _employeeFormViewModel.IsUpdate = false;
                _navigationManager.NavigateTo("/employees/create");
            };
            UpdateEmployeeAction = (employee) =>
            {
                _employeeFormViewModel.IsUpdate = true;
                _employeeFormViewModel.Employee = employee;
                _navigationManager.NavigateTo("/employees/update");
            };
        }
    }
}
