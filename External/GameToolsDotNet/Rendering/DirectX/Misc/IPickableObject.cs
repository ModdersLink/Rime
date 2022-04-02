using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameToolsDotNet.Rendering.DirectX.Misc
{
    public interface IPickableObject
    {
        bool DoPickingTest(RenderManager manager, Ray pickingRay, object context, out float distance, out object pickedObjectContext);

        void SelectObject(RenderManager manager, object context);

        bool DeselectObject(RenderManager manager, object context);

        bool HandleInput(RenderManager manager);
    }
}
