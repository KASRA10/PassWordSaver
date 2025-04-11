using System;
using System.Configuration;
using System.Windows.Forms;
using static PassWordSaver.Functions.Helper;

namespace PassWordSaver
{
	public partial class DashBoard_FRM : Form
	{
		#region PublicItems
		string gitHubLink = "https://github.com/KASRA10";
		#endregion

		public DashBoard_FRM()
		{
			InitializeComponent();

			// Set up DataGridView columns.
			UserPassViewer_DGR.Columns.Add("Title", "Title");
			UserPassViewer_DGR.Columns.Add("UserName", "UserName");
			UserPassViewer_DGR.Columns.Add("PassWord", "PassWord");

			// Configure DataGridView layout.
			UserPassViewer_DGR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			UserPassViewer_DGR.AllowUserToAddRows = false;

			// Center-align the header text.
			UserPassViewer_DGR.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			// Center-align the cell text.
			UserPassViewer_DGR.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			// Set default state to mask the password textbox and initialize TogglePass_BTN text.
			PassWord_TB.UseSystemPasswordChar = true;
			TogglePass_BTN.Text = "Show";
		}

		private void GitHub_IMG_Click(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
				{
					FileName = gitHubLink,
					UseShellExecute = true
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unable to open the link. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Adds a new record to App.config and refreshes UI.
		private void AddNewRecord_BTN_Click(object sender, EventArgs e)
		{
			// Read values from textboxes.
			string title = TheTitleName_TB.Text.Trim();
			string username = UserName_TB.Text.Trim();
			string password = PassWord_TB.Text.Trim();

			if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Add new record to App.config and get the record's GUID.
			string guid = AddEntryToAppConfig(title, username, password);

			MessageBox.Show("Record added successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

			// Clear textboxes.
			TheTitleName_TB.Clear();
			UserName_TB.Clear();
			PassWord_TB.Clear();

			// Refresh the grid and combo box with the new record.
			RefreshRecords();
		}

		// Loads all saved records into the grid view and combo box when the form loads.
		private void DashBoard_FRM_Load(object sender, EventArgs e)
		{
			RefreshRecords();
		}

		// Deletes the selected record (from combo box) from App.config and refreshes UI.
		private void Delete_BTN_Click(object sender, EventArgs e)
		{
			if (SavedComBo_CMBX.SelectedItem is ComboBoxItem selectedItem)
			{
				string titleKey = selectedItem.Key;
				string guid = titleKey.Replace("Title_", "");

				Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
				// Remove keys for this record.
				config.AppSettings.Settings.Remove(titleKey);
				config.AppSettings.Settings.Remove($"Username_{guid}");
				config.AppSettings.Settings.Remove($"Password_{guid}");

				// Save changes and refresh configuration.
				config.Save(ConfigurationSaveMode.Modified);
				ConfigurationManager.RefreshSection("appSettings");

				MessageBox.Show("Record deleted successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Refresh the grid and combo box.
				RefreshRecords();
			}
			else
			{
				MessageBox.Show("Please select a record to delete using the combo box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		// Toggles the password masking in the textbox.
		private void TogglePass_BTN_Click_1(object sender, EventArgs e)
		{
			if (PassWord_TB.UseSystemPasswordChar)
			{
				PassWord_TB.UseSystemPasswordChar = false;
				TogglePass_BTN.Text = "Hide";
			}
			else
			{
				PassWord_TB.UseSystemPasswordChar = true;
				TogglePass_BTN.Text = "Show";
			}
		}

		// Refreshes both the DataGridView and ComboBox with all records from App.config.
		private void RefreshRecords()
		{
			// Clear the grid view and combo box.
			UserPassViewer_DGR.Rows.Clear();
			SavedComBo_CMBX.Items.Clear();

			// Loop through all App.config keys and retrieve the records.
			foreach (var key in ConfigurationManager.AppSettings.AllKeys)
			{
				if (key.StartsWith("Title_"))
				{
					string title = ConfigurationManager.AppSettings[key];
					// Get the guid from the key.
					string guid = key.Replace("Title_", "");
					string username = ConfigurationManager.AppSettings[$"Username_{guid}"];
					string password = ConfigurationManager.AppSettings[$"Password_{guid}"];

					// Add the record to the grid view.
					UserPassViewer_DGR.Rows.Add(title, username, password);

					// Add the title to the combo box for deletion purposes.
					SavedComBo_CMBX.Items.Add(new ComboBoxItem { Key = key, Title = title });
				}
			}

			// Set the ComboBox display members.
			SavedComBo_CMBX.DisplayMember = "Title";
			SavedComBo_CMBX.ValueMember = "Key";
		}
	}
}
