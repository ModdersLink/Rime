// Resources.
Texture2D g_Buffer0 : register(t0); // Normal
Texture2D g_Buffer1 : register(t1); // Diffuse
Texture2D g_Buffer2 : register(t2); // ??
Texture2D g_Buffer3 : register(t3); // ??

// Samplers.
SamplerState Sampler0 : register(s0);

// Globals.
float3 lightDirection;

struct VertexOutput
{
    float4 position : SV_POSITION;
    float2 texcoord0 : TEXCOORD0;
};

VertexOutput VS(float4 position : POSITION, float2 texcoord : TEXCOORD0)
{
    VertexOutput output;

	// Pass the position and texcoord through to the pixel shader.
    output.position = position;
    output.texcoord0 = texcoord;

    return output;
}

float4 PS(VertexOutput I) : SV_Target
{
    float4 colors;
    float4 normals;
    float3 lightDir;
    float lightIntensity;
    float4 outputColor;

    // Sample the colors from the color render texture using the point sampler at this texture coordinate location.
    colors = g_Buffer1.Sample(Sampler0, I.texcoord0);
    colors.w = 1.0f;

    // Sample the normals from the normal render texture using the point sampler at this texture coordinate location.
    normals = g_Buffer0.Sample(Sampler0, I.texcoord0);
    normals.w = 1.0f;

    // Calculate the amount of light on this pixel.
    lightIntensity = saturate(dot(normals.xyz, lightDirection));

    // Determine the final amount of diffuse color based on the color of the pixel combined with the light intensity.
    outputColor = saturate(colors * lightIntensity);

    return outputColor;
}
