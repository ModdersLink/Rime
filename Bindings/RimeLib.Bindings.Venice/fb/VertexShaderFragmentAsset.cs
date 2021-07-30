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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class VertexShaderFragmentAsset : 
		Asset
	{
		protected FileRef m_SourceFile = new FileRef();
		[ContainerField(Name: "SourceFile", Offset: 12, NameHash: 1522844286, Flags: 16541), LayoutImmutable]
		public FileRef SourceFile { get { return m_SourceFile; } set { if (OnPropertyChanging("VertexShaderFragmentAsset." + nameof(SourceFile), this, m_SourceFile, value)) m_SourceFile = value; } } // 0xC (12)
		
		protected string m_Function = string.Empty;
		[ContainerField(Name: "Function", Offset: 16, NameHash: 4136871687, Flags: 16509), LayoutImmutable]
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
