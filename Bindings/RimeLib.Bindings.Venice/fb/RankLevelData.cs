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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class RankLevelData : 
		DataContainer
	{
		protected string m_RankName = string.Empty;
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1737773492)]
		public string RankName { get { return m_RankName; } set { if (OnPropertyChanging("RankLevelData." + nameof(RankName), this, m_RankName, value)) m_RankName = value; } } // 0x8 (8)
		
		protected uint m_PointsNeeded = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(4136222257)]
		public uint PointsNeeded { get { return m_PointsNeeded; } set { if (OnPropertyChanging("RankLevelData." + nameof(PointsNeeded), this, m_PointsNeeded, value)) m_PointsNeeded = value; } } // 0xC (12)
		
		protected string m_ImageName = string.Empty;
		[ContainerField(16), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2678981541)]
		public string ImageName { get { return m_ImageName; } set { if (OnPropertyChanging("RankLevelData." + nameof(ImageName), this, m_ImageName, value)) m_ImageName = value; } } // 0x10 (16)
		
		protected string m_IconName = string.Empty;
		[ContainerField(20), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(268503081)]
		public string IconName { get { return m_IconName; } set { if (OnPropertyChanging("RankLevelData." + nameof(IconName), this, m_IconName, value)) m_IconName = value; } } // 0x14 (20)
		
		protected string m_SoundName = string.Empty;
		[ContainerField(24), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(523979073)]
		public string SoundName { get { return m_SoundName; } set { if (OnPropertyChanging("RankLevelData." + nameof(SoundName), this, m_SoundName, value)) m_SoundName = value; } } // 0x18 (24)
		
		protected List<BasicUnlockInfo> m_UnlockInfos = new List<BasicUnlockInfo>();
		[ContainerField(28), MemberInfoFlag(65), ContainerFieldNameHash(4145033000), ContainerArray]
		public List<BasicUnlockInfo> UnlockInfos { get { return m_UnlockInfos; } set { if (OnPropertyChanging("RankLevelData." + nameof(UnlockInfos), this, m_UnlockInfos, value)) m_UnlockInfos = value; } } // 0x1C (28)
		
		protected int m_RankNumber = new int();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2626293584)]
		public int RankNumber { get { return m_RankNumber; } set { if (OnPropertyChanging("RankLevelData." + nameof(RankNumber), this, m_RankNumber, value)) m_RankNumber = value; } } // 0x20 (32)
		
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
