using System;
using Xamarin.Forms;
using System.Diagnostics;

namespace TravelNote
{
	public class Detailhistory : Application
	{
		static TravelNoteDatabase database;

		public Detailhistory()
		{
			
		}

		public static explicit operator Page(Detailhistory v)
		{
			throw new NotImplementedException();
		}

		public static TravelNoteDatabase Database
		{
			get
			{
				if (database == null)
				{
					database = new TravelNoteDatabase();
				}
				return database;
			}
		}

		public int ResumeAtTodoId { get; set; }


	}
}


