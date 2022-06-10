using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp20220605_Slide_Show
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        List<Bitmap> images = new List<Bitmap>();
        int np = 0;
        Bitmap one;
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 500;
            timer.Tick += Next5_Click;
            //Bitmap one_im = new Bitmap("1122.bmp");
            //one = new Bitmap(one_im, pictureBox1.Size);
            //pictureBox1.Image = one;
        }

        

        private void NextPicture()
        {
            if (images.Count == 0) 
            {
                return;
            }
            np++;
            if (np >= images.Count) 
            {
                np = 0;
            }
            pictureBox1.Image = images[np];
            labelcounter.Text=Convert.ToString((np + 1) + "/" + images.Count);
        }

        private void Open4_Click(object sender, EventArgs e)
        {
            Stop2_Click(null, null);
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                timer.Stop();
                if (images.Count != 0)
                {
                    foreach (var item in images)
                    {
                        item.Dispose();
                    }
                    images.Clear();
                   // pictureBox1.Image = one;
                }
                DirectoryInfo direct = new DirectoryInfo(folder.SelectedPath);
                IEnumerable<FileInfo> alf = direct.EnumerateFiles();
                foreach (var item in alf)
                {
                    string ex = Path.GetExtension(item.FullName);
                    if (ex == ".bmp" || ex == ".jpg" || ex == ".jpeg" || ex == ".png")
                    {
                        Bitmap pt = new Bitmap(item.FullName);
                        Size pt_size = pictureBox1.Size;
                        images.Add(new Bitmap(pt, pictureBox1.Size));
                    }
                }
            }
            np = 0;
            labelcounter.Text = "";
            pictureBox1.Image = images[np];
            labelcounter.Text = Convert.ToString((np + 1) + "/" + images.Count);
        }

        private void Stop2_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void Preview3_Click(object sender, EventArgs e)
        {
            Prev();
        }

        private void Prev()
        {
            if (images.Count==0)
            {
                return;
            }
            np--;
            if (np < 0) 
            {
                np = images.Count - 1;
            }
            pictureBox1.Image = images[np];
            labelcounter.Text = Convert.ToString((np + 1) + "/" + images.Count);
        }

        private void Start1_Click(object sender, EventArgs e)
        {
            if (images.Count != 0) 
            {
                timer.Start();
            }
            else
            {
                MessageBox.Show("Не выбрана папка!");
            }
        }

        private void Next5_Click(object sender, EventArgs e)
        {
            NextPicture();
        }
    }
}
