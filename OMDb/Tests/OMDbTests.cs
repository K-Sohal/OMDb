using System;
using NUnit.Framework;

namespace OMDb
{
	
	public class OMDbTests
	{
		
		//[TestCase("Game of Thrones", "2011", "1", "1", "Series")]
		//[TestCase("Game of Thrones", "2011", "1", "1", "")]
		//[TestCase("Game of Thrones", "2011", "1", "", "")]
		//[TestCase("Game of Thrones", "2011", "", "", "")]
		//[TestCase("Game of Thrones", "", "", "", "")]
		//public void WebCallSuccessCheckForEachCorrectParameter(string title, string year, string season, string episode, string type)
		//{
		//	OMDbService _movie = new OMDbService(title, year, season, episode, type);
		//	Assert.That(_movie.MovieDTO.movieInformation.Response);
		//}

		[TestCase("Game of Thrones", "2011", "1", "69", "Series")]
		public void ReturnsFalseResponseAndErrorWhenInvalidEpisode(string title, string year, string season, string episode, string type)
		{
			OMDbService _movie = new OMDbService(title, year, season, episode, type);
			Assert.That(!(_movie.MovieDTO.movieInformation.Response));
			Assert.That(_movie.MovieDTO.movieInformation.Error, Is.EqualTo("Series or episode not found!"));
		}

		[TestCase("Game of Thrones", "2011", "20", "1", "Series")]
		public void ReturnsFalseResponseAndErrorWhenInvalidSeason(string title, string year, string season, string episode, string type)
		{
			OMDbService _movie = new OMDbService(title, year, season, episode, type);
			Assert.That(!(_movie.MovieDTO.movieInformation.Response));
			Assert.That(_movie.MovieDTO.movieInformation.Error, Is.EqualTo("Series or episode not found!"));
		}

		[TestCase("Game of Thrones", "2005", "1", "1", "Series")]
		public void ReturnsFalseResponseAndErrorWhenInvalidYear(string title, string year, string season, string episode, string type)
		{
			OMDbService _movie = new OMDbService(title, year, season, episode, type);
			Assert.That(!(_movie.MovieDTO.movieInformation.Response));
			Assert.That(_movie.MovieDTO.movieInformation.Error, Is.EqualTo("Series or episode not found!"));
		}

		[TestCase("Game of Thrones", "2011", "1", "1", "Movie")]
		public void ReturnsFalseResponseAndErrorWhenInvalidType(string title, string year, string season, string episode, string type)
		{
			OMDbService _movie = new OMDbService(title, year, season, episode, type);
			Assert.That(!(_movie.MovieDTO.movieInformation.Response));
			Assert.That(_movie.MovieDTO.movieInformation.Error, Is.Not.Empty);
		}
	}
}
