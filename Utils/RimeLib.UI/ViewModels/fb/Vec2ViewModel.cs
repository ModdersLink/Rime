using RimeLib.Serialization.Containers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.UI.ViewModels.fb
{
    public class Vec2ViewModel : ObservableObject<Vec2>
    {
        public Vec2ViewModel()
        {
            m_Value = new Vec2();
        }
    }
}
