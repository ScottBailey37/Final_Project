/* CODE OF HONOR: I have not discussed the source code in my program with anyone other than my 
 * instructor’s approved human sources. I have not used source code obtained from another student, 
 * or any other unauthorized source, either modified or unmodified. If any source code or documentation 
 * used in my program was obtained from another source, such as a textbook or course notes, that 
 * has been clearly noted with a proper citation in the comments of my program. I have not knowingly 
 * designed this program in such a way as to defeat or interfere with the normal operation of any 
 * machine it is graded on or to produce apparently correct results when in fact it does not. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAssignment_8
{
    public partial class MainForm : Form
    {
        PayrollSummary payrollSummary;
        List<Employee> employeeList;

        // Highlight and default colors struct for datagridview
        private Color highlightTooManyHours = Color.Yellow;
        private Color highlightDisabled = SystemColors.AppWorkspace;
        private Color defaultColor = SystemColors.Window;
        private Color highlightMissingHours = Color.LightGreen;
        private Color highlightMissingClientInfo = Color.LightBlue;

        public MainForm()
        {
            InitializeComponent();
            payrollSummary = new PayrollSummary();
            employeeList = new List<Employee>();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String allErrors = GetAllErrors(); // Check for any errors

            // Did we get any?
            if (allErrors != null)
            {
                MessageBox.Show("Cannot submit data. Found the following errors: \n" + allErrors);
                return; // Don't go any further in submission
            }

            // No errors so,
            // Create a new instance of employee to use for the user
            Employee employee = new Employee(tbEmployeeName.Text, "", tbSupervisorName.Text); // dont use last name for now

            // Assign some values to employee
            employee.TotalHoursWorked = double.Parse(lblTotal.Text); // We know it has a value for Parse
            employee.RegHourlyWage = 15;

            // Add employee to list of employees
            employeeList.Add(employee); // no real use for this list presently but
            
            // Now, populate payrollSummary controls with employee data
            payrollSummary.lblHeader.Text = "Payroll information for " + employee.FirstName + 
                " for the week ending Week " + numericUpDown1.Value.ToString() + ":";

            payrollSummary.lblTotalHours.Text = String.Format("{0:0.00}", employee.TotalHoursWorked);

            // Reg hours data
            payrollSummary.lblRegHoursWorked.Text = String.Format("{0:0.00}", employee.RegHoursWorked);
            payrollSummary.lblRateRegHours.Text = String.Format("{0:0.00}", employee.RegHourlyWage);
            payrollSummary.lblRegHourlyPay.Text = String.Format("{0:0.00}", employee.RegularHourlyPay);

            // Overtime data
            payrollSummary.lblOvertimeHours.Text = String.Format("{0:0.00}", employee.OvertimeHoursWorked);
            payrollSummary.lblRateOvertimeHours.Text = String.Format("{0:0.00}", employee.OvertimeHourlyWage);
            payrollSummary.lblOvertimeHourlyPay.Text = String.Format("{0:0.00}", employee.OvertimeHourlyPay);

            payrollSummary.lblGrossPay.Text = String.Format("{0:0.00}", employee.getGrossPay());

            // Get a count of checked vacation/holidays
            int count = 0;
            CheckBox cb;
            foreach (Control ctrl in this.Controls) 
            {
                if (ctrl is CheckBox)
                {
                    cb = (CheckBox)ctrl;
                    if (cb.Checked)
                    {
                        count += 1;
                    }
                }
            }

            payrollSummary.lblHoliday.Text = count.ToString(); // Number of vaction/holiday

            payrollSummary.ShowDialog(); // show the payroll data of employee
        }
        
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // A row was removed so sum up totals again and update total fields
            UpdateGridViewTotals();
            UpdateLabelTotals();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CheckBox checkBox = new CheckBox();
            Control[] ctrlColl;

            for (int i = 1; i <= 7; i++) // there is only 7 checkboxes
            {
                checkBox = new CheckBox();
                checkBox.Name = "checkBox" + i.ToString(); // change name incrementally
                ctrlColl = this.Controls.Find(checkBox.Name, true); // search all controls for match

                if (ctrlColl.Length > 0) // found a match
                {
                    // Get the checkbox
                    checkBox = (CheckBox)ctrlColl[0];

                    // Is it checked?
                    if (checkBox.Checked)
                    {
                        // Yes,
                        // Update appropiate cell in new row to reflect that 
                        dataGridView1[int.Parse(checkBox.Tag.ToString()), e.RowIndex].ReadOnly = true;
                        dataGridView1[int.Parse(checkBox.Tag.ToString()), e.RowIndex].Style.BackColor = highlightDisabled;
                    }
                }                
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (dataGridView1.CurrentCell.ColumnIndex)
            {
                // Only the Monday-Sunday columns (4-10)
                case int col when (col >= 4 && col <= 10):
                    double value;
                    // If parse fails then it is non-numeric
                    if (dataGridView1.CurrentCell.Value != null && dataGridView1.CurrentCell.Value.ToString() != "")
                        if (!double.TryParse(dataGridView1.CurrentCell.Value.ToString(), out value))
                        {
                            // Remove string since it contains non-numeric
                            dataGridView1.CurrentCell.Value = "";
                        }

                    break;
            }

            UpdateGridViewTotals();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SetHoliday(sender, e);
        }

        // Checks the daily totals for values greater than 24 and returns boolean value
        //
        private bool CheckMaxHoursMultiple()
        {
            bool errors = false;
            List<int> columnsToHighlight = new List<int>(); // holds columns that total > 24

            // Check totals for each day 
            if (double.Parse(lblMonTotal.Text) > 24) // Monday total
            {
                lblMonTotal.BackColor = highlightTooManyHours;
                columnsToHighlight.Add(int.Parse(lblMonTotal.Tag.ToString()));
                errors = true;
            }
            else { lblMonTotal.BackColor = Label.DefaultBackColor; }
            if (double.Parse(lblTueTotal.Text) > 24) // Tuesday total
            {
                lblTueTotal.BackColor = highlightTooManyHours;
                columnsToHighlight.Add(int.Parse(lblTueTotal.Tag.ToString()));
                errors = true;
            }
            else { lblTueTotal.BackColor = Label.DefaultBackColor; }
            if (double.Parse(lblWedTotal.Text) > 24) // Wednesday total
            {
                lblWedTotal.BackColor = highlightTooManyHours;
                columnsToHighlight.Add(int.Parse(lblWedTotal.Tag.ToString()));
                errors = true;
            }
            else { lblWedTotal.BackColor = Label.DefaultBackColor; }
            if (double.Parse(lblThuTotal.Text) > 24) // Thursday total
            {
                lblThuTotal.BackColor = highlightTooManyHours;
                columnsToHighlight.Add(int.Parse(lblThuTotal.Tag.ToString()));
                errors = true;
            }
            else { lblThuTotal.BackColor = Label.DefaultBackColor; }
            if (double.Parse(lblFriTotal.Text) > 24) // Friday total
            {
                lblFriTotal.BackColor = highlightTooManyHours;
                columnsToHighlight.Add(int.Parse(lblFriTotal.Tag.ToString()));
                errors = true;
            }
            else { lblFriTotal.BackColor = Label.DefaultBackColor; }
            if (double.Parse(lblSatTotal.Text) > 24) // Saturday total
            {
                lblSatTotal.BackColor = highlightTooManyHours;
                columnsToHighlight.Add(int.Parse(lblSatTotal.Tag.ToString()));
                errors = true;
            }
            else { lblSatTotal.BackColor = Label.DefaultBackColor; }
            if (double.Parse(lblSunTotal.Text) > 24) // Sunday total
            {
                lblSunTotal.BackColor = highlightTooManyHours;
                columnsToHighlight.Add(int.Parse(lblSunTotal.Tag.ToString()));
                errors = true;
            }
            else { lblSunTotal.BackColor = Label.DefaultBackColor; }

            // Loop through each offending column and highlight the cell
            foreach (int iCol in columnsToHighlight)
            {
                for (int iRow = 0; iRow < dataGridView1.RowCount - 1; iRow++)
                {
                    dataGridView1[iCol, iRow].Style.BackColor = highlightTooManyHours;
                }
            }

            return errors;
        }

        // Checks the Monday-Sunday DataGridView cells for values greater than 24 and returns boolean value
        //
        private bool CheckMaxHoursSingle()
        {
            // Check the mon-sun fields
            bool errors = false;
            for (int iCol = 4; iCol < dataGridView1.ColumnCount - 1; iCol++)
            {
                for (int iRow = 0; iRow < dataGridView1.RowCount - 1; iRow++)
                {
                    if (dataGridView1[iCol, iRow].Value != null && dataGridView1[iCol, iRow].Value.ToString() != "")
                    {
                        // Only allow 24 hours or less
                        if (double.Parse(dataGridView1[iCol, iRow].Value.ToString()) > 24)
                        {         
                            // Highlight cell
                            dataGridView1.Rows[iRow].Cells[iCol].Style.BackColor = highlightTooManyHours;
                            errors = true;
                        }
                        else
                        {
                            // Un-highlight cell
                            dataGridView1.Rows[iRow].Cells[iCol].Style.BackColor = defaultColor;
                        }
                    }                    
                }
            }
            return errors;
        }

        // Sums up the Mon-Sun fields in the Total field for each valid row
        //
        private void UpdateGridViewTotals()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows) // For every row
            {
                double total = 0;
                for (int cell = 4; cell < 11; cell++) // Only get the mon-sun fields
                {
                    if (((row.Cells[cell].Value != null) && row.Cells[cell].Value.ToString() != "")) // Make sure initialized
                    {
                        // Increment total with the value in cell
                        total += double.Parse(row.Cells[cell].Value.ToString());
                    }
                }

                if (total > 0)
                {
                    // total has a value greatet than 0 so put in the the appropiate Total field
                    row.Cells[row.Cells.Count - 1].Value = total.ToString();
                }
                else // if Total field had a value and user deleted values in mon-sun, reflect changes.
                {
                    // Clear the totals cell
                    row.Cells[row.Cells.Count - 1].Value = "";
                    // Clear corresponding label total
                    UpdateLabelTotals(); // clear total values below gridview
                }
            }
        }

        // Sums up each Day in each column, for each valid row, and final total
        //
        private void UpdateLabelTotals()
        {
            // Columns 4 to 10 which is the days columns
            double total;
            for (int iCol = 4; iCol < 11; iCol++)
            {
                total = 0;
                // Each row in the current column except last empty row
                for (int iRow = 0; iRow < dataGridView1.RowCount - 1; iRow++)
                {
                    if ((dataGridView1[iCol, iRow].Value != null) && dataGridView1[iCol, iRow].Value.ToString() != "")
                    {
                        total += double.Parse(dataGridView1[iCol, iRow].Value.ToString());
                    }
                }                           

                // Get the corresponding label total (lblMonTotal, lblTueTotal, etc.)
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Label && ctrl.Tag != null && ctrl.Tag.ToString() == iCol.ToString())
                    {
                        ctrl.Text = total.ToString(); // Update the labels text
                        break; // Found the one we need so dont check anymore
                    }                 
                }
            }
            // Sum up daily totals and update final total label
            total = (double.Parse(lblMonTotal.Text) + double.Parse(lblTueTotal.Text) + double.Parse(lblWedTotal.Text)
                 + double.Parse(lblThuTotal.Text) + double.Parse(lblFriTotal.Text) + double.Parse(lblSatTotal.Text)
                  + double.Parse(lblSunTotal.Text));

            lblTotal.Text = total.ToString();
        }
         
        // Checks the checkstate of a checkbox and if checked disables appropriate columns
        // for the specific day corresponding to the checkbox arg.
        private void SetHoliday(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // get sender
            // Get index of column that is disabled
            int iCol = int.Parse(checkBox.Tag.ToString());

            if (checkBox.Checked)
            {
                // Loop through fields of column
                for (int iRow = 0; iRow < dataGridView1.RowCount; iRow++) // even new row (empty row)
                {
                    // It's weekend/vacation/holiday so clear hours from fields that are disabled
                    dataGridView1[iCol, iRow].Value = "";
                    dataGridView1[iCol, iRow].ReadOnly = true;// Disable fields in column
                    dataGridView1[iCol, iRow].Style.BackColor = highlightDisabled;
                }

                foreach (Control ctrl in this.Controls) // get highlighted corresponding total label
                {
                    if (ctrl.Tag != null && ctrl is Label && ctrl.Tag.ToString() == checkBox.Tag.ToString())
                    {
                        ctrl.BackColor = Label.DefaultBackColor;// reset daily totals if highlighted
                        break;
                    }
                }
            }
            else
            {
                // Loop through fields of column
                for (int iRow = 0; iRow < dataGridView1.RowCount; iRow++)
                {
                    // It's weekend/vacation/holiday so clear hours from fields that are disabled
                    dataGridView1[iCol, iRow].Value = "";
                    dataGridView1[iCol, iRow].ReadOnly = false;// Enable fields in column
                    dataGridView1[iCol, iRow].Style.BackColor = defaultColor; // Change back to default color
                }

                foreach (Control ctrl in this.Controls) // get highlighted corresponding total label
                {
                    if (ctrl.Tag != null && ctrl is Label && ctrl.Tag.ToString() == checkBox.Tag.ToString())
                    {
                        ctrl.BackColor = Label.DefaultBackColor;// reset daily totals if highlighted
                        break;
                    }
                }
            }

            // Columns were disabled or enabled so reflect changes in total field
            UpdateGridViewTotals();
        }
        
        // Validates all controls and returns any errors it finds
        //
        private String GetAllErrors()
        {
            String empNameError = "        >Employee name cannot be left blank.\n";
            String supNameError = "        >Supervisor name cannot be left blank.\n";
            String clientError1 = "        >Missing information for client (blue).\n";
            String noDataError = "        >No payroll data to submit. \n";
            String hoursError1 = "        >Missing information for hours (green). \n";
            String hoursError2 = "        >Project hours cannot be > 24 (yellow).\n";
            String hoursError3 = "        >Daily total hours cannot be > 24 (yellow).\n";

            String allErrors = null;

            if (String.IsNullOrEmpty(tbEmployeeName.Text))// Employee name
            {
                allErrors += empNameError;
            }
            if (String.IsNullOrEmpty(tbSupervisorName.Text)) // Supervisor name
            {
                allErrors += supNameError;
            }
            if (dataGridView1.RowCount == 1) // No payroll data
            {
                allErrors += noDataError;
            }
            if (ValidateClientFields()) // Client fields
            {
                allErrors += clientError1;
            }
            if (ValidateDayFields()) // Day fields (Mon-Sun)
            {
                allErrors += hoursError1;
            }
            if (CheckMaxHoursSingle()) // Project daily hours > 24 hours
            {
                allErrors += hoursError2;
            }
            if (CheckMaxHoursMultiple()) // Total daily hours > 24
            {
                allErrors += hoursError3;
            }

            return allErrors;
        }

        // Validates the day fields(Mon-Sun) for input and informs user if left empty and not holiday
        // by highlighting the offending field and displaying messagebox..
        // Returns true if any field is invalid. Otherwise false.
        private bool ValidateDayFields()
        {
            // Make sure that each day is either checked for 
            // weekend /vacation/holiday or user has entered hours
            bool errors = false;
            for (int iRow = 0; iRow < dataGridView1.RowCount - 1; iRow++) // don't check last row (empty row)
            {
                for (int iCol = 4; iCol < 11; iCol++) // only concerned with the mon-sun columns
                {
                    if (dataGridView1[iCol, iRow].Value == null || dataGridView1[iCol, iRow].Value.ToString() == "")
                    {
                        // Only change backcolor if day checkbox is not checked (field is readonly)
                        if (!dataGridView1[iCol, iRow].ReadOnly)
                        {
                            // Highlight cell
                            dataGridView1.Rows[iRow].Cells[iCol].Style.BackColor = highlightMissingHours ;
                            errors = true; // found error in this field
                        }
                    }
                    else
                    {
                        // Un-highlight cell
                        dataGridView1.Rows[iRow].Cells[iCol].Style.BackColor = defaultColor;
                    }
                }
            }

            if (errors)
            {
                dataGridView1.ClearSelection(); // found errors unselect any selected cells (cosmetic only)
            }

            return errors;
        }

        // Validates the Client fields (client, contracts, projects, billing level)
        // and informs user if a field is left empty.
        // Returns true if any field is invalid. Otherwise false.
        private bool ValidateClientFields()
        {
            bool errors = false;
            // Make sure values are entered for Client, Contract, Projects, and Billing Level
            for (int iRow = 0; iRow < dataGridView1.RowCount - 1; iRow++) // Don't check empty row
            {
                for (int iCell = 0; iCell < 4; iCell++) // First 4 cells of each row
                {
                    // There must be values present
                    if (dataGridView1.Rows[iRow].Cells[iCell].Value == null || dataGridView1.Rows[iRow].Cells[iCell].Value.ToString() == "")
                    {
                        // Inform the user of missing values
                        dataGridView1.Rows[iRow].Cells[iCell].Style.BackColor = highlightMissingClientInfo;
                        errors = true; // found errors in client, contracts, projects, or billing level
                    }
                    else
                    {
                        // Inform the user of missing values
                        dataGridView1.Rows[iRow].Cells[iCell].Style.BackColor = defaultColor;
                    }
                }
            }

            if (errors)
            {
                dataGridView1.ClearSelection(); // found errors unselect any selected cells (cosmetic only)
            }

            return errors;
        }

    }
}
