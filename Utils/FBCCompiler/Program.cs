using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using FBCC.Containers;
using FBCC.Generators;
using FBCC.Managers;

namespace FBCC
{
    class Program
    {
        public static bool Archx64 { get; private set; }

        static int Main(string[] p_Args)
        {
#if DEBUG
            var s_Args = new List<string>()
            {
                "--gen-rime",

                //"--gen-bindings",
                //"--gen-native",
                //"--gen-vext-docs",
                //"--arch-x64",
                //@"--out=B:\Projects\Rime\Rime\Bindings\VeniceBindings",
                //@"--out=B:\Games\Battlefield 3\__fbc__\doc",
                //@"--out=B:\Projects\EmulatorNexus\VeniceUnleashed\Client\Components\VeniceEXT\Src",
            };

            //var s_Files = Directory.GetFiles(@"B:\Games\Battlefield 4\fbc\all\");
            //s_Args.AddRange(s_Files.Where(p_File => p_File.EndsWith("Settings.fbc")));

            var s_FBCFiles = Directory.GetFiles(@"B:\Games\Battlefield 3\__fbc__\classes");
            s_Args.AddRange(s_FBCFiles.Where(p_File => p_File.EndsWith(".fbc")));

            p_Args = s_Args.ToArray();
#endif
            Archx64 = false;

            var s_ContainerFiles = new List<string>();

            var s_GenerateNative = false;
            var s_GenerateBindings = false;
            var s_GenerateRime = false;
            var s_GenerateVextDocs = false;
            var s_BasePath = Directory.GetCurrentDirectory();

            foreach (var s_Arg in p_Args)
            {
                switch (s_Arg)
                {
                    case "--arch-x64":
                        Archx64 = true;
                        break;

                    case "--gen-rime":
                        s_GenerateRime = true;
                        break;

                    case "--gen-vext-docs":
                        s_GenerateVextDocs = true;
                        break;

#if DEBUG
                    case "--gen-native":
                        s_GenerateNative = true;
                        break;

                    case "--gen-bindings":
                        s_GenerateBindings = true;
                        break;
#endif

                    default:
                        if (s_Arg.StartsWith("--out="))
                        {
                            s_BasePath = s_Arg.Substring(6);
                        }
                        else if (s_Arg.StartsWith("--in="))
                        {
                            var s_InputPath = s_Arg.Substring(5);
                            var s_FoundFiles = Directory.GetFiles(s_InputPath, "*.fbc");
                            s_ContainerFiles.AddRange(s_FoundFiles);
                        }
                        else if (s_Arg.EndsWith(".fbc"))
                        {
                            s_ContainerFiles.Add(s_Arg);
                        }
                        
                        break;
                }
            }

            if ((!s_GenerateRime && !s_GenerateBindings && !s_GenerateNative && !s_GenerateVextDocs) || s_ContainerFiles.Count == 0)
            {
                var s_Assembly = System.Reflection.Assembly.GetExecutingAssembly();
                var s_VersionInfo = FileVersionInfo.GetVersionInfo(s_Assembly.Location);

                Console.WriteLine("Frostbite Container Compiler - Version {0}", s_VersionInfo.FileVersion);
                Console.WriteLine("");
                Console.WriteLine("Usage:");
                Console.WriteLine("\tfbcc [<options>...] <file>...");
                Console.WriteLine();
                Console.WriteLine("Options:");
                Console.WriteLine("\t--arch-x64\t\tGenerate code targeting the x86_64 architecture.");
                Console.WriteLine("\t--gen-rime\t\tGenerate code for use with the Rime Editor.");
                Console.WriteLine("\t--gen-vext-doc\t\tGenerate DokuWiki documentation.");
                Console.WriteLine("\t--out=<path>\t\tOutput path for generated files [default: current dir].");
                Console.WriteLine("\t--in=<path>\t\tAdditional input path to collect FBC files from.");

#if DEBUG
                Console.WriteLine("\t--gen-native\t\tGenerate native FrostbiteSDK code.");
                Console.WriteLine("\t--gen-bindings\t\tGenerate native VeniceEXT binding code.");
#endif

                return 1;
            }

            // Register the requested generators.
            if (s_GenerateRime)
                ContainerManager.RegisterGenerator(new RimeGenerator());
            
            if (s_GenerateVextDocs)
                ContainerManager.RegisterGenerator(new BindingDocGenerator());

#if DEBUG
            if (s_GenerateNative)
                ContainerManager.RegisterGenerator(new NativeGenerator());

            if (s_GenerateBindings)
                ContainerManager.RegisterGenerator(new BindingGenerator());
            
            var s_EnumRegistrations = new HashSet<string>();
            var s_Registrations = new Dictionary<string, IContainerDefinition>();
#endif

            var s_FilePaths = new List<string>();

            try
            {
                Directory.CreateDirectory(s_BasePath);
            }
            catch
            {
                Console.WriteLine("Could not create output directory.");
                return 5; // ERROR_ACCESS_DENIED
            }

            foreach (var s_File in s_ContainerFiles)
            {
                var s_FullPath = Path.GetFullPath(s_File);

                if (!File.Exists(s_FullPath))
                {
                    Console.WriteLine("Could not find file '{0}'.", s_File);
                    return 87;  // ERROR_INVALID_PARAMETER
                }

                s_FilePaths.Add(s_FullPath);
            }

            foreach (var s_Path in s_FilePaths)
            {
                Console.WriteLine("Parsing base FBC file '{0}'.", Path.GetFileNameWithoutExtension(s_Path));

                // Parse and register our base container.
                bool s_Exists;

                ContainerManager.RegisterContainer(s_Path, true, out s_Exists);

                try
                {
                    // Resolve all references and dependencies.
                    Console.WriteLine("Resolving FBC dependencies...");
                    //DependencyManager.ResolveDependencies();

					if (s_GenerateBindings)
					{
#if DEBUG
						foreach (var s_Container in ContainerManager.GetContainers())
						{
							foreach (var s_Definition in s_Container.Definitions)
							{
								if (s_Definition.DefinitionType == ContainerDefinitionType.Enum)
								{
									s_EnumRegistrations.Add(((ContainerEnum)s_Definition).Name);
									continue;
								}

							    if (s_Definition is ContainerClass)
							    {
							        var s_Class = s_Definition as ContainerClass;

                                    if (!s_Registrations.ContainsKey(s_Class.Name))
                                        s_Registrations.Add(s_Class.Name, s_Class);
                                }
							    else if (s_Definition is ContainerStruct)
							    {
                                    var s_Struct = s_Definition as ContainerStruct;

                                    if (!s_Registrations.ContainsKey(s_Struct.Name))
                                        s_Registrations.Add(s_Struct.Name, s_Struct);
                                }

							}
						}
#endif
					}
				}
                catch (Exception s_Exception)
                {
                    Console.WriteLine("Dependency resolution failed. Error: {0}", s_Exception.Message);
                    return 87; // ERROR_INVALID_PARAMETER
                }
            }

            // Generate code.
            Console.WriteLine("Generating code...");
            var s_GeneratedFiles = ContainerManager.GenerateCode();
            
            foreach (var s_File in s_GeneratedFiles)
            {
                try
                {
                    Console.WriteLine("Writing generated file '{0}'.", s_File.Key);

                    var s_FilePath = Path.Combine(s_BasePath, s_File.Key);
                    var s_FileDirectory = Path.GetDirectoryName(s_FilePath);

                    Directory.CreateDirectory(s_FileDirectory);

                    // Skip files that are already generated and have the same exact data.
                    if (File.Exists(s_FilePath))
                    {
                        var s_CurrentHash = SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(s_File.Value));
                        var s_FileHash = SHA1.Create().ComputeHash(File.ReadAllBytes(s_FilePath));

                        if (s_CurrentHash.SequenceEqual(s_FileHash))
                            continue;
                    }

                    File.WriteAllText(s_FilePath, s_File.Value);
                }
                catch (Exception)
                {
                    Console.WriteLine(
                        "An error occurred while writing generated file '{0}'. Please verify you have permissions to write this file and try again.",
                        s_File.Key);
                    return 5; // ERROR_ACCESS_DENIED
                }
            }

#if DEBUG
            // Print VeniceEXT class registrations.
            if (s_GenerateBindings)
            {
                // Sort registrations based on their dependencies.
                var s_FinalRegistrations = s_Registrations.Keys.TSort((p_Name) =>
                {
                    var s_Dependencies = new HashSet<string>();

                    if (IsBuiltinType(p_Name))
                        return s_Dependencies;

                    var s_Definition = s_Registrations[p_Name];
                    var s_Members = new List<ContainerMember>();

                    if (s_Definition is ContainerClass)
                    {
                        var s_Class = s_Definition as ContainerClass;
                        BindingGenerator.GetSuperClasses(s_Class, s_Dependencies);
                        s_Members = s_Class.Members;
                    }

                    if (s_Definition is ContainerStruct)
                    {
                        var s_Struct = s_Definition as ContainerStruct;
                        s_Members = s_Struct.Members;
                    }

                    // Add member type dependencies.
                    foreach (var s_Member in s_Members)
                    {
                        if (s_Member.MemberType != ContainerMemberType.Container)
                            continue;

                        if (ContainerManager.HasClass(s_Member.ContainerType) || ContainerManager.HasStruct(s_Member.ContainerType))
                            s_Dependencies.Add(s_Member.ContainerType.Components.Last());
                    }

                    // Filter out base classes.
                    s_Dependencies = new HashSet<string>(s_Dependencies.Where(p_Dep => !IsBuiltinType(p_Dep) && p_Dep != p_Name));

                    return s_Dependencies;
                });

                Console.WriteLine("Writing final binding module...");
                
                var s_Writer = new StreamWriter(Path.Combine(s_BasePath, "VeniceEXT\\GeneratedModule.cpp"));
                
                s_Writer.WriteLine("#include <VeniceEXT/ModuleImpl.h>");
                s_Writer.WriteLine();

                // Add includes
                foreach (var s_Registration in s_EnumRegistrations)
                    s_Writer.WriteLine("void Register{0}(::sol::state_view*);", s_Registration);

                foreach (var s_Registration in s_FinalRegistrations)
                    if (!IsBuiltinType(s_Registration))
                        s_Writer.WriteLine("void Register{0}(::sol::state_view*);", s_Registration);

                if (s_EnumRegistrations.Count > 0 || s_FinalRegistrations.Count > 0)
                    s_Writer.WriteLine();

                s_Writer.WriteLine("void ::VeniceEXT::ModuleImpl::ConfigureGenerated()");
                s_Writer.WriteLine("{");

                foreach (var s_Registration in s_EnumRegistrations)
                    s_Writer.WriteLine("\t::Register{0}(m_SolState);", s_Registration);

                foreach (var s_Registration in s_FinalRegistrations)
                    if (!IsBuiltinType(s_Registration))
                        s_Writer.WriteLine("\t::Register{0}(m_SolState);", s_Registration);

                s_Writer.WriteLine("}");

                s_Writer.Flush();
                s_Writer.Dispose();
            }
#endif

