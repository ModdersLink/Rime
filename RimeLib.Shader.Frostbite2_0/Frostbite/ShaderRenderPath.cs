using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Shader.Frostbite2_0.Frostbite
{
    //WARNING: This enum has changed on newer shaderdb versions.
    /* 
    Bfh(fb2013) version of this enum
    public enum ShaderRenderPath 
    {
        ShaderRenderPath_Dx10 = 0, 
        ShaderRenderPath_Dx10Plus = 1, 
        ShaderRenderPath_Dx10_1 = 2, 
        ShaderRenderPath_Dx11 = 3, 
        ShaderRenderPath_Dx11_1 = 4, 
        ShaderRenderPath_Xenon = 5, 
        ShaderRenderPath_Ps3 = 6, 
        ShaderRenderPath_Gl = 7, 
        ShaderRenderPath_Gen4a = 8, 
        ShaderRenderPath_Gen4b = 9, 
        ShaderRenderPathCount = 10
     }  
     */
    public enum ShaderRenderPath
    {
        ShaderRenderPath_Dx10 = 0,
        ShaderRenderPath_Dx10Plus = 1,
        ShaderRenderPath_Dx10_1 = 2,
        ShaderRenderPath_Dx11 = 3,
        ShaderRenderPath_Xenon = 4,
        ShaderRenderPath_Ps3 = 5,
        ShaderRenderPath_Gl = 6,
        ShaderRenderPathCount = 7,
    }
}
