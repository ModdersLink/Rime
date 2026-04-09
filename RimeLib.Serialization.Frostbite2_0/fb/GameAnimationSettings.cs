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
	[ContainerType(4, 72)]
	public partial class GameAnimationSettings :
		SystemSettings
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _TemporalLoddingFourthDeltaTime;

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<string> _AntOnClientOnlyGamemodes = new();

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _TemporalLoddingFarDistance;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _TemporalLoddingSixthDeltaTime;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _TemporalLoddingFifthDeltaTime;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _TemporalLoddingFirstDeltaTime;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _TemporalLoddingSecondDeltaTime;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _TemporalLoddingThirdDeltaTime;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _TemporalLoddingSixthDistance;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _TemporalLoddingSecondDistance;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _TemporalLoddingFifthDistance;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _TemporalLoddingFirstDistance;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _TemporalLoddingThirdDistance;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _TemporalLoddingFourthDistance;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private bool _ServerEnable;

		[ObservableProperty]
		[property: ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		private bool _UseRawGamepadInput;

		[ObservableProperty]
		[property: ContainerField(70), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
		private bool _ClientEnable;

		[ObservableProperty]
		[property: ContainerField(71), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
		private bool _UseAnimationDrivenCharacter;

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
