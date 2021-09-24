using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEntities.Data
{
	
	public class Movie
	{

		[Key]
		public int Id {  get; set; }

		public string Title {  get; set; }

		public string Description {  get; set; }

		public DateTime ReleaseDate {  get; set; }

		public ICollection<Genre> Genres { get; set; }

		public ICollection<Person> Actors { get; set; }

		//public Person Director { get; set; }

	}

}