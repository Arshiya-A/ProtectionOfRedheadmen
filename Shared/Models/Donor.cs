using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Donor
    {
        [Key]
        public int DonorID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public bool IsShowInDonorsList { get; set; }
    }
}