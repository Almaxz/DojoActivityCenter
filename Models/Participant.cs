using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DojoActivities.Models
{
    public class Participant
    {
        [Key]
        public int ParticipantId { get; set; }  
        public int UserId { get; set; }
        public int ActivityId { get; set; }

        public User Ninja { get; set; }
        public DojoActivity DojoActivity { get; set; }
    }
}