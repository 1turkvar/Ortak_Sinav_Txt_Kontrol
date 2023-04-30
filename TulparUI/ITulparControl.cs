namespace TulparUI
{
    /// <summary>
    /// Defines the <see cref="ITulparControl" />
    /// </summary>
    public interface ITulparControl
    {
        /// <summary>
        /// Gets or sets the Depth
        /// </summary>
        int Depth { get; set; }

        /// <summary>
        /// Gets the SkinManager
        /// </summary>
        TulparSkinManager SkinManager { get; }

        /// <summary>
        /// Gets or sets the MouseState
        /// </summary>
        MouseState MouseState { get; set; }
    }

    /// <summary>
    /// Defines the MouseState
    /// </summary>
    public enum MouseState
    {
        /// <summary>
        /// Defines the HOVER
        /// </summary>
        HOVER,

        /// <summary>
        /// Defines the DOWN
        /// </summary>
        DOWN,

        /// <summary>
        /// Defines the OUT
        /// </summary>
        OUT
    }
}