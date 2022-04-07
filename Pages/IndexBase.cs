using Microsoft.AspNetCore.Components;
using Radzen.Blazor;

namespace TinyMceBackwardsRadzenDatagridRepro.Pages
{
    public class IndexBase : ComponentBase
    {
        public RadzenDataGrid<Employee> EmployeeGrid;
        public List<Employee> EmployeeList;
        
        protected override async Task OnInitializedAsync()
        {
            EmployeeList = GetEmployeeData();
            await base.OnInitializedAsync();
        }

        public void InsertRow()
        {
            var employee = new Employee()
            {
                Id = EmployeeList.Count + 1,
                FirstName = "A",
                LastName = "B"
            };

            EmployeeGrid.InsertRow(employee);
        }

        public void OnCreateRow(Employee employee)
        {
            EmployeeList.Add(employee);

            var orderedList = EmployeeList.OrderBy(s => s.Id).ToList();
            EmployeeList = orderedList;
        }

        public void OnUpdateRow(Employee employee)
        {
            
        }

        public void EditRow(Employee employee)
        {
            EmployeeGrid.EditRow(employee);
        }

        public void SaveRow(Employee employee)
        {
            EmployeeGrid.UpdateRow(employee);

            var orderedList = EmployeeList.OrderBy(s => s.Id).ToList();

            EmployeeList = orderedList;
        }

        public void CancelEdit(Employee employee)
        {
            EmployeeGrid.CancelEditRow(employee);
        }

        protected List<Employee> GetEmployeeData()
        {
            var employeeData = new List<Employee>
            {
                new Employee()
                {
                    Id = 1,
                    FirstName = "Joe",
                    LastName = "Smith",
                    Notes = "Notes1"
                },

                new Employee()
                {
                    Id = 2,
                    FirstName = "Tom",
                    LastName = "Thumb",
                    Notes = "Notes2"
                }
            };

            return employeeData;
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string Notes { get; set; }
    }
}