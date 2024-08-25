using MatchMakingServer.Model.DTO.Request;
using MatchMakingServer.Model.DTO.Response;
using Microsoft.AspNetCore.Mvc;

namespace MatchMakingServer.Controller;

[ApiController]
[Route("api/[controller]")]
public class InsideRoomHandler : ControllerBase
{

    [HttpPost]
    public async Task<InsideRoomResponseParams> Post([FromBody] InsideRoomRequestParams requestParams)
    {

        return new InsideRoomResponseParams();
    }
}