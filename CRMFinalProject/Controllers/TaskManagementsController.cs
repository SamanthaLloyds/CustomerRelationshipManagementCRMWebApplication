using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CooperativeFuneralFundInc.Models.SupplyRequest;
using CooperativeFuneralFundInc.Models.TasksManagement;
using Microsoft.AspNetCore.Authorization;

namespace CooperativeFuneralFundInc.Controllers
{
    public class TaskManagementsController : Controller
    {
        private readonly CFFDataContext _context;

        public TaskManagementsController(CFFDataContext context)
        {
            _context = context;
        }

        // GET: TaskManagements
        [Authorize(Roles = "Admin, User, Visitor")]
        public async Task<IActionResult> Index()
        {
            var cFFDataContext = _context.TaskManagements;
            return View(await cFFDataContext.ToListAsync());
        }

        // GET: TaskManagements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskManagement = await _context.TaskManagements
              
                .FirstOrDefaultAsync(m => m.TaskManagementId == id);
            if (taskManagement == null)
            {
                return NotFound();
            }

            return View(taskManagement);
        }

        // GET: TaskManagements/Create
        [Authorize(Roles = "Admin, User")]
        public IActionResult Create()
        {
            ViewData["Owner"] = new SelectList(_context.OwnerNames, "Owner", "OwnerName");
            ViewData["RequestType"] = new SelectList(_context.RequestTypes, "RequestTypeId", "RequestTypeDescription");
            ViewData["Status"] = new SelectList(_context.Statuses, "StatusId", "StatusDescription");
            ViewData["Priority"] = new SelectList(_context.Priorities, "PriorityId", "PriorityName");
            ViewData["RelatedTo"] = new SelectList(_context.RelatedTos, "RelatedToId","RelatedToName");
            
            return View();
        }

        // POST: TaskManagements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TaskManagementId,Status,Owner,RelatedTo,RelatedToName,RequestType,Priority,CreateBy,CreatedTime,UpdatedBy,UpdatedTime")] TaskManagement taskManagement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taskManagement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Owner"] = new SelectList(_context.OwnerNames, "Owner", "OwnerName");
            ViewData["RequestType"] = new SelectList(_context.RequestTypes, "RequestTypeId", "RequestTypeDescription");
            ViewData["Status"] = new SelectList(_context.Statuses, "StatusId", "StatusDescription");
            ViewData["Priority"] = new SelectList(_context.Priorities, "PriorityId", "PriorityName");
            ViewData["RelatedTo"] = new SelectList(_context.RelatedTos, "RelatedToId", "RelatedToName");
            return View(taskManagement);
        }

        // GET: TaskManagements/Edit/5
        [Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskManagement = await _context.TaskManagements.FindAsync(id);
            if (taskManagement == null)
            {
                return NotFound();
            }
            ViewData["Owner"] = new SelectList(_context.OwnerNames, "Owner", "OwnerName");
            ViewData["RequestType"] = new SelectList(_context.RequestTypes, "RequestTypeId", "RequestTypeDescription");
            ViewData["Status"] = new SelectList(_context.Statuses, "StatusId", "StatusDescription");
            ViewData["Priority"] = new SelectList(_context.Priorities, "PriorityId", "PriorityName");
            ViewData["RelatedTo"] = new SelectList(_context.RelatedTos, "RelatedToId", "RelatedToName");
            return View(taskManagement);
        }

        // POST: TaskManagements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TaskManagementId,Status,Owner,RelatedTo,RelatedToName,RequestType,Priority,CreateBy,CreatedTime,UpdatedBy,UpdatedTime")] TaskManagement taskManagement)
        {
            if (id != taskManagement.TaskManagementId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taskManagement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskManagementExists(taskManagement.TaskManagementId))
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
            ViewData["Owner"] = new SelectList(_context.OwnerNames, "Owner", "OwnerName");
            ViewData["RequestType"] = new SelectList(_context.RequestTypes, "RequestTypeId", "RequestTypeDescription");
            ViewData["Status"] = new SelectList(_context.Statuses, "StatusId", "StatusDescription");
            ViewData["Priority"] = new SelectList(_context.Priorities, "PriorityId", "PriorityName");
            ViewData["RelatedTo"] = new SelectList(_context.RelatedTos, "RelatedToId", "RelatedToName");
            return View(taskManagement);
        }

        // GET: TaskManagements/Delete/5
        [Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskManagement = await _context.TaskManagements
       
                .FirstOrDefaultAsync(m => m.TaskManagementId == id);
            if (taskManagement == null)
            {
                return NotFound();
            }

            return View(taskManagement);
        }

        // POST: TaskManagements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taskManagement = await _context.TaskManagements.FindAsync(id);
            _context.TaskManagements.Remove(taskManagement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskManagementExists(int id)
        {
            return _context.TaskManagements.Any(e => e.TaskManagementId == id);
        }
    }
}
