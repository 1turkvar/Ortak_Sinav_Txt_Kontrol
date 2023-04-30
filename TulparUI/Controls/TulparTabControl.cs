namespace MaterialSkin.Controls
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;
    using TulparUI;

    public class TulparTabControl : TabControl, ITulparControl
    {
        public TulparTabControl()
        {
            Multiline = true;
        }

        public bool HideTabArea { get; set; }

        [Browsable(false)]
        public int Depth { get; set; }

        [Browsable(false)]
        public TulparSkinManager SkinManager => TulparSkinManager.Instance;

        [Browsable(false)]
        public MouseState MouseState { get; set; }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x1328 && !DesignMode && HideTabArea)
                m.Result = (IntPtr)1;
            else
                base.WndProc(ref m);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            e.Control.BackColor = System.Drawing.Color.White;
        }
    }
}
