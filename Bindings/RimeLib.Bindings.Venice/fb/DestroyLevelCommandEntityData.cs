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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class DestroyLevelCommandEntityData : 
		GameEntityData
	{
		protected uint m_InstanceCountDestroyedPerFrame = new uint();
		[ContainerField(Name: "InstanceCountDestroyedPerFrame", Offset: 96, NameHash: 961630582, Flags: 49421), LayoutImmutable, Blittable]
		public uint InstanceCountDestroyedPerFrame { get { return m_InstanceCountDestroyedPerFrame; } set { if (OnPropertyChanging("DestroyLevelCommandEntityData." + nameof(InstanceCountDestroyedPerFrame), this, m_InstanceCountDestroyedPerFrame, value)) m_InstanceCountDestroyedPerFrame = value; } } // 0x60 (96)
		
		protected uint m_DestroyDelay = new uint();
		[ContainerField(Name: "DestroyDelay", Offset: 100, NameHash: 3844272786, Flags: 49421), LayoutImmutable, Blittable]
		public uint DestroyDelay { get { return m_DestroyDelay; } set { if (OnPropertyChanging("DestroyLevelCommandEntityData." + nameof(DestroyDelay), this, m_DestroyDelay, value)) m_DestroyDelay = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 961630582:
					InstanceCountDestroyedPerFrame = (uint) p_Value;
					break;

				case 3844272786:
					DestroyDelay = (uint) p_Value;
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
				case 961630582:
					return InstanceCountDestroyedPerFrame;

				case 3844272786:
					return DestroyDelay;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 961630582:
					return typeof(DestroyLevelCommandEntityData).GetProperty(nameof(InstanceCountDestroyedPerFrame));

				case 3844272786:
					return typeof(DestroyLevelCommandEntityData).GetProperty(nameof(DestroyDelay));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
