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
	public class UICombatAreaEntityData : 
		GameObjectData
	{
		protected CtrRef<UICombatAreaAsset> m_Asset = new CtrRef<UICombatAreaAsset>();
		[ContainerField(Name: "Asset", Offset: 12, NameHash: 205976053, Flags: 53)]
		public CtrRef<UICombatAreaAsset> Asset { get { return m_Asset; } set { if (OnPropertyChanging("UICombatAreaEntityData." + nameof(Asset), this, m_Asset, value)) m_Asset = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 205976053:
					Asset = (CtrRef<UICombatAreaAsset>) p_Value;
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
				case 205976053:
					return Asset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 205976053:
					return typeof(UICombatAreaEntityData).GetProperty(nameof(Asset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
