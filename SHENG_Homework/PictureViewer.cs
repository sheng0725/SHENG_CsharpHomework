using SHENG_Homework.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHENG_Homework
{
    public partial class PictureViewer : Form
    {
        public PictureViewer()
        {
            InitializeComponent();
            PictureResources();
        }

        public void PictureResources()
        {
            List<Image> dynamicImageList = new List<Image>();
            var resourceSet = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.InvariantCulture, true, false);
            if (resourceSet != null)
            {
                foreach (DictionaryEntry entry in resourceSet)
                {
                    var value = entry.Value as Bitmap;
                    if (value != null)
                    {
                        dynamicImageList.Add((Image)value);
                    }
                }
            }

            foreach (Image item in dynamicImageList)
            {
                //建立pictureBox
                PictureBox PB = new PictureBox();
                PB.Size = new Size(100, 100);
                PB.SizeMode = PictureBoxSizeMode.Zoom;
                PB.Image = item;
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
