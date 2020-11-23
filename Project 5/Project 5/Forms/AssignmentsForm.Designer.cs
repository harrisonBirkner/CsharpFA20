namespace Project_5.Forms
{
    partial class AssignmentsForm
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
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEarned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPossible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmEarned,
            this.clmPossible});
            this.dgvAssignments.Location = new System.Drawing.Point(12, 12);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.RowHeadersWidth = 51;
            this.dgvAssignments.Size = new System.Drawing.Size(430, 213);
            this.dgvAssignments.TabIndex = 0;
            this.dgvAssignments.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvAssignments_CellValidating);
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.MinimumWidth = 6;
            this.clmName.Name = "clmName";
            this.clmName.Width = 125;
            // 
            // clmEarned
            // 
            this.clmEarned.HeaderText = "Pointed Earned";
            this.clmEarned.MinimumWidth = 6;
            this.clmEarned.Name = "clmEarned";
            this.clmEarned.Width = 125;
            // 
            // clmPossible
            // 
            this.clmPossible.HeaderText = "Points Possible";
            this.clmPossible.MinimumWidth = 6;
            this.clmPossible.Name = "clmPossible";
            this.clmPossible.Width = 125;
            // 
            // AssignmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 236);
            this.Controls.Add(this.dgvAssignments);
            this.Name = "AssignmentsForm";
            this.Text = "AssignmentsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AssignmentsForm_FormClosed);
            this.Load += new System.EventHandler(this.AssignmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEarned;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPossible;
    }
}