using MidTerm.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MidTerm.Components
{
    public class VeterinarianMenuViewComponent : ViewComponent
    {
        //Note: Custom Component, will populate a dynamic drop down menu
        private readonly ApplicationDbContext _context;

        public VeterinarianMenuViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var veterinarian = await _context.Veterinarians.ToListAsync();
            return View(veterinarian);
        }
    }
}