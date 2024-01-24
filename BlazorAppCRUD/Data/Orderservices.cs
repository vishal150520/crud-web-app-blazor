using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Data
{
    public class Orderservices
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public Orderservices(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Employees
        public async Task<List<Orders>> GetOrder()
        {
            return await _appDBContext.order.ToListAsync();
        }
        public async Task<List<Windows>> GetWindows()
        {
            return await _appDBContext.window.ToListAsync();
        }
        public async Task<List<SubElements>> GetSubElement()
        {
            return await _appDBContext.subelement.ToListAsync();
        }
        #endregion

        #region Insert Employee
        public async Task<bool> InsertOrder(Orders orders)
        {
            await _appDBContext.order.AddAsync(orders);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> InsertWindows(Windows windows)
        {
            await _appDBContext.window.AddAsync(windows);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> InsertSubElement(SubElements subElements)
        {
            await _appDBContext.subelement.AddAsync(subElements);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Employee by Id
        public async Task<Orders> GetOrder(int OrderId)
        {
            Orders order = await _appDBContext.order.FirstOrDefaultAsync(c => c.OrderId.Equals(OrderId));
            return order;
        }
        public async Task<Windows> GetWindows(int WindowId)
        {
            Windows windows = await _appDBContext.window.FirstOrDefaultAsync(c => c.WindowId.Equals(WindowId));
            return windows;
        }
        public async Task<SubElements> GetSubElement(int SubElementId)
        {
            SubElements SubElement = await _appDBContext.subelement.FirstOrDefaultAsync(c => c.SubElementId.Equals(SubElementId));
            return SubElement;
        }
        #endregion

        #region Update Employee
        public async Task<bool> Updateorder(Orders orders)
        {
            _appDBContext.order.Update(orders);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Updatewindow(Windows windows)
        {
            _appDBContext.window.Update(windows);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Updatesubelement(SubElements subElements)
        {
            _appDBContext.subelement.Update(subElements);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        #endregion

        #region DeleteEmployee
        public async Task<bool> DeleteOrder(Orders orders)
        {
            _appDBContext.order.Remove(orders);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteWindow(Windows windows)
        {
            _appDBContext.window.Remove(windows);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteSublist(SubElements subElements)
        {
            _appDBContext.subelement.Remove(subElements);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
