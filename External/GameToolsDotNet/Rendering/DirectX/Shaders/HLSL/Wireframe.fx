
cbuffer CameraShaderConstants : register(b0)
{
	float4x4 gWorldViewProjectionMatrix;
};

struct VOut
{
	float4 position : SV_POSITION;
	float4 color : COLOR0;
};

VOut VShader(float4 position : POSITION0, float4 color : COLOR0)
{
	VOut output;

	output.position = mul(position, gWorldViewProjectionMatrix);
	output.color = color;

	return output;
}


float4 PShader(VOut I) : SV_TARGET
{
	return I.color;
}