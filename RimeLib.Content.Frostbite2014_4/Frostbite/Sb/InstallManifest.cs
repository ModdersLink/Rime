using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Frostbite2014_4.Frostbite.Sb;

public class InstallManifest : DbObjectSerializable
{
	public class InstallChunk : DbObjectSerializable
	{
		[DbObjectField("id")]
		public GUID Id { get; set; } = GUID.Empty;
		
		[DbObjectField("name")]
		public string Name { get; set; } = "";
		
		[DbObjectField("installPackageId")]
		public GUID InstallPackageId { get; set; } = GUID.Empty;
		
		[DbObjectField("installBundle")]
		public string? InstallBundle { get; set; } = null;

		
		[DbObjectField("alwaysInstalled", DefaultValue = false)]
		public bool AlwaysInstalled { get; set; } = false;
		[DbObjectField("mandatoryDLC", DefaultValue = false)]
		public bool MandatoryDLC { get; set; } = false;
		[DbObjectField("optionalDLC", DefaultValue = false)]
		public bool OptionalDLC { get; set; } = false;
		
		[DbObjectField("license")]
		public string? License { get; set; } = null;
		
		[DbObjectField("estimatedSize")]
		public long EstimatedSize { get; set; }
		[DbObjectField("maxSize")]
		public long MaxSize { get; set; }

		[DbObjectField("requiredChunks")]
		public GUID[] RequiredChunks { get; set; } = new GUID[0];
		
		
		
		[DbObjectField("superbundles")]
		public string[] Superbundles { get; set; } = new string[0];
		
		
		
		
	}
	
	public class InstallGroup : DbObjectSerializable
	{
		[DbObjectField("name")]
		public string Name { get; set; } = string.Empty;
            
		[DbObjectField("chunks")]
		public GUID[] Chunks { get; set; } = new GUID[0];
	}

	public class InstallLocalization : DbObjectSerializable
	{
		/*
		 * Types:
		   *  0 = ?
		   *  1 = French
		   *  2 = German
		   *  3 = Spanish

		   *  6 = Italian
		   *  7 = Japanese
		   *  8 = Russian
		   *  9 = Polish
		   * 10 = Dutch
		   * 11 = Portuguese
		   * 12 = TraditionalChinese
		   * 13 = Korean
		   * 14 = Czech
		   * 15 = BrazilianPortuguese
		   
		   * 20 = default
		 */
		[DbObjectField("language")]
		public string Language { get; set; } = string.Empty;
            
		[DbObjectField("superbundles")]
		public string[] Superbundles { get; set; } = new string[0];
	}

	[DbObjectField("installChunks")]
	public InstallChunk[] Chunks { get; set; } = new InstallChunk[0];

	[DbObjectField("installGroups")]
	public InstallGroup[] Groups { get; set; } = new InstallGroup[0];

	[DbObjectField("installLocalization")]
	public InstallLocalization[] Localizations { get; set; } = new InstallLocalization[0];

	
	[DbObjectField("enableDuplication", DefaultValue = false)]
	public bool EnableDuplication { get; set; }

	[DbObjectField("maxTotalSize")]
	public long MaxTotalSize { get; set; }
}