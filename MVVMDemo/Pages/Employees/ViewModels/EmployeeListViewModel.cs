using MVVMDemo.Pages.Employees.Dtos;
using System.Collections.ObjectModel;

namespace MVVMDemo.Pages.Employees.ViewModels
{
    public class EmployeeListViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>(); 
    }
}
