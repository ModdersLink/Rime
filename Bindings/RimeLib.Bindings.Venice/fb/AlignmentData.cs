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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class AlignmentData : 
		DataContainer
	{
		protected EntryInputActionEnum m_AlignAction = new EntryInputActionEnum();
		[ContainerField(Name: "AlignAction", Offset: 8, NameHash: 2810627638, Flags: 137)]
		public EntryInputActionEnum AlignAction { get { return m_AlignAction; } set { if (OnPropertyChanging("AlignmentData." + nameof(AlignAction), this, m_AlignAction, value)) m_AlignAction = value; } } // 0x8 (8)
		
		protected float m_StopTolerance = new float();
		[ContainerField(Name: "StopTolerance", Offset: 12, NameHash: 3127075412, Flags: 49469), LayoutImmutable, Blittable]
		public float StopTolerance { get { return m_StopTolerance; } set { if (OnPropertyChanging("AlignmentData." + nameof(StopTolerance), this, m_StopTolerance, value)) m_StopTolerance = value; } } // 0xC (12)
		
		protected float m_Speed = new float();
		[ContainerField(Name: "Speed", Offset: 16, NameHash: 230887042, Flags: 49469), LayoutImmutable, Blittable]
		public float Speed { get { return m_Speed; } set { if (OnPropertyChanging("AlignmentData." + nameof(Speed), this, m_Speed, value)) m_Speed = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2810627638:
					AlignAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 3127075412:
					StopTolerance = (float) p_Value;
					break;

				case 230887042:
					Speed = (float) p_Value;
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
				case 2810627638:
					return AlignAction;

				case 3127075412:
					return StopTolerance;

				case 230887042:
					return Speed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2810627638:
					return typeof(AlignmentData).GetProperty(nameof(AlignAction));

				case 3127075412:
					return typeof(AlignmentData).GetProperty(nameof(StopTolerance));

				case 230887042:
					return typeof(AlignmentData).GetProperty(nameof(Speed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
