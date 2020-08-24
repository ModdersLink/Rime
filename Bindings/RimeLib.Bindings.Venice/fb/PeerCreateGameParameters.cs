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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class PeerCreateGameParameters : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(41)]
		public MatchmakingCreateGameParameters Base { get; set; } = new MatchmakingCreateGameParameters(); // 0x0 (0)
		
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint PlayerCapacity { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088806864:
					Base = (MatchmakingCreateGameParameters) p_Value;
					break;

				case 646509826:
					PlayerCapacity = (uint) p_Value;
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
				case 2088806864:
					return Base;

				case 646509826:
					return PlayerCapacity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088806864:
					return typeof(PeerCreateGameParameters).GetProperty(nameof(Base));

				case 646509826:
					return typeof(PeerCreateGameParameters).GetProperty(nameof(PlayerCapacity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
