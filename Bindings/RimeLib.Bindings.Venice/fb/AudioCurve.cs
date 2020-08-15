///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4)]
	public class AudioCurve : FrostbiteContainer
	{
		[ContainerField(0)]
		public List<AudioCurvePoint> Points { get; set; } = new List<AudioCurvePoint>(); // 0x0 (0)
		
		[ContainerField(4)]
		public AudioCurveType CurveType { get; set; } = new AudioCurveType(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3383606106:
					Points = (List<AudioCurvePoint>) p_Value;
					break;

				case 2399916074:
						CurveType = (AudioCurveType) Enum.ToObject(typeof(AudioCurveType), p_Value);
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3383606106:
					return Points;

				case 2399916074:
					return CurveType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3383606106:
					return typeof(AudioCurve).GetProperty(nameof(Points));

				case 2399916074:
					return typeof(AudioCurve).GetProperty(nameof(CurveType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
