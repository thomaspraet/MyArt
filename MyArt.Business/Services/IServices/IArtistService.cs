using MyArt.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyArt.Business.Services.IServices
{
    public interface IArtistService
    {
        Task<Artist?> GetArtistByIdAsync(int id);
        Task<IEnumerable<Artist>> GetAllArtistsAsync();
        Task<Artist> CreateArtistAsync(Artist Artist);
        Task UpdateArtistAsync(Artist Artist);
        Task DeleteArtistAsync(int id);
    }
}
