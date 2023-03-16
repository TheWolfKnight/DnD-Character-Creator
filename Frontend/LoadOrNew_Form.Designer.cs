using System;
using System.Drawing;
using System.Windows.Forms;

namespace DnD_Charactor_Creator.Frontend
{
    partial class LoadOrNew_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_NewChar = new Button();
            btn_LoadChar = new Button();
            SuspendLayout();
            // 
            // btn_NewChar
            // 
            btn_NewChar.Location = new Point(122, 49);
            btn_NewChar.Name = "btn_NewChar";
            btn_NewChar.Size = new Size(75, 23);
            btn_NewChar.TabIndex = 0;
            btn_NewChar.Text = "New";
            btn_NewChar.UseVisualStyleBackColor = true;
            btn_NewChar.Click += onButtonClick;
            // 
            // btn_LoadChar
            // 
            btn_LoadChar.Location = new Point(122, 94);
            btn_LoadChar.Name = "btn_LoadChar";
            btn_LoadChar.Size = new Size(75, 23);
            btn_LoadChar.TabIndex = 1;
            btn_LoadChar.Text = "Load";
            btn_LoadChar.UseVisualStyleBackColor = true;
            btn_LoadChar.Click += onButtonClick;
            // 
            // LoadOrNew_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 188);
            Controls.Add(btn_LoadChar);
            Controls.Add(btn_NewChar);
            Name = "LoadOrNew_Form";
            Text = "DnD Character Creator";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_NewChar;
        private Button btn_LoadChar;
    }
}