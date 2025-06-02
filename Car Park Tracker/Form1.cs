using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Car_Park_Tracker
{
    public partial class FormCarParkTracker : Form
    {
        private static readonly string saveFolder = Path.Combine(Application.StartupPath, "SavedData");
        List<string> ListLicencePlateMain = new List<string>();
        List<string> ListLicencePlateTagged = new List<string>();
        private static readonly Regex plateRegex = new Regex(@"^[A-Z0-9]{4}-[A-Z0-9]{3}$", RegexOptions.IgnoreCase);

        public FormCarParkTracker()
        {
            InitializeComponent();
            #region Tool Tips
            ToolTip.SetToolTip(TextBoxUserInput, "Enter a Licence Plate (e.g. 1GTF-234)");
            ToolTip.SetToolTip(ListBoxLicencePlateMain, "Main list of Licence Plates");
            ToolTip.SetToolTip(ListBoxLicencePlateTagged, "Tagged Licence Plates for review");
            ToolTip.SetToolTip(ButtonEnterNewLicencePlate, "Add Licence Plate");
            ToolTip.SetToolTip(ButtonOpenLoadData, "Open day_##.txt file to Load Licence Plate data");
            ToolTip.SetToolTip(ButtonEditLicencePlate, "Edit selected Licence Plate");
            ToolTip.SetToolTip(ButtonExitExistingLicencePlate, "Remove selected Licence Plate");
            ToolTip.SetToolTip(ButtonResetData, "Clear all Licence Plate data");
            ToolTip.SetToolTip(ButtonSaveData, "Save all Licence Plate data to a text file");
            ToolTip.SetToolTip(ButtonSearchBinary, "Find Licence Plate using Binary Search");
            ToolTip.SetToolTip(ButtonSearchLinear, "Find Licence Plate using Linear Search");
            ToolTip.SetToolTip(ButtonTagLicencePlate, "Tag selected Licence Plate for review");
            ToolTip.SetToolTip(ToolStripStatusLabelMessage.GetCurrentParent(), "Displays messages to the user");
            #endregion
        }

        #region Button Load Licence Plate Data Click
        private void ButtonOpenLoadData_Click(object sender, EventArgs e)
        {
            string textFileName;
            OpenFileDialog openTextFileDialog = new OpenFileDialog();
            openTextFileDialog.InitialDirectory = saveFolder;
            openTextFileDialog.Filter = "txt files (*.txt)|*.txt";
            openTextFileDialog.Title = "Load Licence Plate Text File";
            DialogResult sr = openTextFileDialog.ShowDialog();
            if (sr == DialogResult.OK)
            {
                textFileName = openTextFileDialog.FileName;
            }
            else
            {
                return;
            }
            try
            {
                ListLicencePlateMain.Clear();
                ListLicencePlateTagged.Clear();

                using (StreamReader reader = new StreamReader(File.OpenRead(textFileName)))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string trimmed = line.Trim();
                        
                        if (string.IsNullOrEmpty(trimmed))
                        {
                            continue;
                        }
                        if (trimmed.StartsWith(">"))
                        {
                            ListLicencePlateTagged.Add(trimmed.Substring(1)); // Remove '>'
                        }
                        else
                        {
                            ListLicencePlateMain.Add(trimmed);
                        }
                    }
                }
                string fileName = Path.GetFileName(textFileName);
                DisplayMainList();
                DisplayTaggedList();
                ToolStripStatusLabelMessage.Text = fileName + " Text File Loaded Successfully";
            }
            catch (IOException)
            {
                MessageBox.Show("Error Opening Text File");
            }
        }
        #endregion
        #region Button Save Licence Plate Data Click
        private void ButtonSaveData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveTextFileDialog = new SaveFileDialog();
            saveTextFileDialog.InitialDirectory = saveFolder;
            saveTextFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveTextFileDialog.Title = "Save Licence Plate Text File";
            DialogResult sr = saveTextFileDialog.ShowDialog();
            if (sr == DialogResult.OK)
            {
                SaveTextFile(saveTextFileDialog.FileName);
            }
            if (sr == DialogResult.Cancel)
            {
                return;
            }
        }
        #endregion
        #region Button Reset Data Click
        private void ButtonResetData_Click(object sender, EventArgs e)
        {
            ListLicencePlateMain.Clear();
            ListLicencePlateTagged.Clear();
            DisplayMainList();
            DisplayTaggedList();
            TextBoxUserInput.Clear();
            ToolStripStatusLabelMessage.Text = "System Reset";
        }
        #endregion
        #region Button Exit Existing Licence Plate Click
        private void ButtonExitExistingLicencePlate_Click(object sender, EventArgs e)
        {
            ListBoxLicencePlateMain.SetSelected(ListBoxLicencePlateMain.SelectedIndex, true);
            ListLicencePlateMain.RemoveAt(ListBoxLicencePlateMain.SelectedIndex);
            ToolStripStatusLabelMessage.Text = TextBoxUserInput.Text + " Licence Plate Removed.";
            DisplayMainList();
            TextBoxUserInput.Clear();
            TextBoxUserInput.Focus();
        }
        #endregion
        #region Button Enter New Licence Plate Click
        private void ButtonEnterNewLicencePlate_Click(object sender, EventArgs e)
        {
            if (NullOrWhiteSpace(TextBoxUserInput.Text))
            {
                ToolStripStatusLabelMessage.Text = "ERROR: User must enter a Licence Plate into the text box.";
                TextBoxUserInput.Focus();
                return;
            }
            if (ValidName(TextBoxUserInput.Text))
            {
                ToolStripStatusLabelMessage.Text = "ERROR: Licence Plate value already exists.";
                TextBoxUserInput.Focus();
                return;
            }
            if (ValidFormat(TextBoxUserInput.Text))
            {
                ToolStripStatusLabelMessage.Text = "ERROR: Licence Plate format not valid. Format needs to be: XXXX-XXX where X is A-Z, 0-9.";
                TextBoxUserInput.Focus();
                return;
            }
            else
            {
                ListLicencePlateMain.Add(TextBoxUserInput.Text);
                ListLicencePlateMain.Sort();
                ToolStripStatusLabelMessage.Text = TextBoxUserInput.Text + " Licence Plate Added.";
                DisplayMainList();
                TextBoxUserInput.Clear();
                TextBoxUserInput.Focus();
            }
        }

        private bool NullOrWhiteSpace(string checkThisEmpty)
        {
            if (string.IsNullOrWhiteSpace(TextBoxUserInput.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidFormat(string checkThisFormat)
        {
            if (!plateRegex.IsMatch(checkThisFormat))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidName(string checkThisName)
        {
            if (ListLicencePlateMain.Exists(duplicate => duplicate.Equals(checkThisName)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
        #region Button Edit Licence Plate Click
        private void ButtonEditLicencePlate_Click(object sender, EventArgs e)
        {
            if (NullOrWhiteSpace(TextBoxUserInput.Text))
            {
                ToolStripStatusLabelMessage.Text = "ERROR: User must enter a Licence Plate into the text box.";
                TextBoxUserInput.Focus();
                return;
            }
            if (ValidName(TextBoxUserInput.Text))
            {
                ToolStripStatusLabelMessage.Text = "ERROR: Licence Plate value already exists.";
                TextBoxUserInput.Focus();
                return;
            }
            if (ValidFormat(TextBoxUserInput.Text))
            {
                ToolStripStatusLabelMessage.Text = "ERROR: Licence Plate format not valid. Format needs to be: XXXX-XXX where X is A-Z, 0-9.";
                TextBoxUserInput.Focus();
                return;
            }
            else
            {
                ListLicencePlateMain[ListBoxLicencePlateMain.SelectedIndex] = TextBoxUserInput.Text;
                ToolStripStatusLabelMessage.Text = "Licence Plate edited.";
                TextBoxUserInput.Clear();
                DisplayMainList();
            }
        }
        #endregion
        #region Button Search Linear Click
        private void ButtonSearchLinear_Click(object sender, EventArgs e)
        {
            ListLicencePlateMain.Sort();
            string target = TextBoxUserInput.Text;
            for (int i = 0; i < ListLicencePlateMain.Count; i++)
            {
                if (ListLicencePlateMain[i] == target)
                {
                    ListBoxLicencePlateMain.SelectedIndex = i;
                    ToolStripStatusLabelMessage.Text = "Number Plate Found (Linear Search)";
                    return;
                }
            }
            TextBoxUserInput.Clear();
            TextBoxUserInput.Focus();
            ToolStripStatusLabelMessage.Text = "Number Plate Not Found (Linear Search)";
        }
        #endregion
        #region Button Search Binary Click
        private void ButtonSearchBinary_Click(object sender, EventArgs e)
        {
            ListLicencePlateMain.Sort();
            string target = TextBoxUserInput.Text;
            int index = ListLicencePlateMain.BinarySearch(target);
            if (index >= 0)
            {
                ListBoxLicencePlateMain.SelectedIndex = index;
                ToolStripStatusLabelMessage.Text = "Number Plate Found (Binary Search).";
            }
            else
            {
                ToolStripStatusLabelMessage.Text = "Number Plate Not Found (Binary Search).";
                TextBoxUserInput.Clear();
                TextBoxUserInput.Focus();
            }
        }
        #endregion
        #region Button Tag Licence Plate Click
        private void ButtonTagLicencePlate_Click(object sender, EventArgs e)
        {
            if (ListBoxLicencePlateMain.SelectedItem != null)
            {
                string selected = ListBoxLicencePlateMain.SelectedItem.ToString();
                ListLicencePlateMain.Remove(selected);
                ListLicencePlateTagged.Add(selected);
                DisplayMainList();
                DisplayTaggedList();
                TextBoxUserInput.Clear();
                ToolStripStatusLabelMessage.Text = selected + " Plate tagged for investigation.";
            }
        }
        #endregion
        
        #region List Box Licence Plate Main List Selected Index Changed
        private void ListBoxLicencePlateMainList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = ListBoxLicencePlateMain.SelectedItem.ToString();
            TextBoxUserInput.Text = selectedItem;
        }
        #endregion
        #region List Box Licence Plate Main Double Click
        private void ListBoxLicencePlateMain_DoubleClick(object sender, EventArgs e)
        {
            if (ListBoxLicencePlateMain.SelectedItem != null &&
                MessageBox.Show("Are you sure you want to delete this Licence Plate?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                ListLicencePlateMain.Remove(ListBoxLicencePlateMain.SelectedItem.ToString());
                DisplayMainList();
                TextBoxUserInput.Clear();
                ToolStripStatusLabelMessage.Text = "Licence Plate Removed."; 
                }
        }
        #endregion
        #region List Box Licence Plate Tagged Selected Index Changed
        private void ListBoxLicencePlateTagged_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = ListBoxLicencePlateTagged.SelectedItem.ToString();
            TextBoxUserInput.Text = selectedItem;
        }
        #endregion
        #region List Box Licence Plate Tagged Double Click
        private void ListBoxLicencePlateTagged_DoubleClick(object sender, EventArgs e)
        {
            string selected = ListBoxLicencePlateTagged.SelectedItem.ToString();
            ListLicencePlateTagged.Remove(selected);
            ListLicencePlateMain.Add(selected);
            DisplayMainList();
            DisplayTaggedList();
            TextBoxUserInput.Clear();
            ToolStripStatusLabelMessage.Text = selected + " Plate removed from tagged for investigation.";
        }
        #endregion
        
        #region Display Licence Plate Data
        private void DisplayMainList()
        {
            ListLicencePlateMain.Sort();
            int licencePlateMainLength = ListLicencePlateMain.Count;
            // Clear List Box
            ListBoxLicencePlateMain.Items.Clear();
            // Display each element of LicencePlateMainList
            for (int i = 0; i < licencePlateMainLength; i++)
            {
                // Display the value of licencePlateMainLength in ListBoxLicencePlateMainList
                ListBoxLicencePlateMain.Items.Add("" + ListLicencePlateMain[i]);
            }
        }

        private void DisplayTaggedList()
        {
            ListLicencePlateTagged.Sort();
            int licencePlateTaggedLength = ListLicencePlateTagged.Count;
            // Clear List Box
            ListBoxLicencePlateTagged.Items.Clear();
            // Display each element of LicencePlateMainList
            for (int i = 0; i < licencePlateTaggedLength; i++)
            {
                // Display the value of licencePlateMainLength in ListBoxLicencePlateMainList
                ListBoxLicencePlateTagged.Items.Add("" + ListLicencePlateTagged[i]);
            }
        }
        #endregion
        #region Form Car Park Tracker Form Closing
        private void FormCarParkTracker_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            int fileCounter = 1;
            string fileName;
            string fullPath;
            do
            {
                fileName = $"day_{fileCounter:D2}.txt";
                fullPath = Path.Combine(saveFolder, fileName);
                fileCounter++;
            } while (File.Exists(fullPath));
            
            SaveTextFile(fullPath);
        }
        #endregion
        #region Save Licence Plate Data to Text File
        private void SaveTextFile(string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, false))
                {
                    foreach (string plate in ListLicencePlateMain)
                        writer.WriteLine(plate);

                    foreach (string plate in ListLicencePlateTagged)
                        writer.WriteLine(">" + plate); // add '>' prefix back
                }
                string name = Path.GetFileName(fileName);
                MessageBox.Show($"License plate data saved to:\n{name}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToolStripStatusLabelMessage.Text = "Text File Saved Successfully";
            }
            catch (IOException)
            {
                MessageBox.Show("Error saving data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("File NOT saved");
            }
        }
        #endregion
    }
}
