/**
 * I, Simrit Waraich 000774535, certify that this material is my original
 * work. No other person's work has been used without due acknowledgement and I have
 * not made my work available to anyone else.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3B
{

    public partial class Form1 : Form
    {

        private double hairDresserCost;
        private double servicesCost;
        private double sumOfVisit;
   
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Setting a default value to the combobox where Jane is the first selected hairdresser 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            
            selectDresserComboBox.SelectedIndex = 0;
        }
        private void selectHairdresser_Enter(object sender, EventArgs e)
        {
             

        }

        private void chargedItems_Enter(object sender, EventArgs e)
        {

        }

        private void slectAService_Enter(object sender, EventArgs e)
        {

        }

        private void price_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Setting the cost of a service based of what service is selected
        /// also checking if there is something selected and enabling the add button when something is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxServices.SelectedIndex == 0)
            {
                servicesCost = 30.00;
            }
            else if (listBoxServices.SelectedIndex == 1)
            {
                servicesCost = 20.00;
            }
            else if (listBoxServices.SelectedIndex == 2)
            {
                servicesCost = 40.00;
            }
            else if (listBoxServices.SelectedIndex == 3)
            {
                servicesCost = 50.00;
            }
            else if (listBoxServices.SelectedIndex == 4)
            {
                servicesCost = 200.00;
            }
            else if (listBoxServices.SelectedIndex == 5)
            {
                servicesCost = 60.00;
            }
            if (listBoxServices.SelectedIndex != -1)
            {
                addService.Enabled = true;
                addService.Focus();
            }
            else
            {
                addService.Enabled = false;
            }
        }
        /// <summary>
        /// Setting the default value of blank
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxChargedItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxChargedItems.Text = " ";
        }
        /// <summary>
        /// Setting the default value of Blank
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxPrice.Text = " ";
        }

        private void finalPriceBox_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Exiting the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Reseting all of the box's and text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_Click(object sender, EventArgs e)
        {
            selectDresserComboBox.Enabled = true;
            selectDresserComboBox.SelectedIndex = 0;
            addService.Enabled = false;
            totalPrice.Enabled = false;
            listBoxChargedItems.Items.Clear();
            listBoxPrice.Items.Clear();
            listBoxServices.ClearSelected();
            finalPriceBox.Text = "";
        }
        /// <summary>
        /// A calculate button, where a foreach loop goes through all of the items
        /// in the box price to calculate the total. The loop also converts to double
        /// and trims the spaces and the $ out of the string so that it can be converted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void totalPrice_Click(object sender, EventArgs e)
        {
            foreach( String i in listBoxPrice.Items)
            {
                sumOfVisit = sumOfVisit + Convert.ToDouble(i.Trim(new char[] { ' ', '$' }));
            }
            finalPriceBox.Text = sumOfVisit.ToString("$0.00");
            sumOfVisit = 0;
        }
        /// <summary>
        /// Adding the dresser and the service, and costs to the charged items box and the
        /// price box, and enabeling and diabeling certain features of the product 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addService_Click(object sender, EventArgs e)
        {
            if(selectDresserComboBox.Enabled == false)
            {
                listBoxChargedItems.Items.Add(listBoxServices.Text);
                listBoxPrice.Items.Add(servicesCost.ToString("$0.00"));
            }
            else
            {
                listBoxChargedItems.Items.Add(selectDresserComboBox.Text);
                listBoxChargedItems.Items.Add(listBoxServices.Text);
                listBoxPrice.Items.Add(hairDresserCost.ToString("$0.00"));
                listBoxPrice.Items.Add(servicesCost.ToString("$0.00"));
            }

            totalPrice.Enabled = true;
            totalPrice.Focus();
            listBoxServices.ClearSelected();
            selectDresserComboBox.Enabled = false;

        }
        /// <summary>
        /// Setting the hairdresser cost based off what hairdresser is selected in the combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectDresserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectDresserComboBox.SelectedIndex == 0)
            {
                hairDresserCost = 30.00;
            }
            if (selectDresserComboBox.SelectedIndex == 1)
            {
                hairDresserCost = 45.00;
            }
            if (selectDresserComboBox.SelectedIndex == 2)
            {
                hairDresserCost = 40.00;
            }
            if (selectDresserComboBox.SelectedIndex == 3)
            {
                hairDresserCost = 50.00;
            }
            if (selectDresserComboBox.SelectedIndex == 4)
            {
                hairDresserCost = 55.00;
            }
        }
    }
}
