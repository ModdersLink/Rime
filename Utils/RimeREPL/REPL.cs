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
            for (var i = 0; i < Console.WindowHeight - 1; ++i)
                Console.WriteLine();

            Console.Write(m_Context.GetDescription() + "> ");
        }

        private void RenderCommandLine()
        {
            Console.CursorLeft = 0;
            Console.Write(m_Context.GetDescription() + "> ");

            var s_DescriptionLength = Console.CursorLeft;

            // Write buffer.
            var s_AvailableLength = Console.WindowWidth - s_DescriptionLength - 1;

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

            if (p_Backwards)
                --m_Offset;

            m_CurrentBuffer = m_CurrentBuffer.Remove(m_Offset, 1);

            RenderCommandLine();
        }

        private void OnSuggest()
        {

        }

        private void OnCursorLeft()
        {
            if (m_Offset <= 0)
                return;

            --m_Offset;

            RenderCommandLine();
        }

        private void OnCursorRight()
        {
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

            RenderCommandLine();
        }

        private bool OnConfirmInput()
        {
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
                RenderCommandLine();

                return true;
            }

            if (s_Input == "help")
            {

                m_Context.PrintHelp();
                Console.WriteLine();
                RenderCommandLine();

                return true;
            }

            // For anything else, pass to our context.
            if (!m_Context.ProcessCommand(s_Input, out m_Context))
                Console.WriteLine("Your input was not recognized. You can use the 'help' command to see all available options.");

            Console.WriteLine();
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
