namespace RimeLib.Content.Frostbite.Storage.Sb
{
    public class SuperbundleEntry
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public string? PatchPath { get; set; }

        public PackageManifest? ContainedPackage { get; set; }

        public TableOfContents<SuperbundleLayout> Toc { get; set; }

        public TableOfContents<SuperbundleLayout>? PatchToc { get; set; }

        public SuperbundleEntry(string p_Name, string p_Path, TableOfContents<SuperbundleLayout> p_Toc)
        {
            Name = p_Name;
            Path = p_Path;
            Toc = p_Toc;
        }
    }
}
