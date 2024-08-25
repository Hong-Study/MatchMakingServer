using MatchMakingServer.Model.DTO;
using MatchMakingServer.Model.DTO.Request;
using MatchMakingServer.Model.DTO.Response;
using Microsoft.AspNetCore.Mvc;

namespace MatchMakingServer.Controller;

[ApiController]
[Route("api/[controller]")]
public class CreateRoomController : ControllerBase
{
    [HttpPost]
    public async Task<CreateRoomResponseParams> Post([FromBody] CreateRoomRequestParams requestParams)
    {
        // todo

        return new CreateRoomResponseParams();
    }
}