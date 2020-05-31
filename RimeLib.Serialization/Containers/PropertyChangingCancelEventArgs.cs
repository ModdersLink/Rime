using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Serialization.Containers
{
    /// <summary>
    /// Base property change cancel arguments
    /// </summary>
    public class PropertyChangingCancelEventArgs : RimePropertyChangingCancelEventArgs
    {
        /// <summary>
        /// Parent object
        /// </summary>
        public object Parent { get; private set; }

        /// <summary>
        /// The original value
        /// </summary>
        public object? OriginalValue { get; private set; }

        /// <summary>
        /// The new value that is being changed to
        /// </summary>
        public object? NewValue { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="p_PropertyName"></param>
        /// <param name="p_Parent"></param>
        /// <param name="p_OriginalValue"></param>
        /// <param name="p_NewValue"></param>
        public PropertyChangingCancelEventArgs(string p_PropertyName, object p_Parent, object? p_OriginalValue, object? p_NewValue)
            : base(p_PropertyName)
        {
            Parent = p_Parent;
            OriginalValue = p_OriginalValue;
            NewValue = p_NewValue;
        }
    }
}
