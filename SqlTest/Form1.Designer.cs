namespace SqlTest
{
    partial class FormSQL
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
            this.GridViewOutput = new System.Windows.Forms.DataGridView();
            this.rButtonSelect = new System.Windows.Forms.RadioButton();
            this.rButtonUpdate = new System.Windows.Forms.RadioButton();
            this.rButtonCreate = new System.Windows.Forms.RadioButton();
            this.rButtonDelete = new System.Windows.Forms.RadioButton();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewOutput
            // 
            this.GridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewOutput.Location = new System.Drawing.Point(51, 240);
            this.GridViewOutput.Name = "GridViewOutput";
            this.GridViewOutput.RowHeadersWidth = 51;
            this.GridViewOutput.RowTemplate.Height = 24;
            this.GridViewOutput.Size = new System.Drawing.Size(700, 169);
            this.GridViewOutput.TabIndex = 2;
            // 
            // rButtonSelect
            // 
            this.rButtonSelect.AutoSize = true;
            this.rButtonSelect.Checked = true;
            this.rButtonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonSelect.Location = new System.Drawing.Point(280, 54);
            this.rButtonSelect.Name = "rButtonSelect";
            this.rButtonSelect.Size = new System.Drawing.Size(112, 29);
            this.rButtonSelect.TabIndex = 3;
            this.rButtonSelect.TabStop = true;
            this.rButtonSelect.Text = "SELECT";
            this.rButtonSelect.UseVisualStyleBackColor = true;
            this.rButtonSelect.CheckedChanged += new System.EventHandler(this.rButtonSelect_CheckedChanged);
            // 
            // rButtonUpdate
            // 
            this.rButtonUpdate.AutoSize = true;
            this.rButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonUpdate.Location = new System.Drawing.Point(280, 81);
            this.rButtonUpdate.Name = "rButtonUpdate";
            this.rButtonUpdate.Size = new System.Drawing.Size(114, 29);
            this.rButtonUpdate.TabIndex = 4;
            this.rButtonUpdate.Text = "UPDATE";
            this.rButtonUpdate.UseVisualStyleBackColor = true;
            this.rButtonUpdate.CheckedChanged += new System.EventHandler(this.rButtonUpdate_CheckedChanged);
            // 
            // rButtonCreate
            // 
            this.rButtonCreate.AutoSize = true;
            this.rButtonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonCreate.Location = new System.Drawing.Point(280, 108);
            this.rButtonCreate.Name = "rButtonCreate";
            this.rButtonCreate.Size = new System.Drawing.Size(114, 29);
            this.rButtonCreate.TabIndex = 5;
            this.rButtonCreate.Text = "CREATE";
            this.rButtonCreate.UseVisualStyleBackColor = true;
            this.rButtonCreate.CheckedChanged += new System.EventHandler(this.rButtonCreate_CheckedChanged);
            // 
            // rButtonDelete
            // 
            this.rButtonDelete.AutoSize = true;
            this.rButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonDelete.Location = new System.Drawing.Point(280, 135);
            this.rButtonDelete.Name = "rButtonDelete";
            this.rButtonDelete.Size = new System.Drawing.Size(110, 29);
            this.rButtonDelete.TabIndex = 6;
            this.rButtonDelete.Text = "DELETE";
            this.rButtonDelete.UseVisualStyleBackColor = true;
            this.rButtonDelete.CheckedChanged += new System.EventHandler(this.rButtonDelete_CheckedChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(72, 60);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 34);
            this.textBoxID.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(72, 135);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 34);
            this.textBoxName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name (to update)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(476, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 69);
            this.button1.TabIndex = 11;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.rButtonDelete);
            this.Controls.Add(this.rButtonCreate);
            this.Controls.Add(this.rButtonUpdate);
            this.Controls.Add(this.rButtonSelect);
            this.Controls.Add(this.GridViewOutput);
            this.Name = "FormSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL test";
            this.Load += new System.EventHandler(this.FormSQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GridViewOutput;
        private System.Windows.Forms.RadioButton rButtonSelect;
        private System.Windows.Forms.RadioButton rButtonUpdate;
        private System.Windows.Forms.RadioButton rButtonCreate;
        private System.Windows.Forms.RadioButton rButtonDelete;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

