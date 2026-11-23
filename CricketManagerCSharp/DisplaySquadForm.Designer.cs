namespace CricketManagerCSharp
{
    partial class DisplaySquadForm
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
            squadListCmbx = new ComboBox();
            DisplayPlayerDetailsBtn = new Button();
            SuspendLayout();
            // 
            // squadListCmbx
            // 
            squadListCmbx.FormattingEnabled = true;
            squadListCmbx.Location = new Point(107, 142);
            squadListCmbx.Name = "squadListCmbx";
            squadListCmbx.Size = new Size(236, 23);
            squadListCmbx.TabIndex = 0;
            // 
            // DisplayPlayerDetailsBtn
            // 
            DisplayPlayerDetailsBtn.Location = new Point(388, 142);
            DisplayPlayerDetailsBtn.Name = "DisplayPlayerDetailsBtn";
            DisplayPlayerDetailsBtn.Size = new Size(142, 23);
            DisplayPlayerDetailsBtn.TabIndex = 1;
            DisplayPlayerDetailsBtn.Text = "Display Player Details";
            DisplayPlayerDetailsBtn.UseVisualStyleBackColor = true;
            DisplayPlayerDetailsBtn.Click += DisplayPlayerDetailsBtn_Click;
            // 
            // DisplaySquadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayPlayerDetailsBtn);
            Controls.Add(squadListCmbx);
            Name = "DisplaySquadForm";
            Text = "DisplaySquadForm";
            Load += DisplaySquadForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox squadListCmbx;
        private Button DisplayPlayerDetailsBtn;
    }
}