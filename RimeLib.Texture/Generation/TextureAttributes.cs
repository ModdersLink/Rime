namespace RimeLib.Texture.Generation;

public record TextureAttributes
{
    public string Name { get; init; } = default!;
    public string TextureGroup { get; set; } = "Default";
    public bool SrgbGamma { get; set; } = false;
    // When false, the texture is generated FULLY RESIDENT (all mips in its own chunk, no Streaming flag).
    // Required when the texture is delivered self-contained in a mod bundle (the engine streaming pool
    // won't have the high-res mips) — otherwise only the small resident mips load (pale) or none (black).
    public bool Streaming { get; set; } = true;
    // When true, use the Frostbite NormalDXT1/DXN normal-map formats (correct normal reconstruction).
    public bool IsNormalMap { get; set; } = false;
}
