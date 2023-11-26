/*
 * InsultsDbContext.cs
 *
 *   Created: 2023-24-31T16:24:38-04:00
 *   Modified: 2023-24-31T16:24:40-04:00
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.InsultGenerator;

using Dgmjr.InsultGenerator.Models;

public partial interface IInsultsDbContext : IDbContext<IInsultsDbContext>
{
    DbSet<Insult> Insults { get; set; }
}

public class InsultsDbContext(DbContextOptions<InsultsDbContext> options)
    : DbContext(options),
        IDbContext<InsultsDbContext>
{
    public virtual DbSet<Insult> Insults { get; set; }

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Insult>(builder =>
    {
        builder.HasKey(e => e.Id);
        builder
            .HasMany(e => e.Insults)
            .WithMany(e => e.Comebacks)
            .UsingEntity<InsultComeback>(
                j => j.HasOne(e => e.Insult).WithMany().HasForeignKey(e => e.InsultId),
                j => j.HasOne(e => e.Comeback).WithMany().HasForeignKey(e => e.ComebackId),
                j =>
                {
                    j.HasKey(e => e.Id);
                    j.ToTable("InsultComebacks");
                }
            );
    });
}
}
