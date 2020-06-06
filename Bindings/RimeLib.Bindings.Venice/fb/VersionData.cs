///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class VersionData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string disclaimer { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int Version { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string DateTime { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string BranchId { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable]
		public string GameName { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 33610342:
					disclaimer = (string) p_Value;
					break;

				case 747123679:
					Version = (int) p_Value;
					break;

				case 3244533220:
					DateTime = (string) p_Value;
					break;

				case 2969494588:
					BranchId = (string) p_Value;
					break;

				case 509587500:
					GameName = (string) p_Value;
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
				case 33610342:
					return disclaimer;

				case 747123679:
					return Version;

				case 3244533220:
					return DateTime;

				case 2969494588:
					return BranchId;

				case 509587500:
					return GameName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 33610342:
					return typeof(VersionData).GetProperty(nameof(disclaimer));

				case 747123679:
					return typeof(VersionData).GetProperty(nameof(Version));

				case 3244533220:
					return typeof(VersionData).GetProperty(nameof(DateTime));

				case 2969494588:
					return typeof(VersionData).GetProperty(nameof(BranchId));

				case 509587500:
					return typeof(VersionData).GetProperty(nameof(GameName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
