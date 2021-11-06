
namespace GridGame
{
    partial class frm2048
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
            this.pbxGrid = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScorePoints = new System.Windows.Forms.Label();
            this.lblObjective = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxGrid
            // 
            this.pbxGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxGrid.BackColor = System.Drawing.Color.Olive;
            this.pbxGrid.Location = new System.Drawing.Point(3, 85);
            this.pbxGrid.Name = "pbxGrid";
            this.pbxGrid.Size = new System.Drawing.Size(363, 342);
            this.pbxGrid.TabIndex = 0;
            this.pbxGrid.TabStop = false;
            this.pbxGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm2048_MouseMove);
            this.pbxGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm2048_MouseUp);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.SystemColors.Info;
            this.lblScore.Location = new System.Drawing.Point(3, 52);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(76, 30);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScorePoints
            // 
            this.lblScorePoints.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScorePoints.ForeColor = System.Drawing.SystemColors.Info;
            this.lblScorePoints.Location = new System.Drawing.Point(85, 52);
            this.lblScorePoints.Name = "lblScorePoints";
            this.lblScorePoints.Size = new System.Drawing.Size(116, 30);
            this.lblScorePoints.TabIndex = 2;
            this.lblScorePoints.Text = "0000000";
            // 
            // lblObjective
            // 
            this.lblObjective.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblObjective.ForeColor = System.Drawing.SystemColors.Info;
            this.lblObjective.Location = new System.Drawing.Point(224, 12);
            this.lblObjective.Name = "lblObjective";
            this.lblObjective.Size = new System.Drawing.Size(142, 70);
            this.lblObjective.TabIndex = 3;
            this.lblObjective.Text = "Reach 2048";
            this.lblObjective.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUndo.Location = new System.Drawing.Point(3, 12);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(76, 37);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.TabStop = false;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(104, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "By:";
            // 
            // cboBy
            // 
            this.cboBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBy.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboBy.FormattingEnabled = true;
            this.cboBy.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32",
            "64"});
            this.cboBy.Location = new System.Drawing.Point(152, 12);
            this.cboBy.Name = "cboBy";
            this.cboBy.Size = new System.Drawing.Size(49, 38);
            this.cboBy.TabIndex = 5;
            this.cboBy.TabStop = false;
            this.cboBy.SelectedIndexChanged += new System.EventHandler(this.cboBy_SelectedIndexChanged);
            this.cboBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboBy_KeyDown);
            this.cboBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboBy_KeyPress);
            // 
            // frm2048
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(368, 429);
            this.Controls.Add(this.cboBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.lblObjective);
            this.Controls.Add(this.lblScorePoints);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbxGrid);
            this.KeyPreview = true;
            this.Name = "frm2048";
            this.Text = "2048";
            this.Shown += new System.EventHandler(this.frm2048_Shown);
            this.ResizeEnd += new System.EventHandler(this.frm2048_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.frm2048_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm2048_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm2048_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm2048_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm2048_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxGrid;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScorePoints;
        private System.Windows.Forms.Label lblObjective;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBy;
    }
}

