using GameToolsDotNet.Rendering.DirectX.Misc;
using GameToolsDotNet.Rendering.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameToolsDotNet.Rendering.DirectX.Gizmos
{
    public class TriggerVolume : IRenderable
    {

        public bool InitializeGraphics(RenderManager manager, params object[] args)
        {
            throw new NotImplementedException();
        }

        public bool DrawFrame(RenderManager manager, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void DrawObjectPropertiesUI(RenderManager manager, object context = null)
        {
            throw new NotImplementedException();
        }

        public void CleanupGraphics(RenderManager manager, object context = null)
        {
            throw new NotImplementedException();
        }

        public bool DoClippingTest(RenderManager manager, FastBoundingBox viewBox, object context = null)
        {
            return false;
        }
    }
}
