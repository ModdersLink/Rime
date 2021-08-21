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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class SoundStateEntityData : 
		EntityData
	{
		protected CtrRef<SoundState> m_SoundState = new CtrRef<SoundState>();
		[ContainerField(Name: "SoundState", Offset: 12, NameHash: 123875281, Flags: 53)]
		public CtrRef<SoundState> SoundState { get { return m_SoundState; } set { if (OnPropertyChanging("SoundStateEntityData." + nameof(SoundState), this, m_SoundState, value)) m_SoundState = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 123875281:
					SoundState = (CtrRef<SoundState>) p_Value;
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
				case 123875281:
					return SoundState;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 123875281:
					return typeof(SoundStateEntityData).GetProperty(nameof(SoundState));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
