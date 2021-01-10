using System;
using RestSharp;


namespace OMDb
{
	public class OMDbCallManager
	{
		private readonly IRestClient _client;

		public OMDbCallManager()
		{
			_client = new RestClient(ConfigReader.BaseUrl);
		}

		public string GetMovieByTitle(string movieTitle, string year, string season, string episode, string type)
		{
			var request = new RestRequest(ConfigReader.ApiUrlMod + ConfigReader.ApiKey + "&t=" + movieTitle + "&y=" + year + "&Season=" + season + "&Episode=" + episode + "&type=" + type);
			return _client.Execute(request, Method.GET).Content;
		}

		public string GetMovieByID(string iMDbID)
		{
			var request = new RestRequest(ConfigReader.ApiUrlMod + ConfigReader.ApiKey + "&i=" + iMDbID);
			return _client.Execute(request, Method.GET).Content;
		}



	}
}
