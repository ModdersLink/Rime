using System.Collections.Generic;
using System.IO;
using RimeLib.IO;

namespace RimeLib.Audio.EA.Audio;

public class Xas1
{
	
	private static readonly List<KeyValuePair<float, float>> c_FilterList = new()
	{
		new KeyValuePair<float, float>(0.0f, 0.0f),
		new KeyValuePair<float, float>(0.9375f, 0.0f),
		new KeyValuePair<float, float>(1.796875f, -0.8125f),
		new KeyValuePair<float, float>(1.53125f, -0.8125f),
	};
	
	private static readonly List<KeyValuePair<short, short>> c_FilterListShort = new()
	{
		// same as filter above, but multiplied by 256
		new KeyValuePair<short, short>(0, 0),
		new KeyValuePair<short, short>(240, 0),
		new KeyValuePair<short, short>(460, 208),
		new KeyValuePair<short, short>(392, -208),
	};

	private static readonly List<double> c_Curve = new()
	{
		// this is dealing with bad quality floats the further down it goes. 
		// assume every number ends with a 5
		// possibly recompute with higher presicion? seems to just be "(1/8)/pow(2, index)" 
		// Should probably remove it and do computes live in code

		0.125,
		0.0625, //0.06245, 
		0.03125,
		0.015625,
		0.0078125,
		0.00390625,
		0.001953125,
		0.0009765625,
		0.00048828125,
		0.000244140625,
		0.0001220703125,
		0.00006103515625,
		0.000030517578125,
		0.0000152587890625, // 0.0,
		0.00000762939453125, // 0.0,
		0.000003814697265625, // ga
	};


	static void EncodeBlock(float[] p_Source, RimeWriter p_Writer)
	{
		float[] s_ScaledAndEncoded = new float[p_Source.Length];

		for (var i = 0; i < p_Source.Length; i++)
			s_ScaledAndEncoded[i] = System.Math.Clamp(p_Source[i] * 32767.0f, -30718.0f, 30718.0f);


		uint s_Sample0Int = (uint)(s_ScaledAndEncoded[0] + 8) & 0xFFFFFFFF;
		uint s_Sample1Int = (uint)(s_ScaledAndEncoded[1] + 8) & 0xFFFFFFFF;

		int s_EncodeFilterId = 0;
		
		
		// Do basic encoding to get error 
		float s_MinError = float.MinValue;
		float[] s_MaxError = new float[c_FilterList.Count];
		for (var s_FilterIdx = 0; s_FilterIdx < c_FilterList.Count; s_FilterIdx++)
		{
			var s_Filter = c_FilterList[s_FilterIdx];
			
			
			s_MaxError[s_FilterIdx] = 0.0f;
			
			var s_CurrentSample0Int = s_Sample0Int;
			var s_CurrentSample1Int = s_Sample1Int;

			for (var i = 2; i < 32; i++)
			{
				float s_Base = s_ScaledAndEncoded[i];

				float s_Encoded = s_Base + s_Filter.Key * (float)s_CurrentSample1Int +
				                  s_Filter.Value * (float)s_CurrentSample0Int;

				s_Encoded = System.Math.Abs(s_Encoded);

				if (s_Encoded >= s_MaxError[s_FilterIdx])
					s_MaxError[s_FilterIdx] = s_Encoded;

				s_CurrentSample0Int = s_CurrentSample1Int;
				s_CurrentSample1Int = (uint)s_Base;
			}

			if (s_MinError > s_MaxError[s_FilterIdx])
			{
				s_MinError = s_MaxError[s_FilterIdx];
				s_EncodeFilterId = s_FilterIdx;
			}

			if (s_FilterIdx == 0 && s_MaxError[s_FilterIdx] >= 7.0f)
			{
				s_EncodeFilterId = 0;
				break;
			}
		}
		
		// Get float error
		var s_EncodeErrorId = 0;
		var s_ErrorMask = 0x4000;
		for (var i = 0; i < 12; i++, s_ErrorMask >>= 1)
		{
			if ((((int)s_MaxError[i] + (s_ErrorMask >> 3)) & s_ErrorMask) == 0)
				continue;

			s_EncodeErrorId = i;
			break;
		}

		var s_EncodeFilter = c_FilterList[s_EncodeFilterId];
		
		var s_Header0 = (s_Sample0Int | (uint)s_EncodeFilterId);
		var s_Header1 = (s_Sample1Int | (uint)s_EncodeErrorId);
		p_Writer.WriteByte((byte)(s_Header0 & 0xFF));
		p_Writer.WriteByte((byte)((s_Header0 >> 8) & 0xFF));
		p_Writer.WriteByte((byte)(s_Header1 & 0xFF));
		p_Writer.WriteByte((byte)((s_Header1 >> 8) & 0xFF));
		
		//TODO: Finish encoder

		for (var s_I = 2; s_I < 32; s_I++)
		{
			// does some clipping stuff
		}
	}

	static short DecodePair(RimeReader p_Reader, out int s_FilterIndex)
	{
		var s_Byte0 = p_Reader.ReadByte();
		var s_Byte1 = p_Reader.ReadByte();

		s_FilterIndex = s_Byte0 & 0xF;

		return (short)((s_Byte1 << 8) | (s_Byte0 & 0xF0));
	}

