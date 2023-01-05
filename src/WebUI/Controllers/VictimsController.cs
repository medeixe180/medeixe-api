using medeixeApi.Application.Victims.Commands.AddVictim;
using medeixeApi.WebUI.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
public class VictimsController : ApiControllerBase
{
    [HttpPost]
    public async Task<ActionResult<int>> Add(AddVictimCommand command)
    {
        return await Mediator.Send(command);
    }
}