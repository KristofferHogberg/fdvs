
namespace AudioDeliveryManagementSystem
{
    partial class adms
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
            this.userDraggedFiles = new System.Windows.Forms.ListBox();
            this.submitSelectedFiles = new System.Windows.Forms.Button();
            this.browseSystemFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userDraggedFiles
            // 
            this.userDraggedFiles.AllowDrop = true;
            this.userDraggedFiles.FormattingEnabled = true;
            this.userDraggedFiles.ItemHeight = 15;
            this.userDraggedFiles.Location = new System.Drawing.Point(12, 12);
            this.userDraggedFiles.Name = "userDraggedFiles";
            this.userDraggedFiles.Size = new System.Drawing.Size(776, 364);
            this.userDraggedFiles.TabIndex = 0;
            this.userDraggedFiles.SelectedIndexChanged += new System.EventHandler(this.userDraggedFiles_SelectedIndexChanged);
            this.userDraggedFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.userDraggedFiles_DragDrop);
            this.userDraggedFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.userDraggedFiles_DragEnter);
            // 
            // submitSelectedFiles
            // 
            this.submitSelectedFiles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitSelectedFiles.Location = new System.Drawing.Point(679, 382);
            this.submitSelectedFiles.Name = "submitSelectedFiles";
            this.submitSelectedFiles.Size = new System.Drawing.Size(109, 42);
            this.submitSelectedFiles.TabIndex = 1;
            this.submitSelectedFiles.Text = "Validate";
            this.submitSelectedFiles.UseVisualStyleBackColor = true;
            // 
            // browseSystemFiles
            // 
            this.browseSystemFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browseSystemFiles.Location = new System.Drawing.Point(13, 383);
            this.browseSystemFiles.Name = "browseSystemFiles";
            this.browseSystemFiles.Size = new System.Drawing.Size(87, 26);
            this.browseSystemFiles.TabIndex = 2;
            this.browseSystemFiles.Text = "Browse files";
            this.browseSystemFiles.UseVisualStyleBackColor = true;
            this.browseSystemFiles.Click += new System.EventHandler(this.browseSystemFiles_Click);
            // 
            // adms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.browseSystemFiles);
            this.Controls.Add(this.submitSelectedFiles);
            this.Controls.Add(this.userDraggedFiles);
            this.Name = "adms";
            this.Text = "ADMS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox userDraggedFiles;
        private System.Windows.Forms.Button submitSelectedFiles;
        private System.Windows.Forms.Button browseSystemFiles;
    }
}

