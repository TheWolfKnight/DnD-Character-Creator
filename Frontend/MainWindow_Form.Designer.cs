namespace DnD_Charactor_Creator.Frontend
{
    partial class MainWindow_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tc_MainDisplay = new System.Windows.Forms.TabControl();
            tp_CharSheet = new System.Windows.Forms.TabPage();
            tp_Inv = new System.Windows.Forms.TabPage();
            tp_Spell = new System.Windows.Forms.TabPage();
            ms_MainStrip = new System.Windows.Forms.MenuStrip();
            tmi_File = new System.Windows.Forms.ToolStripMenuItem();
            file_New = new System.Windows.Forms.ToolStripMenuItem();
            file_Open = new System.Windows.Forms.ToolStripMenuItem();
            file_Recent = new System.Windows.Forms.ToolStripMenuItem();
            file_Sep1 = new System.Windows.Forms.ToolStripSeparator();
            file_Save = new System.Windows.Forms.ToolStripMenuItem();
            file_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            file_Sep2 = new System.Windows.Forms.ToolStripSeparator();
            file_Exit = new System.Windows.Forms.ToolStripMenuItem();
            tmi_Options = new System.Windows.Forms.ToolStripMenuItem();
            tmi_Char = new System.Windows.Forms.ToolStripMenuItem();
            tmi_Inv = new System.Windows.Forms.ToolStripMenuItem();
            tmi_Spell = new System.Windows.Forms.ToolStripMenuItem();
            tc_MainDisplay.SuspendLayout();
            ms_MainStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tc_MainDisplay
            // 
            tc_MainDisplay.Controls.Add(tp_CharSheet);
            tc_MainDisplay.Controls.Add(tp_Inv);
            tc_MainDisplay.Controls.Add(tp_Spell);
            tc_MainDisplay.Location = new System.Drawing.Point(1, 30);
            tc_MainDisplay.Name = "tc_MainDisplay";
            tc_MainDisplay.SelectedIndex = 0;
            tc_MainDisplay.Size = new System.Drawing.Size(1433, 711);
            tc_MainDisplay.TabIndex = 0;
            // 
            // tp_CharSheet
            // 
            tp_CharSheet.Location = new System.Drawing.Point(4, 24);
            tp_CharSheet.Name = "tp_CharSheet";
            tp_CharSheet.Padding = new System.Windows.Forms.Padding(3);
            tp_CharSheet.Size = new System.Drawing.Size(1425, 683);
            tp_CharSheet.TabIndex = 0;
            tp_CharSheet.Text = "Character Sheet";
            tp_CharSheet.UseVisualStyleBackColor = true;
            // 
            // tp_Inv
            // 
            tp_Inv.Location = new System.Drawing.Point(4, 24);
            tp_Inv.Name = "tp_Inv";
            tp_Inv.Padding = new System.Windows.Forms.Padding(3);
            tp_Inv.Size = new System.Drawing.Size(1425, 683);
            tp_Inv.TabIndex = 1;
            tp_Inv.Text = "Inventory";
            tp_Inv.UseVisualStyleBackColor = true;
            // 
            // tp_Spell
            // 
            tp_Spell.Location = new System.Drawing.Point(4, 24);
            tp_Spell.Name = "tp_Spell";
            tp_Spell.Size = new System.Drawing.Size(1425, 683);
            tp_Spell.TabIndex = 2;
            tp_Spell.Text = "Spells";
            tp_Spell.UseVisualStyleBackColor = true;
            // 
            // ms_MainStrip
            // 
            ms_MainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tmi_File, tmi_Options, tmi_Char, tmi_Inv, tmi_Spell });
            ms_MainStrip.Location = new System.Drawing.Point(0, 0);
            ms_MainStrip.Name = "ms_MainStrip";
            ms_MainStrip.Size = new System.Drawing.Size(1434, 24);
            ms_MainStrip.TabIndex = 1;
            ms_MainStrip.Text = "ms_MainStrip";
            ms_MainStrip.ItemClicked += mp_MainStripItemClick;
            // 
            // tmi_File
            // 
            tmi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { file_New, file_Open, file_Recent, file_Sep1, file_Save, file_SaveAs, file_Sep2, file_Exit });
            tmi_File.Name = "tmi_File";
            tmi_File.Size = new System.Drawing.Size(37, 20);
            tmi_File.Text = "File";
            // 
            // file_New
            // 
            file_New.Name = "file_New";
            file_New.Size = new System.Drawing.Size(180, 22);
            file_New.Text = "New";
            // 
            // file_Open
            // 
            file_Open.Name = "file_Open";
            file_Open.Size = new System.Drawing.Size(180, 22);
            file_Open.Text = "Open";
            // 
            // file_Recent
            // 
            file_Recent.Name = "file_Recent";
            file_Recent.Size = new System.Drawing.Size(180, 22);
            file_Recent.Text = "Open Recent";
            // 
            // file_Sep1
            // 
            file_Sep1.Name = "file_Sep1";
            file_Sep1.Size = new System.Drawing.Size(177, 6);
            // 
            // file_Save
            // 
            file_Save.Name = "file_Save";
            file_Save.Size = new System.Drawing.Size(180, 22);
            file_Save.Text = "Save";
            // 
            // file_SaveAs
            // 
            file_SaveAs.Name = "file_SaveAs";
            file_SaveAs.Size = new System.Drawing.Size(180, 22);
            file_SaveAs.Text = "Save As";
            // 
            // file_Sep2
            // 
            file_Sep2.Name = "file_Sep2";
            file_Sep2.Size = new System.Drawing.Size(177, 6);
            // 
            // file_Exit
            // 
            file_Exit.Name = "file_Exit";
            file_Exit.Size = new System.Drawing.Size(180, 22);
            file_Exit.Text = "Exit";
            // 
            // tmi_Options
            // 
            tmi_Options.Name = "tmi_Options";
            tmi_Options.Size = new System.Drawing.Size(61, 20);
            tmi_Options.Text = "Options";
            // 
            // tmi_Char
            // 
            tmi_Char.Name = "tmi_Char";
            tmi_Char.Size = new System.Drawing.Size(70, 20);
            tmi_Char.Text = "Character";
            // 
            // tmi_Inv
            // 
            tmi_Inv.Name = "tmi_Inv";
            tmi_Inv.Size = new System.Drawing.Size(62, 20);
            tmi_Inv.Text = "Invetory";
            // 
            // tmi_Spell
            // 
            tmi_Spell.Name = "tmi_Spell";
            tmi_Spell.Size = new System.Drawing.Size(44, 20);
            tmi_Spell.Text = "Spell";
            // 
            // MainWindow_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1434, 741);
            Controls.Add(tc_MainDisplay);
            Controls.Add(ms_MainStrip);
            MainMenuStrip = ms_MainStrip;
            Name = "MainWindow_Form";
            Text = "DnD Charactor Creator";
            Load += MainWindow_Form_Load;
            tc_MainDisplay.ResumeLayout(false);
            ms_MainStrip.ResumeLayout(false);
            ms_MainStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // TAP CONTROL

        private System.Windows.Forms.TabControl tc_MainDisplay;
        private System.Windows.Forms.TabPage tp_CharSheet;
        private System.Windows.Forms.TabPage tp_Inv;
        private System.Windows.Forms.TabPage tp_Spell;

        // END TAP CONTROL

        // MENU STRIP

        private System.Windows.Forms.MenuStrip ms_MainStrip;
        private System.Windows.Forms.ToolStripMenuItem tmi_File;
        private System.Windows.Forms.ToolStripMenuItem file_New;
        private System.Windows.Forms.ToolStripMenuItem file_Open;
        private System.Windows.Forms.ToolStripMenuItem file_Recent;
        private System.Windows.Forms.ToolStripSeparator file_Sep1;
        private System.Windows.Forms.ToolStripMenuItem file_Save;
        private System.Windows.Forms.ToolStripMenuItem file_SaveAs;
        private System.Windows.Forms.ToolStripSeparator file_Sep2;
        private System.Windows.Forms.ToolStripMenuItem file_Exit;
        private System.Windows.Forms.ToolStripMenuItem tmi_Options;
        private System.Windows.Forms.ToolStripMenuItem tmi_Char;
        private System.Windows.Forms.ToolStripMenuItem tmi_Inv;
        private System.Windows.Forms.ToolStripMenuItem tmi_Spell;

        // END MENU STRIP

    }
}