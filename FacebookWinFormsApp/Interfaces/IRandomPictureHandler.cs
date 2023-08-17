

namespace FacebookApp.Interfaces
{
    public interface IRandomPictureHandler
    {
        void GetRandomPost(out string o_pictureUrl, out string o_Date, out string o_Location, out string o_Text);
    }
}
