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
	[Table("AspNetUsers", Schema = "dbo")]
	public partial class AspNetUsersModel : BaseModel
	{
		#region normal properties

		[Display(Name = "Access Failed Count")]
		public int AccessFailedCount { get; set; }

		[Display(Name = "Concurrency Stamp")]
		public string ConcurrencyStamp { get; set; }

		[Display(Name = "Email"), MaxLength(256)]
		public string Email { get; set; }

		[Display(Name = "Email Confirmed")]
		public bool EmailConfirmed { get; set; }

		[Key, Display(Name = "Id"), MaxLength(450), Required(AllowEmptyStrings = true)]
		public string Id { get; set; }

		[Display(Name = "Lockout Enabled")]
		public bool LockoutEnabled { get; set; }

		[Display(Name = "Lockout End")]
		public DateTimeOffset? LockoutEnd { get; set; }

		[Display(Name = "Normalized Email"), Index("EmailIndex"), MaxLength(256)]
		public string NormalizedEmail { get; set; }

		[Display(Name = "Normalized User Name"), Index("UserNameIndex"), MaxLength(256)]
		public string NormalizedUserName { get; set; }

		[Display(Name = "Password Hash")]
		public string PasswordHash { get; set; }

		[Display(Name = "Phone Number")]
		public string PhoneNumber { get; set; }

		[Display(Name = "Phone Number Confirmed")]
		public bool PhoneNumberConfirmed { get; set; }

		[Display(Name = "Security Stamp")]
		public string SecurityStamp { get; set; }

		[Display(Name = "Two Factor Enabled")]
		public bool TwoFactorEnabled { get; set; }

		[Display(Name = "User Name"), MaxLength(256)]
		public string UserName { get; set; }

		#endregion

		#region navigation properties

		[InverseProperty("User")]
		public virtual ICollection<AspNetUserClaimsModel> AspNetUserClaimsModels { get; set; }

		[InverseProperty("User")]
		public virtual ICollection<AspNetUserLoginsModel> AspNetUserLoginsModels { get; set; }

		[InverseProperty("User")]
		public virtual ICollection<AspNetUserRolesModel> AspNetUserRolesModels { get; set; }

		[InverseProperty("User")]
		public virtual ICollection<AspNetUserTokensModel> AspNetUserTokensModels { get; set; }

		#endregion
	}
}
