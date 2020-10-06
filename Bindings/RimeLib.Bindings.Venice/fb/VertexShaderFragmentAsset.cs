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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(20), ContainerClass]
	public class VertexShaderFragmentAsset : 
		Asset
	{
		protected FileRef m_SourceFile = new FileRef();
		[ContainerField(12), LayoutImmutable, MemberInfoFlag(16541), ContainerFieldNameHash(1522844286)]
		public FileRef SourceFile { get { return m_SourceFile; } set { if (OnPropertyChanging("VertexShaderFragmentAsset." + nameof(SourceFile), this, m_SourceFile, value)) m_SourceFile = value; } } // 0xC (12)
		
		protected string m_Function = string.Empty;
		[ContainerField(16), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(4136871687)]
		public string Function { get { return m_Function; } set { if (OnPropertyChanging("VertexShaderFragmentAsset." + nameof(Function), this, m_Function, value)) m_Function = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1522844286:
					SourceFile = (FileRef) p_Value;
					break;

				case 4136871687:
					Function = (string) p_Value;
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
				case 1522844286:
					return SourceFile;

				case 4136871687:
					return Function;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1522844286:
					return typeof(VertexShaderFragmentAsset).GetProperty(nameof(SourceFile));

				case 4136871687:
					return typeof(VertexShaderFragmentAsset).GetProperty(nameof(Function));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
