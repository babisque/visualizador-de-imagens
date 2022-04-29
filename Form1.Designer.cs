namespace Aula24_Desafio
{
    partial class Form1
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
            this.txtPath = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPath = new MaterialSkin.Controls.MaterialLabel();
            this.listDiretorio = new MaterialSkin.Controls.MaterialListBox();
            this.btnFolderSelect = new MaterialSkin.Controls.MaterialButton();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.AnimateReadOnly = false;
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPath.Depth = 0;
            this.txtPath.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPath.LeadingIcon = null;
            this.txtPath.Location = new System.Drawing.Point(6, 120);
            this.txtPath.MaxLength = 50;
            this.txtPath.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPath.Multiline = false;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(1088, 50);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "";
            this.txtPath.TrailingIcon = null;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Depth = 0;
            this.lblPath.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPath.Location = new System.Drawing.Point(7, 88);
            this.lblPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(135, 19);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "Caminho da pasta:";
            // 
            // listDiretorio
            // 
            this.listDiretorio.BackColor = System.Drawing.Color.White;
            this.listDiretorio.BorderColor = System.Drawing.Color.LightGray;
            this.listDiretorio.Depth = 0;
            this.listDiretorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listDiretorio.Location = new System.Drawing.Point(6, 216);
            this.listDiretorio.MouseState = MaterialSkin.MouseState.HOVER;
            this.listDiretorio.Name = "listDiretorio";
            this.listDiretorio.SelectedIndex = -1;
            this.listDiretorio.SelectedItem = null;
            this.listDiretorio.Size = new System.Drawing.Size(441, 443);
            this.listDiretorio.TabIndex = 2;
            this.listDiretorio.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.listDiretorio_SelectedIndexChanged);
            // 
            // btnFolderSelect
            // 
            this.btnFolderSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFolderSelect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFolderSelect.Depth = 0;
            this.btnFolderSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolderSelect.HighEmphasis = true;
            this.btnFolderSelect.Icon = null;
            this.btnFolderSelect.Location = new System.Drawing.Point(1118, 120);
            this.btnFolderSelect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFolderSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFolderSelect.Name = "btnFolderSelect";
            this.btnFolderSelect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFolderSelect.Size = new System.Drawing.Size(146, 36);
            this.btnFolderSelect.TabIndex = 3;
            this.btnFolderSelect.Text = "Procurar pasta";
            this.btnFolderSelect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFolderSelect.UseAccentColor = false;
            this.btnFolderSelect.UseVisualStyleBackColor = true;
            this.btnFolderSelect.Click += new System.EventHandler(this.btnFolderSelect_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(603, 216);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(661, 443);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 665);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnFolderSelect);
            this.Controls.Add(this.listDiretorio);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.txtPath);
            this.Name = "Form1";
            this.Text = "Visualizador de imagem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtPath;
        private MaterialSkin.Controls.MaterialLabel lblPath;
        private MaterialSkin.Controls.MaterialListBox listDiretorio;
        private MaterialSkin.Controls.MaterialButton btnFolderSelect;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

