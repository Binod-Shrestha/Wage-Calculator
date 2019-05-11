using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2_Binod_Shrestha
{
    public partial class Form1 : Form
    {

        List<Employee> employees;


        public Form1()
        {
            InitializeComponent();
            employees = new List<Employee>();
            txtName.Focus();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            try
            {
                Employee emp = new Employee();
                Employee manager = new Manager();
                if (string.IsNullOrEmpty(txtName.Text) != false && string.IsNullOrEmpty(txtHours.Text) != false && string.IsNullOrEmpty(txtWage.Text) != false)
                {
                    throw new ApplicationException("The fields are empty.");
                }


                String name = txtName.Text;
                double hourlyWage = double.Parse(txtWage.Text);
                double hoursWorked = double.Parse(txtHours.Text);

                // Unique employee name validation
                Boolean isDuplicate = false;
                for (int i = 0; i < employees.Count(); i++)
                {
                    if (employees[i].Name == name)
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                

                if (isDuplicate == false)
                    emp.Name = name;
                else
                    throw (new DuplicateNameException("The name already exists."));

              
                               
                emp.HourlyWage = hourlyWage;
                manager.HourlyWage = hourlyWage;
                emp.HoursWorked = hoursWorked;
                manager.HoursWorked = hoursWorked;
                manager.Name = name;
               
                // employee object added to employees list
                employees.Add(emp);

                cmbEmployees.Items.Clear();

                // employee object's properties display on  selection of combo box list.
                if (ckBoxManager.Checked)
                {
                    txtGrossEarnings.Text = manager.Earnings().ToString();
                    txtNetEarnings.Text = manager.NetEarning().ToString();
                    txtFWT.Text = manager.LessFWT().ToString();
                }
                else
                {
                    txtGrossEarnings.Text = emp.Earnings().ToString();
                    txtNetEarnings.Text = emp.NetEarning().ToString();
                    txtFWT.Text = emp.LessFWT().ToString();
                }


                //name of the object employee appended in the combo box list.
                foreach (Employee newEmp in employees)
                {
                    cmbEmployees.Items.Add(newEmp.Name);
                }
            }

            // customized and system.exception exceptions
            catch (ApplicationException apEx)
            {
                MessageBox.Show(apEx.Message,"Error Message!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (DuplicateNameException dupEx)
            {
                MessageBox.Show(dupEx.Message, "Error Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please check wage or hours entries. ", "Error Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             }
        
        /// <summary>
        /// removed predisplayed infomation in the texboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void btnClear_Click(object sender, EventArgs e)
            {
                txtName.Clear();
                txtFWT.Clear();
                txtGrossEarnings.Clear();
                txtHours.Clear();
                txtNetEarnings.Clear();
                txtWage.Clear();
            ckBoxManager.Checked = false;
            } // end of button click 


        /// <summary>
        /// closes the application with user's consent.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
            {
            if (MessageBox.Show("Do you want to close the application?", "Close Application", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }

        } // end of button close.

        /// <summary>
        /// displays the object information in the text boxes on selection in the combo box dropdown list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
            {
               for (int i = 0; i < employees.Count; i++)
                {
                    if (employees[i].Name == cmbEmployees.Text)
                    txtName.Text = employees[i].Name;
                    txtFWT.Text = employees[i].LessFWT().ToString();
                    txtGrossEarnings.Text = employees[i].Earnings().ToString();
                    txtHours.Text = employees[i].HoursWorked.ToString();
                    txtNetEarnings.Text = employees[i].NetEarning().ToString();
                    txtWage.Text = employees[i].HourlyWage.ToString();

                }                        
            }// end of combo box function        
        }
    }
