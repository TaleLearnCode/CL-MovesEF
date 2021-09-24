using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEntities.Data
{
	
	public class Person
	{

		public int Id {  get; set; }

		public string FirstName { get; set; }

		public string LastName {  get; set; }
			
		public DateTime DateOfBirth { get; set; }

		public ICollection<Movie> MoviesActedIn { get; set; }

		//public ICollection<Movie> MoviesDirected { get; set; }

	}
}