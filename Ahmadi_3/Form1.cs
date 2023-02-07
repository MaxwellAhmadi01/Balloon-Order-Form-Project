// Programmer: Maxwell Ahmadi
// Project: Ahmadi_3
// Date: 11/11/2022
// Description: Individual Assignment #3

using System;
using System.IO;
using System.Windows.Forms;

namespace Ahmadi_3
{
    public partial class bonniesBalloonsOrderForm : Form
    {

        // Declare all constants needed for purchase/delivery options of balloons and extra amenities*
        private const decimal STORE_PICKUP_COST = 0.00m;
        private const decimal HOME_DELIVERY_COST = 7.50m;
        private const decimal SINGLE_BUNDLE_COST = 9.95m;
        private const decimal HALF_DOZEN_BUNDLE_COST = 35.95m;
        private const decimal FULL_DOZEN_BUNDLE_COST = 65.95m;
        private const decimal EXTRA_AMENITIES_COST = 9.50m;
        private const decimal PERSONALIZED_MESSAGE_COST = 2.50m;
        private const decimal SALES_TAX_RATE = 0.07m;

        // Declare all of the necessary class-level variables for calculation of totals (come end of the program)
        private decimal subTotal = 0m;
        private decimal salesTax = 0m;
        private decimal orderTotal = 0m;
        private decimal homeDeliveryCost = 0m;
        private decimal sizeCost = 0m;
        private decimal personalizedMessageCost = 0m;
        private decimal extrasCost = 0m;

        public bonniesBalloonsOrderForm()
        {
            InitializeComponent();
        }

        // Establishes the event handler, which will allow for the initial display of values after the form has loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            // Allows each of the proper radio buttons to be clicked when the form first loads
            singleRadioButton.Checked = true;
            storePickupRadioButton.Checked = true;
            personalizedMessageCheckBox.Checked = false;
            personalizedMessageTextBox.Enabled = false;

            // Display the current date
            deliveryDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            // Home Delivery Cost (Store-Pickup would NOT be included because it is free)*
            homeDeliveryPriceLabel.Text = HOME_DELIVERY_COST.ToString("c");

            // Balloon Bundle Size Costs
            singlePriceLabel.Text = SINGLE_BUNDLE_COST.ToString("c");
            halfDozenPriceLabel.Text = HALF_DOZEN_BUNDLE_COST.ToString("c");
            dozenPriceLabel.Text = FULL_DOZEN_BUNDLE_COST.ToString("c");

            // Extra Ammenitie(s) Cost
            extrasPriceLabel.Text = EXTRA_AMENITIES_COST.ToString("c");

            // Personalized Message Cost
            personalizedMessageCostLabel.Text = PERSONALIZED_MESSAGE_COST.ToString("c");

            // Total Order Prices
            subtotalLabel.Text = subTotal.ToString("c");
            salesTaxLabel.Text = salesTax.ToString("c");
            orderTotalLabel.Text = orderTotal.ToString("c");

            // Allows the combo and list boxes to load everything necessary to operate*
            PopulateBoxes();

            // Allows totals to be updated periodically as the system runs/is updated with new information
            UpdateTotals();

            // Allows for the 'Birthday' label to be selected at the initial start-up of the program
            specialOccasionComboBox.SelectedItem = "Birthday";
        }

        // Declare totals
        private void UpdateTotals()
        {

            int extrasCount = 0;

            for (int counter = 0; counter < extrasListBox.Items.Count; counter++)
            {
                if (extrasListBox.GetSelected(counter))
                {
                    extrasCount++;
                }
            }

            if (storePickupRadioButton.Checked)
            {
                homeDeliveryCost = 0m;
            }
            else
            {
                homeDeliveryCost = HOME_DELIVERY_COST;
            }

            if (singleRadioButton.Checked)
            {
                sizeCost = SINGLE_BUNDLE_COST;
            }
            else if (halfDozenRadioButton.Checked)
            {
                sizeCost = HALF_DOZEN_BUNDLE_COST;
            }
            else if (dozenRadioButton.Checked)
            {
                sizeCost = FULL_DOZEN_BUNDLE_COST;
            }

            if (personalizedMessageCheckBox.Checked)
            {
                personalizedMessageCost = PERSONALIZED_MESSAGE_COST;
            }
            else
            {
                personalizedMessageCost = 0m;
            }

            subTotal = homeDeliveryCost + sizeCost + extrasCost + personalizedMessageCost;
            subtotalLabel.Text = subTotal.ToString("c");
            salesTax = subTotal * SALES_TAX_RATE;
            salesTaxLabel.Text = salesTax.ToString("c");
            orderTotal = subTotal + salesTax;
            orderTotalLabel.Text = orderTotal.ToString("c");
            extrasCost = EXTRA_AMENITIES_COST * extrasCount;
        }

