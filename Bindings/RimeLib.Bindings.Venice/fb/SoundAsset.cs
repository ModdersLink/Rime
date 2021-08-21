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
	public class SoundAsset : 
		Asset
	{
		protected CtrRef<SoundScopeData> m_Scope = new CtrRef<SoundScopeData>();
		[ContainerField(Name: "Scope", Offset: 12, NameHash: 231225103, Flags: 53)]
		public CtrRef<SoundScopeData> Scope { get { return m_Scope; } set { if (OnPropertyChanging("SoundAsset." + nameof(Scope), this, m_Scope, value)) m_Scope = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231225103:
					Scope = (CtrRef<SoundScopeData>) p_Value;
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
				case 231225103:
					return Scope;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 231225103:
					return typeof(SoundAsset).GetProperty(nameof(Scope));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
