using RimeLib.Frostbite;
using RimeLib.IO;
using System.Diagnostics.CodeAnalysis;
using fb;
using RimeLib.Mesh.Frostbite;
using System.IO;
using RimeLib.Extensions;
using System.Collections.Generic;
using RimeLib.Shader.Frostbite2_0.Frostbite.Rendering;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Solutions;

public class ShaderSolutionState : IFbSerializable
{
    public uint SurfaceShaderNameHash { get; set; }
    public uint VertexShaderFragmentNameHash { get; set; }
    public uint GeometryDeclarationHash { get; set; }

    public GeometryDeclarationDesc GeometryDeclarationDesc { get; set; } = default!;

    public ShaderRenderMode Mode { get; set; } = ShaderRenderMode.ShaderRenderMode_Default;
    public ShaderGeometrySpace GeometrySpace { get; set; } = ShaderGeometrySpace.ShaderGeometrySpace_Object;
    public ShaderSkinningMethod SkinningMethod { get; set; } = ShaderSkinningMethod.ShaderSkinningMethod_None;
    public ShaderInstancingMethod InstancingMethod { get; set; } = ShaderInstancingMethod.ShaderInstancingMethod_None;
    public ShaderObjectLighting ObjectLighting { get; set; } = ShaderObjectLighting.ShaderObjectLighting_None;

    public byte ColorScale { get; set; }
    public byte Technique { get; set; }
    public byte BoolPermutation { get; set; }

    public byte Ps3ClipPlaneCount { get; set; }
    public byte HeightfieldTessellation { get; set; }

    public bool OutdoorLightEnable { get; set; }
    public ShaderShadowmapMethod OutdoorLightShadowmapMethod { get; set; } = ShaderShadowmapMethod.ShaderShadowmapMethod_None;
    public ShaderShadowmapQuality OutdoorLightShadowmapQuality { get; set; } = ShaderShadowmapQuality.ShaderShadowmapQuality_Pcf2x2;
    public bool OutdoorLightTransparencyShadowmapEnable { get; set; }
    public byte OutdoorLightMultisampleCount { get; set; }

    public ulong Hash
    {
        get
        {
            using var s_Writer = new RimeWriter(new MemoryStream());
            Serialize(s_Writer);
            s_Writer.Seek(0, SeekOrigin.Begin);
            return RimeLib.Frostbite.Utils.Fletcher64(s_Writer.ToArray());
        }
    }


    //TODO: fb::VertexShaderFragment is an instance of a shader
    //  - optional
    //  - seems to be used for decals and emitters
    //  - examples:
    //      - "Systems/Emitter/EmitterVSF_PerVertexLighting"
    //      - "Systems/Emitter/EmitterVSF_PerPixelLighting"
    public ShaderSolutionState(
        ShaderState? p_ShaderState,
        //object p_DrawBlock,  //TODO: fb::ShaderDrawBlock

        SurfaceShaderInfo p_Surface,
        GeometryDeclarationDesc p_Geometry,

        ShaderRenderMode p_Mode,
        byte p_OutdoorLightMultisampleCount,
        string? p_VertexShaderFragmentName = null)
    {
        // To get this working properly a partial implimentation of the fb render stack seems useful.
        // Specifically fb::ShaderRenderContext


        // Theres 2 fb::ShaderState in StateStack. 
        // 1. is baseShaderState | check fb::setDefaultShaderState
        // 2. is state from draw block
        // it prefers the 2nd one, but falls back to baseShaderState






        // Is this some debug feature?
        if (p_Mode == ShaderRenderMode.ShaderRenderMode_DebugOverdraw ||
            p_Mode == ShaderRenderMode.ShaderRenderMode_DebugShaderCost)
        {
            p_Mode = ShaderRenderMode.ShaderRenderMode_Default;
        }

        if (p_Mode != ShaderRenderMode.ShaderRenderMode_DeferredShadingUnlit)
            Mode = p_Mode;
        else
            Mode = ShaderRenderMode.ShaderRenderMode_Default;


        // unsure if this geometry ptr is needed
        this.GeometryDeclarationDesc = p_Geometry;
        this.GeometryDeclarationHash = p_Geometry.Hash;

        this.SurfaceShaderNameHash = p_Surface.NameHash;


        //p_VertexShaderFragment.NameHash;
        if (p_VertexShaderFragmentName != null)
            VertexShaderFragmentNameHash = RimeLib.Frostbite.Utils.HashQuick(p_VertexShaderFragmentName);


        if (p_ShaderState != null && 
            p_ShaderState.StateFlags.HasFlag(ShaderStateType.ShaderStateType_GeometrySpace))
            GeometrySpace = p_ShaderState.GeometrySpace;
        else
            GeometrySpace = ShaderState.c_DefaultState.GeometrySpace;


        if (p_ShaderState != null &&
            p_ShaderState.StateFlags.HasFlag(ShaderStateType.ShaderStateType_SkinningMethod))
            SkinningMethod = p_ShaderState.SkinningMethod;
        else
            SkinningMethod = ShaderState.c_DefaultState.SkinningMethod;


        if (p_ShaderState != null &&
            p_ShaderState.StateFlags.HasFlag(ShaderStateType.ShaderStateType_Technique))
            Technique = (byte)p_ShaderState.Technique;
        else
            Technique = (byte)ShaderState.c_DefaultState.Technique;

        //if(p_DrawBlock.hasGeometry)
        //    InstancingMethod = p_DrawBlock.Geometry.InstancingMethod;

        //if (InstancingMethod == ShaderInstancingMethod.ShaderInstancingMethod_None && p_DrawBlock.instanceCount > 1)
        //    InstancingMethod = ShaderInstancingMethod.ShaderInstancingMethod_DxBuffer;


        if (p_Surface.BoolParameterCount > 0)
        {
            this.BoolPermutation = p_Surface.BoolParameterDefaultMask;

            // TODO: get ShaderParameterBlocks from state stack
            var s_ParameterBlocks = new List<object>();

            for (var i=0; i < p_Surface.BoolParameterCount; i++ )
            {
                var s_Id = p_Surface.BoolParameterIds[i];
                var s_Mask = (uint)1 << i;

                
                foreach (var s_Parameters in s_ParameterBlocks)
                {
                    //if(s_Parameters.BoolCount == 0)
                    //  continue;

                    //if(!s_Parameters.TryReadBool(s_Id, out var s_BoolValue))
                    //  continue;

                    bool s_BoolValue = false;

                    if (s_BoolValue)
                        BoolPermutation |= (byte) s_Mask;
                    else
                        BoolPermutation &= (byte) ~s_Mask;
                }
            }
        }

        if (p_Mode == ShaderRenderMode.ShaderRenderMode_Default ||
            p_Mode == ShaderRenderMode.ShaderRenderMode_DeferredShadingUnlit)
        {
            //if (stateStack.outdoorLight)
            //{
            //    OutdoorLightEnable = true;
            //    OutdoorLightShadowmapMethod = ShaderShadowmapMethod.ShaderShadowmapMethod_None;
            //    OutdoorLightShadowmapQuality = ShaderShadowmapQuality.ShaderShadowmapQuality_Pcf2x2;
            //    OutdoorLightTransparencyShadowmapEnable = false;
            //}
        }

        if (p_Mode == ShaderRenderMode.ShaderRenderMode_DeferredShadingGBufferLayout0 || 
            p_Mode == ShaderRenderMode.ShaderRenderMode_DeferredShadingGBufferLayout1 ||
            (p_Mode == ShaderRenderMode.ShaderRenderMode_Default && p_Surface.SurfaceShaderType == SurfaceShaderType.SurfaceShaderType_Transparent))
        {

            //if (stateStack.lightProbes) 
            //    ObjectLighting = ShaderObjectLighting.ShaderObjectLighting_LightProbe;
            //else if (stateStack.lightMaps)
            //    ObjectLighting = ShaderObjectLighting.ShaderObjectLighting_LightMap;
        }

        OutdoorLightMultisampleCount = 1;
        if (p_Surface.SurfaceShaderType == SurfaceShaderType.SurfaceShaderType_OpaqueAlphaTest ||
            p_Surface.SurfaceShaderType == SurfaceShaderType.SurfaceShaderType_OpaqueAlphaTestSimple)
            OutdoorLightMultisampleCount = p_OutdoorLightMultisampleCount;

        //if (stateStack.heightfieldTessellation)
        //    HeightfieldTessellation = 1;
    }


