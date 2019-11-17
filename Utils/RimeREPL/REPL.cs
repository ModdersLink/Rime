using System;
using System.Collections.Generic;
using Rime.Utils.RimeREPL.Contexts;

namespace Rime.Utils.RimeREPL
{
    internal class REPL
    {
        private REPLContext m_Context;
        private string m_CurrentBuffer = "";
        private int m_Offset;
        private int m_HistoryOffset;
        private string m_PendingCommand = "";
        private List<string> m_History = new List<string>();
        private List<string> m_Suggestions = new List<string>();
        private int m_SuggestionIndex = -1;

        public REPL()
        {
            m_Context = new BaseContext();
        }

        public void Process()
        {
            StartWriteLine();

            while (true)
                if (!ProcessREPL())
                    break;
        }

        private bool ProcessREPL()
        {
            var s_Input = Console.ReadKey(true);

            switch (s_Input.Key)
            {
                case ConsoleKey.UpArrow:
                    OnHistoryPrevious();
                    return true;

                case ConsoleKey.DownArrow:
                    OnHistoryNext();
                    return true;

                case ConsoleKey.Backspace:
                    OnDeleteInput(true);
                    return true;

                case ConsoleKey.Delete:
                    OnDeleteInput(false);
                    return true;

                case ConsoleKey.Tab:
                    OnSuggest();
                    return true;

                case ConsoleKey.LeftArrow:
                    OnCursorLeft();
                    return true;

                case ConsoleKey.RightArrow:
                    OnCursorRight();
                    return true;

                case ConsoleKey.Enter:
                    return OnConfirmInput();

                default:
                    OnCharacterInput(s_Input.KeyChar);
                    return true;
            }
        }

        private void StartWriteLine()
        {
            for (var i = 0; i < Console.WindowHeight - 2; ++i)
                Console.WriteLine();

            WriteDescription();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            Console.ResetColor();
        }

