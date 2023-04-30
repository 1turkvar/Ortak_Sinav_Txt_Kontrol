using System.ComponentModel;
using System.Windows.Forms;

namespace TulparUI.Controls
{
    public sealed class TulparDivider : Control, ITulparControl
    {
        [Browsable(false)]
        public int Depth { get; set; }

        [Browsable(false)]
        public TulparSkinManager SkinManager => TulparSkinManager.Instance;

        [Browsable(false)]
        public MouseState MouseState { get; set; }

        public TulparDivider()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Height = 1;
            BackColor = SkinManager.DividersColor;
        }
    }
}
