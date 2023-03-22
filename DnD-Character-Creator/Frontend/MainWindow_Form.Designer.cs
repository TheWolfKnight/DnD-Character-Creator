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
            pn_CharDisplay = new System.Windows.Forms.Panel();
            tc_MainDisplay.SuspendLayout();
            tp_CharSheet.SuspendLayout();
            ms_MainStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tc_MainDisplay
            // 
            tc_MainDisplay.Controls.Add(tp_CharSheet);
            tc_MainDisplay.Controls.Add(tp_Inv);
            tc_MainDisplay.Controls.Add(tp_Spell);
            tc_MainDisplay.Location = new System.Drawing.Point(1, 40);
            tc_MainDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tc_MainDisplay.Name = "tc_MainDisplay";
            tc_MainDisplay.SelectedIndex = 0;
            tc_MainDisplay.Size = new System.Drawing.Size(1638, 948);
            tc_MainDisplay.TabIndex = 0;
            // 
            // tp_CharSheet
            // 
            tp_CharSheet.Controls.Add(pn_CharDisplay);
            tp_CharSheet.Location = new System.Drawing.Point(4, 29);
            tp_CharSheet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tp_CharSheet.Name = "tp_CharSheet";
            tp_CharSheet.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tp_CharSheet.Size = new System.Drawing.Size(1630, 915);
            tp_CharSheet.TabIndex = 0;
            tp_CharSheet.Text = "Character Sheet";
            tp_CharSheet.UseVisualStyleBackColor = true;
            // 
            // tp_Inv
            // 
            tp_Inv.Location = new System.Drawing.Point(4, 29);
            tp_Inv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tp_Inv.Name = "tp_Inv";
            tp_Inv.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tp_Inv.Size = new System.Drawing.Size(1630, 915);
            tp_Inv.TabIndex = 1;
            tp_Inv.Text = "Inventory";
            tp_Inv.UseVisualStyleBackColor = true;
            // 
            // tp_Spell
            // 
            tp_Spell.Location = new System.Drawing.Point(4, 29);
            tp_Spell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tp_Spell.Name = "tp_Spell";
            tp_Spell.Size = new System.Drawing.Size(1630, 915);
            tp_Spell.TabIndex = 2;
            tp_Spell.Text = "Spells";
            tp_Spell.UseVisualStyleBackColor = true;
            // 
            // ms_MainStrip
            // 
            ms_MainStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            ms_MainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tmi_File, tmi_Options, tmi_Char, tmi_Inv, tmi_Spell });
            ms_MainStrip.Location = new System.Drawing.Point(0, 0);
            ms_MainStrip.Name = "ms_MainStrip";
            ms_MainStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            ms_MainStrip.Size = new System.Drawing.Size(1639, 30);
            ms_MainStrip.TabIndex = 1;
            ms_MainStrip.Text = "ms_MainStrip";
            ms_MainStrip.ItemClicked += mp_MainStripItemClick;
            // 
            // tmi_File
            // 
            tmi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { file_New, file_Open, file_Recent, file_Sep1, file_Save, file_SaveAs, file_Sep2, file_Exit });
            tmi_File.Name = "tmi_File";
            tmi_File.Size = new System.Drawing.Size(46, 24);
            tmi_File.Text = "File";
            // 
            // file_New
            // 
            file_New.Name = "file_New";
            file_New.Size = new System.Drawing.Size(177, 26);
            file_New.Text = "New";
            // 
            // file_Open
            // 
            file_Open.Name = "file_Open";
            file_Open.Size = new System.Drawing.Size(177, 26);
            file_Open.Text = "Open";
            // 
            // file_Recent
            // 
            file_Recent.Name = "file_Recent";
            file_Recent.Size = new System.Drawing.Size(177, 26);
            file_Recent.Text = "Open Recent";
            // 
            // file_Sep1
            // 
            file_Sep1.Name = "file_Sep1";
            file_Sep1.Size = new System.Drawing.Size(174, 6);
            // 
            // file_Save
            // 
            file_Save.Name = "file_Save";
            file_Save.Size = new System.Drawing.Size(177, 26);
            file_Save.Text = "Save";
            // 
            // file_SaveAs
            // 
            file_SaveAs.Name = "file_SaveAs";
            file_SaveAs.Size = new System.Drawing.Size(177, 26);
            file_SaveAs.Text = "Save As";
            // 
            // file_Sep2
            // 
            file_Sep2.Name = "file_Sep2";
            file_Sep2.Size = new System.Drawing.Size(174, 6);
            // 
            // file_Exit
            // 
            file_Exit.Name = "file_Exit";
            file_Exit.Size = new System.Drawing.Size(177, 26);
            file_Exit.Text = "Exit";
            // 
            // tmi_Options
            // 
            tmi_Options.Name = "tmi_Options";
            tmi_Options.Size = new System.Drawing.Size(75, 24);
            tmi_Options.Text = "Options";
            // 
            // tmi_Char
            // 
            tmi_Char.Name = "tmi_Char";
            tmi_Char.Size = new System.Drawing.Size(86, 24);
            tmi_Char.Text = "Character";
            // 
            // tmi_Inv
            // 
            tmi_Inv.Name = "tmi_Inv";
            tmi_Inv.Size = new System.Drawing.Size(76, 24);
            tmi_Inv.Text = "Invetory";
            // 
            // tmi_Spell
            // 
            tmi_Spell.Name = "tmi_Spell";
            tmi_Spell.Size = new System.Drawing.Size(56, 24);
            tmi_Spell.Text = "Spell";
            // 
            // pn_CharDisplay
            // 
            pn_CharDisplay.Location = new System.Drawing.Point(6, 7);
            pn_CharDisplay.Name = "pn_CharDisplay";
            pn_CharDisplay.Size = new System.Drawing.Size(250, 125);
            pn_CharDisplay.TabIndex = 1;
            // 
            // MainWindow_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1639, 988);
            Controls.Add(tc_MainDisplay);
            Controls.Add(ms_MainStrip);
            MainMenuStrip = ms_MainStrip;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MainWindow_Form";
            Text = "DnD Charactor Creator";
            Load += MainWindow_Form_Load;
            tc_MainDisplay.ResumeLayout(false);
            tp_CharSheet.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pn_CharDisplay;

        // END MENU STRIP

    }
}