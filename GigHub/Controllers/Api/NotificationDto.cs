using System;
using System.ComponentModel.DataAnnotations;
using GigHub.Models;

namespace GigHub.Controllers.Api
{
    public class NotificationDto
    {
        //public int Id { get; private set; }  no need to tell client

        public DateTime DateTime { get; set; }

        public NotificationType Type { get; set; }

        public DateTime? OriginalDateTime { get; set; }

        public string OriginalVenue { get; set; }

        public GigDto Gig { get; set; }
    }
}