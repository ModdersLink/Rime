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
	public class SoundStateEntityData : 
		EntityData
	{
		protected CtrRef<SoundState> m_SoundState = new CtrRef<SoundState>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(123875281), ContainerCtrRef]
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
