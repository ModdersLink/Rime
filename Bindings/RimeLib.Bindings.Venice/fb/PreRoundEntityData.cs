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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(112), ContainerClass]
	public class PreRoundEntityData : 
		GameEntityData
	{
		protected int m_RoundMaxPlayerCount = new int();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3644312963)]
		public int RoundMaxPlayerCount { get { return m_RoundMaxPlayerCount; } set { if (OnPropertyChanging("PreRoundEntityData." + nameof(RoundMaxPlayerCount), this, m_RoundMaxPlayerCount, value)) m_RoundMaxPlayerCount = value; } } // 0x60 (96)
		
		protected uint m_RoundRestartCountdown = new uint();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1048503553)]
		public uint RoundRestartCountdown { get { return m_RoundRestartCountdown; } set { if (OnPropertyChanging("PreRoundEntityData." + nameof(RoundRestartCountdown), this, m_RoundRestartCountdown, value)) m_RoundRestartCountdown = value; } } // 0x64 (100)
		
		protected int m_RoundMinPlayerCount = new int();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1656551901)]
		public int RoundMinPlayerCount { get { return m_RoundMinPlayerCount; } set { if (OnPropertyChanging("PreRoundEntityData." + nameof(RoundMinPlayerCount), this, m_RoundMinPlayerCount, value)) m_RoundMinPlayerCount = value; } } // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3644312963:
					RoundMaxPlayerCount = (int) p_Value;
					break;

				case 1048503553:
					RoundRestartCountdown = (uint) p_Value;
					break;

				case 1656551901:
					RoundMinPlayerCount = (int) p_Value;
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
				case 3644312963:
					return RoundMaxPlayerCount;

				case 1048503553:
					return RoundRestartCountdown;

				case 1656551901:
					return RoundMinPlayerCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3644312963:
					return typeof(PreRoundEntityData).GetProperty(nameof(RoundMaxPlayerCount));

				case 1048503553:
					return typeof(PreRoundEntityData).GetProperty(nameof(RoundRestartCountdown));

				case 1656551901:
					return typeof(PreRoundEntityData).GetProperty(nameof(RoundMinPlayerCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
