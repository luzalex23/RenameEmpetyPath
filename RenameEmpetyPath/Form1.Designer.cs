namespace RenameEmpetyPath
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnRenameEmptyFolders_Click = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnRenameEmptyFolders_Click);
            this.groupBox.Location = new System.Drawing.Point(92, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(633, 303);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "RenameEmpetyPath";
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // btnRenameEmptyFolders_Click
            // 
            this.btnRenameEmptyFolders_Click.Location = new System.Drawing.Point(106, 102);
            this.btnRenameEmptyFolders_Click.Name = "btnRenameEmptyFolders_Click";
            this.btnRenameEmptyFolders_Click.Size = new System.Drawing.Size(374, 23);
            this.btnRenameEmptyFolders_Click.TabIndex = 0;
            this.btnRenameEmptyFolders_Click.Text = "Rename Path";
            this.btnRenameEmptyFolders_Click.UseVisualStyleBackColor = true;
            this.btnRenameEmptyFolders_Click.Click += new System.EventHandler(this.btnRenameEmptyFolders_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox;
        private Button btnRenameEmptyFolders_Click;
    }
}