using System;
using NUnit.Framework;

namespace OMDb
{
	
	public class SearchByTitle
	{

		[TestCase("Game of Thrones", "2011", "1", "1", "Series")]
		[TestCase("Game of Thrones", "2011", "1", "1", "")]
		[TestCase("Game of Thrones", "2011", "1", "", "")]
		[TestCase("Game of Thrones", "2011", "", "", "")]
		[TestCase("Game of Thrones", "", "", "", "")]
		public void WebCallSuccessCheckForEachCorrectParameter(string title, string year, string season, string episode, string type)
		{
			Service _movie = new Service(title, year, season, episode, type);
			Assert.That(_movie.DTO.movieInformation.Response);
		}

		[Test]
		public void ReturnsFalseResponseAndErrorWhenInvalidEpisode()
		{
			Service _movie = new Service("Game of Thrones", "2011", "1", "69", "Series");
			Assert.That(!(_movie.DTO.movieInformation.Response));
			Assert.That(_movie.DTO.movieInformation.Error, Is.EqualTo("Series or episode not found!"));
		}

		[Test]
		public void ReturnsFalseResponseAndErrorWhenInvalidSeason()
		{
			Service _movie = new Service("Game of Thrones", "2011", "20", "1", "Series");
			Assert.That(!(_movie.DTO.movieInformation.Response));
			Assert.That(_movie.DTO.movieInformation.Error, Is.EqualTo("Series or episode not found!"));
		}

		[Test]
		public void ReturnsFalseResponseAndErrorWhenInvalidYear()
		{
			Service _movie = new Service("Game of Thrones", "2005", "1", "1", "Series");
			Assert.That(!(_movie.DTO.movieInformation.Response));
			Assert.That(_movie.DTO.movieInformation.Error, Is.EqualTo("Series or episode not found!"));
		}

		[Test]
		public void ReturnsFalseResponseAndErrorWhenInvalidType()
		{
			Service _movie = new Service("Game of Thrones", "2011", "1", "1", "Movie");
			Assert.That(!(_movie.DTO.movieInformation.Response));
			Assert.That(_movie.DTO.movieInformation.Error, Is.Not.Empty);
		}

	}
}
