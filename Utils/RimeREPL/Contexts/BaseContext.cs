using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace Rime.Utils.RimeREPL.Contexts
{
    class BaseContext : REPLContext
    {
        private int m_LastMounterId = 0;
        private Dictionary<int, IEngineMounter> m_Mounters = new Dictionary<int, IEngineMounter>();

        public override bool TryGetParent(out REPLContext? p_Parent)
        {
            p_Parent = null;
            return false;
        }

        public override bool ProcessCommand(string p_Input, out REPLContext p_NewContext)
        {
            p_NewContext = this;

            if (p_Input.StartsWith("mount_game "))
                return OnMountGame(p_Input);

            if (p_Input == "list_games")
                return OnListGames();

            if (p_Input.StartsWith("select_game "))
                return OnSelectGame(p_Input, out p_NewContext);

            if (p_Input.StartsWith("dismount_game "))
                return OnDismountGame(p_Input);

            return false;
        }

        public override List<string> GetSuggestions(string p_Input)
        {
            var s_Commands = new string[]
            {
                "help",
                "mount_game",
                "list_games",
                "select_game",
                "dismount_game",
                "exit",
            };

            var s_Suggestions = new List<string>();

            foreach (var s_Command in s_Commands)
                if (s_Command.StartsWith(p_Input))
                    s_Suggestions.Add(s_Command);

            return s_Suggestions;
        }

        public override void PrintHelp()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("");
            Console.WriteLine("help - Prints this message.");
            Console.WriteLine("mount_game <path> <engine> [automount] - Mounts a game.");
            Console.WriteLine("list_games - Lists all the currently mounted games.");
            Console.WriteLine("select_game <id> - Selects a mounted game by its ID.");
            Console.WriteLine("dismount_game <id> - Dismounts a mounted game by its ID.");
            Console.WriteLine("exit - Closes this app.");
        }

        public override string GetDescription()
        {
            return $"rimecmd - {m_Mounters.Count} game{(m_Mounters.Count == 1 ? "" : "s")} mounted";
        }

        private bool OnMountGame(string p_Input)
        {
            // TODO: This isn't right. We need a proper command-line parser.
            var s_Parts = p_Input.Split(" ");

            if (s_Parts.Length < 3 || s_Parts.Length > 4)
                return false;

            if (s_Parts.Length == 4 && s_Parts[3] != "false" && s_Parts[3] != "true")
                return false;

            if (!Enum.TryParse<EngineType>(s_Parts[2], out var s_EngineType) || s_EngineType == EngineType.None || s_EngineType == EngineType.Unknown)
            {
                Console.WriteLine("Invalid engine type specified. Available types:");

                foreach (var s_Type in Enum.GetNames(typeof(EngineType)).Except(new[] { EngineType.None.ToString(), EngineType.Unknown.ToString() }))
                    Console.WriteLine("- " + s_Type);

                return true;
            }

            if (!Directory.Exists(s_Parts[1]))
            {
                Console.WriteLine("The specified path does not exist or is not a directory.");
                return true;
            }

            // Mount the game.
            LoadContentAssembly(s_EngineType);
            var s_Mounter = EngineMounterRegistry.Create(s_EngineType);
            var s_Id = ++m_LastMounterId;

            m_Mounters[s_Id] = s_Mounter;

            Console.WriteLine("Mounting game. Please wait...");
            s_Mounter.Mount(s_Parts[1], s_Parts.Length == 4 && s_Parts[3] == "true", s_EngineType).Wait();

            return true;
        }

        private bool OnListGames()
        {
            if (m_Mounters.Count == 0)
            {
                Console.WriteLine("No games are currently mounted.");
                return true;
            }

            Console.WriteLine("Mounted games:");
            Console.WriteLine();

            foreach (var s_Mounter in m_Mounters)
                Console.WriteLine($"[{s_Mounter.Key}] {s_Mounter.Value.GetGamePath()} - {s_Mounter.Value.GetEngineType()}");

            return true;
        }

        private bool OnSelectGame(string p_Input, out REPLContext p_NewContext)
        {
            p_NewContext = this;

            var s_Parts = p_Input.Split(" ");

            if (s_Parts.Length != 2)
                return false;

            if (!int.TryParse(s_Parts[1], out var s_Id))
                return false;

            if (!m_Mounters.TryGetValue(s_Id, out var s_Mounter))
            {
                Console.WriteLine($"Could not find mounted game with ID {s_Id}. Use the 'list_games' command to see all mounted games and their IDs.");
                return true;
            }

            // Create context from mounter.
            p_NewContext = new GameContext(this, s_Mounter, s_Id);

            return true;
        }

        private bool OnDismountGame(string p_Input)
        {
            var s_Parts = p_Input.Split(" ");

            if (s_Parts.Length != 2)
                return false;

            if (!int.TryParse(s_Parts[1], out var s_Id))
                return false;

            if (!m_Mounters.TryGetValue(s_Id, out var s_Mounter))
            {
                Console.WriteLine($"Could not find mounted game with ID {s_Id}. Use the 'list_games' command to see all mounted games and their IDs.");
                return true;
            }

            m_Mounters.Remove(s_Id);
            return true;
        }

        private void LoadContentAssembly(EngineType p_Engine)
        {
            var s_AssemblyName = "RimeLib.Content." + p_Engine;

            try
            {
                if (!Program.Quiet)
                    Console.WriteLine($"Loading engine content support assembly for '{p_Engine}'.");

                Assembly.Load(s_AssemblyName);
            }
            catch
            {
                if (!Program.Quiet)
                    Console.WriteLine($"Failed to load supporting engine assembly ({s_AssemblyName}.dll). This means that the engine is not supported or that you are missing required files.");
            }
        }
    }
}
