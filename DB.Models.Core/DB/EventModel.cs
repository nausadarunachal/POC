/* *** THIS FILE IS GENERATED BY A REALLY SMART ROBOT.      ***
   *** IF YOU EDIT THIS FILE, THE ROBOT WILL EAT YOUR CODE, ***
   *** AND REPLACE YOUR CODE WITH HIS, BECAUSE THAT'S HOW   ***
   *** HE ROLLS. YOU HAVE BEEN WARNED.                      ***

   *** Seriously, if you want to make changes to this file, ***
   *** either run the template that created it again,       ***
   *** or change the template code, at the project path     ***
   *** below.                                               ***

   *** DB.Models/Code Templates/TextTemplate.tt     ***
*/
using DGDean.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models.Core.DB
{
	[Table("Event", Schema = "dbo")]
	public partial class EventModel : BaseModel
	{
		#region normal properties

		[Display(Name = "Created By Consultant")]
		public int? CreatedByConsultant { get; set; }

		[Display(Name = "Created By User")]
		public int? CreatedByUser { get; set; }

		[Display(Name = "End Date")]
		public DateTime EndDate { get; set; }

		[Display(Name = "End Time")]
		public TimeSpan EndTime { get; set; }

		[Display(Name = "Event Details"), Required(AllowEmptyStrings = true)]
		public string EventDetails { get; set; }

		[Display(Name = "Event Heading"), MaxLength(300)]
		public string EventHeading { get; set; }

		[Display(Name = "Event Image"), MaxLength(200), Required(AllowEmptyStrings = true)]
		public string EventImage { get; set; }

		[Display(Name = "Event Name"), MaxLength(300), Required(AllowEmptyStrings = true)]
		public string EventName { get; set; }

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Display(Name = "Id")]
		public int Id { get; set; }

		[Display(Name = "Location"), MaxLength(100)]
		public string Location { get; set; }

		[Display(Name = "Price"), MaxLength(100), Required(AllowEmptyStrings = true)]
		public string Price { get; set; }

		[Display(Name = "Start Date")]
		public DateTime StartDate { get; set; }

		[Display(Name = "Start Time")]
		public TimeSpan StartTime { get; set; }

		#endregion
	}
}
