using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
<<<<<<< HEAD
=======
using System.Linq;
>>>>>>> dev

namespace OMDb
{
	public class Service
	{
		public OMDbCallManager OMDbCallManager { get; set; } = new OMDbCallManager();

		public DTO DTO { get; set; } = new DTO();

		public string Movie { get; set; }

		public JObject Json_Movie { get; set; }

		public void Deserialize()
		{
			Json_Movie = JsonConvert.DeserializeObject<JObject>(Movie);

			DTO.DeserializeRates(Movie);
		}

<<<<<<< HEAD
=======

>>>>>>> dev
		public Service(string iMDbID)
		{
			Movie = OMDbCallManager.GetMovieByID(iMDbID);

			Deserialize();
		}
		public Service(string movieTitle, string year, string season, string episode, string type)
		{
			Movie = OMDbCallManager.GetMovieByTitle(movieTitle, year, season, episode, type);

			Deserialize();
		}
	}
}
