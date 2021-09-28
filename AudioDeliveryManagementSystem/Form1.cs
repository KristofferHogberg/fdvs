using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioDeliveryManagementSystem
{
    public partial class adms : Form
    {
        public adms()
        {
            InitializeComponent();
        }

        private void userDraggedFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userDraggedFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void userDraggedFiles_DragDrop(object sender, DragEventArgs e)
        {
            //Take dropped items and store in array
            string[] droppedFiles = (string[]) e.Data.GetData(DataFormats.FileDrop);

            //Loop through all dropped items and display them
            foreach (string file in droppedFiles)
            {
                string filePath = getFilePath(file);
                MessageBox.Show($"{filePath} added.");
                userDraggedFiles.Items.Add(filePath);
            }
        }

        private string getFilePath(string path)
        {
            return Path.GetFullPath(path);
        }

        private void browseSystemFiles_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }
    }
}
