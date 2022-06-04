using AuthServer.Core.DTOs;
using SharedLibrary.DTOs;

namespace AuthServer.Core.Services
{
    public interface IAuthenticationService
    {
        Task<Response<TokenDto>> CreateTokenAsync(LoginDto loginDto);

        Task<Response<TokenDto>> CreateTokenByRefreshToken(string refreshToken);

        Task<Response<NoDataDto>> RevokeRefreshToken(string refreshToken);

        Task<Response<ClientTokenDto>> CreateTokenByClient(ClientLoginDto clientLoginDto);
    }
}
