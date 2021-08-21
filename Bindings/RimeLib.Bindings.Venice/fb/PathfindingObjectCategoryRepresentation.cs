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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class PathfindingObjectCategoryRepresentation : FrostbiteContainer
	{
		[ContainerField(Name: "Category", Offset: 0, NameHash: 3455858997, Flags: 53)]
		public CtrRef<PathfindingObjectCategoryAsset> Category { get; set; } = new CtrRef<PathfindingObjectCategoryAsset>(); // 0x0 (0)
		
		[ContainerField(Name: "Representation", Offset: 4, NameHash: 1809320132, Flags: 137)]
		public PathfindingRepresentation Representation { get; set; } = new PathfindingRepresentation(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3455858997:
					Category = (CtrRef<PathfindingObjectCategoryAsset>) p_Value;
					break;

				case 1809320132:
						Representation = (PathfindingRepresentation) Enum.ToObject(typeof(PathfindingRepresentation), p_Value);
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
				case 3455858997:
					return Category;

				case 1809320132:
					return Representation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3455858997:
					return typeof(PathfindingObjectCategoryRepresentation).GetProperty(nameof(Category));

				case 1809320132:
					return typeof(PathfindingObjectCategoryRepresentation).GetProperty(nameof(Representation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
