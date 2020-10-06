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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(12), ContainerClass]
	public class CreateDestructionVolumeParams : 
		DataContainer
	{
		protected string m_AssetName = string.Empty;
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(3654276786)]
		public string AssetName { get { return m_AssetName; } set { if (OnPropertyChanging("CreateDestructionVolumeParams." + nameof(AssetName), this, m_AssetName, value)) m_AssetName = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3654276786:
					AssetName = (string) p_Value;
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
				case 3654276786:
					return AssetName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3654276786:
					return typeof(CreateDestructionVolumeParams).GetProperty(nameof(AssetName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
