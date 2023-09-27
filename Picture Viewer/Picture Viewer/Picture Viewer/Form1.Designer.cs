
namespace Picture_Viewer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Add_Picture = new System.Windows.Forms.ToolStripMenuItem();
            this.Single_Mode = new System.Windows.Forms.ToolStripMenuItem();
            this.Mult_Mode = new System.Windows.Forms.ToolStripMenuItem();
            this.Slide_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_Mode = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Mode = new System.Windows.Forms.Label();
            this.listBoxPicture = new System.Windows.Forms.ListBox();
            this.pictureBoxSlideShow = new System.Windows.Forms.PictureBox();
            this.listViewMulti = new System.Windows.Forms.ListView();
            this.pictureBoxSingle = new System.Windows.Forms.PictureBox();
            this.AddPictrueDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlideShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSingle)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Picture,
            this.Single_Mode,
            this.Mult_Mode,
            this.Slide_Show,
            this.Exit_Mode});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 124);
            this.contextMenuStrip1.Text = "menu";
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // Add_Picture
            // 
            this.Add_Picture.Name = "Add_Picture";
            this.Add_Picture.Size = new System.Drawing.Size(162, 24);
            this.Add_Picture.Text = "Add Picture";
            // 
            // Single_Mode
            // 
            this.Single_Mode.Name = "Single_Mode";
            this.Single_Mode.Size = new System.Drawing.Size(162, 24);
            this.Single_Mode.Text = "Single Mode";
            // 
            // Mult_Mode
            // 
            this.Mult_Mode.Name = "Mult_Mode";
            this.Mult_Mode.Size = new System.Drawing.Size(162, 24);
            this.Mult_Mode.Text = "Multi Mode";
            // 
            // Slide_Show
            // 
            this.Slide_Show.Name = "Slide_Show";
            this.Slide_Show.Size = new System.Drawing.Size(162, 24);
            this.Slide_Show.Text = "Slide Show";
            // 
            // Exit_Mode
            // 
            this.Exit_Mode.Name = "Exit_Mode";
            this.Exit_Mode.Size = new System.Drawing.Size(162, 24);
            this.Exit_Mode.Text = "Exit";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxSlideShow);
            this.splitContainer1.Panel2.Controls.Add(this.listViewMulti);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxSingle);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 473);
            this.splitContainer1.SplitterDistance = 332;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.Mode);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBoxPicture);
            this.splitContainer2.Size = new System.Drawing.Size(332, 473);
            this.splitContainer2.SplitterDistance = 92;
            this.splitContainer2.TabIndex = 0;
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.Dock = System.Windows.Forms.DockStyle.Top;
            this.Mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Mode.Location = new System.Drawing.Point(0, 0);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(238, 43);
            this.Mode.TabIndex = 0;
            this.Mode.Text = "Single Mode";
            this.Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxPicture
            // 
            this.listBoxPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPicture.FormattingEnabled = true;
            this.listBoxPicture.HorizontalScrollbar = true;
            this.listBoxPicture.ItemHeight = 20;
            this.listBoxPicture.Location = new System.Drawing.Point(0, 0);
            this.listBoxPicture.Name = "listBoxPicture";
            this.listBoxPicture.ScrollAlwaysVisible = true;
            this.listBoxPicture.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxPicture.Size = new System.Drawing.Size(332, 377);
            this.listBoxPicture.TabIndex = 1;
            this.listBoxPicture.Click += new System.EventHandler(this.listBoxPicture_SelectedIndexChanged);
            // 
            // pictureBoxSlideShow
            // 
            this.pictureBoxSlideShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSlideShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSlideShow.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSlideShow.Name = "pictureBoxSlideShow";
            this.pictureBoxSlideShow.Size = new System.Drawing.Size(664, 473);
            this.pictureBoxSlideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSlideShow.TabIndex = 4;
            this.pictureBoxSlideShow.TabStop = false;
            this.pictureBoxSlideShow.Visible = false;
            // 
            // listViewMulti
            // 
            this.listViewMulti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMulti.HideSelection = false;
            this.listViewMulti.Location = new System.Drawing.Point(0, 0);
            this.listViewMulti.Name = "listViewMulti";
            this.listViewMulti.Size = new System.Drawing.Size(664, 473);
            this.listViewMulti.TabIndex = 3;
            this.listViewMulti.UseCompatibleStateImageBehavior = false;
            this.listViewMulti.Visible = false;
            // 
            // pictureBoxSingle
            // 
            this.pictureBoxSingle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSingle.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSingle.Name = "pictureBoxSingle";
            this.pictureBoxSingle.Size = new System.Drawing.Size(664, 473);
            this.pictureBoxSingle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSingle.TabIndex = 2;
            this.pictureBoxSingle.TabStop = false;
            // 
            // AddPictrueDialog
            // 
            this.AddPictrueDialog.FileName = "AddPictrueDialog";
            this.AddPictrueDialog.InitialDirectory = "C:\\\\";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 473);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlideShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSingle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Single_Mode;
        private System.Windows.Forms.ToolStripMenuItem Mult_Mode;
        private System.Windows.Forms.ToolStripMenuItem Slide_Show;
        private System.Windows.Forms.ToolStripMenuItem Exit_Mode;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listBoxPicture;
        private System.Windows.Forms.ListView listViewMulti;
        private System.Windows.Forms.PictureBox pictureBoxSingle;
        private System.Windows.Forms.OpenFileDialog AddPictrueDialog;
        private System.Windows.Forms.ToolStripMenuItem Add_Picture;
        private System.Windows.Forms.Label Mode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxSlideShow;
    }
}

