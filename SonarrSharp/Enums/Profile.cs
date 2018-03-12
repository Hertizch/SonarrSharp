using System.ComponentModel;

namespace SonarrSharp.Enums
{
    public enum Profile
    {
        [Description("SDTV")] SDTV,
        [Description("WEBDL-480p")] WEBDL480p,
        [Description("DVD")] DVD,
        [Description("HDTV-720p")] HDTV720p,
        [Description("HDTV-1080p")] HDTV1080p,
        [Description("Raw-HD")] RawHD,
        [Description("WEBDL-720p")] WEBDL720p,
        [Description("Bluray-720p")] Bluray720p,
        [Description("WEBDL-1080p")] WEBDL1080p,
        [Description("Bluray-1080p")] Bluray1080p,
        [Description("HDTV-2160p")] HDTV2160p,
        [Description("WEBDL-2160p")] WEBDL2160p,
        [Description("Bluray-2160p")] Bluray2160p
    }
}
