namespace CricketManagerCSharp
{
    partial class DisplayPlayerForm
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
            NameLbl = new Label();
            AgeLbl = new Label();
            RoleLbl = new Label();
            BowlStyleLbl = new Label();
            SuspendLayout();
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Font = new Font("Segoe UI", 24F);
            NameLbl.Location = new Point(12, 9);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(233, 45);
            NameLbl.TabIndex = 0;
            NameLbl.Text = "Example Name";
            // 
            // AgeLbl
            // 
            AgeLbl.AutoSize = true;
            AgeLbl.Font = new Font("Segoe UI", 15F);
            AgeLbl.Location = new Point(12, 82);
            AgeLbl.Name = "AgeLbl";
            AgeLbl.Size = new Size(51, 28);
            AgeLbl.TabIndex = 1;
            AgeLbl.Text = "Age:";
            // 
            // RoleLbl
            // 
            RoleLbl.AutoSize = true;
            RoleLbl.Font = new Font("Segoe UI", 15F);
            RoleLbl.Location = new Point(12, 128);
            RoleLbl.Name = "RoleLbl";
            RoleLbl.Size = new Size(54, 28);
            RoleLbl.TabIndex = 2;
            RoleLbl.Text = "Role:";
            // 
            // BowlStyleLbl
            // 
            BowlStyleLbl.AutoSize = true;
            BowlStyleLbl.Font = new Font("Segoe UI", 15F);
            BowlStyleLbl.Location = new Point(12, 170);
            BowlStyleLbl.Name = "BowlStyleLbl";
            BowlStyleLbl.Size = new Size(58, 28);
            BowlStyleLbl.TabIndex = 3;
            BowlStyleLbl.Text = "Style:";
            // 
            // DisplayPlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BowlStyleLbl);
            Controls.Add(RoleLbl);
            Controls.Add(AgeLbl);
            Controls.Add(NameLbl);
            Name = "DisplayPlayerForm";
            Text = "DisplayPlayerForm";
            Load += DisplayPlayerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLbl;
        private Label AgeLbl;
        private Label RoleLbl;
        private Label BowlStyleLbl;
    }
}