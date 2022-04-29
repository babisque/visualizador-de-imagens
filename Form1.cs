using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using System.Collections;

namespace Aula24_Desafio
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            string userName = Environment.UserName;
            txtPath.Text = $"C:\\Users\\{userName}\\Pictures\\";

            DirectoryInfo dir = new DirectoryInfo(txtPath.Text);
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                listDiretorio.AddItem(file.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listDiretorio_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            string picture = listDiretorio.SelectedItem.Text;
            picBox.ImageLocation = txtPath.Text + "\\" + picture;
        }

        private void btnFolderSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog pathDir = new FolderBrowserDialog();
            pathDir.ShowNewFolderButton = true;

            DialogResult result = pathDir.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPath.Text = pathDir.SelectedPath;
                Environment.SpecialFolder root = pathDir.RootFolder;
            }

            listDiretorio.Clear();
            DirectoryInfo dir = new DirectoryInfo(txtPath.Text);
            FileInfo[] files = dir.GetFiles("*");

            foreach (FileInfo file in files)
            {
                listDiretorio.AddItem(file.Name);
            }
        }
    }
}
