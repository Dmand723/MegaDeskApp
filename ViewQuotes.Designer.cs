namespace MegaDeskApp
{
    partial class ViewQuotes
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
            backBtn = new Button();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 386);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(198, 52);
            backBtn.TabIndex = 0;
            backBtn.Text = "Go Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += GoBackBtn;
            // 
            // ViewQuotes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backBtn);
            Name = "ViewQuotes";
            Text = "ViewQuotes";
            ResumeLayout(false);
        }

        #endregion

        private Button backBtn;
    }
}