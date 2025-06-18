namespace MegaDeskApp
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addBtn = new Button();
            veiwBtn = new Button();
            searchBtn = new Button();
            ExitBtn = new Button();
            deskPicBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)deskPicBox).BeginInit();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(12, 1);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(198, 52);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add New Quote";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // veiwBtn
            // 
            veiwBtn.Location = new Point(12, 59);
            veiwBtn.Name = "veiwBtn";
            veiwBtn.Size = new Size(198, 52);
            veiwBtn.TabIndex = 1;
            veiwBtn.Text = "View Quotes";
            veiwBtn.UseVisualStyleBackColor = true;
            veiwBtn.Click += veiwBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(12, 117);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(198, 52);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search Quotes";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(12, 175);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(198, 52);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // deskPicBox
            // 
            deskPicBox.ImageLocation = "D:\\School\\C#\\MegaDeskApp\\desk.png";
            deskPicBox.Location = new Point(216, 23);
            deskPicBox.Name = "deskPicBox";
            deskPicBox.Size = new Size(217, 190);
            deskPicBox.TabIndex = 4;
            deskPicBox.TabStop = false;
            deskPicBox.Click += deskPicBox_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 239);
            Controls.Add(deskPicBox);
            Controls.Add(ExitBtn);
            Controls.Add(searchBtn);
            Controls.Add(veiwBtn);
            Controls.Add(addBtn);
            Name = "MainMenu";
            Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)deskPicBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addBtn;
        private Button veiwBtn;
        private Button searchBtn;
        private Button ExitBtn;
        private PictureBox deskPicBox;
    }
}
