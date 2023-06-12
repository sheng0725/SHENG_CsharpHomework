﻿using SHENG_Homework.Properties;
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

namespace SHENG_Homework
{
    public partial class PictureViewer : Form
    {
        List<PictureBox> lsPB;
        string folderPath = @"..\..\img\";
        //FolderBrowserDialog folderBrowserDialog;
        //string[] imagePath;
        public PictureViewer()
        {
            InitializeComponent();
            pictureBox();
        }
        //建立pictureBox
        public void pictureBox()
        {
            lsPB = new List<PictureBox>();
            string[] imagePath = Directory.GetFiles(folderPath, "*.*");
            foreach (string item in imagePath)
            {
                PictureBox PB = new PictureBox();
                PB.Size = new Size(100, 100);
                PB.SizeMode = PictureBoxSizeMode.Zoom;
                PB.Image = Image.FromFile(item);
                flowLayoutPanel1.Controls.Add(PB);
                PB.MouseClick += PB_MouseClick;
            }
        }
        //開啟單一圖片
        private void PB_MouseClick(object sender, MouseEventArgs e)
        {
            Form singleImgForm = new Form();
            singleImgForm.BackgroundImage = ((PictureBox)sender).Image;
            singleImgForm.BackgroundImageLayout = ImageLayout.Zoom;
            singleImgForm.Show();
        }
    }
}
