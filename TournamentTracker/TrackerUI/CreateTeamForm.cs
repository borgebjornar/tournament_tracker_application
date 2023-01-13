using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            // Initialize the form.
            InitializeComponent();
            // Create sample data.
            // CreateSampleData();
            // Wire up our lists
            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Wagner" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });
        }

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private bool ValidateForm()
        {
            bool output = true;
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }
            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }
        
            return true;
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            {
                if (ValidateForm())
                {
                    PersonModel p = new PersonModel();

                    p.FirstName = firstNameValue.Text;
                    p.LastName = lastNameValue.Text;
                    p.EmailAddress = emailValue.Text;
                    p.CellphoneNumber = cellphoneValue.Text;

                    p = GlobalConfig.Connection.CreatePerson(p);
                    
                    selectedTeamMembers.Add(p);
                    
                    WireUpLists();

                    // Clear the form when the button is pressed.
                    firstNameValue.Text = "";
                    lastNameValue.Text = "";
                    emailValue.Text = "";
                    cellphoneValue.Text = "";

                }
                else
                {
                    MessageBox.Show("You need to fill in all of the fields.");
                }
            }
        }

        private void addTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }
        }
    }
}
