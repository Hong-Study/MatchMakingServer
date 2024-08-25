using MatchMakingServer.Model.DTO;
using MatchMakingServer.Model.DTO.Request;
using MatchMakingServer.Model.DTO.Response;
using Microsoft.AspNetCore.Mvc;

namespace MatchMakingServer.Controller;

[ApiController]
[Route("api/[controller]")]
public class FindRoomController : ControllerBase
{
    [HttpPost]
    public async Task<FindRoomResponseParamas> Post([FromBody] FindRoomRequestParams requestParams)
    {
        return new FindRoomResponseParamas();
    }
}