using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace RimeLib.UI.ViewModels
{
    public class ObservableObject<T> : INotifyPropertyChanged where T : IEquatable<T>
    {
        // UNDO-REDO: Keep the old and current values
        protected T m_OldValue;
        protected T m_Value;

        // Have a public accessor for writing and handling events
        public T Value
        {
            get { return m_Value; }
            set
            {
                if (!EqualityComparer<T>.Default.Equals(m_Value, value))
                {
                    m_OldValue = m_Value;
                    m_Value = value;
                    OnPropertyChanged(nameof(Value));
                }
            }
        }

        /// <summary>
        /// Raised when a property on this object has a new value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string p_PropertyName)
        {
            VerifyPropertyName(p_PropertyName);

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(p_PropertyName));
        }

        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public virtual void VerifyPropertyName(string p_PropertyName)
        {
            // Verify that the property name matches a real,
            // public, instance property on this object.
            if (TypeDescriptor.GetProperties(this)[p_PropertyName] == null)
            {
                string msg = "Invalid property name: " + p_PropertyName;

                if (ThrowOnInvalidPropertyName)
                    throw new Exception(msg);
                else
                    Debug.Fail(msg);
            }
        }

        protected virtual bool ThrowOnInvalidPropertyName { get; private set; } 
    }
}
