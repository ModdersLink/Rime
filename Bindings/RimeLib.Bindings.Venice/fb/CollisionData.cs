///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 16)]
	public class CollisionData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<ValueAtX> DamageAtVerticalVelocity { get; set; } = new();

		[ContainerField(12)]
		public List<ValueAtX> DamageAtHorizVelocity { get; set; } = new();

		public static void Deserialize(CollisionData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DamageAtVerticalVelocity.Clear();
			(RimeReader Reader, uint Count) s_DamageAtVerticalVelocity = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_DamageAtVerticalVelocity.Count; ++i)
			{
				var s_Value = new ValueAtX();
				fb.ValueAtX.Deserialize(s_Value, s_DamageAtVerticalVelocity.Reader, p_Parser);
				p_Instance.DamageAtVerticalVelocity.Add(s_Value);
			}
			
			s_DamageAtVerticalVelocity.Reader.Dispose();
			p_Instance.DamageAtHorizVelocity.Clear();
			(RimeReader Reader, uint Count) s_DamageAtHorizVelocity = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_DamageAtHorizVelocity.Count; ++i)
			{
				var s_Value = new ValueAtX();
				fb.ValueAtX.Deserialize(s_Value, s_DamageAtHorizVelocity.Reader, p_Parser);
				p_Instance.DamageAtHorizVelocity.Add(s_Value);
			}
			
			s_DamageAtHorizVelocity.Reader.Dispose();
		}

	}
}
