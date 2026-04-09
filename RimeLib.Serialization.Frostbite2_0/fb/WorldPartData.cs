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
	[ContainerType(4, 56)]
	public partial class WorldPartData :
		SpatialPrefabBlueprint
	{
		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private GUID _HackToSolveRealTimeTweakingIssue = GUID.Empty;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private bool _UseDeferredEntityCreation;

		[ObservableProperty]
		[property: ContainerField(53), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
		private bool _Enabled;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			HackToSolveRealTimeTweakingIssue.Serialize(p_Writer);
			p_Writer.Write(UseDeferredEntityCreation);
			p_Writer.Write(Enabled);
			p_Writer.WriteNullBytes(2);
		}
	}
}
