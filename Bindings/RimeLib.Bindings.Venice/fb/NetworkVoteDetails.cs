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
	public class NetworkVoteDetails : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public uint Issuer { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public bool Personal { get; set; } // 0x4 (4)
		
		[ContainerField(5), LayoutImmutable, Blittable]
		public sbyte VoteId { get; set; } // 0x5 (5)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2815342350:
					Issuer = (uint) p_Value;
					break;

				case 2875334909:
					Personal = (bool) p_Value;
					break;

				case 3157740256:
					VoteId = (sbyte) p_Value;
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
				case 2815342350:
					return Issuer;

				case 2875334909:
					return Personal;

				case 3157740256:
					return VoteId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2815342350:
					return typeof(NetworkVoteDetails).GetProperty(nameof(Issuer));

				case 2875334909:
					return typeof(NetworkVoteDetails).GetProperty(nameof(Personal));

				case 3157740256:
					return typeof(NetworkVoteDetails).GetProperty(nameof(VoteId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
