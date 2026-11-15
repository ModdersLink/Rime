
namespace RimeLib.Editor.Managers.Input
{
    /// <summary>
    /// Input actions to the editor
    /// </summary>
    public enum InputAction : int
    {
        /// <summary>
        /// Default no action
        /// </summary>
        None = 0,

        #region Movements
        /// <summary>
        /// Move Forward
        /// </summary>
        MoveForward,

        /// <summary>
        /// Move Backward
        /// </summary>
        MoveBackward,

        /// <summary>
        /// Move Left
        /// </summary>
        StrafeLeft,

        /// <summary>
        /// Move Right
        /// </summary>
        StrafeRight,

        /// <summary>
        /// Move Up
        /// </summary>
        MoveUp,

        /// <summary>
        /// Move Down
        /// </summary>
        MoveDown,
        #endregion

        #region Selections
        /// <summary>
        /// Select (ex: Left Mouse)
        /// </summary>
        Select,

        /// <summary>
        /// Context (ex: Right Mouse)
        /// </summary>
        Context,

        /// <summary>
        /// Alternative Select (ex: Middle Mouse)
        /// </summary>
        AltSelect,
        #endregion

        #region Camera
        /// <summary>
        /// Camera speed increase
        /// </summary>
        CamSpeedIncrease,

        /// <summary>
        /// Camera speed decrease
        /// </summary>
        CamSpeedDecrease,
        #endregion

        // Misc actions:
        MiscAction1,
        MiscAction2,

        /// <summary>
        /// Max number of inputs
        /// </summary>
        Max
    }
}