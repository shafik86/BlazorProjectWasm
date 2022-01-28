using BlazorProject.Shared;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Client.Services
{
    public class EmployeeAdapter : DataAdaptor
    {
        private readonly IEmployeeService employeeService;
        public EmployeeAdapter(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;

        }
        public override async Task<object> ReadAsync(DataManagerRequest dataManagerRequest, string key = null)
        {
            string orderByString = null;
            if (dataManagerRequest.Sorted != null)
            {
                List<Sort> sortList = dataManagerRequest.Sorted;
                orderByString = string.Join(",", sortList.Select(s => string.Format("{0} {1}", s.Name, s.Direction)));
            }
            EmployeeDataResult result =
                await employeeService.GetEmployees(dataManagerRequest.Skip, dataManagerRequest.Take, orderByString);

            DataResult dataResult = new DataResult()
            {
                Result = result.Employees,
                Count = result.Count
            };

            return dataResult;
        }
    }
}
