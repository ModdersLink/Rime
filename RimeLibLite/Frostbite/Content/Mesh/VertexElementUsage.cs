namespace RimeLib.Frostbite.Content.Mesh
{
    /// <summary>
    /// Vertex element usage
    /// </summary>
    public enum VertexElementUsage : byte
    {
        /// <summary>
        /// Unknown usage
        /// </summary>
        VertexElementUsage_Unknown = 0x0,

        /// <summary>
        /// Position usage
        /// </summary>
        VertexElementUsage_Pos = 0x1,

        /// <summary>
        /// Bone indicies usage
        /// </summary>
        VertexElementUsage_BoneIndices = 0x2,

        /// <summary>
        /// Bone indicies usage 2?
        /// </summary>
        VertexElementUsage_BoneIndices2 = 0x3,

        /// <summary>
        /// Bone weights usage
        /// </summary>
        VertexElementUsage_BoneWeights = 0x4,

        /// <summary>
        /// Bone weights usage 2?
        /// </summary>
        VertexElementUsage_BoneWeights2 = 0x5,

        /// <summary>
        /// Normal usage
        /// </summary>
        VertexElementUsage_Normal = 0x6,

        /// <summary>
        /// Tangent usage
        /// </summary>
        VertexElementUsage_Tangent = 0x7,

        /// <summary>
        /// Binormal usage
        /// </summary>
        VertexElementUsage_Binormal = 0x8,

        /// <summary>
        /// Binormal signed usage
        /// </summary>
        VertexElementUsage_BinormalSign = 0x9,

        /// <summary>
        /// World transform 1 usage
        /// </summary>
        VertexElementUsage_WorldTrans1 = 0xA,

        /// <summary>
        /// World transform 2 usage
        /// </summary>
        VertexElementUsage_WorldTrans2 = 0xB,

        /// <summary>
        /// World transform 3 usage
        /// </summary>
        VertexElementUsage_WorldTrans3 = 0xC,

        /// <summary>
        /// Instance identifier usage
        /// </summary>
        VertexElementUsage_InstanceId = 0xD,

        /// <summary>
        /// Instance user data 0 usage
        /// </summary>
        VertexElementUsage_InstanceUserData0 = 0xE,

        /// <summary>
        /// Instance user data 1 usage
        /// </summary>
        VertexElementUsage_InstanceUserData1 = 0xF,

        /// <summary>
        /// Xenon index (Xbox 360) usage
        /// </summary>
        VertexElementUsage_XenonIndex = 0x10,

        /// <summary>
        /// Xenon (Xbox 360) barycentric usage
        /// </summary>
        VertexElementUsage_XenonBarycentric = 0x11,

        /// <summary>
        /// Xenon (Xbox 360) quad identifier usage
        /// </summary>
        VertexElementUsageXenonQuadId = 0x12,

        /// <summary>
        /// Index usage
        /// </summary>
        VertexElementUsage_Index = 0x13,

        /// <summary>
        /// View index usage
        /// </summary>
        VertexElementUsage_ViewIndex = 0x14,

        /// <summary>
        /// Color0 usage
        /// </summary>
        VertexElementUsage_Color0 = 0x1E,

        /// <summary>
        /// Color1 usage
        /// </summary>
        VertexElementUsage_Color1 = 0x1F,

        /// <summary>
        /// Texture coordinate 0 usage
        /// </summary>
        VertexElementUsage_TexCoord0 = 0x21,

        /// <summary>
        /// Texture coordinate 1 usage
        /// </summary>
        VertexElementUsage_TexCoord1 = 0x22,

        /// <summary>
        /// Texture coordinate 2 usage
        /// </summary>
        VertexElementUsage_TexCoord2 = 0x23,

        /// <summary>
        /// Texture coordinate 3 usage
        /// </summary>
        VertexElementUsage_TexCoord3 = 0x24,

        /// <summary>
        /// Texture coordinate 4 usage
        /// </summary>
        VertexElementUsage_TexCoord4 = 0x25,

        /// <summary>
        /// Texture coordinate 5 usage
        /// </summary>
        VertexElementUsage_TexCoord5 = 0x26,

        /// <summary>
        /// Texture coordinate 6 usage
        /// </summary>
        VertexElementUsage_TexCoord6 = 0x27,

        /// <summary>
        /// Texture coordinate 7 usage
        /// </summary>
        VertexElementUsage_TexCoord7 = 0x28,

        /// <summary>
        /// Radiosity texture coordniate usage
        /// </summary>
        VertexElementUsage_RadiosityTexCoord = 0x29,

        /// <summary>
        /// VisInfo usage
        /// </summary>
        VertexElementUsage_VisInfo = 0x2A,

        /// <summary>
        /// Sprite size usage
        /// </summary>
        VertexElementUsage_SpriteSize = 0x2B,

        /// <summary>
        /// Packed texture coordinate 0 usage
        /// </summary>
        VertexElementUsage_PackedTexCoord0 = 0x2C,

        /// <summary>
        /// Packed texture coordinate 1 usage
        /// </summary>
        VertexElementUsage_PackedTexCoord1 = 0x2D,

        /// <summary>
        /// Packed texture coordinate 2 usage
        /// </summary>
        VertexElementUsage_PackedTexCoord2 = 0x2E,

        /// <summary>
        /// Packed texture coordinate 3 usage
        /// </summary>
        VertexElementUsage_PackedTexCoord3 = 0x2F,

        /// <summary>
        /// Clip distance 0 usage
        /// </summary>
        VertexElementUsage_ClipDistance0 = 0x30,

        /// <summary>
        /// Clip distance 1 usage
        /// </summary>
        VertexElementUsage_ClipDistance1 = 0x31,

        /// <summary>
        /// Sub-material index usage
        /// </summary>
        VertexElementUsage_SubMaterialIndex = 0x32,

        /// <summary>
        /// Branch information usage
        /// </summary>
        VertexElementUsage_BranchInfo = 0x3C,

        /// <summary>
        /// Position and scale usage
        /// </summary>
        VertexElementUsage_PosAndScale = 0x3D,

        /// <summary>
        /// Rotation usage
        /// </summary>
        VertexElementUsage_Rotation = 0x3E,

        /// <summary>
        /// Sprite size and uv coordinate usage
        /// </summary>
        VertexElementUsage_SpriteSizeAndUv = 0x3F,

        /// <summary>
        /// Fade position usage
        /// </summary>
        VertexElementUsage_FadePos = 0x5A,

        /// <summary>
        /// Spawn time usage
        /// </summary>
        VertexElementUsage_SpawnTime = 0x5B,

        /// <summary>
        /// Position and soft multiplier usage
        /// </summary>
        VertexElementUsage_PosAndSoftMul = 0x96,

        /// <summary>
        /// Alpha usage
        /// </summary>
        VertexElementUsage_Alpha = 0x97,

        /// <summary>
        /// Misc0 usage
        /// </summary>
        VertexElementUsage_Misc0 = 0x98,

        /// <summary>
        /// Misc1 usage
        /// </summary>
        VertexElementUsage_Misc1 = 0x99,

        /// <summary>
        /// Left and rotation usage
        /// </summary>
        VertexElementUsage_LeftAndRotation = 0x9A,

        /// <summary>
        /// Up and normal blend usage
        /// </summary>
        VertexElementUsage_UpAndNormalBlend = 0x9B,

        /// <summary>
        /// ShR usage
        /// </summary>
        VertexElementUsageShR = 0x9C,

        /// <summary>
        /// ShG usage
        /// </summary>
        VertexElementUsageShG = 0x9D,

        /// <summary>
        /// ShB usage
        /// </summary>
        VertexElementUsageShB = 0x9E,

        /// <summary>
        /// Position and reject culling usage
        /// </summary>
        VertexElementUsage_PosAndRejectCulling = 0x9F,

        /// <summary>
        /// Shadow usage
        /// </summary>
        VertexElementUsage_Shadow = 0xA0,

        /// <summary>
        /// Patch uv coordinate usage
        /// </summary>
        VertexElementUsage_PatchUv = 0xB4,

        /// <summary>
        /// Height usage
        /// </summary>
        VertexElementUsage_Height = 0xB5,

        /// <summary>
        /// Mask UV 0 usage
        /// </summary>
        VertexElementUsage_MaskUVs0 = 0xB6,

        /// <summary>
        /// Mask UV 1 usage
        /// </summary>
        VertexElementUsage_MaskUVs1 = 0xB7,

        /// <summary>
        /// Mask UV 2 usage
        /// </summary>
        VertexElementUsage_MaskUVs2 = 0xB8,

        /// <summary>
        /// Mask UV 3 usage
        /// </summary>
        VertexElementUsage_MaskUVs3 = 0xB9,

        /// <summary>
        /// Mask UV user usage
        /// </summary>
        VertexElementUsage_UserMasks = 0xBA,

        /// <summary>
        /// Heightfield uv coordinate usage
        /// </summary>
        VertexElementUsage_HeightfieldUv = 0xBB,

        /// <summary>
        /// Mask uv coordinate usage
        /// </summary>
        VertexElementUsage_MaskUv = 0xBC,

        /// <summary>
        /// Global color uv coordinate usage
        /// </summary>
        VertexElementUsage_GlobalColorUv = 0xBD,

        /// <summary>
        /// heightfield pixel size and aspect ratio usage
        /// </summary>
        VertexElementUsage_HeightfieldPixelSizeAndAspect = 0xBE,

        /// <summary>
        /// World position XZ usage
        /// </summary>
        VertexElementUsage_WorldPositionXz = 0xBF,

        /// <summary>
        /// Terrain texture node uv coordinate usage
        /// </summary>
        VertexElementUsage_TerrainTextureNodeUv = 0xC0,

        /// <summary>
        /// Parent terrain texture node uv coordinate usage
        /// </summary>
        VertexElementUsage_ParentTerrainTextureNodeUv = 0xC1,

        /// <summary>
        /// UV coordinate usage
        /// </summary>
        VertexElementUsage_Uv01 = 0xD2,

        /// <summary>
        /// World position usage
        /// </summary>
        VertexElementUsage_WorldPos = 0xD3,

        /// <summary>
        /// Eye vector usage
        /// </summary>
        VertexElementUsage_EyeVector = 0xD4,

        /// <summary>
        /// Light parameters 1 usage
        /// </summary>
        VertexElementUsage_LightParams1 = 0xDC,

        /// <summary>
        /// Light parameters 2 usage
        /// </summary>
        VertexElementUsage_LightParams2 = 0xDD,

        /// <summary>
        /// Light sub parameters usage
        /// </summary>
        VertexElementUsage_LightSubParams = 0xDE,

        /// <summary>
        /// Light side vector usage
        /// </summary>
        VertexElementUsage_LightSideVector = 0xDF,

        /// <summary>
        /// Light inner and outer angle usage
        /// </summary>
        VertexElementUsage_LightInnerAndOuterAngle = 0xE0,

        /// <summary>
        /// Light direction usage
        /// </summary>
        VertexElementUsage_LightDir = 0xE1,

        /// <summary>
        /// Light matrix usage
        /// </summary>
        VertexElementUsage_LightMatrix1 = 0xE2,

        /// <summary>
        /// Light matrix 2 usage
        /// </summary>
        VertexElementUsage_LightMatrix2 = 0xE3,

        /// <summary>
        /// Light matrix 3 usage
        /// </summary>
        VertexElementUsage_LightMatrix3 = 0xE4,

        /// <summary>
        /// Light matrix 4 usage
        /// </summary>
        VertexElementUsage_LightMatrix4 = 0xE5,

        /// <summary>
        /// Custom usage
        /// </summary>
        VertexElementUsage_Custom = 0xE6,
    }
}
