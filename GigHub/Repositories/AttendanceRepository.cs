﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GigHub.Core.Models;

namespace GigHub.Repositories
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly ApplicationDbContext _context;

        public AttendanceRepository(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        /*return type should not be list, 
         IE allow us to iterator amony attendances*/
        public IEnumerable<Attendance> GetFutureAttendances(string userId)
        {
            return _context.Attendances
                .Where(a => a.AttendeeId == userId && a.Gig.DateTime > DateTime.Now)
                .ToList();
        }

       public Attendance GetAttendance(int gigId, string userId)
        {
           return  _context.Attendances
               .SingleOrDefault(a => a.GigId == gigId && a.AttendeeId == userId);

        }
    }
}