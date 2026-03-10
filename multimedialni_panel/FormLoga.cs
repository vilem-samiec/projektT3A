using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multimedialni_panel
{
    public partial class FormLoga : Form
    {
        public FormLoga()
        {
            InitializeComponent();
        }

        private Image ResizeLogo(Image img)
        {
            return new Bitmap(img, new Size(200, 200));
        }

        private void FormLoga_Load(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(open.FileName);
                Bitmap resized = new Bitmap(img, new Size(200, 200));

                pictureHome.Image = resized;

                string path = Path.Combine(Application.StartupPath, "Loga", "home.png");
                resized.Save(path);
            }
        }

        private void buttonAway_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(open.FileName);
                Bitmap resized = new Bitmap(img, new Size(200, 200));

                pictureAway.Image = resized;

                string path = Path.Combine(Application.StartupPath, "Loga", "away.png");
                resized.Save(path);
            }
        }
    }
}
