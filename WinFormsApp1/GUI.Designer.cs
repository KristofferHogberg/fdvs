
namespace adms
{
    partial class GUI
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
            this.HeaderText = new System.Windows.Forms.Label();
            this.uploadFilesBoxLabel = new System.Windows.Forms.Label();
            this.acceptSelectedFilesToUpload = new System.Windows.Forms.Button();
            this.removeSelectedFiles = new System.Windows.Forms.Button();
            this.validatedFilesBoxLabel = new System.Windows.Forms.Label();
            this.validatedFilesList = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderText.Location = new System.Drawing.Point(12, 9);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(519, 33);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "Audio Delivery Management System";
            this.HeaderText.Click += new System.EventHandler(this.label1_Click);
            // 
            // uploadFilesBoxLabel
            // 
            this.uploadFilesBoxLabel.AutoSize = true;
            this.uploadFilesBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uploadFilesBoxLabel.Location = new System.Drawing.Point(12, 78);
            this.uploadFilesBoxLabel.Name = "uploadFilesBoxLabel";
            this.uploadFilesBoxLabel.Size = new System.Drawing.Size(91, 16);
            this.uploadFilesBoxLabel.TabIndex = 2;
            this.uploadFilesBoxLabel.Text = "Upload files";
            this.uploadFilesBoxLabel.Click += new System.EventHandler(this.uploadFilesBoxLabel_Click);
            // 
            // acceptSelectedFilesToUpload
            // 
            this.acceptSelectedFilesToUpload.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.acceptSelectedFilesToUpload.Location = new System.Drawing.Point(12, 203);
            this.acceptSelectedFilesToUpload.Name = "acceptSelectedFilesToUpload";
            this.acceptSelectedFilesToUpload.Size = new System.Drawing.Size(75, 41);
            this.acceptSelectedFilesToUpload.TabIndex = 3;
            this.acceptSelectedFilesToUpload.Text = "Validate";
            this.acceptSelectedFilesToUpload.UseVisualStyleBackColor = false;
            // 
            // removeSelectedFiles
            // 
            this.removeSelectedFiles.Location = new System.Drawing.Point(93, 203);
            this.removeSelectedFiles.Name = "removeSelectedFiles";
            this.removeSelectedFiles.Size = new System.Drawing.Size(75, 41);
            this.removeSelectedFiles.TabIndex = 4;
            this.removeSelectedFiles.Text = "Remove";
            this.removeSelectedFiles.UseVisualStyleBackColor = true;
            this.removeSelectedFiles.Click += new System.EventHandler(this.removeSelectedFiles_Click);
            // 
            // validatedFilesBoxLabel
            // 
            this.validatedFilesBoxLabel.AutoSize = true;
            this.validatedFilesBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.validatedFilesBoxLabel.Location = new System.Drawing.Point(12, 278);
            this.validatedFilesBoxLabel.Name = "validatedFilesBoxLabel";
            this.validatedFilesBoxLabel.Size = new System.Drawing.Size(107, 16);
            this.validatedFilesBoxLabel.TabIndex = 6;
            this.validatedFilesBoxLabel.Text = "Validated files";
            this.validatedFilesBoxLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // validatedFilesList
            // 
            this.validatedFilesList.FormattingEnabled = true;
            this.validatedFilesList.ItemHeight = 16;
            this.validatedFilesList.Location = new System.Drawing.Point(12, 297);
            this.validatedFilesList.Name = "validatedFilesList";
            this.validatedFilesList.Size = new System.Drawing.Size(667, 196);
            this.validatedFilesList.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(667, 100);
            this.listBox1.TabIndex = 7;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(691, 523);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.validatedFilesBoxLabel);
            this.Controls.Add(this.validatedFilesList);
            this.Controls.Add(this.removeSelectedFiles);
            this.Controls.Add(this.acceptSelectedFilesToUpload);
            this.Controls.Add(this.uploadFilesBoxLabel);
            this.Controls.Add(this.HeaderText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI";
            this.Text = "ADMS";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.Label uploadFilesBoxLabel;
        private System.Windows.Forms.Button acceptSelectedFilesToUpload;
        private System.Windows.Forms.Button removeSelectedFiles;
        private System.Windows.Forms.Label validatedFilesBoxLabel;
        private System.Windows.Forms.ListBox validatedFilesList;
        private System.Windows.Forms.ListBox listBox1;
    }
}

