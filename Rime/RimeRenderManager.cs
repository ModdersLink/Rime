using System;
using System.Drawing;
using GameToolsDotNet.Rendering.DirectX;

namespace Rime;

public class RimeRenderManager : RenderManager
{
    public RimeRenderManager() : base(GetRenderConfig())
    {
    }

    private static RenderConfig GetRenderConfig()
    {
        return new RenderConfig()
        {
            DebugLayerEnabled = true,
            DrawDistanceMinimum = 1,
            DrawDistanceMaximum = 9999,
            RightHandPerspective = false,
            UpAxis = UpAxis.Y_Up,
        };
    }

    public override object GetResourceFromFileName(string p_FileName)
    {
        throw new NotImplementedException();
    }

    public override object GetResourceFromKey(object p_Key)
    {
        throw new NotImplementedException();
    }
}
