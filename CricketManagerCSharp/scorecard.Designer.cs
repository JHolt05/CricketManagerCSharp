using System.ComponentModel;

namespace CricketManagerCSharp;

partial class scorecard
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        BattingCardTable = new System.Windows.Forms.TableLayoutPanel();
        BowlingCardTable = new System.Windows.Forms.TableLayoutPanel();
        BattingTeamNameLbl = new System.Windows.Forms.Label();
        BattingTeamScoreLbl = new System.Windows.Forms.Label();
        BowlingTeamNameLbl = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // BattingCardTable
        // 
        BattingCardTable.ColumnCount = 7;
        BattingCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.55967F));
        BattingCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.44033F));
        BattingCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
        BattingCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        BattingCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        BattingCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        BattingCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        BattingCardTable.Location = new System.Drawing.Point(-2, 54);
        BattingCardTable.Name = "BattingCardTable";
        BattingCardTable.RowCount = 12;
        BattingCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.213593F));
        BattingCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.78641F));
        BattingCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
        BattingCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        BattingCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        BattingCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        BattingCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        BattingCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        BattingCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        BattingCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        BattingCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        BattingCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        BattingCardTable.Size = new System.Drawing.Size(404, 399);
        BattingCardTable.TabIndex = 0;
        // 
        // BowlingCardTable
        // 
        BowlingCardTable.ColumnCount = 6;
        BowlingCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        BowlingCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        BowlingCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        BowlingCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        BowlingCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        BowlingCardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        BowlingCardTable.Location = new System.Drawing.Point(447, 49);
        BowlingCardTable.Name = "BowlingCardTable";
        BowlingCardTable.RowCount = 2;
        BowlingCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        BowlingCardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        BowlingCardTable.Size = new System.Drawing.Size(352, 271);
        BowlingCardTable.TabIndex = 1;
        // 
        // BattingTeamNameLbl
        // 
        BattingTeamNameLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        BattingTeamNameLbl.Location = new System.Drawing.Point(0, 0);
        BattingTeamNameLbl.Name = "BattingTeamNameLbl";
        BattingTeamNameLbl.Size = new System.Drawing.Size(166, 51);
        BattingTeamNameLbl.TabIndex = 2;
        BattingTeamNameLbl.Text = "Team1";
        // 
        // BattingTeamScoreLbl
        // 
        BattingTeamScoreLbl.Font = new System.Drawing.Font("Segoe UI", 24F);
        BattingTeamScoreLbl.Location = new System.Drawing.Point(137, 0);
        BattingTeamScoreLbl.Name = "BattingTeamScoreLbl";
        BattingTeamScoreLbl.Size = new System.Drawing.Size(135, 48);
        BattingTeamScoreLbl.TabIndex = 3;
        BattingTeamScoreLbl.Text = "0/0";
        // 
        // BowlingTeamNameLbl
        // 
        BowlingTeamNameLbl.Font = new System.Drawing.Font("Segoe UI", 24F);
        BowlingTeamNameLbl.Location = new System.Drawing.Point(448, 0);
        BowlingTeamNameLbl.Name = "BowlingTeamNameLbl";
        BowlingTeamNameLbl.Size = new System.Drawing.Size(136, 47);
        BowlingTeamNameLbl.TabIndex = 4;
        BowlingTeamNameLbl.Text = "Team2";
        // 
        // scorecard
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(BowlingTeamNameLbl);
        Controls.Add(BattingTeamScoreLbl);
        Controls.Add(BattingTeamNameLbl);
        Controls.Add(BowlingCardTable);
        Controls.Add(BattingCardTable);
        Text = "scorecard";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label BattingTeamScoreLbl;
    private System.Windows.Forms.Label BowlingTeamNameLbl;

    private System.Windows.Forms.TableLayoutPanel BowlingCardTable;
    private System.Windows.Forms.Label BattingTeamNameLbl;

    private System.Windows.Forms.TableLayoutPanel BattingCardTable;

    #endregion
}