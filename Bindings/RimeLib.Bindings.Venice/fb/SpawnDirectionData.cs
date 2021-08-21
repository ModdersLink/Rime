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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 64)]
	public class SpawnDirectionData : 
		ProcessorData
	{
		protected float m_DirectionFromEmitterOrigin = new float();
		[ContainerField(Name: "DirectionFromEmitterOrigin", Offset: 48, NameHash: 657561364, Flags: 49469), LayoutImmutable, Blittable]
		public float DirectionFromEmitterOrigin { get { return m_DirectionFromEmitterOrigin; } set { if (OnPropertyChanging("SpawnDirectionData." + nameof(DirectionFromEmitterOrigin), this, m_DirectionFromEmitterOrigin, value)) m_DirectionFromEmitterOrigin = value; } } // 0x30 (48)
		
		protected bool m_InheritSpeedAndDirectionFromEmitter = new bool();
		[ContainerField(Name: "InheritSpeedAndDirectionFromEmitter", Offset: 52, NameHash: 1871208809, Flags: 49325), LayoutImmutable, Blittable]
		public bool InheritSpeedAndDirectionFromEmitter { get { return m_InheritSpeedAndDirectionFromEmitter; } set { if (OnPropertyChanging("SpawnDirectionData." + nameof(InheritSpeedAndDirectionFromEmitter), this, m_InheritSpeedAndDirectionFromEmitter, value)) m_InheritSpeedAndDirectionFromEmitter = value; } } // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 657561364:
					DirectionFromEmitterOrigin = (float) p_Value;
					break;

				case 1871208809:
					InheritSpeedAndDirectionFromEmitter = (bool) p_Value;
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
				case 657561364:
					return DirectionFromEmitterOrigin;

				case 1871208809:
					return InheritSpeedAndDirectionFromEmitter;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 657561364:
					return typeof(SpawnDirectionData).GetProperty(nameof(DirectionFromEmitterOrigin));

				case 1871208809:
					return typeof(SpawnDirectionData).GetProperty(nameof(InheritSpeedAndDirectionFromEmitter));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
