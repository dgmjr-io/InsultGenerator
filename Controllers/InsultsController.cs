using Microsoft.AspNetCore.Mvc;
using Dgmjr.AspNetCore.Mvc;
using Dgmjr.WetherForecast.Models.Abstractions;
using Dgmjr.WetherForecast.Models;
using Dgmjr.AspNetCore.Controllers;
using Dgmjr.Payloads.ModelBinders;
using Range = Dgmjr.Payloads.Range;

namespace Dgmjr.InsultGenerator;

[ApiController]
[Route("[controller]")]
public class InsultsController(ILogger<InsultsController> logger, InsultsDbContext db)
    : ApiControllerBase<InsultsDbContext>(db, logger)
{
    [HttpGet("{id:int}/comebacks")]
    public Pager<Insult> Comebacks(int id, [RangeRequest] Range range) =>
        new(
            Db.Insults
                .Include(i => i.Comebacks)
                .FirstOrDefault(i => i.Id == id)
                ?.Comebacks.AsQueryable(),
            range
        );
}
