namespace CricketManagerCSharp
{
    partial class Form1
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
            GenerateTestSquadBtn = new Button();
            ScorecardBtn = new Button();
            SuspendLayout();
            // 
            // GenerateTestSquadBtn
            // 
            GenerateTestSquadBtn.Location = new Point(45, 57);
            GenerateTestSquadBtn.Name = "GenerateTestSquadBtn";
            GenerateTestSquadBtn.Size = new Size(147, 41);
            GenerateTestSquadBtn.TabIndex = 0;
            GenerateTestSquadBtn.Text = "Show Test Squad";
            GenerateTestSquadBtn.UseVisualStyleBackColor = true;
            GenerateTestSquadBtn.Click += GenerateTestSquadBtn_Click;
            // 
            // ScorecardBtn
            // 
            ScorecardBtn.Location = new Point(45, 104);
            ScorecardBtn.Name = "ScorecardBtn";
            ScorecardBtn.Size = new Size(147, 38);
            ScorecardBtn.TabIndex = 1;
            ScorecardBtn.Text = "Show Scorecard";
            ScorecardBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ScorecardBtn);
            Controls.Add(GenerateTestSquadBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button GenerateTestSquadBtn;
        private Button ScorecardBtn;
    }
}
