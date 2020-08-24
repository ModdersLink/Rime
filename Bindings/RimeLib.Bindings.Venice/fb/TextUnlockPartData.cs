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
	public class TextUnlockPartData : 
		DataContainer
	{
		protected string m_ShaderNodeName = string.Empty;
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(4213969131)]
		public string ShaderNodeName { get { return m_ShaderNodeName; } set { if (OnPropertyChanging("TextUnlockPartData." + nameof(ShaderNodeName), this, m_ShaderNodeName, value)) m_ShaderNodeName = value; } } // 0x8 (8)
		
		protected CtrRef<ObjectBlueprint> m_MeshBlueprint = new CtrRef<ObjectBlueprint>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(1662348825), ContainerCtrRef]
		public CtrRef<ObjectBlueprint> MeshBlueprint { get { return m_MeshBlueprint; } set { if (OnPropertyChanging("TextUnlockPartData." + nameof(MeshBlueprint), this, m_MeshBlueprint, value)) m_MeshBlueprint = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4213969131:
					ShaderNodeName = (string) p_Value;
					break;

				case 1662348825:
					MeshBlueprint = (CtrRef<ObjectBlueprint>) p_Value;
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
				case 4213969131:
					return ShaderNodeName;

				case 1662348825:
					return MeshBlueprint;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4213969131:
					return typeof(TextUnlockPartData).GetProperty(nameof(ShaderNodeName));

				case 1662348825:
					return typeof(TextUnlockPartData).GetProperty(nameof(MeshBlueprint));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
