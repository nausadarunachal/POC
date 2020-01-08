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
	[Table("Consultant", Schema = "dbo")]
	public partial class ConsultantModel : BaseModel
	{
		#region normal properties

		[Display(Name = "About Yourself"), Required(AllowEmptyStrings = true)]
		public string AboutYourself { get; set; }

		[Display(Name = "Address"), MaxLength(400)]
		public string Address { get; set; }

		[Display(Name = "Area Of Expertise")]
		public int? AreaOfExpertise { get; set; }

		[Display(Name = "Biography")]
		public string Biography { get; set; }

		[Display(Name = "Cover Image"), MaxLength(300)]
		public string CoverImage { get; set; }

		[Display(Name = "Create Date")]
		public DateTime? CreateDate { get; set; }

		[Display(Name = "Date Of Birth")]
		public DateTime? DateOfBirth { get; set; }

		[Display(Name = "Display Name"), MaxLength(200), Required(AllowEmptyStrings = true)]
		public string DisplayName { get; set; }

		[Display(Name = "Education"), MaxLength(200), Required(AllowEmptyStrings = true)]
		public string Education { get; set; }

		[Display(Name = "Email Address"), MaxLength(200), Required(AllowEmptyStrings = true)]
		public string EmailAddress { get; set; }

		[Display(Name = "Full Name"), MaxLength(200), Required(AllowEmptyStrings = true)]
		public string FullName { get; set; }

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Display(Name = "Id")]
		public int Id { get; set; }

		[Display(Name = "Image"), MaxLength(300)]
		public string Image { get; set; }

		[Active(true), Display(Name = "Is Active")]
		public bool IsActive { get; set; }

		[Display(Name = "Phone Number"), MaxLength(20)]
		public string PhoneNumber { get; set; }

		[Display(Name = "Skills"), MaxLength(500)]
		public string Skills { get; set; }

		[Display(Name = "State"), MaxLength(100), Required(AllowEmptyStrings = true)]
		public string State { get; set; }

		[Display(Name = "Update Date")]
		public DateTime? UpdateDate { get; set; }

		[Display(Name = "Website"), MaxLength(200)]
		public string Website { get; set; }

		[Display(Name = "Year Of Experience")]
		public double? YearOfExperience { get; set; }

		#endregion

		#region navigation properties

		[InverseProperty("Consultant")]
		public virtual ICollection<ConsultantCommentsModel> ConsultantCommentsModels { get; set; }

		[InverseProperty("Consultant")]
		public virtual ICollection<ConsultantLikesModel> ConsultantLikesModels { get; set; }

		[InverseProperty("Consultant")]
		public virtual ICollection<ConsultantPostModel> ConsultantPostModels { get; set; }

		[ForeignKey("AreaOfExpertise")]
		public virtual ExpertiseAreaModel ExpertiseAreaModel { get; set; }

		[InverseProperty("Consultant")]
		public virtual ICollection<GroupCommentsModel> GroupCommentsModels { get; set; }

		[InverseProperty("Consultant")]
		public virtual ICollection<GroupLikesModel> GroupLikesModels { get; set; }

		[InverseProperty("Consultant")]
		public virtual ICollection<GroupMembersModel> GroupMembersModels { get; set; }

		[InverseProperty("Consultant")]
		public virtual ICollection<UserCommentsModel> UserCommentsModels { get; set; }

		[InverseProperty("Consultant")]
		public virtual ICollection<UserLikesModel> UserLikesModels { get; set; }

		[InverseProperty("Consultant")]
		public virtual ICollection<UserPostModel> UserPostModels { get; set; }

		[InverseProperty("Consultant")]
		public virtual ICollection<WorkExpModel> WorkExpModels { get; set; }

		#endregion
	}
}
