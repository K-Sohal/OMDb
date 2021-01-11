using System;
using NUnit.Framework;

namespace OMDb
{
	public class SearchByID
	{
		private readonly Service _movie;
		public SearchByID()
		{
			_movie = new Service("tt1375666");
		}

		[Test]
		public void WebCallSuccessCheckForCorrectID()
		{
			Assert.That(_movie.DTO.movieInformation.Response);
		}

		[Test]
		public void WebCallFailCheckForIncorrectID()
		{
			Service _invalidMovie = new Service("wrongID");
			Assert.That(!(_invalidMovie.DTO.movieInformation.Response));
			Assert.That(_invalidMovie.DTO.movieInformation.Error, Is.EqualTo("Incorrect IMDb ID."));
		}

		[Test]
		public void ReturnsCorrectTitle()
		{
			Assert.That(_movie.DTO.movieInformation.Title, Is.EqualTo("Inception"));
		}

		[Test]
		public void ReturnsCorrectYear()
		{
			Assert.That(_movie.DTO.movieInformation.Year, Is.EqualTo("2010"));
		}


	}
}
