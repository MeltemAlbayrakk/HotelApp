using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Otelim.Context;
using Otelim.Models;

namespace Otelim.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly HotelContext _context;

        public ReservationsController(HotelContext context)
        {
            _context = context;
        }

        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            var hotelContext = _context.Reservations.Include(r => r.Hotel).Include(r => r.PaymentType).Include(r => r.User);
            return View(await hotelContext.ToListAsync());
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Reservations == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .Include(r => r.Hotel)
                .Include(r => r.PaymentType)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.ReservationId == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Reservations/Create
        public IActionResult Create()
        {
            ViewData["HotelId"] = new SelectList(_context.Hotels, "HotelId", "HotelAddress");
            ViewData["PaymentTypeId"] = new SelectList(_context.PaymentTypes, "PaymentTypeId", "PaymentTypeName");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserEmail");
            return View();
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReservationId,UserId,HotelId,numOfAdult,ArrivalDate,ExitDate,PaymentTypeId,Price")] Reservation reservation)
        {

            //reservation.User = _context.Users.FirstOrDefault(p => p.UserId == reservation.UserId);
            //reservation.Hotel = _context.Hotels.FirstOrDefault(p => p.HotelId == reservation.HotelId);
            //reservation.PaymentType = _context.PaymentTypes.FirstOrDefault(p => p.PaymentTypeId == reservation.PaymentTypeId);
            
            
                reservation.Price = _context.Hotels.FirstOrDefault(p => p.HotelId == reservation.HotelId).Price;
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details));
            
            //ViewData["HotelId"] = new SelectList(_context.Hotels, "HotelId", "HotelAddress", reservation.HotelId);
            //ViewData["PaymentTypeId"] = new SelectList(_context.PaymentTypes, "PaymentTypeId", "PaymentTypeId", reservation.PaymentTypeId);
            //ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserEmail", reservation.UserId);
            //return View(reservation);
        }

        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Reservations == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            ViewData["HotelId"] = new SelectList(_context.Hotels, "HotelId", "HotelAddress", reservation.HotelId);
            ViewData["PaymentTypeId"] = new SelectList(_context.PaymentTypes, "PaymentTypeId", "PaymentTypeId", reservation.PaymentTypeId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserEmail", reservation.UserId);
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReservationId,UserId,HotelId,numOfAdult,ArrivalDate,ExitDate,PaymentTypeId,Price")] Reservation reservation)
        {
            if (id != reservation.ReservationId)
            {
                return NotFound();
            }

            
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.ReservationId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Details));
            
            //ViewData["HotelId"] = new SelectList(_context.Hotels, "HotelId", "HotelAddress", reservation.HotelId);
            //ViewData["PaymentTypeId"] = new SelectList(_context.PaymentTypes, "PaymentTypeId", "PaymentTypeId", reservation.PaymentTypeId);
            //ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserEmail", reservation.UserId);
            //return View(reservation);
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Reservations == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .Include(r => r.Hotel)
                .Include(r => r.PaymentType)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.ReservationId == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Reservations == null)
            {
                return Problem("Entity set 'HotelContext.Reservations'  is null.");
            }
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation != null)
            {
                _context.Reservations.Remove(reservation);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
          return _context.Reservations.Any(e => e.ReservationId == id);
        }
    }
}
