#pragma warning disable 1591

namespace RimeLib.Frostbite
{
    /// <summary>
    /// Data Resource Types
    /// </summary>
    public enum ResourceType : uint
    {
        // Venice Resource Types
        AnimatedPointCloud = 0xC6DBEE07,
        AnimTrackData = 0xD070EED1,
        AssetBank = 0x51A3C853,
        DxShaderDatabase = 0xE565EB15,
        DxShaderProgramDatabase = 0x10F0E5A1,
        DxTexture = 0x5C4954A6,
        EnlightenDatabase = 0x70C5CB3E,
        EnlightenProbeSet = 0xE156AF73,
        EnlightenShaderDatabase = 0x59CEEB57,
        EnlightenSystem = 0x5BDFDEFE,
        HavokDestructionPhysicsData = 0x4864737B,
        HavokPhysicsData = 0x91043F65,
        ImpulseResponse = 0xC78B9D9D,
        IShaderDatabase = 0x36F3F2C0,
        ITexture = 0xC417BBD3,
        MeshSet = 0x49B156D4,
        OccluderMesh = 0x30B4A553,
        RagdollResource = 0x319D8CD0,
        RawFileData = 0x3568E2B7,
        RenderTexture = 0x41D57E10,
        StaticEnlightenDatabase = 0x7AEFC446,
        SwfMovie = 0x2D47A5FF,
        Terrain = 0x6BB6D7D2,
        TerrainDecals = 0x15E1F32E,
        TerrainStreamingTree = 0x22FE8AC8,
        VisualTerrain = 0x1CA38E06,

        // Warsaw Additions
        AtlasTexture = 0x957C32B1,
        CompiledLuaResource = 0xAFECB022,
        Dx11Texture = 0xBCC7FB86,
        Dx11ShaderProgramDatabase = 0xF04F0C81,
        EnlightenStaticDatabase = 0xC6CD3286,
        HavokClothPhysicsData = 0xE36F0D59,
        MovieTexture = 0x31E779A2,
        TerrainLayerCombinations = 0xA23E75DB,

        // Whiteshark Additions
        Dx12Texture = 0x6BDE20BA,
        HeightfieldDecal = 0x9C4FAA17,
        MeshEmitterResource = 0xC611F34A,
        UITtfFontFile = 0x9D00966A,

        // Pamplona Additions
        EAClothData = 0x387CA0AD,
        ZoneStreamerGrid = 0xEFC70728,
        LinearMediaAsset = 0x86521D6C,
        IesResource = 0x0DEAFE10,
        PamReplayResource = 0xC664A660,

        // FIFA Additions
        EAClothEntityData = 0x85EA8656,
        EAClothAssetData = 0x85AC783D,
        PSDResource = 0x3B9D1688,
        BundleRefTableResource = 0x428EC9D4,
        FifaPhysicsResourceData = 0xEF23407C,
        MorphTargetsResource = 0x1091C8C5,
        NewWaveResource = 0xB2C465F6,
    }
}
