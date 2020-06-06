using System.ComponentModel;

namespace RimeLib.Serialization.Containers
{
    /// <summary>
    /// Cancel the property changing event
    /// </summary>
    public class RimePropertyChangingCancelEventArgs : PropertyChangingEventArgs
    {
        /// <summary>
        /// Set this to true to cancel
        /// </summary>
        public bool Cancel { get; set; }
        /// <summary>
        /// Default property args constructor
        /// </summary>
        /// <param name="p_PropertyName">The property name</param>
        public RimePropertyChangingCancelEventArgs(string p_PropertyName) :
            base(p_PropertyName)
        {
        }
    }
}
