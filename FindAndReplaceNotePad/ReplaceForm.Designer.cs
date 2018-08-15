namespace FindAndReplaceNotePad
{
    partial class ReplaceForm
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
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromTB = new System.Windows.Forms.TextBox();
            this.toTB = new System.Windows.Forms.TextBox();
            this.findNextButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.replaceAllButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.caseSensitiveCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(12, 18);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(33, 13);
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(22, 47);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 1;
            this.toLabel.Text = "To:";
            // 
            // fromTB
            // 
            this.fromTB.Location = new System.Drawing.Point(51, 15);
            this.fromTB.Name = "fromTB";
            this.fromTB.Size = new System.Drawing.Size(210, 20);
            this.fromTB.TabIndex = 2;
            // 
            // toTB
            // 
            this.toTB.Location = new System.Drawing.Point(51, 44);
            this.toTB.Name = "toTB";
            this.toTB.Size = new System.Drawing.Size(210, 20);
            this.toTB.TabIndex = 3;
            // 
            // findNextButton
            // 
            this.findNextButton.Location = new System.Drawing.Point(267, 12);
            this.findNextButton.Name = "findNextButton";
            this.findNextButton.Size = new System.Drawing.Size(75, 23);
            this.findNextButton.TabIndex = 4;
            this.findNextButton.Text = "Find next";
            this.findNextButton.UseVisualStyleBackColor = true;
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(267, 41);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(75, 23);
            this.replaceButton.TabIndex = 5;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            // 
            // replaceAllButton
            // 
            this.replaceAllButton.Location = new System.Drawing.Point(267, 71);
            this.replaceAllButton.Name = "replaceAllButton";
            this.replaceAllButton.Size = new System.Drawing.Size(75, 23);
            this.replaceAllButton.TabIndex = 6;
            this.replaceAllButton.Text = "Replace all";
            this.replaceAllButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(267, 100);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // caseSensitiveCB
            // 
            this.caseSensitiveCB.AutoSize = true;
            this.caseSensitiveCB.Location = new System.Drawing.Point(13, 104);
            this.caseSensitiveCB.Name = "caseSensitiveCB";
            this.caseSensitiveCB.Size = new System.Drawing.Size(94, 17);
            this.caseSensitiveCB.TabIndex = 8;
            this.caseSensitiveCB.Text = "Case sensitive";
            this.caseSensitiveCB.UseVisualStyleBackColor = true;
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 133);
            this.Controls.Add(this.caseSensitiveCB);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.replaceAllButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.findNextButton);
            this.Controls.Add(this.toTB);
            this.Controls.Add(this.fromTB);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox fromTB;
        private System.Windows.Forms.TextBox toTB;
        private System.Windows.Forms.Button findNextButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button replaceAllButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox caseSensitiveCB;
    }
}