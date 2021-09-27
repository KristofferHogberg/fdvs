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
                string filename = getFileName(file);
                MessageBox.Show($"{filename} added.");
                userDraggedFiles.Items.Add(filename);
            }
        }

        private string getFileName(string path)
        {
            return Path.GetFileName(path);
        }
    }
}
