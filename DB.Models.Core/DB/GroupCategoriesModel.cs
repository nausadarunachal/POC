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
	[Table("GroupCategories", Schema = "dbo")]
	public partial class GroupCategoriesModel : BaseModel
	{
		#region normal properties

		[Display(Name = "Category Name"), MaxLength(400), Required(AllowEmptyStrings = true)]
		public string CategoryName { get; set; }

		[Display(Name = "Create Date")]
		public DateTime CreateDate { get; set; } 

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Display(Name = "Id")]
		public int Id { get; set; }

		[Active(true), Display(Name = "Is Active")]
		public bool IsActive { get; set; } = true;

		#endregion

		#region navigation properties

		[InverseProperty("GroupCategory")]
		public virtual ICollection<GroupModel> GroupModels { get; set; }

		#endregion
	}
}