            if (s_GenerateVextDocs)
            {
                var s_Writer = new StreamWriter(Path.Combine(s_BasePath, "fb.txt"));

                var s_Containers = ContainerManager.GetContainers();

                var s_Classes = new List<ContainerClass>();
                var s_Structs = new List<ContainerStruct>();
                var s_Enums = new List<ContainerEnum>();

                foreach (var s_Ctr in s_Containers)
                {
                    foreach (var s_Definition in s_Ctr.Definitions)
                    {
                        if (s_Definition is ContainerClass)
                            s_Classes.Add(s_Definition as ContainerClass);
                        else if (s_Definition is ContainerStruct)
                            s_Structs.Add(s_Definition as ContainerStruct);
                        else if (s_Definition is ContainerEnum)
                            s_Enums.Add(s_Definition as ContainerEnum);
                    }
                }

                s_Writer.WriteLine("====== Frostbite Types Reference (Venice Unleashed) ======");

                if (s_Classes.Count > 0)
                {
                    s_Writer.WriteLine("===== Containers =====");

                    foreach (var s_Chunk in s_Classes.SplitChunks(2))
                    {
                        s_Writer.Write("|");

                        for (var i = 0; i < 2; ++i)
                        {
                            if (i >= s_Chunk.Count)
                            {
                                s_Writer.Write("  |");
                                continue;
                            }

                            s_Writer.Write(" [[vext:ref:vu:cls:fb:{0}|{1}]] |", s_Chunk[i].Name.ToLowerInvariant(), s_Chunk[i].Name);
                        }

                        s_Writer.WriteLine();
                    }
                }

                if (s_Structs.Count > 0)
                {
                    s_Writer.WriteLine("===== Structures =====");

                    foreach (var s_Chunk in s_Structs.SplitChunks(3))
                    {
                        s_Writer.Write("|");

                        for (var i = 0; i < 3; ++i)
                        {
                            if (i >= s_Chunk.Count)
                            {
                                s_Writer.Write("  |");
                                continue;
                            }

                            s_Writer.Write(" [[vext:ref:vu:cls:fb:{0}|{1}]] |", s_Chunk[i].Name.ToLowerInvariant(), s_Chunk[i].Name);
                        }

                        s_Writer.WriteLine();
                    }
                }

                if (s_Enums.Count > 0)
                {
                    s_Writer.WriteLine("===== Enumerations =====");

                    foreach (var s_Chunk in s_Enums.SplitChunks(3))
                    {
                        s_Writer.Write("|");

                        for (var i = 0; i < 3; ++i)
                        {
                            if (i >= s_Chunk.Count)
                            {
                                s_Writer.Write("  |");
                                continue;
                            }

                            s_Writer.Write(" [[vext:ref:vu:cls:fb:{0}|{1}]] |", s_Chunk[i].Name.ToLowerInvariant(), s_Chunk[i].Name);
                        }

                        s_Writer.WriteLine();
                    }
                }

                s_Writer.Flush();
                s_Writer.Dispose();
            }

            return 0;
        }

        private static bool IsBuiltinType(string p_Type)
        {
            return (
                p_Type == "DataContainer" ||
                p_Type == "Vec2" ||
                p_Type == "Vec3" ||
                p_Type == "Vec4" ||
                p_Type == "Mat4" ||
                p_Type == "LinearTransform" ||
                p_Type == "AxisAlignedBox" ||
                p_Type == "Guid" ||
                p_Type == "SHA1"
            );
        }
    }
}
