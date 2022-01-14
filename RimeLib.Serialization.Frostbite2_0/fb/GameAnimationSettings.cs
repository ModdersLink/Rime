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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 72)]
	public class GameAnimationSettings :
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float TemporalLoddingFourthDeltaTime { get; set; }

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<string> AntOnClientOnlyGamemodes { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float TemporalLoddingFarDistance { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float TemporalLoddingSixthDeltaTime { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float TemporalLoddingFifthDeltaTime { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float TemporalLoddingFirstDeltaTime { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float TemporalLoddingSecondDeltaTime { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float TemporalLoddingThirdDeltaTime { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float TemporalLoddingSixthDistance { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float TemporalLoddingSecondDistance { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float TemporalLoddingFifthDistance { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float TemporalLoddingFirstDistance { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float TemporalLoddingThirdDistance { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float TemporalLoddingFourthDistance { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public bool ServerEnable { get; set; }

		[ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		public bool UseRawGamepadInput { get; set; }

		[ContainerField(70), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
		public bool ClientEnable { get; set; }

		[ContainerField(71), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
		public bool UseAnimationDrivenCharacter { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(TemporalLoddingFourthDeltaTime);
			(RimeWriter Writer, uint ArrayIndex) s_AntOnClientOnlyGamemodes = p_EbxWriter.GetArrayWriter(AntOnClientOnlyGamemodes.GetType(), AntOnClientOnlyGamemodes.Count);
			p_Writer.Write(s_AntOnClientOnlyGamemodes.ArrayIndex);
			foreach (var s_Entry in AntOnClientOnlyGamemodes)
			{
				s_AntOnClientOnlyGamemodes.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.Write(TemporalLoddingFarDistance);
			p_Writer.Write(TemporalLoddingSixthDeltaTime);
			p_Writer.Write(TemporalLoddingFifthDeltaTime);
			p_Writer.Write(TemporalLoddingFirstDeltaTime);
			p_Writer.Write(TemporalLoddingSecondDeltaTime);
			p_Writer.Write(TemporalLoddingThirdDeltaTime);
			p_Writer.Write(TemporalLoddingSixthDistance);
			p_Writer.Write(TemporalLoddingSecondDistance);
			p_Writer.Write(TemporalLoddingFifthDistance);
			p_Writer.Write(TemporalLoddingFirstDistance);
			p_Writer.Write(TemporalLoddingThirdDistance);
			p_Writer.Write(TemporalLoddingFourthDistance);
			p_Writer.Write(ServerEnable);
			p_Writer.Write(UseRawGamepadInput);
			p_Writer.Write(ClientEnable);
			p_Writer.Write(UseAnimationDrivenCharacter);
		}
	}
}
