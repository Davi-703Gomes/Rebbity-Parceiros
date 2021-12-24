using Rebbity.Partners.Dal.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebbity.Partners.Dal.Models;

public class Feedback
{
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [StringLength(500, MinimumLength = 5)]
    public string Email { get; set; }
    [Required]
    public DegreeOfSatisfaction Satisfaction { get; set; }
}

