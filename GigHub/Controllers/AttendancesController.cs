using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GigHub.Dtos;
using GigHub.Models;
using Microsoft.AspNet.Identity;

namespace GigHub.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {

        private ApplicationDbContext _contex;

        public AttendancesController()
        {
            _contex = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto dto)
        {

            var userId = User.Identity.GetUserId();

            var exists = _contex.Attendances.
                Any(a => a.AttendeeId == userId && a.GigId == dto.GigId);

            if(exists)
                return BadRequest("The attendance already exists.");

            var attendance = new Attendance
            {
                GigId = dto.GigId,
                AttendeeId = userId
            };

            _contex.Attendances.Add(attendance);
            _contex.SaveChanges();

            return Ok();
        }
    }
}
