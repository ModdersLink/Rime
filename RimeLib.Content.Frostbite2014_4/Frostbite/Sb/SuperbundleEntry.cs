namespace RimeLib.Content.Frostbite2014_4.Frostbite.Sb;

public class SuperbundleEntry
{
	public string Name { get; set; }

	public string Path { get; set; }

	public string? PatchPath { get; set; }

	public PackageManifest? ContainedPackage { get; set; }

	public TableOfContents<SuperbundleLayout> Toc { get; set; }

	public TableOfContents<SuperbundleLayout>? PatchToc { get; set; }


	public bool Cas => PatchToc?.Layout.Cas ?? Toc.Layout.Cas ?? false;
	

	public SuperbundleEntry(string p_Name, string p_Path, TableOfContents<SuperbundleLayout> p_Toc)
	{
		Name = p_Name;
		Path = p_Path;
		Toc = p_Toc;
	}
}