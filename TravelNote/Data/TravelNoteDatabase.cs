using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace TravelNote
{
	public class TravelNoteDatabase
	{
		static object locker = new object();

		SQLiteConnection database;

		public TravelNoteDatabase()
		{
			database = DependencyService.Get<ISQLite>().GetConnection();
			// create the tables
			database.CreateTable<NoteItem>();
		}

		public IEnumerable<NoteItem> GetItems()
		{
			lock (locker)
			{
				
				return (from i in database.Table<NoteItem>() select i).ToList();
			}
		}

		public IEnumerable<NoteItem> GetItemsNotDone()
		{
			lock (locker)
			{
				return database.Query<NoteItem>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
			}
		}

		public NoteItem GetItem(int id)
		{
			lock (locker)
			{
				return database.Table<NoteItem>().FirstOrDefault(x => x.ID == id);
			}
		}

		public int SaveItem(NoteItem item)
		{
			lock (locker)
			{
				if (item.ID != 0)
				{
					database.Update(item);
					return item.ID;
				}
				else {
					var newthought = new NoteItem
					{
						ID = item.ID,
						Name = item.Name,
						Notes = item.Notes,
						Done = item.Done,
						Date = DateTime.UtcNow,

					};
					return database.Insert(newthought);
				}	
			}
		}

		public int DeleteItem(int id)
		{
			lock (locker)
			{
				return database.Delete<NoteItem>(id);
			}
		}
	}
}

