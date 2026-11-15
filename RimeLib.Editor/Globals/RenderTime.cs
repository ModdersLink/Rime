namespace RimeLib.Editor.Globals
{
    /// <summary>
    /// RenderTime globals
    /// 
    /// Credit: grimdoomer
    /// </summary>
    internal class RenderTime
    {
        /// <summary>
        /// Tick count from the last frame
        /// </summary>
        public long LastTickCount;

        /// <summary>
        /// Tick count for the current frame
        /// </summary>
        public long CurrentTickCount;

        /// <summary>
        /// Tick count for the last time input was polled at
        /// </summary>
        public long InputPollTime;

        /// <summary>
        /// Time that has elapsed since the previous frame
        /// </summary>
        public float TimeDelta;
    }
}
