namespace Odon.Track.Application.Contract.Auth
{
    public class PostRolesSemestreRequest
    {
        public int Periodo { get; set; }
        public List<int> Roles { get; set; }
    }
}
