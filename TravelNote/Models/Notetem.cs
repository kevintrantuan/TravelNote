using System;
using SQLite;

namespace TravelNote
{
	public class NoteItem
	{
		public NoteItem ()
		{
		}

		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Notes { get; set; }
		public bool Done { get; set; }
		public DateTime Date { get; set; }
	}
}