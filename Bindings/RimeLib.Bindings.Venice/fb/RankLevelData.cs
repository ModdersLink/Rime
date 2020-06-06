///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class RankLevelData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string RankName { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint PointsNeeded { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string ImageName { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string IconName { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string SoundName { get; set; } // 0x18 (24)
		
		[ContainerField(28)]
		public List<BasicUnlockInfo> UnlockInfos { get; set; } = new List<BasicUnlockInfo>(); // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public int RankNumber { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1737773492:
					RankName = (string) p_Value;
					break;

				case 4136222257:
					PointsNeeded = (uint) p_Value;
					break;

				case 2678981541:
					ImageName = (string) p_Value;
					break;

				case 268503081:
					IconName = (string) p_Value;
					break;

				case 523979073:
					SoundName = (string) p_Value;
					break;

				case 4145033000:
					UnlockInfos = (List<BasicUnlockInfo>) p_Value;
					break;

				case 2626293584:
					RankNumber = (int) p_Value;
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
				case 1737773492:
					return RankName;

				case 4136222257:
					return PointsNeeded;

				case 2678981541:
					return ImageName;

				case 268503081:
					return IconName;

				case 523979073:
					return SoundName;

				case 4145033000:
					return UnlockInfos;

				case 2626293584:
					return RankNumber;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1737773492:
					return typeof(RankLevelData).GetProperty(nameof(RankName));

				case 4136222257:
					return typeof(RankLevelData).GetProperty(nameof(PointsNeeded));

				case 2678981541:
					return typeof(RankLevelData).GetProperty(nameof(ImageName));

				case 268503081:
					return typeof(RankLevelData).GetProperty(nameof(IconName));

				case 523979073:
					return typeof(RankLevelData).GetProperty(nameof(SoundName));

				case 4145033000:
					return typeof(RankLevelData).GetProperty(nameof(UnlockInfos));

				case 2626293584:
					return typeof(RankLevelData).GetProperty(nameof(RankNumber));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
