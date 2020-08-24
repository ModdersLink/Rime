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
	public class CharacterSprintData : 
		DataContainer
	{
		protected float m_SprintPowerDecreasePerSecond = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4236817773)]
		public float SprintPowerDecreasePerSecond { get { return m_SprintPowerDecreasePerSecond; } set { if (OnPropertyChanging("CharacterSprintData." + nameof(SprintPowerDecreasePerSecond), this, m_SprintPowerDecreasePerSecond, value)) m_SprintPowerDecreasePerSecond = value; } } // 0x8 (8)
		
		protected float m_SprintPowerIncreasePerSecond = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3679952971)]
		public float SprintPowerIncreasePerSecond { get { return m_SprintPowerIncreasePerSecond; } set { if (OnPropertyChanging("CharacterSprintData." + nameof(SprintPowerIncreasePerSecond), this, m_SprintPowerIncreasePerSecond, value)) m_SprintPowerIncreasePerSecond = value; } } // 0xC (12)
		
		protected float m_SprintMinimumPower = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2057558894)]
		public float SprintMinimumPower { get { return m_SprintMinimumPower; } set { if (OnPropertyChanging("CharacterSprintData." + nameof(SprintMinimumPower), this, m_SprintMinimumPower, value)) m_SprintMinimumPower = value; } } // 0x10 (16)
		
		protected bool m_AllowContinousSprinting = new bool();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3446677350)]
		public bool AllowContinousSprinting { get { return m_AllowContinousSprinting; } set { if (OnPropertyChanging("CharacterSprintData." + nameof(AllowContinousSprinting), this, m_AllowContinousSprinting, value)) m_AllowContinousSprinting = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4236817773:
					SprintPowerDecreasePerSecond = (float) p_Value;
					break;

				case 3679952971:
					SprintPowerIncreasePerSecond = (float) p_Value;
					break;

				case 2057558894:
					SprintMinimumPower = (float) p_Value;
					break;

				case 3446677350:
					AllowContinousSprinting = (bool) p_Value;
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
				case 4236817773:
					return SprintPowerDecreasePerSecond;

				case 3679952971:
					return SprintPowerIncreasePerSecond;

				case 2057558894:
					return SprintMinimumPower;

				case 3446677350:
					return AllowContinousSprinting;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4236817773:
					return typeof(CharacterSprintData).GetProperty(nameof(SprintPowerDecreasePerSecond));

				case 3679952971:
					return typeof(CharacterSprintData).GetProperty(nameof(SprintPowerIncreasePerSecond));

				case 2057558894:
					return typeof(CharacterSprintData).GetProperty(nameof(SprintMinimumPower));

				case 3446677350:
					return typeof(CharacterSprintData).GetProperty(nameof(AllowContinousSprinting));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
