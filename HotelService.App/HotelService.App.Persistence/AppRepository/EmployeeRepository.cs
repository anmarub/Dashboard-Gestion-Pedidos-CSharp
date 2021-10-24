using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using HotelService.App.Domain;

namespace HotelService.App.Persistence.AppRepository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DbAppContext _context;

        public EmployeeRepository(DbAppContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployee()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int idEmployee)
        {
            var SearchEmployee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == idEmployee);
            return SearchEmployee;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            try
            {
                var AddingEmployee = await _context.Employees.AddAsync(employee);
                await _context.SaveChangesAsync();
                return AddingEmployee.Entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var UpdatingEmployee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == employee.Id);

            if (UpdatingEmployee != null)
            {
                UpdatingEmployee.Id = employee.Id;
                UpdatingEmployee.TypeIdentity = employee.TypeIdentity;
                UpdatingEmployee.IdentityNumber = employee.IdentityNumber;
                UpdatingEmployee.FirstName = employee.FirstName;
                UpdatingEmployee.LastName = employee.LastName;
                UpdatingEmployee.BirthDate = employee.BirthDate;
                UpdatingEmployee.PhoneNumber = employee.PhoneNumber;
                UpdatingEmployee.IdRole = employee.IdRole;

                await _context.SaveChangesAsync();
            }

            return UpdatingEmployee;
        }

        public async Task<Employee> DeleteEmployee(int idEmployee)
        {
            var DeletingEmployee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == idEmployee);

            if (DeletingEmployee != null)
            {
                _context.Employees.Remove(DeletingEmployee);
                await _context.SaveChangesAsync();
                return DeletingEmployee;
            }
            return null;
        }
    }
}