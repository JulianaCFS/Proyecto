using Gtk;
using System;
using System.Collections.Generic;
using System.Data;

namespace Proyecto.Ad
{
	public class ListStoreExtensions
	{
		public static void Fill(ListStore listStore, IDataReader dataReader)
		{
			while(dataReader.Read ()) {
				List<string> values = new List<string>();
				for (int index = 0; index < dataReader.FieldCount; index++)
				{
					values.Add (dataReader[index].ToString ());
					Console.WriteLine("El iden es: {0} {1} ", dataReader[index].ToString (), index);
					
				}
				values.Add("Selecciona una cantidad");
				listStore.AppendValues (values.ToArray());
			}
		}
		
		public static void FillTicket(ListStore listStore, IDataReader dataReader)
		{
			while(dataReader.Read ()) {
				List<string> values = new List<string>();
				for (int index = 0; index < dataReader.FieldCount; index++)
				{
					values.Add (dataReader[index].ToString ());
					Console.WriteLine("El iden es: {0} {1} ", dataReader[index].ToString (), index);
					
				}
				listStore.AppendValues (values.ToArray());
			}
		}
	}
}

