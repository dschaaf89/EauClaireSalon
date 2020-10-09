using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
namespace HairSalon.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // public string Stylist {get;set;}
        public virtual Stylist Stylist { get; set; }
        public int StylistId { get; set; }

    }
}