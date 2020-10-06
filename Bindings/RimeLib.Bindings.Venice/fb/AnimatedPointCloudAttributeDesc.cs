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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(12), ContainerStruct]
	public class AnimatedPointCloudAttributeDesc : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(137)]
		public PointCloudAttributeUsage Usage { get; set; } = new PointCloudAttributeUsage(); // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(137)]
		public PointCloudAttributeQuantization IFrameQuantization { get; set; } = new PointCloudAttributeQuantization(); // 0x4 (4)
		
		[ContainerField(8), MemberInfoFlag(137)]
		public PointCloudAttributeQuantization DFrameQuantization { get; set; } = new PointCloudAttributeQuantization(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 219072544:
						Usage = (PointCloudAttributeUsage) Enum.ToObject(typeof(PointCloudAttributeUsage), p_Value);
					break;

				case 616209600:
						IFrameQuantization = (PointCloudAttributeQuantization) Enum.ToObject(typeof(PointCloudAttributeQuantization), p_Value);
					break;

				case 2409914605:
						DFrameQuantization = (PointCloudAttributeQuantization) Enum.ToObject(typeof(PointCloudAttributeQuantization), p_Value);
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
				case 219072544:
					return Usage;

				case 616209600:
					return IFrameQuantization;

				case 2409914605:
					return DFrameQuantization;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 219072544:
					return typeof(AnimatedPointCloudAttributeDesc).GetProperty(nameof(Usage));

				case 616209600:
					return typeof(AnimatedPointCloudAttributeDesc).GetProperty(nameof(IFrameQuantization));

				case 2409914605:
					return typeof(AnimatedPointCloudAttributeDesc).GetProperty(nameof(DFrameQuantization));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
