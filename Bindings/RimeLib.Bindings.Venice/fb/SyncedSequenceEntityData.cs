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
	public class SyncedSequenceEntityData : 
		SequenceEntityData
	{
		protected bool m_InterpolateTime = new bool();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(500083415)]
		public bool InterpolateTime { get { return m_InterpolateTime; } set { if (OnPropertyChanging("SyncedSequenceEntityData." + nameof(InterpolateTime), this, m_InterpolateTime, value)) m_InterpolateTime = value; } } // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 500083415:
					InterpolateTime = (bool) p_Value;
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
				case 500083415:
					return InterpolateTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 500083415:
					return typeof(SyncedSequenceEntityData).GetProperty(nameof(InterpolateTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
