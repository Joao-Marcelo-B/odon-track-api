namespace Odon.Track.Application.ConvertTypes
{
    public static partial class ConvertTypes
    {
        public static int? ConvertBoolForIntNull(this bool? boolean) => boolean == null ? null : (boolean == true ? 1 : 0);
    }
}
