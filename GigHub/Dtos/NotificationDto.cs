using System;
using GigHub.Models;

namespace GigHub.Dtos
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