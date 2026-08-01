namespace RimeLib.Texture.Generation;

public record TextureAttributes
{
    public string Name { get; init; } = default!;
    public string TextureGroup { get; set; } = "Default";
    public bool SrgbGamma { get; set; } = false;
    // Set false to generate the texture fully resident, with every mip in its own chunk and no
    // Streaming flag. A texture delivered self-contained in a mod bundle needs this: the engine's
    // streaming pool has no high-res mips for it, so only the small resident ones would load.
    public bool Streaming { get; set; } = true;

    // Use the NormalDXT1 and DXN formats, which reconstruct normals correctly.
    public bool IsNormalMap { get; set; } = false;
}
