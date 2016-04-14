#region Imports

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace MediaPlayer
{
    #region MPTabControl

    class MPTabControl : TabControl
    {
        public MPTabControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer, true);

            DoubleBuffered = true;
            //SizeMode = TabSizeMode.FillToRight;
            ItemSize = new Size(160, 45);
            DrawMode = TabDrawMode.OwnerDrawFixed;

            //İlk oluşturmada, mevcut bütün tabların arkaplanı renklendiriliyor.
            foreach (TabPage Page in this.TabPages)
            {
                Page.BackColor = Color.FromArgb(33, 42, 52);
            }
        }

        protected override void CreateHandle()
        {
            base.CreateHandle();
            base.DoubleBuffered = true;
            SizeMode = TabSizeMode.Fixed;
            Appearance = TabAppearance.Normal;
            //Alignment = TabAlignment.Top;
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            if (e.Control is TabPage)
            {
                IEnumerator enumerator;
                try
                {
                    enumerator = this.Controls.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        TabPage current = (TabPage)enumerator.Current;
                        current = new TabPage();
                    }
                }
                finally
                {
                    //İç zemin rengi
                    //e.Control.BackColor = Color.FromArgb(33, 42, 52);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush TabBasligi = new SolidBrush(Color.FromArgb(33, 42, 52));


            base.OnPaint(e);
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            var _Graphics = G;

            //  Etkisiz tab arkaplanı
            _Graphics.Clear(Color.FromArgb(33, 42, 52));
            _Graphics.SmoothingMode = SmoothingMode.HighSpeed;
            _Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            _Graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;

            for (int TabIndex = 0; TabIndex <= TabCount - 1; TabIndex++)
            {
                if (TabIndex == SelectedIndex)
                {
                    // Seçilen tab başlığının içeriği
                    Rectangle TabRect = new Rectangle(new Point(GetTabRect(TabIndex).Location.X - 2, GetTabRect(TabIndex).Location.Y - 4), new Size(GetTabRect(TabIndex).Width + 3, GetTabRect(TabIndex).Height - 8));

                    // Seçilen tab başlığının rengi
                    _Graphics.FillRectangle(TabBasligi, TabRect.X, TabRect.Y, TabRect.Width - 4, TabRect.Height + 3);

                    // Seçilen tab başlığı altındaki çizgi
                    if (Alignment == TabAlignment.Left | Alignment == TabAlignment.Right)
                    {
                        //Dikey
                        Rectangle TabHighlighter = new Rectangle(new Point(GetTabRect(TabIndex).X - 2, GetTabRect(TabIndex).Location.Y - (TabIndex == 0 ? 1 : 1)), new Size(4, GetTabRect(TabIndex).Height - 7));
                        _Graphics.FillRectangle(new SolidBrush(Color.FromArgb(52, 114, 188)), TabHighlighter);
                    }
                    else
                    {
                        //Yatay
                        //Rectangle TabHighlighter = new Rectangle(new Point(GetTabRect(TabIndex).X, GetTabRect(TabIndex).Location.Y + GetTabRect(TabIndex).Height - 4), new Size(GetTabRect(TabIndex).Width, 5));
                        Rectangle TabHighlighter = new Rectangle(new Point(GetTabRect(TabIndex).X, GetTabRect(TabIndex).Location.Y), new Size(GetTabRect(TabIndex).Width, GetTabRect(TabIndex).Height));
                        _Graphics.FillRectangle(new SolidBrush(Color.FromArgb(52, 114, 188)), TabHighlighter);
                    }

                    // Seçilen tab başlığı metni
                    _Graphics.DrawString(TabPages[TabIndex].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), new SolidBrush(Color.FromArgb(254, 255, 255)), new Rectangle(TabRect.Left, TabRect.Top + 14, TabRect.Width, TabRect.Height), new StringFormat { Alignment = StringAlignment.Center });

                    if (this.ImageList != null)
                    {
                        int Index = TabPages[TabIndex].ImageIndex;
                        if (!(Index == -1))
                        {
                            _Graphics.DrawImage(ImageList.Images[TabPages[TabIndex].ImageIndex], TabRect.X + 9, TabRect.Y + 6, 24, 24);
                        }
                    }
                }
                else
                {
                    // Etkisiz tab başlığının içeriği
                    Rectangle TabRect = new Rectangle(new Point(GetTabRect(TabIndex).Location.X - 2, GetTabRect(TabIndex).Location.Y - 4), new Size(GetTabRect(TabIndex).Width + 3, GetTabRect(TabIndex).Height - 8));
                    // Etkisiz tab başlığının metni
                    _Graphics.DrawString(TabPages[TabIndex].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), new SolidBrush(Color.FromArgb(159, 162, 167)), new Rectangle(TabRect.Left, TabRect.Top + 14, TabRect.Width, TabRect.Height), new StringFormat { Alignment = StringAlignment.Center });

                    if (this.ImageList != null)
                    {
                        int Index = TabPages[TabIndex].ImageIndex;
                        if (!(Index == -1))
                        {
                            _Graphics.DrawImage(ImageList.Images[TabPages[TabIndex].ImageIndex], TabRect.X + 9, TabRect.Y + 6, 24, 24);
                        }
                    }

                }
            }
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.DrawImage((Image)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }
    }
    #endregion
    #region MPButon
    class MPButon : Button
    {
        public MPButon()
        {
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImage = global::MediaPlayer.Properties.Resources._1_780x35_y;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            ForeColor = System.Drawing.Color.Transparent;
            Location = new System.Drawing.Point(34, 30);
            Size = new System.Drawing.Size(240, 35);
            TabIndex = 0;
            Text = "MPButon";
            UseVisualStyleBackColor = false;
            //Click += new System.EventHandler(this.buttonVideoEkle_Click);
        }
    }
    #endregion MPButon

}
