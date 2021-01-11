using System;
<<<<<<< HEAD
=======
using System.Linq;
>>>>>>> dev
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

<<<<<<< HEAD
=======
		[Test]
		public void DirectorIsEqualToWriter()
		{
			Assert.That(_movie.DTO.movieInformation.Director, Is.EqualTo(_movie.DTO.movieInformation.Writer));
		}

		[Test]
		public void ReturnsCorrectOscarWins()
		{
			Assert.That(_movie.DTO.movieInformation.Awards, Does.Contain("4 Oscars"));
		}

		[Test]
		public void ReturnsCorrectNumberOfWins()
		{
			Assert.That(_movie.DTO.movieInformation.Awards, Does.Contain("152 wins"));
		}

		[Test]
		public void ReturnsCorrectNumberOfNominations()
		{
			Assert.That(_movie.DTO.movieInformation.Awards, Does.Contain("218 nominations"));
		}

		[Test]
		public void RuntimeEndsInMinutes()
		{
			Assert.That(_movie.DTO.movieInformation.Runtime, Does.EndWith("min"));
		}

		[Test]
		public void EndOfReleaseIsEqualToYear()
		{
			Assert.That(_movie.DTO.movieInformation.Year == "2010", Is.EqualTo(_movie.DTO.movieInformation.Released.EndsWith("2010")));
		}

		[Test]
		public void AllResponsesReturnAValue()
		{
			Assert.That(_movie.DTO.movieInformation.GetType().GetProperties().TakeWhile(x => x !=  null), Has.Exactly(26).Items);
		}
>>>>>>> dev

	}
}
