using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImVector2 = System.Numerics.Vector2;

namespace GameToolsDotNet.Rendering.ImGuiUI.Dialogs
{
    public enum ImGuiDialogBoxResult
    {
        None,
        Ok,
        Yes,
        No,
        Cancel
    }

    public abstract class ImGuiDialogBox
    {
        /// <summary>
        /// Title of the message box
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Result of the dialog based on user interaction
        /// </summary>
        public ImGuiDialogBoxResult Result { get; set; } = ImGuiDialogBoxResult.None;

        /// <summary>
        /// Indicates if the dialog was opened so we can track when it closes
        /// </summary>
        public bool IsDisplayed { get; protected set; } = false;
        /// <summary>
        /// True if the title bar should be drawn or false to hide it
        /// </summary>
        public bool ShowTitle { get; set; } = true;
        /// <summary>
        /// True if the dialog can be moved around, false if the position is fixed
        /// </summary>
        public bool AllowMove { get; set; } = true;
        /// <summary>
        /// True if the dialog can be resized or false otherwise
        /// </summary>
        public bool AllowResize { get; set; } = true;
        /// <summary>
        /// True if the dialog should auto resize to fit the contents or false otherwise
        /// </summary>
        public bool AutoResize { get; set; } = true;
        /// <summary>
        /// Gets or sets the position of the dialog
        /// </summary>
        //public ImVector2 Position { get; set; } = new ImVector2();

        protected ImVector2 size = new ImVector2(-1, -1);
        /// <summary>
        /// Gets or sets the size of the dialog
        /// </summary>
        public ImVector2 Size { get { return this.size; } set { this.size = value; this.AutoResize = false; } }

        public delegate void OnDialogCloseHandler();
        /// <summary>
        /// Event called when the dialog box has been closed.
        /// </summary>
        public OnDialogCloseHandler OnDialogClose { get; set; }

        /// <summary>
        /// Creates a new ImGuiDialog with the specified title
        /// </summary>
        /// <param name="title">Title of the dialog box</param>
        public ImGuiDialogBox(string title)
        {
            // Initialize fields.
            this.Title = title;
        }

        /// <summary>
        /// Called when the dialog should be displayed
        /// </summary>
        public virtual void ShowDialog()
        {
            // Reset the dialog result so the same dialog can be used multiple times.
            this.Result = ImGuiDialogBoxResult.None;

            // Display the message box.
            ImGui.OpenPopup(this.Title);
            this.IsDisplayed = true;
        }

        /// <summary>
        /// Called each frame to draw the dialog box if it is being displayed.
        /// </summary>
        /// <returns>True if the dialog was closed, false otherwise</returns>
        public abstract bool DrawDialog();

        /// <summary>
        /// Closes the dialog and calls the OnDialogClose event handler if one is set.
        /// </summary>
        public virtual void CloseDialog()
        {
            // Close the dialog.
            ImGui.CloseCurrentPopup();

            // Flag that the dialog is no longer being displayed.
            this.IsDisplayed = false;

            // If there is an OnDialogClose event call it now.
            if (this.OnDialogClose != null)
                this.OnDialogClose();
        }
    }
}
