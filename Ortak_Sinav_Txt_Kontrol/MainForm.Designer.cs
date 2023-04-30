namespace Ortak_Sinav_Txt_Kontrol
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new MaterialSkin.Controls.TulparTabControl();
            this.TabPageControl = new System.Windows.Forms.TabPage();
            this.MainMultiLineTextBox = new System.Windows.Forms.RichTextBox();
            this.BTxtSec = new TulparUI.Controls.TulparButton();
            this.TabPagetoExcel = new System.Windows.Forms.TabPage();
            this.ListSinav = new System.Windows.Forms.ListView();
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TCno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OgrCevapA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.SaveDocx = new System.Windows.Forms.SaveFileDialog();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.BtxtToExcel = new TulparUI.Controls.TulparButton();
            this.TabControl.SuspendLayout();
            this.TabPageControl.SuspendLayout();
            this.TabPagetoExcel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPageControl);
            this.TabControl.Controls.Add(this.TabPagetoExcel);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.HideTabArea = true;
            this.TabControl.ImageList = this.ImageList;
            this.TabControl.Location = new System.Drawing.Point(3, 64);
            this.TabControl.MouseState = TulparUI.MouseState.HOVER;
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1665, 738);
            this.TabControl.TabIndex = 0;
            // 
            // TabPageControl
            // 
            this.TabPageControl.BackColor = System.Drawing.Color.White;
            this.TabPageControl.Controls.Add(this.MainMultiLineTextBox);
            this.TabPageControl.Controls.Add(this.BTxtSec);
            this.TabPageControl.ImageKey = "txt.png";
            this.TabPageControl.Location = new System.Drawing.Point(4, 23);
            this.TabPageControl.Name = "TabPageControl";
            this.TabPageControl.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageControl.Size = new System.Drawing.Size(1657, 711);
            this.TabPageControl.TabIndex = 0;
            this.TabPageControl.Text = "Txt Kontrol";
            // 
            // MainMultiLineTextBox
            // 
            this.MainMultiLineTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMultiLineTextBox.Location = new System.Drawing.Point(3, 3);
            this.MainMultiLineTextBox.Name = "MainMultiLineTextBox";
            this.MainMultiLineTextBox.Size = new System.Drawing.Size(1651, 662);
            this.MainMultiLineTextBox.TabIndex = 2;
            this.MainMultiLineTextBox.Text = "";
            // 
            // BTxtSec
            // 
            this.BTxtSec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTxtSec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTxtSec.Density = TulparUI.Controls.TulparButton.TulparButtonDensity.Default;
            this.BTxtSec.Depth = 0;
            this.BTxtSec.HighEmphasis = true;
            this.BTxtSec.Icon = null;
            this.BTxtSec.Location = new System.Drawing.Point(7, 674);
            this.BTxtSec.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTxtSec.MouseState = TulparUI.MouseState.HOVER;
            this.BTxtSec.Name = "BTxtSec";
            this.BTxtSec.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BTxtSec.Size = new System.Drawing.Size(73, 36);
            this.BTxtSec.TabIndex = 1;
            this.BTxtSec.Text = "Txt Seç!";
            this.BTxtSec.Type = TulparUI.Controls.TulparButton.TulparButtonType.Contained;
            this.BTxtSec.UseAccentColor = false;
            this.BTxtSec.UseVisualStyleBackColor = true;
            this.BTxtSec.Click += new System.EventHandler(this.BTxtSec_Click);
            // 
            // TabPagetoExcel
            // 
            this.TabPagetoExcel.BackColor = System.Drawing.Color.White;
            this.TabPagetoExcel.Controls.Add(this.BtxtToExcel);
            this.TabPagetoExcel.Controls.Add(this.ListSinav);
            this.TabPagetoExcel.ImageKey = "excel.png";
            this.TabPagetoExcel.Location = new System.Drawing.Point(4, 23);
            this.TabPagetoExcel.Name = "TabPagetoExcel";
            this.TabPagetoExcel.Padding = new System.Windows.Forms.Padding(3);
            this.TabPagetoExcel.Size = new System.Drawing.Size(1657, 711);
            this.TabPagetoExcel.TabIndex = 1;
            this.TabPagetoExcel.Text = "Txt To Excel";
            // 
            // ListSinav
            // 
            this.ListSinav.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListSinav.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ad,
            this.Soyad,
            this.TCno,
            this.OgrCevapA});
            this.ListSinav.GridLines = true;
            this.ListSinav.HideSelection = false;
            this.ListSinav.Location = new System.Drawing.Point(3, 3);
            this.ListSinav.Name = "ListSinav";
            this.ListSinav.Size = new System.Drawing.Size(1651, 655);
            this.ListSinav.TabIndex = 5;
            this.ListSinav.UseCompatibleStateImageBehavior = false;
            this.ListSinav.View = System.Windows.Forms.View.Details;
            // 
            // Ad
            // 
            this.Ad.Text = "Ad";
            this.Ad.Width = 200;
            // 
            // Soyad
            // 
            this.Soyad.Text = "Soyad";
            this.Soyad.Width = 200;
            // 
            // TCno
            // 
            this.TCno.Text = "T.C. Kimlik No";
            this.TCno.Width = 200;
            // 
            // OgrCevapA
            // 
            this.OgrCevapA.Text = "Öğrenci Cevap Anahtarı";
            this.OgrCevapA.Width = 200;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "excel.png");
            this.ImageList.Images.SetKeyName(1, "txt.png");
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "OpenFile";
            // 
            // BtxtToExcel
            // 
            this.BtxtToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtxtToExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtxtToExcel.Density = TulparUI.Controls.TulparButton.TulparButtonDensity.Default;
            this.BtxtToExcel.Depth = 0;
            this.BtxtToExcel.HighEmphasis = true;
            this.BtxtToExcel.Icon = null;
            this.BtxtToExcel.Location = new System.Drawing.Point(7, 669);
            this.BtxtToExcel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtxtToExcel.MouseState = TulparUI.MouseState.HOVER;
            this.BtxtToExcel.Name = "BtxtToExcel";
            this.BtxtToExcel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtxtToExcel.Size = new System.Drawing.Size(151, 36);
            this.BtxtToExcel.TabIndex = 8;
            this.BtxtToExcel.Text = "Txt\'yi Excel\'e Aktar";
            this.BtxtToExcel.Type = TulparUI.Controls.TulparButton.TulparButtonType.Contained;
            this.BtxtToExcel.UseAccentColor = false;
            this.BtxtToExcel.UseVisualStyleBackColor = true;
            this.BtxtToExcel.Click += new System.EventHandler(this.BtxtToExcel_Click_2);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1671, 805);
            this.Controls.Add(this.TabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabControl;
            this.Name = "MainForm";
            this.Text = "Txt Veri Kontrol";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.TabPageControl.ResumeLayout(false);
            this.TabPageControl.PerformLayout();
            this.TabPagetoExcel.ResumeLayout(false);
            this.TabPagetoExcel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.TulparTabControl TabControl;
        private System.Windows.Forms.TabPage TabPageControl;
        private System.Windows.Forms.TabPage TabPagetoExcel;
        private System.Windows.Forms.ListView ListSinav;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Soyad;
        private System.Windows.Forms.ColumnHeader TCno;
        private System.Windows.Forms.ColumnHeader OgrCevapA;
        private System.Windows.Forms.SaveFileDialog SaveDocx;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private TulparUI.Controls.TulparButton BTxtSec;
        private System.Windows.Forms.RichTextBox MainMultiLineTextBox;
        private System.Windows.Forms.ImageList ImageList;
        private TulparUI.Controls.TulparButton BtxtToExcel;
    }
}

