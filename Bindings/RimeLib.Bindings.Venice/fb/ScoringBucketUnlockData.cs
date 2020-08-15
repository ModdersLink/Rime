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
	public class ScoringBucketUnlockData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public uint PointsNeeded { get; set; } // 0x0 (0)
		
		[ContainerField(4)]
		public BasicUnlockInfo UnlockInfo { get; set; } = new BasicUnlockInfo(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4136222257:
					PointsNeeded = (uint) p_Value;
					break;

				case 1036660731:
					UnlockInfo = (BasicUnlockInfo) p_Value;
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
				case 4136222257:
					return PointsNeeded;

				case 1036660731:
					return UnlockInfo;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4136222257:
					return typeof(ScoringBucketUnlockData).GetProperty(nameof(PointsNeeded));

				case 1036660731:
					return typeof(ScoringBucketUnlockData).GetProperty(nameof(UnlockInfo));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
