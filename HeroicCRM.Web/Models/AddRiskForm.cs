using Heroic.AutoMapper;
using HeroicCRM.Web.Core;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace HeroicCRM.Web.Models
{
	public class AddRiskForm : IMapTo<Risk>
	{
        [HiddenInput]
		public int CustomerId { get; set; }

        [Required]
		public string Title { get; set; }

        [DataType(DataType.MultilineText)]
		public string Description { get; set; }
	}
}