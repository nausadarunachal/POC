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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models.Core.DB
{
	[Table("AspNetRoleClaims", Schema = "dbo")]
	public partial class AspNetRoleClaimsModel : BaseModel
	{
		#region normal properties

		[Display(Name = "Claim Type")]
		public string ClaimType { get; set; }

		[Display(Name = "Claim Value")]
		public string ClaimValue { get; set; }

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Display(Name = "Id")]
		public int Id { get; set; }

		[Display(Name = "Role Id"), Index("IX_AspNetRoleClaims_RoleId"), MaxLength(450), Required(AllowEmptyStrings = true)]
		public string RoleId { get; set; }

		#endregion

		#region navigation properties

		[ForeignKey("RoleId")]
		public virtual AspNetRolesModel Role { get; set; }

		#endregion
	}
}
