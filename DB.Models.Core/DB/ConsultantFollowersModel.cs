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
	[Table("ConsultantFollowers", Schema = "dbo")]
	public partial class ConsultantFollowersModel : BaseModel
	{
		#region normal properties

		[Display(Name = "Date")]
		public DateTime Date { get; set; }

		[Display(Name = "Followed By Consultant")]
		public int? FollowedByConsultant { get; set; }

		[Display(Name = "Followed By User")]
		public int? FollowedByUser { get; set; }

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Display(Name = "Id")]
		public int Id { get; set; }

		[Display(Name = "Profile Consultant Id")]
		public int ProfileConsultantId { get; set; }

		#endregion
	}
}