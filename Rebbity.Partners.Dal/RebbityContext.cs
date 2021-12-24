using Microsoft.EntityFrameworkCore;
using Rebbity.Partners.Dal.Models;

namespace Rebbity.Partners.Dal;
public class RebbityContext : DbContext
{
    public DbSet<Feedback> Feedbacks { get; set; }
}
