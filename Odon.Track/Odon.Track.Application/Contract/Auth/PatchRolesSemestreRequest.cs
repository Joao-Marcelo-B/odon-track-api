namespace Odon.Track.Application.Contract.Auth
{
    public class PatchRolesSemestreRequest
    {
        public int Periodo { get; set; }
        public List<int> Roles { get; set; }
    }
}
