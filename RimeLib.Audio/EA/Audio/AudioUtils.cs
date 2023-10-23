using System;

namespace RimeLib.Audio.EA.Audio;

public static class AudioUtils
{

	public static float ShortToFloat(short p_Sample)
	{
		return (float)p_Sample / 32768.0f;
	}
	
	public static short FloatToShort(float p_Sample)
	{
		return (short)(p_Sample * 32768.0f);
	}

	public static float[] ScaleSamples(float[] p_Samples, float gain)
	{
		float[] s_Result = new float[p_Samples.Length];
		Array.Copy(p_Samples, s_Result, p_Samples.Length);

		for (var s_Idx = 0; s_Idx < s_Result.Length; s_Idx++)
			s_Result[s_Idx] *= gain;

		return s_Result;
	}
	
	public static short[] ScaleSamples(short[] p_Samples, float gain)
	{
		short[] s_Result = new short[p_Samples.Length];
		Array.Copy(p_Samples, s_Result, p_Samples.Length);

		for (var s_Idx = 0; s_Idx < s_Result.Length; s_Idx++)
			s_Result[s_Idx] = FloatToShort(ShortToFloat(s_Result[s_Idx]) * gain);

		return s_Result;
	}
}