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
using DGDean.Models.Attributes;
using DGDean.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models.Core.DB
{
	[Table("WorkExp", Schema = "dbo")]
	public partial class WorkExpModel : BaseModel
	{
		#region normal properties

		[Display(Name = "City"), MaxLength(100), Required(AllowEmptyStrings = true)]
		public string City { get; set; }

		[Display(Name = "Company Email"), MaxLength(200)]
		public string CompanyEmail { get; set; }

		[Display(Name = "Company Name"), MaxLength(200), Required(AllowEmptyStrings = true)]
		public string CompanyName { get; set; }

		[Display(Name = "Consultant Id")]
		public int? ConsultantId { get; set; }

		[Display(Name = "Create Date")]
		public DateTime CreateDate { get; set; }

		[Display(Name = "Currently Working")]
		public bool CurrentlyWorking { get; set; }

		[Display(Name = "Description"), Required(AllowEmptyStrings = true)]
		public string Description { get; set; }

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Display(Name = "Id")]
		public int Id { get; set; }

		[Active(true), Display(Name = "Is Active")]
		public bool IsActive { get; set; }

		[Display(Name = "Position"), MaxLength(200)]
		public string Position { get; set; }

		[Display(Name = "Update Date")]
		public DateTime? UpdateDate { get; set; }

		[Display(Name = "User Id")]
		public int? UserId { get; set; }

		[Display(Name = "Working From")]
		public DateTime WorkingFrom { get; set; }

		[Display(Name = "Working To")]
		public DateTime? WorkingTo { get; set; }

		#endregion

		#region navigation properties

		[ForeignKey("ConsultantId")]
		public virtual ConsultantModel Consultant { get; set; }

		[ForeignKey("UserId")]
		public virtual UserModel User { get; set; }

		#endregion
	}
}
