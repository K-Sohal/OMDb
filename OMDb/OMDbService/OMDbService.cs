using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace OMDb
{
	public class OMDbService
	{
		public OMDbCallManager OMDbCallManager { get; set; } = new OMDbCallManager();

		public MovieDTO MovieDTO { get; set; } = new MovieDTO();

		public string Movie { get; set; }

		public JObject Json_Movie { get; set; }

		public void Deserialize()
		{
			Json_Movie = JsonConvert.DeserializeObject<JObject>(Movie);

			MovieDTO.DeserializeRates(Movie);
		}

		public OMDbService() {}

		public OMDbService(string iMDbID)
		{
			Movie = OMDbCallManager.GetMovieByID(iMDbID);

			Deserialize();
		}
		public OMDbService(string movieTitle, string year, string season, string episode, string type)
		{
			Movie = OMDbCallManager.GetMovieByTitle(movieTitle, year, season, episode, type);

			Deserialize();
		}
	}
}
