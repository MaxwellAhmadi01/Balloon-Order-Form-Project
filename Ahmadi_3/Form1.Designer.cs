namespace Ahmadi_3
{
    partial class bonniesBalloonsOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bonniesBalloonsOrderForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.stateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.abbreviationLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.phoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.abbreviationComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.deliveryTypeLabel = new System.Windows.Forms.Label();
            this.deliveryDateLabel = new System.Windows.Forms.Label();
            this.homeDeliveryPriceLabel = new System.Windows.Forms.Label();
            this.homeDeliveryRadioButton = new System.Windows.Forms.RadioButton();
            this.storePickupRadioButton = new System.Windows.Forms.RadioButton();
            this.deliveryDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.orderDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.personalizedMessageCostLabel = new System.Windows.Forms.Label();
            this.characterLimitLabel = new System.Windows.Forms.Label();
            this.personalizedMessageTextBox = new System.Windows.Forms.TextBox();
            this.personalizedMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.extrasPriceLabel = new System.Windows.Forms.Label();
            this.extrasListBox = new System.Windows.Forms.ListBox();
            this.specialOccasionComboBox = new System.Windows.Forms.ComboBox();
            this.specialOccasionLabel = new System.Windows.Forms.Label();
            this.dozenPriceLabel = new System.Windows.Forms.Label();
            this.halfDozenPriceLabel = new System.Windows.Forms.Label();
            this.singlePriceLabel = new System.Windows.Forms.Label();
            this.dozenRadioButton = new System.Windows.Forms.RadioButton();
            this.halfDozenRadioButton = new System.Windows.Forms.RadioButton();
            this.singleRadioButton = new System.Windows.Forms.RadioButton();
            this.bundleSizeLabel = new System.Windows.Forms.Label();
            this.orderTotalsGroupBox = new System.Windows.Forms.GroupBox();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.orderTotalTextLabel = new System.Windows.Forms.Label();
            this.salesTaxTextLabel = new System.Windows.Forms.Label();
            this.subtotalTextLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clearFormButton = new System.Windows.Forms.Button();
            this.exitProgramButton = new System.Windows.Forms.Button();
            this.displaySummaryButton = new System.Windows.Forms.Button();
            this.displaySummaryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearFormToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitProgramToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customerInfoGroupBox.SuspendLayout();
            this.deliveryInfoGroupBox.SuspendLayout();
            this.orderDetailsGroupBox.SuspendLayout();
            this.orderTotalsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(679, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bonnie\'s Balloons";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ahmadi_3.Properties.Resources.Balloons;
            this.pictureBox1.Location = new System.Drawing.Point(637, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // customerInfoGroupBox
            // 
            this.customerInfoGroupBox.Controls.Add(this.stateMaskedTextBox);
            this.customerInfoGroupBox.Controls.Add(this.abbreviationLabel);
            this.customerInfoGroupBox.Controls.Add(this.cityTextBox);
            this.customerInfoGroupBox.Controls.Add(this.streetTextBox);
            this.customerInfoGroupBox.Controls.Add(this.zipCodeMaskedTextBox);
            this.customerInfoGroupBox.Controls.Add(this.zipCodeLabel);
            this.customerInfoGroupBox.Controls.Add(this.phoneNumberMaskedTextBox);
            this.customerInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.customerInfoGroupBox.Controls.Add(this.firstNameTextBox);
            this.customerInfoGroupBox.Controls.Add(this.stateLabel);
            this.customerInfoGroupBox.Controls.Add(this.phoneNumberLabel);
            this.customerInfoGroupBox.Controls.Add(this.streetLabel);
            this.customerInfoGroupBox.Controls.Add(this.cityLabel);
            this.customerInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.customerInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.customerInfoGroupBox.Controls.Add(this.abbreviationComboBox);
            this.customerInfoGroupBox.Location = new System.Drawing.Point(23, 175);
            this.customerInfoGroupBox.Name = "customerInfoGroupBox";
            this.customerInfoGroupBox.Size = new System.Drawing.Size(608, 403);
            this.customerInfoGroupBox.TabIndex = 2;
            this.customerInfoGroupBox.TabStop = false;
            this.customerInfoGroupBox.Text = "Customer Information:";
            // 
            // stateMaskedTextBox
            // 
            this.stateMaskedTextBox.Location = new System.Drawing.Point(407, 222);
            this.stateMaskedTextBox.Mask = "AA";
            this.stateMaskedTextBox.Name = "stateMaskedTextBox";
            this.stateMaskedTextBox.Size = new System.Drawing.Size(50, 31);
            this.stateMaskedTextBox.TabIndex = 5;
            // 
            // abbreviationLabel
            // 
            this.abbreviationLabel.AutoSize = true;
            this.abbreviationLabel.Location = new System.Drawing.Point(-1, 75);
            this.abbreviationLabel.Name = "abbreviationLabel";
            this.abbreviationLabel.Size = new System.Drawing.Size(138, 25);
            this.abbreviationLabel.TabIndex = 12;
            this.abbreviationLabel.Text = "Abbreviation:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(407, 159);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(195, 31);
            this.cityTextBox.TabIndex = 4;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(407, 107);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(195, 31);
            this.streetTextBox.TabIndex = 3;
            // 
            // zipCodeMaskedTextBox
            // 
            this.zipCodeMaskedTextBox.Location = new System.Drawing.Point(182, 342);
            this.zipCodeMaskedTextBox.Mask = "00000";
            this.zipCodeMaskedTextBox.Name = "zipCodeMaskedTextBox";
            this.zipCodeMaskedTextBox.Size = new System.Drawing.Size(89, 31);
            this.zipCodeMaskedTextBox.TabIndex = 7;
            this.zipCodeMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(62, 348);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(105, 25);
            this.zipCodeLabel.TabIndex = 7;
            this.zipCodeLabel.Text = "Zip Code:";
            // 
            // phoneNumberMaskedTextBox
            // 
            this.phoneNumberMaskedTextBox.Location = new System.Drawing.Point(178, 278);
            this.phoneNumberMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneNumberMaskedTextBox.Name = "phoneNumberMaskedTextBox";
            this.phoneNumberMaskedTextBox.Size = new System.Drawing.Size(156, 31);
            this.phoneNumberMaskedTextBox.TabIndex = 6;
            this.phoneNumberMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(143, 183);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(153, 31);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(143, 123);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(153, 31);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(316, 222);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(68, 25);
            this.stateLabel.TabIndex = 5;
            this.stateLabel.Text = "State:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(6, 284);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(161, 25);
            this.phoneNumberLabel.TabIndex = 3;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(316, 113);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(75, 25);
            this.streetLabel.TabIndex = 3;
            this.streetLabel.Text = "Street:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(316, 166);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(55, 25);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "City:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(16, 186);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(121, 25);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(15, 129);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(122, 25);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name:";
            // 
            // abbreviationComboBox
            // 
            this.abbreviationComboBox.FormattingEnabled = true;
            this.abbreviationComboBox.Items.AddRange(new object[] {
            "Dr.",
            "Mr.",
            "Ms.",
            "Mrs.",
            "Rev."});
            this.abbreviationComboBox.Location = new System.Drawing.Point(178, 72);
            this.abbreviationComboBox.Name = "abbreviationComboBox";
            this.abbreviationComboBox.Size = new System.Drawing.Size(83, 33);
            this.abbreviationComboBox.TabIndex = 0;
            // 
            // deliveryInfoGroupBox
            // 
            this.deliveryInfoGroupBox.Controls.Add(this.deliveryTypeLabel);
            this.deliveryInfoGroupBox.Controls.Add(this.deliveryDateLabel);
            this.deliveryInfoGroupBox.Controls.Add(this.homeDeliveryPriceLabel);
            this.deliveryInfoGroupBox.Controls.Add(this.homeDeliveryRadioButton);
            this.deliveryInfoGroupBox.Controls.Add(this.storePickupRadioButton);
            this.deliveryInfoGroupBox.Controls.Add(this.deliveryDateMaskedTextBox);
            this.deliveryInfoGroupBox.Location = new System.Drawing.Point(1013, 175);
            this.deliveryInfoGroupBox.Name = "deliveryInfoGroupBox";
            this.deliveryInfoGroupBox.Size = new System.Drawing.Size(579, 403);
            this.deliveryInfoGroupBox.TabIndex = 8;
            this.deliveryInfoGroupBox.TabStop = false;
            this.deliveryInfoGroupBox.Text = "Delivery Information:";
            // 
            // deliveryTypeLabel
            // 
            this.deliveryTypeLabel.AutoSize = true;
            this.deliveryTypeLabel.Location = new System.Drawing.Point(29, 108);
            this.deliveryTypeLabel.Name = "deliveryTypeLabel";
            this.deliveryTypeLabel.Size = new System.Drawing.Size(150, 25);
            this.deliveryTypeLabel.TabIndex = 5;
            this.deliveryTypeLabel.Text = "Delivery Type:";
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.AutoSize = true;
            this.deliveryDateLabel.Location = new System.Drawing.Point(29, 61);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(147, 25);
            this.deliveryDateLabel.TabIndex = 4;
            this.deliveryDateLabel.Text = "Delivery Date:";
            // 
            // homeDeliveryPriceLabel
            // 
            this.homeDeliveryPriceLabel.AutoSize = true;
            this.homeDeliveryPriceLabel.Location = new System.Drawing.Point(442, 183);
            this.homeDeliveryPriceLabel.Name = "homeDeliveryPriceLabel";
            this.homeDeliveryPriceLabel.Size = new System.Drawing.Size(75, 25);
            this.homeDeliveryPriceLabel.TabIndex = 3;
            this.homeDeliveryPriceLabel.Text = "PRICE";
            this.homeDeliveryPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // homeDeliveryRadioButton
            // 
            this.homeDeliveryRadioButton.AutoSize = true;
            this.homeDeliveryRadioButton.Location = new System.Drawing.Point(226, 179);
            this.homeDeliveryRadioButton.Name = "homeDeliveryRadioButton";
            this.homeDeliveryRadioButton.Size = new System.Drawing.Size(183, 29);
            this.homeDeliveryRadioButton.TabIndex = 10;
            this.homeDeliveryRadioButton.TabStop = true;
            this.homeDeliveryRadioButton.Text = "Home Delivery";
            this.homeDeliveryRadioButton.UseVisualStyleBackColor = true;
            this.homeDeliveryRadioButton.CheckedChanged += new System.EventHandler(this.homeDeliveryRadioButton_CheckedChanged);
            // 
            // storePickupRadioButton
            // 
            this.storePickupRadioButton.AutoSize = true;
            this.storePickupRadioButton.Location = new System.Drawing.Point(226, 123);
            this.storePickupRadioButton.Name = "storePickupRadioButton";
            this.storePickupRadioButton.Size = new System.Drawing.Size(165, 29);
            this.storePickupRadioButton.TabIndex = 9;
            this.storePickupRadioButton.TabStop = true;
            this.storePickupRadioButton.Text = "Store Pickup";
            this.storePickupRadioButton.UseVisualStyleBackColor = true;
            this.storePickupRadioButton.CheckedChanged += new System.EventHandler(this.storePickupRadioButton_CheckedChanged);
            // 
            // deliveryDateMaskedTextBox
            // 
            this.deliveryDateMaskedTextBox.Location = new System.Drawing.Point(226, 61);
            this.deliveryDateMaskedTextBox.Mask = "00/00/0000";
            this.deliveryDateMaskedTextBox.Name = "deliveryDateMaskedTextBox";
            this.deliveryDateMaskedTextBox.Size = new System.Drawing.Size(128, 31);
            this.deliveryDateMaskedTextBox.TabIndex = 8;
            this.deliveryDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.deliveryDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // orderDetailsGroupBox
            // 
            this.orderDetailsGroupBox.Controls.Add(this.personalizedMessageCostLabel);
            this.orderDetailsGroupBox.Controls.Add(this.characterLimitLabel);
            this.orderDetailsGroupBox.Controls.Add(this.personalizedMessageTextBox);
            this.orderDetailsGroupBox.Controls.Add(this.personalizedMessageCheckBox);
            this.orderDetailsGroupBox.Controls.Add(this.extrasPriceLabel);
            this.orderDetailsGroupBox.Controls.Add(this.extrasListBox);
            this.orderDetailsGroupBox.Controls.Add(this.specialOccasionComboBox);
            this.orderDetailsGroupBox.Controls.Add(this.specialOccasionLabel);
            this.orderDetailsGroupBox.Controls.Add(this.dozenPriceLabel);
            this.orderDetailsGroupBox.Controls.Add(this.halfDozenPriceLabel);
            this.orderDetailsGroupBox.Controls.Add(this.singlePriceLabel);
            this.orderDetailsGroupBox.Controls.Add(this.dozenRadioButton);
            this.orderDetailsGroupBox.Controls.Add(this.halfDozenRadioButton);
            this.orderDetailsGroupBox.Controls.Add(this.singleRadioButton);
            this.orderDetailsGroupBox.Controls.Add(this.bundleSizeLabel);
            this.orderDetailsGroupBox.Location = new System.Drawing.Point(23, 597);
            this.orderDetailsGroupBox.Name = "orderDetailsGroupBox";
            this.orderDetailsGroupBox.Size = new System.Drawing.Size(926, 329);
            this.orderDetailsGroupBox.TabIndex = 9;
            this.orderDetailsGroupBox.TabStop = false;
            this.orderDetailsGroupBox.Text = "Order Details:";
            // 
            // personalizedMessageCostLabel
            // 
            this.personalizedMessageCostLabel.AutoSize = true;
            this.personalizedMessageCostLabel.Location = new System.Drawing.Point(836, 238);
            this.personalizedMessageCostLabel.Name = "personalizedMessageCostLabel";
            this.personalizedMessageCostLabel.Size = new System.Drawing.Size(75, 25);
            this.personalizedMessageCostLabel.TabIndex = 14;
            this.personalizedMessageCostLabel.Text = "PRICE";
            this.personalizedMessageCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // characterLimitLabel
            // 
            this.characterLimitLabel.AutoSize = true;
            this.characterLimitLabel.Location = new System.Drawing.Point(556, 287);
            this.characterLimitLabel.Name = "characterLimitLabel";
            this.characterLimitLabel.Size = new System.Drawing.Size(187, 25);
            this.characterLimitLabel.TabIndex = 13;
            this.characterLimitLabel.Text = "30 Character Limit";
            // 
            // personalizedMessageTextBox
            // 
            this.personalizedMessageTextBox.Location = new System.Drawing.Point(556, 238);
            this.personalizedMessageTextBox.MaxLength = 30;
            this.personalizedMessageTextBox.Name = "personalizedMessageTextBox";
            this.personalizedMessageTextBox.Size = new System.Drawing.Size(248, 31);
            this.personalizedMessageTextBox.TabIndex = 17;
            // 
            // personalizedMessageCheckBox
            // 
            this.personalizedMessageCheckBox.AutoSize = true;
            this.personalizedMessageCheckBox.Location = new System.Drawing.Point(556, 187);
            this.personalizedMessageCheckBox.Name = "personalizedMessageCheckBox";
            this.personalizedMessageCheckBox.Size = new System.Drawing.Size(263, 29);
            this.personalizedMessageCheckBox.TabIndex = 16;
            this.personalizedMessageCheckBox.Text = "Personalized Message";
            this.personalizedMessageCheckBox.UseVisualStyleBackColor = true;
            this.personalizedMessageCheckBox.CheckedChanged += new System.EventHandler(this.personalizedMessageCheckBox_CheckedChanged);
            // 
            // extrasPriceLabel
            // 
            this.extrasPriceLabel.AutoSize = true;
            this.extrasPriceLabel.Location = new System.Drawing.Point(831, 93);
            this.extrasPriceLabel.Name = "extrasPriceLabel";
            this.extrasPriceLabel.Size = new System.Drawing.Size(75, 25);
            this.extrasPriceLabel.TabIndex = 10;
            this.extrasPriceLabel.Text = "PRICE";
            this.extrasPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // extrasListBox
            // 
            this.extrasListBox.FormattingEnabled = true;
            this.extrasListBox.ItemHeight = 25;
            this.extrasListBox.Location = new System.Drawing.Point(556, 66);
            this.extrasListBox.Name = "extrasListBox";
            this.extrasListBox.Size = new System.Drawing.Size(245, 79);
            this.extrasListBox.Sorted = true;
            this.extrasListBox.TabIndex = 15;
            this.extrasListBox.SelectedIndexChanged += new System.EventHandler(this.extrasListBox_SelectedIndexChanged);
            // 
            // specialOccasionComboBox
            // 
            this.specialOccasionComboBox.FormattingEnabled = true;
            this.specialOccasionComboBox.Location = new System.Drawing.Point(270, 212);
            this.specialOccasionComboBox.Name = "specialOccasionComboBox";
            this.specialOccasionComboBox.Size = new System.Drawing.Size(121, 33);
            this.specialOccasionComboBox.Sorted = true;
            this.specialOccasionComboBox.TabIndex = 14;
            // 
            // specialOccasionLabel
            // 
            this.specialOccasionLabel.AutoSize = true;
            this.specialOccasionLabel.Location = new System.Drawing.Point(11, 212);
            this.specialOccasionLabel.Name = "specialOccasionLabel";
            this.specialOccasionLabel.Size = new System.Drawing.Size(185, 25);
            this.specialOccasionLabel.TabIndex = 7;
            this.specialOccasionLabel.Text = "Special Occasion:";
            // 
            // dozenPriceLabel
            // 
            this.dozenPriceLabel.AutoSize = true;
            this.dozenPriceLabel.Location = new System.Drawing.Point(456, 150);
            this.dozenPriceLabel.Name = "dozenPriceLabel";
            this.dozenPriceLabel.Size = new System.Drawing.Size(75, 25);
            this.dozenPriceLabel.TabIndex = 6;
            this.dozenPriceLabel.Text = "PRICE";
            this.dozenPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // halfDozenPriceLabel
            // 
            this.halfDozenPriceLabel.AutoSize = true;
            this.halfDozenPriceLabel.Location = new System.Drawing.Point(456, 112);
            this.halfDozenPriceLabel.Name = "halfDozenPriceLabel";
            this.halfDozenPriceLabel.Size = new System.Drawing.Size(75, 25);
            this.halfDozenPriceLabel.TabIndex = 5;
            this.halfDozenPriceLabel.Text = "PRICE";
            this.halfDozenPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // singlePriceLabel
            // 
            this.singlePriceLabel.AutoSize = true;
            this.singlePriceLabel.Location = new System.Drawing.Point(456, 77);
            this.singlePriceLabel.Name = "singlePriceLabel";
            this.singlePriceLabel.Size = new System.Drawing.Size(75, 25);
            this.singlePriceLabel.TabIndex = 4;
            this.singlePriceLabel.Text = "PRICE";
            this.singlePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dozenRadioButton
            // 
            this.dozenRadioButton.AutoSize = true;
            this.dozenRadioButton.Location = new System.Drawing.Point(270, 147);
            this.dozenRadioButton.Name = "dozenRadioButton";
            this.dozenRadioButton.Size = new System.Drawing.Size(105, 29);
            this.dozenRadioButton.TabIndex = 13;
            this.dozenRadioButton.TabStop = true;
            this.dozenRadioButton.Text = "Dozen";
            this.dozenRadioButton.UseVisualStyleBackColor = true;
            this.dozenRadioButton.CheckedChanged += new System.EventHandler(this.dozenRadioButton_CheckedChanged);
            // 
            // halfDozenRadioButton
            // 
            this.halfDozenRadioButton.AutoSize = true;
            this.halfDozenRadioButton.Location = new System.Drawing.Point(270, 112);
            this.halfDozenRadioButton.Name = "halfDozenRadioButton";
            this.halfDozenRadioButton.Size = new System.Drawing.Size(150, 29);
            this.halfDozenRadioButton.TabIndex = 12;
            this.halfDozenRadioButton.TabStop = true;
            this.halfDozenRadioButton.Text = "Half-Dozen";
            this.halfDozenRadioButton.UseVisualStyleBackColor = true;
            this.halfDozenRadioButton.CheckedChanged += new System.EventHandler(this.halfDozenRadioButton_CheckedChanged);
            // 
            // singleRadioButton
            // 
            this.singleRadioButton.AutoSize = true;
            this.singleRadioButton.Location = new System.Drawing.Point(270, 77);
            this.singleRadioButton.Name = "singleRadioButton";
            this.singleRadioButton.Size = new System.Drawing.Size(103, 29);
            this.singleRadioButton.TabIndex = 11;
            this.singleRadioButton.TabStop = true;
            this.singleRadioButton.Text = "Single";
            this.singleRadioButton.UseVisualStyleBackColor = true;
            this.singleRadioButton.CheckedChanged += new System.EventHandler(this.singleRadioButton_CheckedChanged);
            // 
            // bundleSizeLabel
            // 
            this.bundleSizeLabel.AutoSize = true;
            this.bundleSizeLabel.Location = new System.Drawing.Point(11, 66);
            this.bundleSizeLabel.Name = "bundleSizeLabel";
            this.bundleSizeLabel.Size = new System.Drawing.Size(211, 25);
            this.bundleSizeLabel.TabIndex = 0;
            this.bundleSizeLabel.Text = "Balloon Bundle Size:";
            // 
            // orderTotalsGroupBox
            // 
            this.orderTotalsGroupBox.Controls.Add(this.orderTotalLabel);
            this.orderTotalsGroupBox.Controls.Add(this.salesTaxLabel);
            this.orderTotalsGroupBox.Controls.Add(this.subtotalLabel);
            this.orderTotalsGroupBox.Controls.Add(this.orderTotalTextLabel);
            this.orderTotalsGroupBox.Controls.Add(this.salesTaxTextLabel);
            this.orderTotalsGroupBox.Controls.Add(this.subtotalTextLabel);
            this.orderTotalsGroupBox.Controls.Add(this.button1);
            this.orderTotalsGroupBox.Location = new System.Drawing.Point(1032, 597);
            this.orderTotalsGroupBox.Name = "orderTotalsGroupBox";
            this.orderTotalsGroupBox.Size = new System.Drawing.Size(560, 329);
            this.orderTotalsGroupBox.TabIndex = 10;
            this.orderTotalsGroupBox.TabStop = false;
            this.orderTotalsGroupBox.Text = "Order Totals:";
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.Location = new System.Drawing.Point(213, 169);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(75, 25);
            this.orderTotalLabel.TabIndex = 6;
            this.orderTotalLabel.Text = "PRICE";
            this.orderTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(213, 120);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(75, 25);
            this.salesTaxLabel.TabIndex = 5;
            this.salesTaxLabel.Text = "PRICE";
            this.salesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(213, 80);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(75, 25);
            this.subtotalLabel.TabIndex = 4;
            this.subtotalLabel.Text = "PRICE";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderTotalTextLabel
            // 
            this.orderTotalTextLabel.AutoSize = true;
            this.orderTotalTextLabel.Location = new System.Drawing.Point(29, 169);
            this.orderTotalTextLabel.Name = "orderTotalTextLabel";
            this.orderTotalTextLabel.Size = new System.Drawing.Size(126, 25);
            this.orderTotalTextLabel.TabIndex = 3;
            this.orderTotalTextLabel.Text = "Order Total:";
            // 
            // salesTaxTextLabel
            // 
            this.salesTaxTextLabel.AutoSize = true;
            this.salesTaxTextLabel.Location = new System.Drawing.Point(29, 120);
            this.salesTaxTextLabel.Name = "salesTaxTextLabel";
            this.salesTaxTextLabel.Size = new System.Drawing.Size(114, 25);
            this.salesTaxTextLabel.TabIndex = 2;
            this.salesTaxTextLabel.Text = "Sales Tax:";
            // 
            // subtotalTextLabel
            // 
            this.subtotalTextLabel.AutoSize = true;
            this.subtotalTextLabel.Location = new System.Drawing.Point(29, 77);
            this.subtotalTextLabel.Name = "subtotalTextLabel";
            this.subtotalTextLabel.Size = new System.Drawing.Size(97, 25);
            this.subtotalTextLabel.TabIndex = 1;
            this.subtotalTextLabel.Text = "Subtotal:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-58, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // clearFormButton
            // 
            this.clearFormButton.Location = new System.Drawing.Point(783, 944);
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.Size = new System.Drawing.Size(146, 75);
            this.clearFormButton.TabIndex = 19;
            this.clearFormButton.Text = "Clear &Form";
            this.clearFormToolTip.SetToolTip(this.clearFormButton, resources.GetString("clearFormButton.ToolTip"));
            this.clearFormButton.UseVisualStyleBackColor = true;
            this.clearFormButton.Click += new System.EventHandler(this.clearFormButton_Click);
            // 
            // exitProgramButton
            // 
            this.exitProgramButton.Location = new System.Drawing.Point(1301, 944);
            this.exitProgramButton.Name = "exitProgramButton";
            this.exitProgramButton.Size = new System.Drawing.Size(136, 77);
            this.exitProgramButton.TabIndex = 20;
            this.exitProgramButton.Text = "&Exit &Program";
            this.exitProgramToolTip.SetToolTip(this.exitProgramButton, resources.GetString("exitProgramButton.ToolTip"));
            this.exitProgramButton.UseVisualStyleBackColor = true;
            this.exitProgramButton.Click += new System.EventHandler(this.exitProgramButton_Click);
            // 
            // displaySummaryButton
            // 
            this.displaySummaryButton.Location = new System.Drawing.Point(142, 944);
            this.displaySummaryButton.Name = "displaySummaryButton";
            this.displaySummaryButton.Size = new System.Drawing.Size(142, 77);
            this.displaySummaryButton.TabIndex = 18;
            this.displaySummaryButton.Text = "&Display Summary";
            this.displaySummaryToolTip.SetToolTip(this.displaySummaryButton, resources.GetString("displaySummaryButton.ToolTip"));
            this.displaySummaryButton.UseVisualStyleBackColor = true;
            this.displaySummaryButton.Click += new System.EventHandler(this.displaySummaryButton_Click);
            // 
            // displaySummaryToolTip
            // 
            this.displaySummaryToolTip.AutoPopDelay = 5000;
            this.displaySummaryToolTip.InitialDelay = 500;
            this.displaySummaryToolTip.ReshowDelay = 20;
            // 
            // clearFormToolTip
            // 
            this.clearFormToolTip.AutoPopDelay = 5000;
            this.clearFormToolTip.InitialDelay = 500;
            this.clearFormToolTip.ReshowDelay = 20;
            // 
            // exitProgramToolTip
            // 
            this.exitProgramToolTip.AutoPopDelay = 5000;
            this.exitProgramToolTip.InitialDelay = 500;
            this.exitProgramToolTip.ReshowDelay = 20;
            // 
            // bonniesBalloonsOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 1579);
            this.Controls.Add(this.displaySummaryButton);
            this.Controls.Add(this.exitProgramButton);
            this.Controls.Add(this.clearFormButton);
            this.Controls.Add(this.orderTotalsGroupBox);
            this.Controls.Add(this.orderDetailsGroupBox);
            this.Controls.Add(this.deliveryInfoGroupBox);
            this.Controls.Add(this.customerInfoGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "bonniesBalloonsOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonnie\'s Balloons Order Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customerInfoGroupBox.ResumeLayout(false);
            this.customerInfoGroupBox.PerformLayout();
            this.deliveryInfoGroupBox.ResumeLayout(false);
            this.deliveryInfoGroupBox.PerformLayout();
            this.orderDetailsGroupBox.ResumeLayout(false);
            this.orderDetailsGroupBox.PerformLayout();
            this.orderTotalsGroupBox.ResumeLayout(false);
            this.orderTotalsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox customerInfoGroupBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskedTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.ComboBox abbreviationComboBox;
        private System.Windows.Forms.MaskedTextBox zipCodeMaskedTextBox;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label abbreviationLabel;
        private System.Windows.Forms.GroupBox deliveryInfoGroupBox;
        private System.Windows.Forms.Label deliveryTypeLabel;
        private System.Windows.Forms.Label deliveryDateLabel;
        private System.Windows.Forms.Label homeDeliveryPriceLabel;
        private System.Windows.Forms.RadioButton homeDeliveryRadioButton;
        private System.Windows.Forms.RadioButton storePickupRadioButton;
        private System.Windows.Forms.MaskedTextBox deliveryDateMaskedTextBox;
        private System.Windows.Forms.GroupBox orderDetailsGroupBox;
        private System.Windows.Forms.Label specialOccasionLabel;
        private System.Windows.Forms.Label dozenPriceLabel;
        private System.Windows.Forms.Label halfDozenPriceLabel;
        private System.Windows.Forms.Label singlePriceLabel;
        private System.Windows.Forms.RadioButton dozenRadioButton;
        private System.Windows.Forms.RadioButton halfDozenRadioButton;
        private System.Windows.Forms.RadioButton singleRadioButton;
        private System.Windows.Forms.Label bundleSizeLabel;
        private System.Windows.Forms.GroupBox orderTotalsGroupBox;
        private System.Windows.Forms.Label characterLimitLabel;
        private System.Windows.Forms.TextBox personalizedMessageTextBox;
        private System.Windows.Forms.CheckBox personalizedMessageCheckBox;
        private System.Windows.Forms.Label extrasPriceLabel;
        private System.Windows.Forms.ListBox extrasListBox;
        private System.Windows.Forms.ComboBox specialOccasionComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clearFormButton;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label orderTotalTextLabel;
        private System.Windows.Forms.Label salesTaxTextLabel;
        private System.Windows.Forms.Label subtotalTextLabel;
        private System.Windows.Forms.Button exitProgramButton;
        private System.Windows.Forms.Button displaySummaryButton;
        private System.Windows.Forms.Label personalizedMessageCostLabel;
        private System.Windows.Forms.MaskedTextBox stateMaskedTextBox;
        private System.Windows.Forms.ToolTip clearFormToolTip;
        private System.Windows.Forms.ToolTip exitProgramToolTip;
        private System.Windows.Forms.ToolTip displaySummaryToolTip;
    }
}