	public static float[] DecodeChannel(RimeReader p_Reader)
	{
		const int c_SectionSize = 32; // 32 samples per section

		float[] s_Samples = new float[c_SectionSize * 4];

		var s_IndexList = new List<KeyValuePair<int, int>>();

		for (var i = 0; i < 4; i++)
		{
			s_Samples[c_SectionSize*i + 0] = AudioUtils.ShortToFloat(DecodePair(p_Reader, out var s_FilterIdx));
			s_Samples[c_SectionSize*i + 1] = AudioUtils.ShortToFloat(DecodePair(p_Reader, out var s_LutIdx));
			
			s_IndexList.Add(new KeyValuePair<int, int>(s_FilterIdx, s_LutIdx));
		}

		//int s_SrcIdx = 2*2*4;
		//int s_OutIdx = 0;

		for (var i = 0; i < 15; i++)
		{
			int s_OutIdx = 2 * i;
			for (var j = 0; j < 4; j++)
			{
				var s_FilterParams = s_IndexList[j];
				// Game has a bug here, doesnt clamp it to 3 for array index
				var s_Filter = c_FilterList[s_FilterParams.Key];
				
				var s_SampleByte = p_Reader.ReadByte();

				byte s_Sample1Byte = (byte)(s_SampleByte >> 4);
				if ((s_Sample1Byte & 0x8) != 0)
					s_Sample1Byte |= 0xF0;
				
				byte s_Sample2Byte = (byte)(s_SampleByte & 0xF);
				if ((s_Sample2Byte & 0x8) != 0)
					s_Sample2Byte |= 0xF0;

				
				// Game ahs a bug here, doesmt clamp value to 14 for array index
				float s_Base1 = (float)((double)((sbyte)s_Sample1Byte) / 8.0 / System.Math.Pow(2, s_FilterParams.Value));
				float s_Base2 = (float)((double)((sbyte)s_Sample2Byte) / 8.0 / System.Math.Pow(2, s_FilterParams.Value));
				
				float s_LastSample1 =  s_Samples[j*c_SectionSize + s_OutIdx + 0];
				float s_LastSample2 =  s_Samples[j*c_SectionSize + s_OutIdx + 1];
				
				float s_Sample1 = s_Base1 + s_Filter.Key * s_LastSample2 + s_Filter.Value * s_LastSample1;
				float s_Sample2 = s_Base2 + s_Filter.Key * s_Sample1     + s_Filter.Value * s_LastSample2;

				s_Samples[j * c_SectionSize + s_OutIdx + 2] = s_Sample1;
				s_Samples[j * c_SectionSize + s_OutIdx + 3] = s_Sample2;
			}
		}

		return s_Samples;
	}
	
	public static short[] DecodeChannelShorts(RimeReader p_Reader)
	{
		const int c_SectionSize = 32; // 32 samples per section

		short[] s_Samples = new short[c_SectionSize * 4];

		var s_IndexList = new List<KeyValuePair<int, int>>();

		for (var i = 0; i < 4; i++)
		{
			s_Samples[c_SectionSize*i + 0] = DecodePair(p_Reader, out var s_FilterIdx);
			s_Samples[c_SectionSize*i + 1] = DecodePair(p_Reader, out var s_LutIdx);
			
			s_IndexList.Add(new KeyValuePair<int, int>(s_FilterIdx, s_LutIdx));
		}

		//int s_SrcIdx = 2*2*4;
		//int s_OutIdx = 0;

		for (var i = 0; i < 15; i++)
		{
			int s_OutIdx = 2 * i;
			for (var j = 0; j < 4; j++)
			{
				var s_FilterParams = s_IndexList[j];
				// Game has a bug here, doesnt clamp it to 3 for array index
				var s_Filter = c_FilterListShort[s_FilterParams.Key];
				
				var s_SampleByte = p_Reader.ReadByte();

				byte s_Sample1Byte = (byte)(s_SampleByte >> 4);
				if ((s_Sample1Byte & 0x8) != 0)
					s_Sample1Byte |= 0xF0;
				
				byte s_Sample2Byte = (byte)(s_SampleByte & 0xF);
				if ((s_Sample2Byte & 0x8) != 0)
					s_Sample2Byte |= 0xF0;

				
				int s_Base1 = ((int)((sbyte)s_Sample1Byte) * (1 << (20 - s_FilterParams.Value)));
				int s_Base2 = ((int)((sbyte)s_Sample2Byte) * (1 << (20 - s_FilterParams.Value)));
				
				int s_LastSample1 =  s_Samples[j*c_SectionSize + s_OutIdx + 0];
				int s_LastSample2 =  s_Samples[j*c_SectionSize + s_OutIdx + 1];
				
				int s_Sample1 = s_Base1 + s_Filter.Key * s_LastSample2 + s_Filter.Value * s_LastSample1;
				int s_Sample2 = s_Base2 + s_Filter.Key * s_Sample1     + s_Filter.Value * s_LastSample2;

				s_Samples[j * c_SectionSize + s_OutIdx + 2] = (short)((s_Sample1 + 0x80) >> 8);
				s_Samples[j * c_SectionSize + s_OutIdx + 3] = (short)((s_Sample2 + 0x80) >> 8);
			}
		}

		return s_Samples;
	}
}
