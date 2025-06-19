namespace MegaDeskApp
{
    partial class addQuote
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            nameTxtBox = new TextBox();
            drawerAmountDropDown = new ComboBox();
            materialDropDown = new ComboBox();
            shipingDropdown = new ComboBox();
            mainMenuBtn = new Button();
            submitBtn = new Button();
            todaysDateLbl = new Label();
            label10 = new Label();
            label11 = new Label();
            label9 = new Label();
            nameErrProvider = new ErrorProvider(components);
            widthErrProvider = new ErrorProvider(components);
            depthErrProvider = new ErrorProvider(components);
            drawerErrProvider = new ErrorProvider(components);
            materialErrProvider = new ErrorProvider(components);
            shippingErrProvider = new ErrorProvider(components);
            widthNumberBox = new NumericUpDown();
            depthNumberBox = new NumericUpDown();
            submitErrProvider = new ErrorProvider(components);
            cl = new Label();
            ((System.ComponentModel.ISupportInitialize)nameErrProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)widthErrProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)depthErrProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)drawerErrProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materialErrProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shippingErrProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)widthNumberBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)depthNumberBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)submitErrProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 46);
            label1.TabIndex = 0;
            label1.Text = "MegaDesk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(47, 74);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 1;
            label2.Text = "Todays Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(47, 148);
            label3.Name = "label3";
            label3.Size = new Size(218, 28);
            label3.TabIndex = 2;
            label3.Text = "Please enter your name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(47, 211);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
            label4.TabIndex = 3;
            label4.Text = "Desk Width:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(47, 293);
            label5.Name = "label5";
            label5.Size = new Size(117, 28);
            label5.TabIndex = 4;
            label5.Text = "Desk Depth:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(47, 410);
            label6.Name = "label6";
            label6.Size = new Size(134, 28);
            label6.TabIndex = 5;
            label6.Text = "Material Type:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(47, 461);
            label7.Name = "label7";
            label7.Size = new Size(192, 28);
            label7.TabIndex = 6;
            label7.Text = "Shipping Timeframe:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(52, 355);
            label8.Name = "label8";
            label8.Size = new Size(201, 28);
            label8.TabIndex = 7;
            label8.Text = "Desk Drawer Amount:";
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(310, 149);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(194, 27);
            nameTxtBox.TabIndex = 9;
            nameTxtBox.TextChanged += nameTxtBox_TextChanged;
            nameTxtBox.Leave += nameTxtBox_TextChanged;
            // 
            // drawerAmountDropDown
            // 
            drawerAmountDropDown.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            drawerAmountDropDown.Location = new Point(310, 355);
            drawerAmountDropDown.Name = "drawerAmountDropDown";
            drawerAmountDropDown.Size = new Size(194, 28);
            drawerAmountDropDown.TabIndex = 12;
            drawerAmountDropDown.Text = "1";
            drawerAmountDropDown.SelectedIndexChanged += drawerAmountDropDown_SelectedIndexChanged;
            drawerAmountDropDown.TextUpdate += drawerAmountDropDown_SelectedIndexChanged;
            // 
            // materialDropDown
            // 
            materialDropDown.FormattingEnabled = true;
            materialDropDown.Items.AddRange(new object[] { "Pine", "Laminate", "Veneer", "Oak", "RoseWood" });
            materialDropDown.Location = new Point(310, 410);
            materialDropDown.Name = "materialDropDown";
            materialDropDown.Size = new Size(194, 28);
            materialDropDown.TabIndex = 13;
            materialDropDown.Text = "Pine";
            materialDropDown.SelectedIndexChanged += materialDropDown_SelectedIndexChanged;
            materialDropDown.TextUpdate += materialDropDown_SelectedIndexChanged;
            // 
            // shipingDropdown
            // 
            shipingDropdown.FormattingEnabled = true;
            shipingDropdown.Items.AddRange(new object[] { "3", "5", "7", "14" });
            shipingDropdown.Location = new Point(310, 461);
            shipingDropdown.Name = "shipingDropdown";
            shipingDropdown.Size = new Size(194, 28);
            shipingDropdown.TabIndex = 14;
            shipingDropdown.Text = "3";
            shipingDropdown.SelectedIndexChanged += shipingDropdown_SelectedIndexChanged;
            shipingDropdown.TextUpdate += shipingDropdown_SelectedIndexChanged;
            // 
            // mainMenuBtn
            // 
            mainMenuBtn.Location = new Point(14, 523);
            mainMenuBtn.Name = "mainMenuBtn";
            mainMenuBtn.Size = new Size(234, 68);
            mainMenuBtn.TabIndex = 15;
            mainMenuBtn.Text = "Main Menu";
            mainMenuBtn.UseVisualStyleBackColor = true;
            mainMenuBtn.Click += mainMenuBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(281, 523);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(234, 68);
            submitBtn.TabIndex = 16;
            submitBtn.Text = "Submit Order";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // todaysDateLbl
            // 
            todaysDateLbl.AutoSize = true;
            todaysDateLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            todaysDateLbl.Location = new Point(342, 74);
            todaysDateLbl.Name = "todaysDateLbl";
            todaysDateLbl.Size = new Size(133, 28);
            todaysDateLbl.TabIndex = 17;
            todaysDateLbl.Text = "Today's Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(47, 239);
            label10.Name = "label10";
            label10.Size = new Size(225, 20);
            label10.TabIndex = 18;
            label10.Text = "min 24 inches and max 96 inches";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(47, 321);
            label11.Name = "label11";
            label11.Size = new Size(225, 20);
            label11.TabIndex = 19;
            label11.Text = "min 12 inches and max 48 inches";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 489);
            label9.Name = "label9";
            label9.Size = new Size(224, 20);
            label9.TabIndex = 20;
            label9.Text = "Express 3 day to standard 7 days";
            // 
            // nameErrProvider
            // 
            nameErrProvider.ContainerControl = this;
            nameErrProvider.RightToLeft = true;
            // 
            // widthErrProvider
            // 
            widthErrProvider.ContainerControl = this;
            widthErrProvider.RightToLeft = true;
            // 
            // depthErrProvider
            // 
            depthErrProvider.ContainerControl = this;
            depthErrProvider.RightToLeft = true;
            // 
            // drawerErrProvider
            // 
            drawerErrProvider.ContainerControl = this;
            drawerErrProvider.RightToLeft = true;
            // 
            // materialErrProvider
            // 
            materialErrProvider.ContainerControl = this;
            materialErrProvider.RightToLeft = true;
            // 
            // shippingErrProvider
            // 
            shippingErrProvider.ContainerControl = this;
            shippingErrProvider.RightToLeft = true;
            // 
            // widthNumberBox
            // 
            widthNumberBox.Location = new Point(310, 211);
            widthNumberBox.Maximum = new decimal(new int[] { 94, 0, 0, 0 });
            widthNumberBox.Minimum = new decimal(new int[] { 24, 0, 0, 0 });
            widthNumberBox.Name = "widthNumberBox";
            widthNumberBox.Size = new Size(194, 27);
            widthNumberBox.TabIndex = 21;
            widthNumberBox.Value = new decimal(new int[] { 24, 0, 0, 0 });
            widthNumberBox.ValueChanged += widthNumberBox_ValueChanged;
            // 
            // depthNumberBox
            // 
            depthNumberBox.Location = new Point(310, 293);
            depthNumberBox.Maximum = new decimal(new int[] { 48, 0, 0, 0 });
            depthNumberBox.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
            depthNumberBox.Name = "depthNumberBox";
            depthNumberBox.Size = new Size(194, 27);
            depthNumberBox.TabIndex = 22;
            depthNumberBox.Value = new decimal(new int[] { 12, 0, 0, 0 });
            depthNumberBox.ValueChanged += depthNumberBox_ValueChanged;
            // 
            // submitErrProvider
            // 
            submitErrProvider.ContainerControl = this;
            submitErrProvider.RightToLeft = true;
            // 
            // cl
            // 
            cl.AutoSize = true;
            cl.Font = new Font("Segoe UI", 14F);
            cl.Location = new Point(326, 24);
            cl.Name = "cl";
            cl.Size = new Size(0, 32);
            cl.TabIndex = 23;
            // 
            // addQuote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 615);
            Controls.Add(cl);
            Controls.Add(depthNumberBox);
            Controls.Add(widthNumberBox);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(todaysDateLbl);
            Controls.Add(submitBtn);
            Controls.Add(mainMenuBtn);
            Controls.Add(shipingDropdown);
            Controls.Add(materialDropDown);
            Controls.Add(drawerAmountDropDown);
            Controls.Add(nameTxtBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "addQuote";
            Text = "Add Quote";
            Load += addQuote_Load;
            ((System.ComponentModel.ISupportInitialize)nameErrProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)widthErrProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)depthErrProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)drawerErrProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)materialErrProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)shippingErrProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)widthNumberBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)depthNumberBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)submitErrProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox nameTxtBox;
        private ComboBox drawerAmountDropDown;
        private ComboBox materialDropDown;
        private ComboBox shipingDropdown;
        private Button mainMenuBtn;
        private Button submitBtn;
        private Label todaysDateLbl;
        private Label label10;
        private Label label11;
        private Label label9;
        private ErrorProvider nameErrProvider;
        private ErrorProvider widthErrProvider;
        private ErrorProvider depthErrProvider;
        private ErrorProvider drawerErrProvider;
        private ErrorProvider materialErrProvider;
        private ErrorProvider shippingErrProvider;
        private NumericUpDown widthNumberBox;
        private NumericUpDown depthNumberBox;
        private ErrorProvider submitErrProvider;
        private Label cl;
    }
}