    public ShaderSolutionState(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(SurfaceShaderNameHash);
        p_Writer.Write(VertexShaderFragmentNameHash);
        p_Writer.Write(GeometryDeclarationHash);

        //0x000C
        p_Writer.Write((byte) Mode); 
        p_Writer.Write((byte) GeometrySpace);
        p_Writer.Write((byte) SkinningMethod);
        p_Writer.Write((byte) InstancingMethod);
        p_Writer.Write((byte) ObjectLighting);

        //0x0011
        p_Writer.Write(ColorScale);
        p_Writer.Write(Technique);
        p_Writer.Write(BoolPermutation);

        //0x0014
        p_Writer.Write(Ps3ClipPlaneCount);
        p_Writer.Write(HeightfieldTessellation);

        p_Writer.Write(OutdoorLightEnable);
        p_Writer.Write((byte) OutdoorLightShadowmapMethod);
        p_Writer.Write((byte) OutdoorLightShadowmapQuality);
        p_Writer.Write(OutdoorLightTransparencyShadowmapEnable);
        p_Writer.Write(OutdoorLightMultisampleCount);


        p_Writer.Write(new byte[0x5]);

        return true;
    }

    public void Deserialize(RimeReader p_Reader)
    {
        SurfaceShaderNameHash = p_Reader.ReadUInt32();
        VertexShaderFragmentNameHash = p_Reader.ReadUInt32();
        GeometryDeclarationHash = p_Reader.ReadUInt32();

        Mode = (ShaderRenderMode)p_Reader.ReadUByte();
        GeometrySpace = (ShaderGeometrySpace)p_Reader.ReadUByte();
        SkinningMethod = (ShaderSkinningMethod)p_Reader.ReadUByte();
        InstancingMethod = (ShaderInstancingMethod)p_Reader.ReadUByte();
        ObjectLighting = (ShaderObjectLighting)p_Reader.ReadUByte();

        ColorScale = p_Reader.ReadUByte();
        Technique = p_Reader.ReadUByte();
        BoolPermutation = p_Reader.ReadUByte();

        Ps3ClipPlaneCount = p_Reader.ReadUByte();
        HeightfieldTessellation = p_Reader.ReadUByte();

        OutdoorLightEnable = p_Reader.ReadBool();
        OutdoorLightShadowmapMethod = (ShaderShadowmapMethod)p_Reader.ReadUByte();
        OutdoorLightShadowmapQuality = (ShaderShadowmapQuality)p_Reader.ReadUByte();
        OutdoorLightTransparencyShadowmapEnable = p_Reader.ReadBool();
        OutdoorLightMultisampleCount = p_Reader.ReadUByte();

        p_Reader.Seek(0x5, SeekOrigin.Current);
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        p_Data = null;
        throw new System.NotImplementedException();
    }
        
    public void Deserialize(byte[] p_Data)
    {
        throw new System.NotImplementedException();
    }


}