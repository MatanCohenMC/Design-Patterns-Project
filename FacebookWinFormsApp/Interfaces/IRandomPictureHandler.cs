

namespace FacebookApp.Interfaces
{
    public interface IRandomPictureHandler
    {
        void GetRandomPictureUrl(out string o_pictureUrl, out string o_pictureUpdatedTime);
    }
}
