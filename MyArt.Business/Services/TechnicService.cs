using MyArt.Business.Services.IServices;
using Microsoft.EntityFrameworkCore;
using MyArt.DataAccess.Migrations;
using MyArt.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyArt.Business.Services
{
    public class TechnicService : ITechnicService
    {
        private readonly ApplicationDbContext _context;

        public TechnicService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Technic>> GetAllTechnicsAsync()
        {
            return await _context.Technics.ToListAsync();
        }

        public async Task<Technic?> GetTechnicByIdAsync(int id)
        {
            return await _context.Technics.FindAsync(id);
        }

        public async Task<Technic> CreateTechnicAsync(Technic technic)
        {
            _context.Technics.Add(technic);
            await _context.SaveChangesAsync();
            return technic;
        }

        public async Task DeleteTechnicAsync(int id)
        {
            var technic = _context.Technics.Find(id);
            if (technic == null)
            {
                throw new KeyNotFoundException($"Technic with id {id} not found.");
            }
            _context.Technics.Remove(technic);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTechnicAsync(Technic technic)
        {
            _context.Technics.Update(technic);
            await _context.SaveChangesAsync();
        }
    }
}
