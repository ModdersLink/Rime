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
	[ContainerType(16, 144)]
	public partial class LoggingEntityData :
		EntityData
	{
		[ObservableProperty]
		[property: ContainerField(12), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private Vec2 _Vec2Value = new();

		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec3 _Vec3Value = new();

		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private LinearTransform _TransformValue = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _FloatValue;

		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private List<string> _Strings = new();

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private int _IntValue;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private bool _BoolValue;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Vec2Value.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(12);
			Vec3Value.Serialize(p_Writer, p_EbxWriter);
			TransformValue.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Realm);
			p_Writer.Write(FloatValue);
			(RimeWriter Writer, uint ArrayIndex) s_Strings = p_EbxWriter.GetArrayWriter(Strings.GetType(), Strings.Count);
			p_Writer.Write(s_Strings.ArrayIndex);
			foreach (var s_Entry in Strings)
			{
				s_Strings.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.Write(IntValue);
			p_Writer.Write(BoolValue);
			p_Writer.WriteNullBytes(15);
		}
	}
}
