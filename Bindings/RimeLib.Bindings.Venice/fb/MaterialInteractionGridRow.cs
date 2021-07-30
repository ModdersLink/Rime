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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 4)]
	public class MaterialInteractionGridRow : FrostbiteContainer
	{
		[ContainerField(Name: "Items", Offset: 0, NameHash: 215446531, Flags: 65)]
		public List<MaterialRelationPropertyPair> Items { get; set; } = new List<MaterialRelationPropertyPair>(); // 0x0 (0)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 215446531:
					Items = (List<MaterialRelationPropertyPair>) p_Value;
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
				case 215446531:
					return Items;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 215446531:
					return typeof(MaterialInteractionGridRow).GetProperty(nameof(Items));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