        private void WriteDescription()
        { 
            var s_Description = m_Context.GetDescription();

            if (s_Description.Length + 2 > Console.WindowWidth)
                s_Description = s_Description.Substring(0, Console.WindowWidth - 3) + "…";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[");

            Console.ResetColor();
            Console.Write(s_Description);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("]");
        }

        private void RenderCommandLine()
        {
            Console.CursorLeft = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("> ");
            Console.ResetColor();

            var s_DescriptionLength = Console.CursorLeft;

            // Write buffer.
            var s_AvailableLength = Console.WindowWidth - s_DescriptionLength - 1;

            if (m_SuggestionIndex == -1)
            {
                if (m_CurrentBuffer.Length > s_AvailableLength)
                {
                    // Decide how to render this based on where the cursor is.
                    string s_StringToPrint;

                    if (m_Offset >= s_AvailableLength)
                        s_StringToPrint = "…" + m_CurrentBuffer.Substring((m_Offset - s_AvailableLength) + 1, s_AvailableLength - 1);
                    else
                        s_StringToPrint = m_CurrentBuffer.Substring(0, s_AvailableLength - 1) + "…";

                    Console.Write(s_StringToPrint);
                }
                else
                {
                    Console.Write(m_CurrentBuffer);
                }
            }
            else
            {
                // Render suggestion.
                var s_CurrentBuffer = m_Suggestions[m_SuggestionIndex];
                var s_SuggestionLength = s_CurrentBuffer.Length - m_CurrentBuffer.Length;

                if (s_CurrentBuffer.Length > s_AvailableLength)
                {
                    // Decide how to render this based on where the cursor is.
                    if (m_Offset >= s_AvailableLength)
                    {
                        var s_StringToPrint = "…";
                        s_StringToPrint += s_CurrentBuffer.Substring((m_Offset - s_AvailableLength) + 1, Math.Min(s_AvailableLength - 1, m_CurrentBuffer.Length));

                        Console.Write(s_StringToPrint);

                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        if (s_StringToPrint.Length < s_AvailableLength)
                            Console.Write(s_CurrentBuffer.Substring(m_CurrentBuffer.Length, Math.Min(s_AvailableLength - s_StringToPrint.Length, s_SuggestionLength)));
                    }
                    else
                    {
                        var s_StringToPrint = s_CurrentBuffer.Substring(0, Math.Min(s_AvailableLength - 1, m_CurrentBuffer.Length));
                        Console.Write(s_StringToPrint);

                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        if (s_StringToPrint.Length < s_AvailableLength - 1)
                            Console.Write(s_CurrentBuffer.Substring(s_StringToPrint.Length, Math.Min(s_AvailableLength - s_StringToPrint.Length - 1, s_SuggestionLength)));

                        Console.Write("…");
                    }
                }
                else
                {
                    Console.Write(m_CurrentBuffer);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(s_CurrentBuffer.Substring(m_CurrentBuffer.Length));
                }
            }

            Console.ResetColor();

            // Clear the rest of the cells.
            for (var i = 0; i < Console.WindowWidth - Console.CursorLeft; ++i)
                Console.Write(" ");

            // Set our cursor to the right spot.
            Console.CursorLeft = Math.Min(s_DescriptionLength + m_Offset, Console.WindowWidth - 1);
        }

        private void OnHistoryPrevious()
        {
            if (m_HistoryOffset + 1 > m_History.Count)
                return;

            m_SuggestionIndex = -1;
            m_Suggestions.Clear();

            if (m_HistoryOffset == 0)
                m_PendingCommand = m_CurrentBuffer;

            ++m_HistoryOffset;

            var s_HistoryItem = m_History[m_History.Count - m_HistoryOffset];

            m_CurrentBuffer = s_HistoryItem;
            m_Offset = m_CurrentBuffer.Length;

            RenderCommandLine();
        }

        private void OnHistoryNext()
        {
            if (m_HistoryOffset <= 0)
                return;

            m_SuggestionIndex = -1;
            m_Suggestions.Clear();

            --m_HistoryOffset;

            if (m_HistoryOffset == 0)
            {
                m_CurrentBuffer = m_PendingCommand;
                m_PendingCommand = "";
                m_Offset = m_CurrentBuffer.Length;
            }
            else
            {
                m_CurrentBuffer = m_History[m_History.Count - m_HistoryOffset];
                m_Offset = m_CurrentBuffer.Length;
            }

            RenderCommandLine();
        }

        private void OnDeleteInput(bool p_Backwards)
        {
            if (p_Backwards && m_Offset == 0)
                return;

            if (!p_Backwards && m_Offset >= m_CurrentBuffer.Length)
                return;

            m_SuggestionIndex = -1;
            m_Suggestions.Clear();

            if (p_Backwards)
                --m_Offset;

            m_CurrentBuffer = m_CurrentBuffer.Remove(m_Offset, 1);

            RenderCommandLine();
        }

        private void OnSuggest()
        {
            if (m_CurrentBuffer.Length == 0)
                return;

            if (m_SuggestionIndex == -1)
            {
                m_Suggestions = m_Context.GetSuggestions(m_CurrentBuffer);

                if (m_Suggestions.Count == 0)
                    return;
            }

            ++m_SuggestionIndex;

            if (m_SuggestionIndex >= m_Suggestions.Count)
                m_SuggestionIndex = 0;

            RenderCommandLine();
        }

        private void OnCursorLeft()
        {
            if (m_Offset <= 0)
                return;

            --m_Offset;

            m_SuggestionIndex = -1;
            m_Suggestions.Clear();

            RenderCommandLine();
        }

        private void OnCursorRight()
        {
            // Auto-fill selected suggestion.
            if (m_SuggestionIndex != -1)
            {
                m_CurrentBuffer = m_Suggestions[m_SuggestionIndex];
                m_Offset = m_CurrentBuffer.Length;
                m_SuggestionIndex = -1;
                m_Suggestions.Clear();

                RenderCommandLine();

                return;
            }

            if (m_Offset >= m_CurrentBuffer.Length)
                return;

            ++m_Offset;

            RenderCommandLine();
        }

        private void OnCharacterInput(char p_Char)
        {
            if (p_Char == '\0')
                return;

            m_CurrentBuffer = m_CurrentBuffer.Insert(m_Offset, p_Char.ToString());
            m_Offset++;

            m_SuggestionIndex = -1;
            m_Suggestions.Clear();

            RenderCommandLine();
        }

        private bool OnConfirmInput()
        {
            // Auto-complete suggestion if we have selected one.
            if (m_SuggestionIndex != -1)
            {
                m_CurrentBuffer = m_Suggestions[m_SuggestionIndex];
                m_Offset = m_CurrentBuffer.Length;
                m_SuggestionIndex = -1;
                m_Suggestions.Clear();
                
                RenderCommandLine();

                return true;
            }

            // Otherwise process the command.
            Console.WriteLine();
            Console.WriteLine();

            var s_Input = m_CurrentBuffer.Trim();

            m_Offset = 0;
            m_CurrentBuffer = "";
            m_PendingCommand = "";

            m_History.Add(s_Input);
            m_HistoryOffset = 0;

            // Handle some built-in commands.
            if (s_Input == "exit")
            {
                if (!PopContext())
                    return false;

                Console.WriteLine();
                WriteDescription();
                RenderCommandLine();

                return true;
            }

            if (s_Input == "help")
            {

                m_Context.PrintHelp();
                Console.WriteLine();
                WriteDescription();
                RenderCommandLine();

                return true;
            }

            // For anything else, pass to our context.
            if (!m_Context.ProcessCommand(s_Input, out m_Context))
                Console.WriteLine("Your input was not recognized. You can use the 'help' command to see all available options.");

            Console.WriteLine();
            WriteDescription();
            RenderCommandLine();

            return true;
        }

        private bool PopContext()
        {
            m_Context.TryGetParent(out m_Context);
            return m_Context != null;
        }
    }
}
