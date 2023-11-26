namespace Dgmjr.InsultGenerator.Models;

using Dgmjr.EntityFrameworkCore.Models;

public class Insult : Entity<int>
{
    public virtual string Text { get; set; }

    public ICollection<Insult> Insults { get; } = new Collection<Insult>();
    public ICollection<Insult> Comebacks { get; } = new Collection<Insult>();
}

public class InsultComeback : Entity<int>
{
    public int InsultId { get; set; }
    public int ComebackId { get; set; }

    public Insult Insult { get; set; }
    public Insult Comeback { get; set; }
}
