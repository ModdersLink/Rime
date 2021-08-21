using RimeLib.Frostbite.Containers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.UI.ViewModels.fb
{
    public class Vec2ViewModel : ObservableObject<Vec2>
    {
        /// <summary>
        /// Displays the X component of the vector to the view
        /// </summary>
        public float X
        {
            get => m_Value.X;
            set
            {
                m_OldValue = m_Value;
                m_Value.X = value;
            }
        }

        /// <summary>
        /// Displays the Y component of the vector to the view
        /// </summary>
        public float Y
        {
            get => m_Value.Y;
            set
            {
                m_OldValue = m_Value;
                m_Value.Y = value;
            }
        }

        public Vec2ViewModel()
        {
            m_Value = new Vec2();
            m_OldValue = new Vec2();
        }

        public Vec2ViewModel(Vec2 p_Model)
        {
            m_Value = p_Model;
            m_OldValue = p_Model;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
