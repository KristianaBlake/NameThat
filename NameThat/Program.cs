using System;

namespace NameThat
{
    public class Program 
    {
        public static void btnSearch_Click(object sender, EventArgs e)
        {
            string userInput = e.ToString();

            if (userInput == null || userInput.Length == 0)
            {
                throw new ApplicationException("The title you have entered Does Not Exist");
            }
            else
            {
                string apiKey = "942af2e";
                string searchUrl = $"http://www.omdbapi.com/?t=" + userInput + "&apikey=" + apiKey;

                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString(searchUrl);
                    JavaScriptSerializer oJS = new JavaScriptSerializer();
                    Program obj - new Program();
                    obj = oJS. Deserialize<OmdbAPI>(json);
                    if (obj.Response == "True")
                    {
                        OmdbAPI.Title == obj.Title;
                        OmdbAPI.Type == obj.Type;
                        OmdbAPI.Picture == obj.Picture;
                        OmdbAPI.YearOfRelease == obj.YearOfRelease
                    }
                    else
                    {
                        OmdbSearchAPI.Title == "";
                        OmdbSearchAPI.Type == "";
                        OmdbSearchAPI.Picture == "";
                        OmdbSearchAPI.YearOfRelease == "";
                    }
                }
            }
        }
    }
}