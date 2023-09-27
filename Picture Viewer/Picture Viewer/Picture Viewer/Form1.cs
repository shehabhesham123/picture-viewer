using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Viewer
{
   
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void listBoxPicture_SelectedIndexChanged(object sender, EventArgs e)
        {
            String pictrue = listBoxPicture.SelectedItem.ToString();
            pictureBoxSingle.Image = Image.FromFile(pictrue);
            this.Text = pictrue;
        }
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Text=="Add Picture")
            {
                contextMenuStrip1.Close();
                AddPictrueDialog.InitialDirectory = ("C:\\");
                AddPictrueDialog.Filter = ("Image File |*.JPEG;*.GIF;*.PNG;*.JPG;*.TIFF;*.PSD;");
                if (AddPictrueDialog.ShowDialog() == DialogResult.OK)
                {
                    listBoxPicture.Items.Add(AddPictrueDialog.FileName);
                }
                
            }    
            else if (e.ClickedItem.Text == "Exit")
                this.Close();
            else if (e.ClickedItem.Text == "Single Mode")
            {
                listViewMulti.Visible = false;
                pictureBoxSingle.Visible = true;
                pictureBoxSlideShow.Visible = false;
                Mode.Text = "Single Mode";
                timer1.Enabled = false;
                listBoxPicture.SelectionMode = SelectionMode.One;
            }
            else if (e.ClickedItem.Text == "Multi Mode")
            {
                listViewMulti.Visible = true;
                pictureBoxSingle.Visible = false;
                pictureBoxSlideShow.Visible = false;
                listBoxPicture.SelectionMode = SelectionMode.MultiExtended;
                Mode.Text = "Multi Mode";
            }
            else if (e.ClickedItem.Text == "Slide Show")
            {
                listViewMulti.Visible = false;
                pictureBoxSingle.Visible = false;
                pictureBoxSlideShow.Visible = true;
                Mode.Text = "Slide Show Mode";
                timer1.Enabled = true;
                listBoxPicture.SelectionMode = SelectionMode.One;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBoxPicture.Items.Count > 0)
            {
                if (i == listBoxPicture.Items.Count)
                {
                    i = 0;
                }
                String pictrue;
                pictrue = listBoxPicture.Items[i].ToString();
                pictureBoxSlideShow.Image = Image.FromFile(pictrue);
                this.Text = pictrue;
                i++;
            }
        }
    }
}