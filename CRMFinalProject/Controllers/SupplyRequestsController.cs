using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CooperativeFuneralFundInc.Models.DropDownMenu;
using CooperativeFuneralFundInc.Models.SupplyRequest;
using Microsoft.AspNetCore.Authorization;

namespace CooperativeFuneralFundInc.Controllers
{
    public class SupplyRequestsController : Controller
    {
        private readonly CFFDataContext _context;

        
        public SupplyRequestsController(CFFDataContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Admin, User, Visitor")]
        // GET: Admin/SupplyRequests
        public async Task<IActionResult> Index()
        {
            var cFFDataContext = _context.SupplyRequests;
          
            return View(await cFFDataContext.ToListAsync());
        }

        // GET: Admin/SupplyRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplyRequest = await _context.SupplyRequests
               
                .FirstOrDefaultAsync(m => m.SupplyRequestId == id);
            if (supplyRequest == null)
            {
                return NotFound();
            }

            return View(supplyRequest);
        }

        [Authorize(Roles = "Admin, User")]
        // GET: Admin/SupplyRequests/Create
        public IActionResult Create()
        {
            ViewData["ClientSupplierID"] = new SelectList(_context.ClientSuppliers, "ClientSupplierID", "ClientSupplierName");
            ViewData["OrderItems"] = new SelectList(_context.OrderItems, "OrderItemsID", "OrderItemsName");
            ViewData["Owner"] = new SelectList(_context.OwnerNames, "OwnerId", "OwnerName");
            ViewData["RequestType"] = new SelectList(_context.RequestTypes, "RequestTypeId", "RequestTypeDescription");
            ViewData["Status"] = new SelectList(_context.Statuses, "StatusId", "StatusDescription");
            ViewData["RequestOrigin"] = new SelectList(_context.RequestOrigins, "RequestOriginId", "RequestOriginDescription");
            return View();
        }

        // POST: Admin/SupplyRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplyRequestId,Status,StatusComments,OrderItems,SupplyRequestOrigin,RequestType,Client,Owner,CreatedBy,CreateTime,UpdatedBy,UpdatedTime")] SupplyRequest supplyRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplyRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientSupplierID"] = new SelectList(_context.ClientSuppliers, "ClientSupplierID", "ClientSupplierName");
            ViewData["OrderItems"] = new SelectList(_context.OrderItems, "OrderItemsID", "OrderItemsName");
            ViewData["Owner"] = new SelectList(_context.OwnerNames, "OwnerId", "OwnerName");
            ViewData["RequestType"] = new SelectList(_context.RequestTypes, "RequestTypeId", "RequestTypeDescription");
            ViewData["Status"] = new SelectList(_context.Statuses, "StatusId", "StatusDescription");
            ViewData["RequestOrigin"] = new SelectList(_context.RequestOrigins, "RequestOriginId", "RequestOriginDescription");
            return View(supplyRequest);
        }

        [Authorize(Roles = "Admin, User")]
        // GET: Admin/SupplyRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplyRequest = await _context.SupplyRequests.FindAsync(id);
            if (supplyRequest == null)
            {
                return NotFound();
            }
            ViewData["ClientSupplierID"] = new SelectList(_context.ClientSuppliers, "ClientSupplierID", "ClientSupplierName");
            ViewData["OrderItems"] = new SelectList(_context.OrderItems, "OrderItemsID", "OrderItemsName");
            ViewData["Owner"] = new SelectList(_context.OwnerNames, "OwnerId", "OwnerName");
            ViewData["RequestType"] = new SelectList(_context.RequestTypes, "RequestTypeId", "RequestTypeDescription");
            ViewData["Status"] = new SelectList(_context.Statuses, "StatusId", "StatusDescription");
            ViewData["RequestOrigin"] = new SelectList(_context.RequestOrigins, "RequestOriginId", "RequestOriginDescription");
            return View(supplyRequest);
        }

        // POST: Admin/SupplyRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplyRequestId,Status,StatusComments,OrderItemsID,RequestOriginId,RequestType,ClientSupplierID,Owner,CreatedBy,CreateTime,UpdatedBy,UpdatedTime")] SupplyRequest supplyRequest)
        {
            if (id != supplyRequest.SupplyRequestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplyRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplyRequestExists(supplyRequest.SupplyRequestId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientSupplierID"] = new SelectList(_context.ClientSuppliers, "ClientSupplierID", "ClientSupplierName");
            ViewData["OrderItems"] = new SelectList(_context.OrderItems, "OrderItemsID", "OrderItemsName");
            ViewData["Owner"] = new SelectList(_context.OwnerNames, "OwnerId", "OwnerName");
            ViewData["RequestType"] = new SelectList(_context.RequestTypes, "RequestTypeId", "RequestTypeDescription");
            ViewData["Status"] = new SelectList(_context.Statuses, "StatusId", "StatusDescription");
            ViewData["RequestOrigin"] = new SelectList(_context.RequestOrigins, "RequestOriginId", "RequestOriginDescription");
            return View(supplyRequest);
        }

        [Authorize(Roles = "Admin, User")]
        // GET: Admin/SupplyRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplyRequest = await _context.SupplyRequests
               
                .FirstOrDefaultAsync(m => m.SupplyRequestId == id);
            if (supplyRequest == null)
            {
                return NotFound();
            }

            return View(supplyRequest);
        }

        // POST: Admin/SupplyRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supplyRequest = await _context.SupplyRequests.FindAsync(id);
            _context.SupplyRequests.Remove(supplyRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupplyRequestExists(int id)
        {
            return _context.SupplyRequests.Any(e => e.SupplyRequestId == id);
        }
    }
}
