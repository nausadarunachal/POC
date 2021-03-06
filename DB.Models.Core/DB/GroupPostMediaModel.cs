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
	[Table("GroupPostMedia", Schema = "dbo")]
	public partial class GroupPostMediaModel : BaseModel
	{
		#region normal properties

		[Display(Name = "Create Date")]
		public DateTime CreateDate { get; set; }

		[Display(Name = "Group Post Id")]
		public int GroupPostId { get; set; }

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Display(Name = "Id")]
		public int Id { get; set; }

		[Display(Name = "Media Name"), MaxLength(300), Required(AllowEmptyStrings = true)]
		public string MediaName { get; set; }

		[Display(Name = "Media Type"), MaxLength(50), Required(AllowEmptyStrings = true)]
		public string MediaType { get; set; }

		[Display(Name = "Update Date")]
		public DateTime? UpdateDate { get; set; }

		#endregion

		#region navigation properties

		[ForeignKey("GroupPostId")]
		public virtual GroupPostModel GroupPost { get; set; }

		#endregion
	}
}
