using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Frostbite2014_4.Frostbite.Sb;

public class ContentManifest : DbObjectSerializable
{
	public class SuperbundleEntry : DbObjectSerializable
	{
		[DbObjectField("name")]
		public string Name { get; set; } = "";
            
		[DbObjectField("delta", DefaultValue = false)]
		public bool Delta { get; set; }
		
		[DbObjectField("same", DefaultValue = false)]
		public bool Same { get; set; }
	}


	[DbObjectField("superBundles")]
	public SuperbundleEntry[] Superbundles { get; set; } = new SuperbundleEntry[0];

	[DbObjectField("fs")]
	public string[] FS { get; set; } = new string[0];

	[DbObjectField("head")]
	public int? Head { get; set; }

	[DbObjectField("base")]
	public int? Base { get; set; }



	[DbObjectField("installManifest")] 
	public InstallManifest? InstallManifest { get; set; } = null;
}