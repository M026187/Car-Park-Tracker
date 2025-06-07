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
        // Global variables
        private static readonly string saveFolder = Path.Combine(Application.StartupPath, "SavedData");
        List<string> ListLicencePlateMain = new List<string>();
        List<string> ListLicencePlateTagged = new List<string>();
        private static readonly Regex plateRegex = new Regex(@"^[A-Z0-9]{4}-[A-Z0-9]{3}$", RegexOptions.IgnoreCase);

        public FormCarParkTracker()
        {
            InitializeComponent();
            #region Tool Tips
            // Tool Tip descriptions
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
        // Method to handle the OPEN/LOAD button click
        private void ButtonOpenLoadData_Click(object sender, EventArgs e)
        {
            string textFileName;
            // Create standard dialog box to allow user to open a file
            OpenFileDialog openTextFileDialog = new OpenFileDialog();
            // Set the file open directory
            openTextFileDialog.InitialDirectory = saveFolder;
            // Filter out text files
            openTextFileDialog.Filter = "txt files (*.txt)|*.txt";
            // Give title to the dialog box
            openTextFileDialog.Title = "Load Licence Plate Text File";
            DialogResult sr = openTextFileDialog.ShowDialog();
            // Obtain the text file name when user clicks OK, else return
            if (sr == DialogResult.OK)
            {
                textFileName = openTextFileDialog.FileName;
            }
            else
            {
                return;
            }
            // Try to load the text file
            try
            {
                // Initialise Main and Tagged lists
                ListLicencePlateMain.Clear();
                ListLicencePlateTagged.Clear();

                // Read the text file and add lines to either the Main or Tagged lists
                using (StreamReader reader = new StreamReader(File.OpenRead(textFileName)))
                {
                    string line;
                    // Read each line until reaching the end of the data
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Remove all leading or trailing whitespace from the line
                        string trimmed = line.Trim();
                        // If the line is null or empty then do nothing
                        if (string.IsNullOrEmpty(trimmed))
                        {
                            continue;
                        }
                        // Identify the the tagged Licence Plates
                        if (trimmed.StartsWith(">"))
                        {
                            // Remove > from the tagged Licence Plates and add to the tagged list
                            ListLicencePlateTagged.Add(trimmed.Substring(1)); // Remove '>'
                        }
                        else
                        {
                            // Add the non tagged Licence Plates to the main list
                            ListLicencePlateMain.Add(trimmed);
                        }
                    }
                }
                // Get the file name
                string fileName = Path.GetFileName(textFileName);
                // Display the main list in the main list box
                DisplayMainList();
                // Display the tagged list in the tagged list box
                DisplayTaggedList();
                // Display to user that the text file has been successfully loaded
                ToolStripStatusLabelMessage.Text = fileName + " Text File Loaded Successfully";
            }
            // If there is a failure to load the text file, display error to user
            catch (IOException)
            {
                MessageBox.Show("Error: Opening Text File");
            }
        }
        #endregion
        #region Button Save Licence Plate Data Click
        // Method to handle the SAVE button click
        private void ButtonSaveData_Click(object sender, EventArgs e)
        {
            // Create standard dialog box to allow user to save a file
            SaveFileDialog saveTextFileDialog = new SaveFileDialog();
            // Set the save folder directory
            saveTextFileDialog.InitialDirectory = saveFolder;
            // Filter out text files
            saveTextFileDialog.Filter = "txt files (*.txt)|*.txt";
            // Give title to the dialog box
            saveTextFileDialog.Title = "Save Licence Plate Text File";
            DialogResult sr = saveTextFileDialog.ShowDialog();
            // Save the text file when user clicks OK, else return
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
        // Method to handle the RESET button click
        private void ButtonResetData_Click(object sender, EventArgs e)
        {
            // Reset both Main and Tagged lists
            ListLicencePlateMain.Clear();
            ListLicencePlateTagged.Clear();
            // Refresh the Main list box
            DisplayMainList();
            // Refresh the Tagged list box
            DisplayTaggedList();
            // Clear the user input text box
            TextBoxUserInput.Clear();
            // Display to user that the system has been reset
            ToolStripStatusLabelMessage.Text = "System Reset";
        }
        #endregion
        #region Button Exit Existing Licence Plate Click
        // Method to handle the EXIT button click
        private void ButtonExitExistingLicencePlate_Click(object sender, EventArgs e)
        {
            // Check if a Licence Plate has been selected by user
            // If a Licence Plate has not been selected
            if (ListBoxLicencePlateMain.SelectedItem == null)
            {
                // Diplay to user that Licence Plate needs to be selected in the Main list box
                ToolStripStatusLabelMessage.Text = "ERROR: User must select a Licence Plate in the main list box.";
                return;
            }
            // A Licence Plate has been selected
            else
            {
                // Remove the selected Licence Plate from the Main list
                ListLicencePlateMain.RemoveAt(ListBoxLicencePlateMain.SelectedIndex);
                // Display to user that the selected Licence Plate has been removed
                ToolStripStatusLabelMessage.Text = TextBoxUserInput.Text + " Licence Plate Removed.";
                // Refresh the Main list box
                DisplayMainList();
                // Clear the user input text box
                TextBoxUserInput.Clear();
                // Bring focus to the user input text box
                TextBoxUserInput.Focus();
            }
        }

        #endregion
        #region Button Enter New Licence Plate Click
        // Method to handle the ENTER button click
        private void ButtonEnterNewLicencePlate_Click(object sender, EventArgs e)
        {
            // Check to see if the user input text box is null or whitespace
            if (NullOrWhiteSpace(TextBoxUserInput.Text))
            {
                // Display to user that a Licence Plate must be entered into the user input text box
                ToolStripStatusLabelMessage.Text = "ERROR: User must enter a Licence Plate into the text box.";
                // Bring focus to the user input text box
                TextBoxUserInput.Focus();
                return;
            }
            // Check to see if the user input text has a valid unique value
            if (ValidName(TextBoxUserInput.Text))
            {
                // Display to user that the Licence Plate already exists
                ToolStripStatusLabelMessage.Text = "ERROR: Licence Plate value already exists.";
                // Bring focus to the user input text box
                TextBoxUserInput.Focus();
                return;
            }
            // Check to see if the user input text is in a valid format
            if (ValidFormat(TextBoxUserInput.Text))
            {
                // Display to user that the Licence Plate format is not valid
                ToolStripStatusLabelMessage.Text = "ERROR: Licence Plate format not valid. Format needs to be: XXXX-XXX where X is A-Z, 0-9.";
                // Bring focus to the user input text box
                TextBoxUserInput.Focus();
                return;
            }
            // User input has passed validation tests
            else
            {
                // Add user input to the Licence Plate Main list
                ListLicencePlateMain.Add(TextBoxUserInput.Text);
                // Sort the Licence Plate Main list
                ListLicencePlateMain.Sort();
                // Display to user that the Licence Plate has been added
                ToolStripStatusLabelMessage.Text = TextBoxUserInput.Text + " Licence Plate Added.";
                // Refresh the Main list box
                DisplayMainList();
                // Clear the user input text box
                TextBoxUserInput.Clear();
                // Bring focus to the user input text box
                TextBoxUserInput.Focus();
            }
        }
        #endregion
        #region Button Edit Licence Plate Click
        // Method to handle the EDIT button click
        private void ButtonEditLicencePlate_Click(object sender, EventArgs e)
        {
            // Check to see if the user input text box is null or whitespace
            if (NullOrWhiteSpace(TextBoxUserInput.Text))
            {
                // Display to user that a Licence Plate must be entered into the user input text box
                ToolStripStatusLabelMessage.Text = "ERROR: User must enter a Licence Plate into the text box.";
                // Bring focus to the user input text box
                TextBoxUserInput.Focus();
                return;
            }
            // Check to see if the user input text has a valid unique value
            if (ValidName(TextBoxUserInput.Text))
            {
                // Display to user that the Licence Plate already exists
                ToolStripStatusLabelMessage.Text = "ERROR: Licence Plate value already exists.";
                // Bring focus to the user input text box
                TextBoxUserInput.Focus();
                return;
            }
            // Check to see if the user input text is in a valid format
            if (ValidFormat(TextBoxUserInput.Text))
            {
                // Display to user that the Licence Plate format is not valid
                ToolStripStatusLabelMessage.Text = "ERROR: Licence Plate format not valid. Format needs to be: XXXX-XXX where X is A-Z, 0-9.";
                // Bring focus to the user input text box
                TextBoxUserInput.Focus();
                return;
            }
            // User input has passed validation tests
            else
            {
                // Edit the Licence Plate selected in the Main list box with the user input
                ListLicencePlateMain[ListBoxLicencePlateMain.SelectedIndex] = TextBoxUserInput.Text;
                // Display to user that the Licence Plate has been edited
                ToolStripStatusLabelMessage.Text = "Licence Plate edited.";
                // Clear the user input text box
                TextBoxUserInput.Clear();
                // Refresh the Main list box
                DisplayMainList();
            }
        }
        #endregion
        #region Button Search Linear Click
        // Method to handle the LINEAR SEARCH button click
        private void ButtonSearchLinear_Click(object sender, EventArgs e)
        {
            // Sort the Main list
            ListLicencePlateMain.Sort();
            // Declare variable and assign the user input to the target search value
            string target = TextBoxUserInput.Text;
            // Check if user input is null or whitespace
            if (NullOrWhiteSpace(target))
            {
                // Display to user that a Licence Plate must be entered into the user input text box
                ToolStripStatusLabelMessage.Text = "ERROR: User must enter a Licence Plate into the text box to search for.";
                // Bring focus to the user input text box
                TextBoxUserInput.Focus();
                return;
            }
            // Search every Licence Plate in the Main list
            for (int i = 0; i < ListLicencePlateMain.Count; i++)
            {
                // If the target Licence Plate is found
                if (ListLicencePlateMain[i] == target)
                {
                    // Show found Licence Plate in Main list box selected
                    ListBoxLicencePlateMain.SelectedIndex = i;
                    // Display to user that the Licence Plate has been found
                    ToolStripStatusLabelMessage.Text = target + " Licence Plate Found (Linear Search)";
                    return;
                }
            }
            // Clear the user input text box
            TextBoxUserInput.Clear();
            // Bring focus to the user input text box
            TextBoxUserInput.Focus();
            // Display to user that the Licence Plate was not found
            ToolStripStatusLabelMessage.Text = target + " Licence Plate Not Found (Linear Search)";
        }
        #endregion
        #region Button Search Binary Click
        // Method to handle the BINARY SEARCH button click
        private void ButtonSearchBinary_Click(object sender, EventArgs e)
        {
            // Sort the Main list
            ListLicencePlateMain.Sort();
            // Declare variable and assign the user input to the target search value
            string target = TextBoxUserInput.Text;
            // Declare variable to store index result of search. Search target using Binary Search.
            int index = ListLicencePlateMain.BinarySearch(target);
            // Check if user input is null or whitespace
            if (NullOrWhiteSpace(target))
            {
                // Display to user that a Licence Plate must be entered into the user input text box
                ToolStripStatusLabelMessage.Text = "ERROR: User must enter a Licence Plate into the text box to search for.";
                // Bring focus to user input text box
                TextBoxUserInput.Focus();
                return;
            }
            // Check if Licence Plate is found
            if (index >= 0)
            {
                // Show found Licence Plate in Main list box selected
                ListBoxLicencePlateMain.SelectedIndex = index;
                // Display to user that the Licence Plate has been found
                ToolStripStatusLabelMessage.Text = target + " Licence Plate Found (Binary Search).";
            }
            // Licence Plate has not been found
            else
            {
                // Diplay to user that the Licence Plate has not been found
                ToolStripStatusLabelMessage.Text = target + " Licence Plate Not Found (Binary Search).";
                // Clear the user input text box
                TextBoxUserInput.Clear();
                // Bring focus to the user input text box
                TextBoxUserInput.Focus();
            }
        }
        #endregion
        #region Button Tag Licence Plate Click
        // Method to handle the TAG button click
        private void ButtonTagLicencePlate_Click(object sender, EventArgs e)
        {
            // Check to make sure that a Licence Plate in the Main list has been selected by the user
            if (ListBoxLicencePlateMain.SelectedItem == null)
            {
                // Display to user that a Licence Plate needs to be selected in the Main list box
                ToolStripStatusLabelMessage.Text = "ERROR: User must select a Licence Plate in the main list box.";
                return;
            }
            // Licence Plate has been selected in the Main list by the user
            else
            {
                // Declare variable and assign to the user selected Licence Plate in the Main list
                string selected = ListBoxLicencePlateMain.SelectedItem.ToString();
                // Remove the user selected Licence Plate from the Main list
                ListLicencePlateMain.Remove(selected);
                // Add user selected Licence Plate to the Tagged list
                ListLicencePlateTagged.Add(selected);
                // Refresh Main list box
                DisplayMainList();
                // Refresh Tagged list box
                DisplayTaggedList();
                // Clear user input text box
                TextBoxUserInput.Clear();
                // Display to user that the user selected Licence Plate has been tagged
                ToolStripStatusLabelMessage.Text = selected + " Plate tagged for investigation.";
            }
        }
        #endregion
        
        #region List Box Licence Plate Main List Selected Index Changed
        // Method to handle a change in selected index of the Main list box
        private void ListBoxLicencePlateMainList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Declare variable and assign to the value of the selected Licence Plate in the Main list box
            string selectedItem = ListBoxLicencePlateMain.SelectedItem.ToString();
            // Display the selected Licence Plate in the user input text box
            TextBoxUserInput.Text = selectedItem;
        }
        #endregion
        #region List Box Licence Plate Main Double Click
        // Method to handle double click in the Main list box
        private void ListBoxLicencePlateMain_DoubleClick(object sender, EventArgs e)
        {
            // Check with user to confirm deletion of selected item
            if (ListBoxLicencePlateMain.SelectedItem != null &&
                MessageBox.Show("Are you sure you want to delete this Licence Plate?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                // Declare variable and assign to the selected Licence Plte in the Main list box
                string selected = ListBoxLicencePlateMain.SelectedItem.ToString();
                // Remove the selected Licence Plate from the Main list
                ListLicencePlateMain.Remove(selected);
                // Refresh the Main list box
                DisplayMainList();
                // Clear the user input text box
                TextBoxUserInput.Clear();
                // Display to user that the Licence Plate has been removed
                ToolStripStatusLabelMessage.Text = selected + " Licence Plate Removed."; 
                }
        }
        #endregion
        #region List Box Licence Plate Tagged Selected Index Changed
        // Method to handle a change in selected index of the Tagged list box 
        private void ListBoxLicencePlateTagged_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Declare variable and assign to the selected Licence Plate in the Tagged list box
            string selectedItem = ListBoxLicencePlateTagged.SelectedItem.ToString();
            // Display the selected Licence Plate in the user input text box
            TextBoxUserInput.Text = selectedItem;
        }
        #endregion
        #region List Box Licence Plate Tagged Double Click
        // Method to handle double click in the Tagged list box
        private void ListBoxLicencePlateTagged_DoubleClick(object sender, EventArgs e)
        {
            // Declare variable and assign to the selected Licence Plate in the Tagged list box
            string selected = ListBoxLicencePlateTagged.SelectedItem.ToString();
            // Remove selected Licence Plate from Tagged list
            ListLicencePlateTagged.Remove(selected);
            // Add selected Licence Plate to Main list
            ListLicencePlateMain.Add(selected);
            // Refresh Main list box
            DisplayMainList();
            // Refresh Tagged list box
            DisplayTaggedList();
            // Clear the user input text box
            TextBoxUserInput.Clear();
            // Display to user that the selected Licence Plate has been removed from the Tagged list
            ToolStripStatusLabelMessage.Text = selected + " Plate removed from tagged for investigation.";
        }
        #endregion
        
        #region Display Licence Plate Data
        // Method to display the Main list in the Main list box
        private void DisplayMainList()
        {
            // Sort the Main list
            ListLicencePlateMain.Sort();
            // Declare variable and assign to the count of the Main list
            int licencePlateMainLength = ListLicencePlateMain.Count;
            // Clear Main list box
            ListBoxLicencePlateMain.Items.Clear();
            // Display each element of Main list in the Main list box
            for (int i = 0; i < licencePlateMainLength; i++)
            {
                // Display current element of Main list in the Main list box
                ListBoxLicencePlateMain.Items.Add("" + ListLicencePlateMain[i]);
            }
        }

        // Method to display the Tagged list in the Tagged list box
        private void DisplayTaggedList()
        {
            // Sort the Tagged list
            ListLicencePlateTagged.Sort();
            // Declare variable and assign to the count of the Tagged list
            int licencePlateTaggedLength = ListLicencePlateTagged.Count;
            // Clear Tagged list box
            ListBoxLicencePlateTagged.Items.Clear();
            // Display each element of Tagged list in the Tagged list box
            for (int i = 0; i < licencePlateTaggedLength; i++)
            {
                // Display current element of the Tagged list in the Tagged list box
                ListBoxLicencePlateTagged.Items.Add("" + ListLicencePlateTagged[i]);
            }
        }
        #endregion
        #region Form Car Park Tracker Form Closing
        // Method to handle closing the Car Park Tracker Form
        private void FormCarParkTracker_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            // Declare variable and initialise to 1
            int fileCounter = 1;
            // Declare variable to store file name
            string fileName;
            // Declare variable to store full file path
            string fullPath;
            do
            {
                // Assign file name to specific file name format
                fileName = $"day_{fileCounter:D2}.txt";
                // Assign full file path to save folder location and file name combined
                fullPath = Path.Combine(saveFolder, fileName);
                // Increment the file counter value
                fileCounter++;
            } while (File.Exists(fullPath)); // Continue to cycle through file names until a unique name is chosen
            // Save the text file to the full path name found to be unique
            SaveTextFile(fullPath);
        }
        #endregion
        #region Null or White Space
        // Method to check whether user input is null or white space
        private bool NullOrWhiteSpace(string checkThisEmpty)
        {
            // if the user input is null or white space, return true, else return false
            if (string.IsNullOrWhiteSpace(TextBoxUserInput.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region Save Licence Plate Data to Text File
        // Method to Save the Text file
        private void SaveTextFile(string fileName)
        {
            try
            {
                // Use Stream Writer to write each element of Main list and Tagged list to a text file
                using (StreamWriter writer = new StreamWriter(fileName, false))
                {
                    // For each element in the Main list, write line to text file
                    foreach (string plate in ListLicencePlateMain)
                        writer.WriteLine(plate);
                    // For each element in the Tagged list, write line to text file
                    foreach (string plate in ListLicencePlateTagged)
                        // Add '>' prefix back to each element to write to text file
                        writer.WriteLine(">" + plate);
                }
                // Declare variable and assign to file name of text file
                string name = Path.GetFileName(fileName);
                // Display message box to inform user that the Licence Plate data has been saved to a text file
                MessageBox.Show($"License plate data saved to:\n{name}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Display to user that the text file has been saved successfully
                ToolStripStatusLabelMessage.Text = "Text File Saved Successfully";
            }
            catch (IOException)
            {
                // Display message box to inform user that there was an error saving the data and the text file was not saved
                MessageBox.Show("Error saving data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("File NOT saved");
            }
        }
        #endregion
        #region Valid Format
        // Method to check if user input is in a valid format
        private bool ValidFormat(string checkThisFormat)
        {
            // If the user input is not in a valid format return true, else return false
            if (!plateRegex.IsMatch(checkThisFormat))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region Valid Name
        // Method to check is user input is a duplicate
        private bool ValidName(string checkThisName)
        {
            // If the user input is a duplicate return true, else return false
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
    }
}
