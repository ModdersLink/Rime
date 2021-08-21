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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class AnimationSpawnTemplate : 
		DataContainer
	{
		protected CtrRef<AntEnumeration> m_RunStyle = new CtrRef<AntEnumeration>();
		[ContainerField(Name: "RunStyle", Offset: 8, NameHash: 1984199259, Flags: 53)]
		public CtrRef<AntEnumeration> RunStyle { get { return m_RunStyle; } set { if (OnPropertyChanging("AnimationSpawnTemplate." + nameof(RunStyle), this, m_RunStyle, value)) m_RunStyle = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1984199259:
					RunStyle = (CtrRef<AntEnumeration>) p_Value;
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
				case 1984199259:
					return RunStyle;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1984199259:
					return typeof(AnimationSpawnTemplate).GetProperty(nameof(RunStyle));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
