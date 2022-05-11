using System;
using System.Numerics;
using GameToolsDotNet.Rendering.DirectX;
using ImGuiNET;
using SharpDX.Direct3D11;

namespace Rime;

public class RimeRenderManager : RenderManager
{
    private Resource? m_TextureResource = null;
    private ShaderResourceView? m_ResourceView = null;
    private Vector2 m_ResourceSize = Vector2.Zero;

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

    public void SetTexture(ShaderResourceView p_Resource)
    {
        m_ResourceSize = new Vector2(256, 256);
        m_ResourceView = p_Resource;
    }

    protected override void RenderGuiLayer(bool p_IsFocused)
    {
        base.RenderGuiLayer(p_IsFocused);

        if (m_ResourceView != null)
        {
            ImGui.Begin("Texture Viewer");

            ImGui.Image(m_ResourceView.NativePointer, m_ResourceSize);

            ImGui.End();
        }
    }
}
