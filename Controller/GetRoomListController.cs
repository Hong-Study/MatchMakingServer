using MatchMakingServer.Model.DTO.Request;
using MatchMakingServer.Model.DTO.Response;
using Microsoft.AspNetCore.Mvc;

namespace MatchMakingServer.Controller;

[ApiController]
[Route("api/[controller]")]
public class GetRoomListController : ControllerBase
{

    [HttpPost]
    public async Task<GetRoomListResponseParams> Post([FromBody] GetRoomListRequestParams requestParams)
    {

        return new GetRoomListResponseParams();
    }
}