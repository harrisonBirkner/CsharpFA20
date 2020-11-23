namespace Project_4
{
    partial class AddForm
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
            this.gbxDorm = new System.Windows.Forms.GroupBox();
            this.cbxDorm = new System.Windows.Forms.ComboBox();
            this.cbxMeal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxDorm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDorm
            // 
            this.gbxDorm.Controls.Add(this.cbxDorm);
            this.gbxDorm.Controls.Add(this.cbxMeal);
            this.gbxDorm.Controls.Add(this.label5);
            this.gbxDorm.Controls.Add(this.label4);
            this.gbxDorm.Location = new System.Drawing.Point(8, 99);
            this.gbxDorm.Name = "gbxDorm";
            this.gbxDorm.Size = new System.Drawing.Size(241, 85);
            this.gbxDorm.TabIndex = 13;
            this.gbxDorm.TabStop = false;
            this.gbxDorm.Text = "Dorm Student Options";
            // 
            // cbxDorm
            // 
            this.cbxDorm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDorm.FormattingEnabled = true;
            this.cbxDorm.Location = new System.Drawing.Point(110, 25);
            this.cbxDorm.Name = "cbxDorm";
            this.cbxDorm.Size = new System.Drawing.Size(121, 24);
            this.cbxDorm.TabIndex = 4;
            // 
            // cbxMeal
            // 
            this.cbxMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMeal.FormattingEnabled = true;
            this.cbxMeal.Location = new System.Drawing.Point(110, 51);
            this.cbxMeal.Name = "cbxMeal";
            this.cbxMeal.Size = new System.Drawing.Size(121, 24);
            this.cbxMeal.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Meal Plan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dorm Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Student Name:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(118, 35);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(121, 22);
            this.txbName.TabIndex = 11;
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(118, 6);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(121, 22);
            this.txbId.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student Type: ";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(118, 63);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 24);
            this.cbxType.TabIndex = 7;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(241, 30);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 228);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxDorm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxType);
            this.Name = "AddForm";
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.gbxDorm.ResumeLayout(false);
            this.gbxDorm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDorm;
        private System.Windows.Forms.ComboBox cbxDorm;
        private System.Windows.Forms.ComboBox cbxMeal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Button btnAdd;
    }
}