using System;
using RestSharp;


namespace OMDb
{
	public class OMDbCallManager
	{
		private readonly IRestClient _client;

		public string StringContent { get; set; }

		public OMDbCallManager()
		{
			_client = new RestClient(OMDbConfigReader.BaseUrl);
		}

		public void GetMovieByTitle(string movieTitle, string year = "", string type = "")
		{
			var request = new RestRequest(OMDbConfigReader.ApiUrlMod + OMDbConfigReader.ApiKey + "&t=" + movieTitle + "&y=" + year + "&type=" + type);
			StringContent = _client.Execute(request, Method.GET).Content;
		}

		public void GetMovieByID(string iMDbID)
		{
			var request = new RestRequest(OMDbConfigReader.ApiUrlMod + OMDbConfigReader.ApiKey + "&i=" + iMDbID);
			StringContent = _client.Execute(request, Method.GET).Content;
		}
	}
}
