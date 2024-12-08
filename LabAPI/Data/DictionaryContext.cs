using LabAPI.Models.Dictionary;
using Microsoft.EntityFrameworkCore;

namespace LabAPI.Data;

public class DictionaryContext(DbContextOptions<DictionaryContext> options) : DbContext(options)
{
    public DbSet<Biomaterial> Biomaterials { get; set; }
}