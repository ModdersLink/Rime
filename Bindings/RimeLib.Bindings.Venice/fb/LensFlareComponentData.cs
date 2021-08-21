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
	public class LensFlareComponentData : 
		ComponentData
	{
		protected CtrRef<LensFlareEntityData> m_LensFlare = new CtrRef<LensFlareEntityData>();
		[ContainerField(Name: "LensFlare", Offset: 96, NameHash: 890070093, Flags: 53)]
		public CtrRef<LensFlareEntityData> LensFlare { get { return m_LensFlare; } set { if (OnPropertyChanging("LensFlareComponentData." + nameof(LensFlare), this, m_LensFlare, value)) m_LensFlare = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 890070093:
					LensFlare = (CtrRef<LensFlareEntityData>) p_Value;
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
				case 890070093:
					return LensFlare;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 890070093:
					return typeof(LensFlareComponentData).GetProperty(nameof(LensFlare));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
