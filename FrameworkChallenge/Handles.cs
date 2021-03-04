using System.Net;

namespace FrameworkChallenge
{
    public static class Handles
    {
        public static string GetJson(string url)
        {
            string json;
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString($@"{url}");
            }
            return json;
        }

    }
}
