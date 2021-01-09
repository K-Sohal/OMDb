using Newtonsoft.Json;

namespace OMDb
{
	public class MovieDTO
	{
		public MovieInformation movieInformation { get; set; }

		public void DeserializeRates(string MovieResponse)
		{
			movieInformation = JsonConvert.DeserializeObject<MovieInformation>(MovieResponse);
		}
	}
}
