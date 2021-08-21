using System.ComponentModel;

namespace RimeLib.Frostbite.Containers
{
    /// <summary>
    /// Changed event arguments
    /// </summary>
    public class RimePropertyChangedEventArgs : PropertyChangedEventArgs
    {
        /// <summary>
        /// Parent object
        /// </summary>
        public object Parent { get; private set; }

        /// <summary>
        /// The previous value
        /// </summary>
        public object? PreviousValue { get; private set; }

        /// <summary>
        /// The new current value
        /// </summary>
        public object? CurrentValue { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="p_PropertyName"></param>
        /// <param name="p_Parent"></param>
        /// <param name="p_PreviousValue"></param>
        /// <param name="p_CurrentValue"></param>
        public RimePropertyChangedEventArgs(string p_PropertyName, object p_Parent, object? p_PreviousValue, object? p_CurrentValue)
            : base(p_PropertyName)
        {
            Parent = p_Parent;
            PreviousValue = p_PreviousValue;
            CurrentValue = p_CurrentValue;
        }
    }
}
