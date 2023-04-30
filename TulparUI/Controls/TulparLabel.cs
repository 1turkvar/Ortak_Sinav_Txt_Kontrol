using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TulparUI.Controls
{
    public partial class TulparLabel : Label, ITulparControl
    {
        [Browsable(false)]
        public int Depth { get; set; }

        [Browsable(false)]
        public TulparSkinManager SkinManager => TulparSkinManager.Instance;

        [Browsable(false)]
        public MouseState MouseState { get; set; }

        private ContentAlignment _TextAlign = ContentAlignment.TopLeft;

        [DefaultValue(typeof(ContentAlignment), "TopLeft")]
        public override ContentAlignment TextAlign
        {
            get
            {
                return _TextAlign;
            }
            set
            {
                _TextAlign = value;
                updateAligment();
                Invalidate();
            }
        }

        [Category("Tulpar Skin"),
        DefaultValue(false)]
        public bool HighEmphasis { get; set; }

        [Category("Tulpar Skin"),
        DefaultValue(false)]
        public bool UseAccent { get; set; }

        private TulparSkinManager.FontType _fontType = TulparSkinManager.FontType.Body1;

        [Category("Tulpar Skin"),
        DefaultValue(typeof(TulparSkinManager.FontType), "Body1")]
        public TulparSkinManager.FontType FontType
        {
            get
            {
                return _fontType;
            }
            set
            {
                _fontType = value;
                Font = SkinManager.getFontByType(_fontType);
                Refresh();
            }
        }

        public TulparLabel()
        {
            FontType = TulparSkinManager.FontType.Body1;
            TextAlign = ContentAlignment.TopLeft;
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            if (AutoSize)
            {
                Size strSize;
                using (NativeTextRenderer NativeText = new NativeTextRenderer(CreateGraphics()))
                {
                    strSize = NativeText.MeasureLogString(Text, SkinManager.GetLogFontByType(_fontType));
                    strSize.Width += 1; // necessary to avoid a bug when autosize = true
                }
                return strSize;
            }
            else
            {
                return proposedSize;
            }
        }

        private NativeTextRenderer.TextAlignFlags Alignment;

        private void updateAligment()
        {
            switch (_TextAlign)
            {
                case ContentAlignment.TopLeft:
                    Alignment = NativeTextRenderer.TextAlignFlags.Top | NativeTextRenderer.TextAlignFlags.Left;
                    break;

                case ContentAlignment.TopCenter:
                    Alignment = NativeTextRenderer.TextAlignFlags.Top | NativeTextRenderer.TextAlignFlags.Center;
                    break;

                case ContentAlignment.TopRight:
                    Alignment = NativeTextRenderer.TextAlignFlags.Top | NativeTextRenderer.TextAlignFlags.Right;
                    break;

                case ContentAlignment.MiddleLeft:
                    Alignment = NativeTextRenderer.TextAlignFlags.Middle | NativeTextRenderer.TextAlignFlags.Left;
                    break;

                case ContentAlignment.MiddleCenter:
                    Alignment = NativeTextRenderer.TextAlignFlags.Middle | NativeTextRenderer.TextAlignFlags.Center;
                    break;

                case ContentAlignment.MiddleRight:
                    Alignment = NativeTextRenderer.TextAlignFlags.Middle | NativeTextRenderer.TextAlignFlags.Right;
                    break;

                case ContentAlignment.BottomLeft:
                    Alignment = NativeTextRenderer.TextAlignFlags.Bottom | NativeTextRenderer.TextAlignFlags.Left;
                    break;

                case ContentAlignment.BottomCenter:
                    Alignment = NativeTextRenderer.TextAlignFlags.Bottom | NativeTextRenderer.TextAlignFlags.Center;
                    break;

                case ContentAlignment.BottomRight:
                    Alignment = NativeTextRenderer.TextAlignFlags.Bottom | NativeTextRenderer.TextAlignFlags.Right;
                    break;

                default:
                    Alignment = NativeTextRenderer.TextAlignFlags.Top | NativeTextRenderer.TextAlignFlags.Left;
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Parent.BackColor);

            // Draw Text
            using (NativeTextRenderer NativeText = new NativeTextRenderer(g))
            {
                NativeText.DrawMultilineTransparentText(
                    Text,
                    SkinManager.GetLogFontByType(_fontType),
                    Enabled ? HighEmphasis ? UseAccent ?
                    SkinManager.ColorScheme.AccentColor : // High emphasis, accent
                    (SkinManager.Theme == TulparSkinManager.Themes.LIGHT) ?
                    SkinManager.ColorScheme.PrimaryColor : // High emphasis, primary Light theme
                    SkinManager.ColorScheme.PrimaryColor.Lighten(0.25f) : // High emphasis, primary Dark theme
                    SkinManager.TextHighEmphasisColor : // Normal
                    SkinManager.TextDisabledOrHintColor, // Disabled
                    ClientRectangle.Location,
                    ClientRectangle.Size,
                    Alignment);
            }
        }

        protected override void InitLayout()
        {
            Font = SkinManager.getFontByType(_fontType);
        }
    }
}
