using System;
using NUnit.Framework;

namespace OMDb
{
	public class OMDbTests
	{
		private readonly OMDbCallManager _parameter = new OMDbCallManager();
		private readonly OMDbService _movie = new OMDbService();

		public OMDbTests()
		{
			_parameter.GetMovieByTitle("batman");
			_movie = new OMDbService(_parameter.StringContent);
		}

		[Test]
		public void WebCallSuccessCheck()
		{
			Assert.That(_movie.MovieDTO.movieInformation.Response);
		}


	}
}
