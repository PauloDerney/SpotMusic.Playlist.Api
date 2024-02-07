using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("spoty-music")]
    public class PlaylistController : ControllerBase
    {
        private readonly ILogger<PlaylistController> _logger;

        public PlaylistController(ILogger<PlaylistController> logger)
        {
            _logger = logger;
        }

        [HttpPost("playlists")]
        public async Task<IActionResult> CreatePlaylistAsync(object playlist)
        {
            return await Task.FromResult(new CreatedResult("", ""));
        }

        [HttpGet("playlists")]
        public async Task<IActionResult> GetAllPlaylistAsync()
        {
            return await Task.FromResult(Ok("playlist"));
        }

        [HttpPost("playlists/{id}/musics/{idMusic}")]
        public async Task<IActionResult> AddMusicToPlaylist(int id, int idMusic)
        {
            return await Task.FromResult(new CreatedResult("", ""));
        }


        [HttpDelete("playlists/{id}/musics/{idMusic}")]
        public async Task<IActionResult> RemoveMusicToPlaylist(int id, int idMusic)
        {
            return await Task.FromResult(new NoContentResult());
        }
    }
}