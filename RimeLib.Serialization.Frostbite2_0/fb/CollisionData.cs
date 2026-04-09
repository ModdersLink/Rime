///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 16)]
	public partial class CollisionData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private List<ValueAtX> _DamageAtVerticalVelocity = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<ValueAtX> _DamageAtHorizVelocity = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			(RimeWriter Writer, uint ArrayIndex) s_DamageAtVerticalVelocity = p_EbxWriter.GetArrayWriter(DamageAtVerticalVelocity.GetType(), DamageAtVerticalVelocity.Count);
			p_Writer.Write(s_DamageAtVerticalVelocity.ArrayIndex);
			foreach (var s_Entry in DamageAtVerticalVelocity)
			{
				s_Entry.Serialize(s_DamageAtVerticalVelocity.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_DamageAtHorizVelocity = p_EbxWriter.GetArrayWriter(DamageAtHorizVelocity.GetType(), DamageAtHorizVelocity.Count);
			p_Writer.Write(s_DamageAtHorizVelocity.ArrayIndex);
			foreach (var s_Entry in DamageAtHorizVelocity)
			{
				s_Entry.Serialize(s_DamageAtHorizVelocity.Writer, p_EbxWriter);
			}
		}
	}
}
