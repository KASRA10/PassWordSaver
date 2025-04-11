using System;
using System.Configuration;

namespace PassWordSaver.Functions
{
	public static class Helper
	{
		// Adds an entry (Title, Username, PassWord) to App.config and returns the GUID part.
		public static string AddEntryToAppConfig(string title, string userName, string passWord)
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

			// Generate a single GUID for the entire record.
			string guid = Guid.NewGuid().ToString();

			string titleKey = $"Title_{guid}";
			string usernameKey = $"Username_{guid}";
			string passwordKey = $"Password_{guid}";

			config.AppSettings.Settings.Add(titleKey, title);
			config.AppSettings.Settings.Add(usernameKey, userName);
			config.AppSettings.Settings.Add(passwordKey, passWord);

			config.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("appSettings");

			return guid;
		}

		public class ComboBoxItem
		{
			public string Key { get; set; }
			public string Title { get; set; }

			public override string ToString()
			{
				return Title;
			}
		}
	}
}
