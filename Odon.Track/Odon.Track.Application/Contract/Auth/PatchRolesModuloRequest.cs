namespace Odon.Track.Application.Contract.Auth
{
    public class PatchRolesModuloRequest
    {
        public int Modulo { get; set; }
        public List<int> Roles { get; set; }
    }
}
