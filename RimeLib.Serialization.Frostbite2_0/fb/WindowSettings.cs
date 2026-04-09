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
	[ContainerType(4, 40)]
	public partial class WindowSettings :
		SystemSettings
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private int _PosX;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private int _PosY;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _Width;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _Height;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private bool _BordersEnable;

		[ObservableProperty]
		[property: ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		private bool _AutoSize;

		[ObservableProperty]
		[property: ContainerField(30), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
		private bool _FullscreenAutoSize;

		[ObservableProperty]
		[property: ContainerField(31), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
		private bool _FullscreenWhenJoiningServer;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private bool _EnableEscape;

		[ObservableProperty]
		[property: ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		private bool _EnableInputOnActivate;

		[ObservableProperty]
		[property: ContainerField(34), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
		private bool _HibernateOnClose;

		[ObservableProperty]
		[property: ContainerField(35), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
		private bool _Hidden;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private bool _Minimized;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(PosX);
			p_Writer.Write(PosY);
			p_Writer.Write(Width);
			p_Writer.Write(Height);
			p_Writer.Write(BordersEnable);
			p_Writer.Write(AutoSize);
			p_Writer.Write(FullscreenAutoSize);
			p_Writer.Write(FullscreenWhenJoiningServer);
			p_Writer.Write(EnableEscape);
			p_Writer.Write(EnableInputOnActivate);
			p_Writer.Write(HibernateOnClose);
			p_Writer.Write(Hidden);
			p_Writer.Write(Minimized);
			p_Writer.WriteNullBytes(3);
		}
	}
}
