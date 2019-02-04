namespace Lab3B
{
    partial class Form1
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
            System.Windows.Forms.GroupBox selectHairdresser;
            this.slectAService = new System.Windows.Forms.GroupBox();
            this.chargedItems = new System.Windows.Forms.GroupBox();
            this.price = new System.Windows.Forms.GroupBox();
            this.addService = new System.Windows.Forms.Button();
            this.totalPrice = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.finalPriceBox = new System.Windows.Forms.TextBox();
            this.listBoxServices = new System.Windows.Forms.ListBox();
            this.listBoxChargedItems = new System.Windows.Forms.ListBox();
            this.listBoxPrice = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.selectDresserComboBox = new System.Windows.Forms.ComboBox();
            selectHairdresser = new System.Windows.Forms.GroupBox();
            selectHairdresser.SuspendLayout();
            this.slectAService.SuspendLayout();
            this.chargedItems.SuspendLayout();
            this.price.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectHairdresser
            // 
            selectHairdresser.Controls.Add(this.selectDresserComboBox);
            selectHairdresser.Location = new System.Drawing.Point(12, 12);
            selectHairdresser.Name = "selectHairdresser";
            selectHairdresser.Size = new System.Drawing.Size(196, 294);
            selectHairdresser.TabIndex = 0;
            selectHairdresser.TabStop = false;
            selectHairdresser.Text = "Select A Hairdresser:";
            selectHairdresser.Enter += new System.EventHandler(this.selectHairdresser_Enter);
            // 
            // slectAService
            // 
            this.slectAService.Controls.Add(this.listBoxServices);
            this.slectAService.Location = new System.Drawing.Point(249, 12);
            this.slectAService.Name = "slectAService";
            this.slectAService.Size = new System.Drawing.Size(205, 294);
            this.slectAService.TabIndex = 1;
            this.slectAService.TabStop = false;
            this.slectAService.Text = "Select a Service:";
            this.slectAService.Enter += new System.EventHandler(this.slectAService_Enter);
            // 
            // chargedItems
            // 
            this.chargedItems.Controls.Add(this.listBoxChargedItems);
            this.chargedItems.Location = new System.Drawing.Point(504, 12);
            this.chargedItems.Name = "chargedItems";
            this.chargedItems.Size = new System.Drawing.Size(200, 294);
            this.chargedItems.TabIndex = 0;
            this.chargedItems.TabStop = false;
            this.chargedItems.Text = "Charged Items:";
            this.chargedItems.Enter += new System.EventHandler(this.chargedItems_Enter);
            // 
            // price
            // 
            this.price.Controls.Add(this.listBoxPrice);
            this.price.Location = new System.Drawing.Point(765, 12);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(200, 294);
            this.price.TabIndex = 2;
            this.price.TabStop = false;
            this.price.Text = "Price:";
            this.price.Enter += new System.EventHandler(this.price_Enter);
            // 
            // addService
            // 
            this.addService.Location = new System.Drawing.Point(326, 359);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(128, 51);
            this.addService.TabIndex = 3;
            this.addService.Text = "Add Service";
            this.addService.UseVisualStyleBackColor = true;
            this.addService.Click += new System.EventHandler(this.addService_Click);
            // 
            // totalPrice
            // 
            this.totalPrice.Location = new System.Drawing.Point(504, 359);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(128, 51);
            this.totalPrice.TabIndex = 4;
            this.totalPrice.Text = "Calculate Total Price";
            this.totalPrice.UseVisualStyleBackColor = true;
            this.totalPrice.Click += new System.EventHandler(this.totalPrice_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(665, 359);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(128, 51);
            this.reset.TabIndex = 5;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(825, 359);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(128, 51);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // totalBox
            // 
            this.totalBox.BackColor = System.Drawing.SystemColors.Control;
            this.totalBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBox.Location = new System.Drawing.Point(765, 322);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(100, 20);
            this.totalBox.TabIndex = 7;
            this.totalBox.Text = "Total Price:";
            // 
            // finalPriceBox
            // 
            this.finalPriceBox.Enabled = false;
            this.finalPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalPriceBox.Location = new System.Drawing.Point(865, 319);
            this.finalPriceBox.Name = "finalPriceBox";
            this.finalPriceBox.Size = new System.Drawing.Size(120, 27);
            this.finalPriceBox.TabIndex = 8;
            this.finalPriceBox.TextChanged += new System.EventHandler(this.finalPriceBox_TextChanged);
            // 
            // listBoxServices
            // 
            this.listBoxServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxServices.FormattingEnabled = true;
            this.listBoxServices.ItemHeight = 20;
            this.listBoxServices.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlighting",
            "Extension",
            "Up-do"});
            this.listBoxServices.Location = new System.Drawing.Point(0, 16);
            this.listBoxServices.Name = "listBoxServices";
            this.listBoxServices.Size = new System.Drawing.Size(196, 264);
            this.listBoxServices.TabIndex = 0;
            this.listBoxServices.SelectedIndexChanged += new System.EventHandler(this.listBoxServices_SelectedIndexChanged);
            // 
            // listBoxChargedItems
            // 
            this.listBoxChargedItems.FormattingEnabled = true;
            this.listBoxChargedItems.Location = new System.Drawing.Point(3, 16);
            this.listBoxChargedItems.Name = "listBoxChargedItems";
            this.listBoxChargedItems.Size = new System.Drawing.Size(191, 264);
            this.listBoxChargedItems.TabIndex = 0;
            this.listBoxChargedItems.SelectedIndexChanged += new System.EventHandler(this.listBoxChargedItems_SelectedIndexChanged);
            // 
            // listBoxPrice
            // 
            this.listBoxPrice.FormattingEnabled = true;
            this.listBoxPrice.Location = new System.Drawing.Point(3, 16);
            this.listBoxPrice.Name = "listBoxPrice";
            this.listBoxPrice.Size = new System.Drawing.Size(191, 264);
            this.listBoxPrice.TabIndex = 0;
            this.listBoxPrice.SelectedIndexChanged += new System.EventHandler(this.listBoxPrice_SelectedIndexChanged);
            // 
            // selectDresserComboBox
            // 
            this.selectDresserComboBox.FormattingEnabled = true;
            this.selectDresserComboBox.Location = new System.Drawing.Point(3, 16);
            this.selectDresserComboBox.Name = "selectDresserComboBox";
            this.selectDresserComboBox.Size = new System.Drawing.Size(187, 21);
            this.selectDresserComboBox.TabIndex = 0;
            this.selectDresserComboBox.Items.AddRange(new object[] {
            "Jane",
            "Pat",
            "Ron",
            "Sue",
            "Laurie"});
            this.selectDresserComboBox.SelectedIndexChanged += new System.EventHandler(this.selectDresserComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.finalPriceBox);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.addService);
            this.Controls.Add(this.price);
            this.Controls.Add(this.chargedItems);
            this.Controls.Add(this.slectAService);
            this.Controls.Add(selectHairdresser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            selectHairdresser.ResumeLayout(false);
            this.slectAService.ResumeLayout(false);
            this.chargedItems.ResumeLayout(false);
            this.price.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox slectAService;
        private System.Windows.Forms.GroupBox chargedItems;
        private System.Windows.Forms.GroupBox price;
        private System.Windows.Forms.Button addService;
        private System.Windows.Forms.Button totalPrice;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.ListBox listBoxServices;
        private System.Windows.Forms.ListBox listBoxChargedItems;
        private System.Windows.Forms.ListBox listBoxPrice;
        private System.Windows.Forms.TextBox finalPriceBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox selectDresserComboBox;
    }
}

