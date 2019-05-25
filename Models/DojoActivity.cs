using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DojoActivities.Models
{
    public class DojoActivity
	{
		[Key]
		public int ActivityId { get; set; }

		[Required(ErrorMessage = "Please enter a name for the activity!")]
		public string Title { get; set; }

		[DataType(DataType.Date)]
		[FutureDate(ErrorMessage = ("Date must be in the future!"))]
		[Required(ErrorMessage = "Please enter a date for the activity!")]
		public DateTime Date { get; set; }
		
		[DataType(DataType.Time)]
		[Required(ErrorMessage = "Please enter a time for the activity!")]
		public DateTime Time { get; set; }

		[Required(ErrorMessage = "Please enter a duration period for the activity!")]
		public int Duration { get; set; }

		[Required(ErrorMessage = "Please specify the unit of the duration period activity!")]
		public string DurationUnit { get; set; }

		[Required(ErrorMessage = "Please enter a description of the activity!")]
		public string Description { get; set; }


		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public DateTime UpdatedAt { get; set; } = DateTime.Now;


		public int CoordinatorId { get; set; }
		public User Coordinator { get; set; }


		public List<Participant> UserParticipating {get; set;}

	}
	public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value != null && (DateTime)value > DateTime.Now;
        }
    }
}