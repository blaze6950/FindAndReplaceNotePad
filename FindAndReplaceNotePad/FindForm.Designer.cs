namespace FindAndReplaceNotePad
{
    partial class FindForm
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
            this.findWhatLabel = new System.Windows.Forms.Label();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findNextButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.caseSensitiveCB = new System.Windows.Forms.CheckBox();
            this.directionGB = new System.Windows.Forms.GroupBox();
            this.downRB = new System.Windows.Forms.RadioButton();
            this.upRB = new System.Windows.Forms.RadioButton();
            this.directionGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // findWhatLabel
            // 
            this.findWhatLabel.AutoSize = true;
            this.findWhatLabel.Location = new System.Drawing.Point(12, 15);
            this.findWhatLabel.Name = "findWhatLabel";
            this.findWhatLabel.Size = new System.Drawing.Size(56, 13);
            this.findWhatLabel.TabIndex = 0;
            this.findWhatLabel.Text = "Find what:";
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(74, 12);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(187, 20);
            this.findTextBox.TabIndex = 1;
            // 
            // findNextButton
            // 
            this.findNextButton.Location = new System.Drawing.Point(267, 10);
            this.findNextButton.Name = "findNextButton";
            this.findNextButton.Size = new System.Drawing.Size(75, 23);
            this.findNextButton.TabIndex = 2;
            this.findNextButton.Text = "Find next";
            this.findNextButton.UseVisualStyleBackColor = true;
            this.findNextButton.Click += new System.EventHandler(this.findNextButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(267, 39);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // caseSensitiveCB
            // 
            this.caseSensitiveCB.AutoSize = true;
            this.caseSensitiveCB.Location = new System.Drawing.Point(12, 68);
            this.caseSensitiveCB.Name = "caseSensitiveCB";
            this.caseSensitiveCB.Size = new System.Drawing.Size(94, 17);
            this.caseSensitiveCB.TabIndex = 4;
            this.caseSensitiveCB.Text = "Case sensitive";
            this.caseSensitiveCB.UseVisualStyleBackColor = true;
            // 
            // directionGB
            // 
            this.directionGB.Controls.Add(this.downRB);
            this.directionGB.Controls.Add(this.upRB);
            this.directionGB.Location = new System.Drawing.Point(154, 38);
            this.directionGB.Name = "directionGB";
            this.directionGB.Size = new System.Drawing.Size(107, 47);
            this.directionGB.TabIndex = 5;
            this.directionGB.TabStop = false;
            this.directionGB.Text = "Direction";
            // 
            // downRB
            // 
            this.downRB.AutoSize = true;
            this.downRB.Checked = true;
            this.downRB.Location = new System.Drawing.Point(51, 19);
            this.downRB.Name = "downRB";
            this.downRB.Size = new System.Drawing.Size(53, 17);
            this.downRB.TabIndex = 1;
            this.downRB.TabStop = true;
            this.downRB.Text = "Down";
            this.downRB.UseVisualStyleBackColor = true;
            // 
            // upRB
            // 
            this.upRB.AutoSize = true;
            this.upRB.Location = new System.Drawing.Point(6, 19);
            this.upRB.Name = "upRB";
            this.upRB.Size = new System.Drawing.Size(39, 17);
            this.upRB.TabIndex = 0;
            this.upRB.Text = "Up";
            this.upRB.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 97);
            this.Controls.Add(this.directionGB);
            this.Controls.Add(this.caseSensitiveCB);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.findNextButton);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.findWhatLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find";
            this.TopMost = true;
            this.directionGB.ResumeLayout(false);
            this.directionGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label findWhatLabel;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Button findNextButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox caseSensitiveCB;
        private System.Windows.Forms.GroupBox directionGB;
        private System.Windows.Forms.RadioButton downRB;
        private System.Windows.Forms.RadioButton upRB;
    }
}