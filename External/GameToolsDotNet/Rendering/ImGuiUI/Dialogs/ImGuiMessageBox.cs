using ImGuiNET;
using ImVector2 = System.Numerics.Vector2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameToolsDotNet.Rendering.ImGuiUI.Dialogs
{
    public enum ImGuiMessageBoxOptions
    {
        None,
        Ok,
        OkCancel,
        YesNo,
        YesNoCancel
    }

    public class ImGuiMessageBox : ImGuiDialogBox
    {
        /// <summary>
        /// Caption to be displayed
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// True if the caption text should be centered in the dialog, or false otherwise
        /// </summary>
        public bool CenterCaption { get; set; } = false;
        /// <summary>
        /// Button options
        /// </summary>
        public ImGuiMessageBoxOptions Options { get; set; }

        public ImGuiMessageBox(string title, string caption, ImGuiMessageBoxOptions options) : base(title)
        {
            // Initialize fields.
            this.Caption = caption;
            this.Options = options;
        }

        public override bool DrawDialog()
        {
            bool dialogResult = false;

            // If the dialog result has been set then bail out.
            if (this.Result != ImGuiDialogBoxResult.None)
                return true;

            // Always center the window when appearing.
            ImVector2 center = new ImVector2(ImGui.GetIO().DisplaySize.X * 0.5f, ImGui.GetIO().DisplaySize.Y * 0.5f);
            ImGui.SetNextWindowPos(center, ImGuiCond.Appearing, new ImVector2(0.5f, 0.5f));

            // If size is not 0 use it to size the window.
            if (this.AutoResize == false && this.Size.X != 0 && this.Size.Y != 0)
                ImGui.SetNextWindowSize(this.Size, ImGuiCond.Always);

            // Calculate extra flags for UI settings.
            ImGuiWindowFlags extraFlags = ImGuiWindowFlags.None;
            if (this.ShowTitle == false)
                extraFlags |= ImGuiWindowFlags.NoTitleBar;
            if (this.AutoResize == true)
                extraFlags |= ImGuiWindowFlags.AlwaysAutoResize;
            if (this.AllowMove == false)
                extraFlags |= ImGuiWindowFlags.NoMove;
            if (this.AllowResize == false)
                extraFlags |= ImGuiWindowFlags.NoResize;

            // Show the dialog box.
            bool isOpen = true;
            if (ImGui.BeginPopupModal(this.Title, ref isOpen, ImGuiWindowFlags.NoSavedSettings | ImGuiWindowFlags.NoCollapse | extraFlags) == true)
            {
                // Calculate the number of buttons to display.
                int buttonCount = 1;
                switch (this.Options)
                {
                    case ImGuiMessageBoxOptions.OkCancel:
                    case ImGuiMessageBoxOptions.YesNo:
                        buttonCount = 2; break;
                    case ImGuiMessageBoxOptions.YesNoCancel:
                        buttonCount = 3; break;
                }

                float startPos = 0.0f;
                float buttonWidth = 65.0f;
                float buttonWidthTotal = (buttonWidth * buttonCount) + (ImGui.GetStyle().ItemInnerSpacing.X * (buttonCount - 1));

                // Check if the caption should be centered.
                if (this.CenterCaption == true)
                {
                    // Get the length of the text.
                    ImVector2 textSize = ImGui.CalcTextSize(this.Caption);
                    ImGui.SetCursorPos(new ImVector2((this.Size.X / 2f) - (textSize.X / 2f),
                        (this.Size.Y / 2f) - (textSize.Y / 2f)));
                }

                // Draw the message box text.
                ImGui.Text(this.Caption);
                if (this.Options != ImGuiMessageBoxOptions.None)
                    ImGui.Separator();

                // Calculate the width of the buttons so we can center them in the dialog.
                ImVector2 dialogSize = ImGui.GetWindowSize();
                if (dialogSize.X > buttonWidthTotal)
                    startPos = (dialogSize.X / 2) - (buttonWidthTotal / 2);

                // Set the starting x position to center the buttons.
                ImGui.SetCursorPosX(startPos);

                // Check the message box style and handle accordingly.
                switch (this.Options)
                {
                    case ImGuiMessageBoxOptions.Ok:
                        {
                            if (ImGui.Button("Ok", new ImVector2(buttonWidth, 0)) == true)
                                this.Result = ImGuiDialogBoxResult.Ok;
                            break;
                        }
                    case ImGuiMessageBoxOptions.OkCancel:
                        {
                            if (ImGui.Button("Ok", new ImVector2(buttonWidth, 0)) == true)
                                this.Result = ImGuiDialogBoxResult.Ok;
                            ImGui.SameLine();
                            if (ImGui.Button("Cancel", new ImVector2(buttonWidth, 0)) == true)
                                this.Result = ImGuiDialogBoxResult.Cancel;
                            break;
                        }
                    case ImGuiMessageBoxOptions.YesNo:
                        {
                            if (ImGui.Button("Yes", new ImVector2(buttonWidth, 0)) == true)
                                this.Result = ImGuiDialogBoxResult.Yes;
                            ImGui.SameLine();
                            if (ImGui.Button("No", new ImVector2(buttonWidth, 0)) == true)
                                this.Result = ImGuiDialogBoxResult.No;
                            break;
                        }
                    case ImGuiMessageBoxOptions.YesNoCancel:
                        {
                            if (ImGui.Button("Yes", new ImVector2(buttonWidth, 0)) == true)
                                this.Result = ImGuiDialogBoxResult.Yes;
                            ImGui.SameLine();
                            if (ImGui.Button("No", new ImVector2(buttonWidth, 0)) == true)
                                this.Result = ImGuiDialogBoxResult.No;
                            ImGui.SameLine();
                            if (ImGui.Button("Cancel", new ImVector2(buttonWidth, 0)) == true)
                                this.Result = ImGuiDialogBoxResult.Cancel;
                            break;
                        }
                    default: break;
                }

                // If the dialog result was set close the dialog box.
                if (this.Result != ImGuiDialogBoxResult.None)
                {
                    // Close the dialog box.
                    this.CloseDialog();
                    dialogResult = true;
                }

                // Get the size of the window.
                this.size = ImGui.GetWindowSize();

                ImGui.EndPopup();
            }
            //else
            //{
            //    // If the dialog is was previously opened and no dialog result is set then the close button was pressed.
            //    if (this.dialogOpen == true && this.Result == ImGuiMessageBoxResult.None)
            //    {
            //        // The close button was pressed, set the cancel dialog result.
            //        this.dialogOpen = false;
            //        dialogResult = true;
            //        this.Result = ImGuiMessageBoxResult.Cancel;
            //    }
            //}

            // Return the dialog result.
            return dialogResult;
        }
    }
}
