using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace OMDb
{
	public class OMDbService
	{
		public MovieDTO MovieDTO { get; set; } = new MovieDTO();

		public string Movie { get; set; }

		public JObject Json_Movie { get; set; }

		public OMDbService() {}

		public OMDbService(string StringContent)
		{
			Movie = StringContent;

			Json_Movie = JsonConvert.DeserializeObject<JObject>(Movie);

			MovieDTO.DeserializeRates(Movie);
		}
	}
}
