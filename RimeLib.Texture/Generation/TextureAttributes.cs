namespace RimeLib.Texture.Generation;

public record TextureAttributes
{
    public string Name { get; init; } = default!;
    public string TextureGroup { get; set; } = "Default";
}
