///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 8)]
	public class NetworkVoteDetails
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public uint Issuer { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public bool Personal { get; set; }
		
		[ContainerField(5), LayoutImmutable, Blittable]
		public sbyte VoteId { get; set; }
		
		public static void Deserialize(NetworkVoteDetails p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Issuer = p_Reader.ReadUInt32();
			p_Instance.Personal = p_Reader.ReadBool();
			p_Instance.VoteId = p_Reader.ReadSByte();
			p_Reader.Seek(2, SeekOrigin.Current);
		}
	}
}
