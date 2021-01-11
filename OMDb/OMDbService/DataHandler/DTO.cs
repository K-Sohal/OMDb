using Newtonsoft.Json;

namespace OMDb
{
	public class DTO
	{
		public Model movieInformation { get; set; }

		public void DeserializeRates(string MovieResponse)
		{
			movieInformation = JsonConvert.DeserializeObject<Model>(MovieResponse);
		}
	}
}
