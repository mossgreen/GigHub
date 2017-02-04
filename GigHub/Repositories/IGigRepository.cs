using System.Collections.Generic;
using GigHub.Core.Models;

namespace GigHub.Repositories
{
    public interface IGigRepository
    {
        Gig GetGig(int id);
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        Gig GetGigWithAttendees(int gigId);
        IEnumerable<Gig> GetUpcomingGigsByArtist(string userId);
        void Add(Gig gig);
    }
}