        private void storePickupRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void homeDeliveryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void singleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void halfDozenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void dozenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void personalizedMessageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();

            if (personalizedMessageCheckBox.Checked)
            {
                personalizedMessageTextBox.Enabled = true;
                characterLimitLabel.Enabled = true;
            }

            else
            {
                personalizedMessageTextBox.Enabled = false;
                characterLimitLabel.Enabled = false;
                personalizedMessageTextBox.Text = "";
            }
        }

        private void PopulateBoxes()
        {
            try
            {
                string extras;
                StreamReader inputFile;
                inputFile = File.OpenText("Extras.txt");
                extrasListBox.Items.Clear();
                while (!inputFile.EndOfStream)
                {
                    extras = inputFile.ReadLine();
                    extrasListBox.Items.Add(extras);
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string specialOccasion;
                StreamReader inputFile;
                inputFile = File.OpenText("Occasions.txt");
                specialOccasionComboBox.Items.Clear();
                while (!inputFile.EndOfStream)
                {
                    specialOccasion = inputFile.ReadLine();
                    specialOccasionComboBox.Items.Add(specialOccasion);
                }
                inputFile.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void extrasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        // Executes the display summary button, which will produce 
        private void displaySummaryButton_Click(object sender, EventArgs e)
        {
            string deliveryType;
            string bundleSize;
            string specialOccasion = specialOccasionComboBox.Text;
            string listOfExtras = "";

            if (storePickupRadioButton.Checked)
            {
                deliveryType = "In-Store Pick Up";
            }
            else
            {
                deliveryType = "Home Delivery";
            }

            if (singleRadioButton.Checked)
            {
                bundleSize = "Single Balloon";
            }
            else if (halfDozenRadioButton.Checked)
            {
                bundleSize = "Half-Dozen Balloons";
            }
            else
            {
                bundleSize = "Full Dozen Balloons";
            }

            // Adds any inputed 'extra' items to the list generated after the display summary button is clicked.
            for (int counter = 0; counter < extrasListBox.Items.Count; counter++)
            {
                if (extrasListBox.GetSelected(counter))
                {
                    listOfExtras += extrasListBox.Items[counter].ToString() + "\n";
                }
            }

            if (firstNameTextBox.Text == "" | lastNameTextBox.Text == "" | phoneNumberMaskedTextBox.Text == "")
            {
                MessageBox.Show("Error: Please review all information entered into the form.");
            }
            else
            {
                // Organize message box to allow it to be clear and insert the necessary icons for display.
                MessageBox.Show("Bonnie's Balloons Order Summary:"
                    + "\nCustomer Name: " + abbreviationComboBox.Text + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text
                    + "\nCustomer Address: " + " " + streetTextBox.Text + ", " + cityTextBox.Text + ", " + stateMaskedTextBox.Text + " " + zipCodeMaskedTextBox.Text
                    + "\nCustomer Phone: " + " " + phoneNumberMaskedTextBox.Text
                    + "\nDelivery Date: " + deliveryDateMaskedTextBox.Text
                    + "\nDelivery Type: " + deliveryType
                    + "\nBundle Order Size: " + bundleSize
                    + "\nSpecial Occasion: " + specialOccasion
                    + "\nExtra Add-Ons: " + listOfExtras
                    + "\nPersonalized Message: " + personalizedMessageTextBox.Text
                    + "\nSubtotal: " + subTotal
                    + "\nSales Tax: " + salesTax
                    + "\nOrder Total: " + orderTotal,
                    "Order Summary:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

           private void ResetForm()
                    {
                    abbreviationComboBox.SelectedItem = "";
                    abbreviationComboBox.Focus();
                    firstNameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    streetTextBox.Text = "";
                    cityTextBox.Text = "";
                    stateMaskedTextBox.Text = "";
                    phoneNumberMaskedTextBox.Text = "";
                    zipCodeMaskedTextBox.Text = "";
                    deliveryDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
                    storePickupRadioButton.Checked = true;
                    singleRadioButton.Checked = true;
                    personalizedMessageCheckBox.Checked = false;
                    specialOccasionComboBox.SelectedItem = null;
                    extrasListBox.SelectedItem = null;
                    specialOccasionComboBox.SelectedItem = "Birthday";
                    }


    // References the 'Reset Form' custom method established below in order to reset the form with the click of the clear button.
    private void clearFormButton_Click(object sender, EventArgs e)
        {
            ResetForm();
            UpdateTotals();
        }

        private void exitProgramButton_Click(object sender, EventArgs e)
        {
            DialogResult selection;
            selection = MessageBox.Show("Are you sure you wish to quit the program?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (selection == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}