using Microsoft.AspNetCore.Http;
using Odon.Track.Application.Configuration;
using Odon.Track.Application.Crypto;
using Org.BouncyCastle.Asn1.Ocsp;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Odon.Track.Application.GetToken
{
    public class GetHeaderValues()
    {
        public static int GetIdUsuario(IEnumerable<Claim> claims)
        {
            var idUsuarioHash = claims.First(claim => claim.Type == ClaimTypes.NameIdentifier);
            if(idUsuarioHash == null)
                return 0;

            int idUsuario = int.Parse(EncryptionHelper.Decrypt(idUsuarioHash.Value));

            return idUsuario;

        }
    }
}
