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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class SyncAnimationsEntityData : 
		EntityData
	{
		protected float m_ExternalTime = new float();
		[ContainerField(Name: "ExternalTime", Offset: 12, NameHash: 2162678253, Flags: 49469), LayoutImmutable, Blittable]
		public float ExternalTime { get { return m_ExternalTime; } set { if (OnPropertyChanging("SyncAnimationsEntityData." + nameof(ExternalTime), this, m_ExternalTime, value)) m_ExternalTime = value; } } // 0xC (12)
		
		protected float m_NearEndEventTime = new float();
		[ContainerField(Name: "NearEndEventTime", Offset: 16, NameHash: 960001067, Flags: 49469), LayoutImmutable, Blittable]
		public float NearEndEventTime { get { return m_NearEndEventTime; } set { if (OnPropertyChanging("SyncAnimationsEntityData." + nameof(NearEndEventTime), this, m_NearEndEventTime, value)) m_NearEndEventTime = value; } } // 0x10 (16)
		
		protected bool m_StartServerPaused = new bool();
		[ContainerField(Name: "StartServerPaused", Offset: 20, NameHash: 2407205110, Flags: 49325), LayoutImmutable, Blittable]
		public bool StartServerPaused { get { return m_StartServerPaused; } set { if (OnPropertyChanging("SyncAnimationsEntityData." + nameof(StartServerPaused), this, m_StartServerPaused, value)) m_StartServerPaused = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2162678253:
					ExternalTime = (float) p_Value;
					break;

				case 960001067:
					NearEndEventTime = (float) p_Value;
					break;

				case 2407205110:
					StartServerPaused = (bool) p_Value;
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
				case 2162678253:
					return ExternalTime;

				case 960001067:
					return NearEndEventTime;

				case 2407205110:
					return StartServerPaused;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2162678253:
					return typeof(SyncAnimationsEntityData).GetProperty(nameof(ExternalTime));

				case 960001067:
					return typeof(SyncAnimationsEntityData).GetProperty(nameof(NearEndEventTime));

				case 2407205110:
					return typeof(SyncAnimationsEntityData).GetProperty(nameof(StartServerPaused));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
