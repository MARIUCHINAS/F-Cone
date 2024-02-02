namespace F_Cone
{
    partial class FConeLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConeLauncher));
            btn_Launch = new MetroFramework.Controls.MetroButton();
            pnl_Bar = new MetroFramework.Controls.MetroPanel();
            btn_Minimize = new MetroFramework.Controls.MetroButton();
            btn_Exit = new MetroFramework.Controls.MetroButton();
            lbl_FCone = new MetroFramework.Controls.MetroLabel();
            btn_CheckForUpdates = new MetroFramework.Controls.MetroButton();
            prgsbr_Lauch = new MetroFramework.Controls.MetroProgressBar();
            rchtxtbx_PatchNotes = new RichTextBox();
            picbx_Logo = new PictureBox();
            pnl_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbx_Logo).BeginInit();
            SuspendLayout();
            // 
            // btn_Launch
            // 
            btn_Launch.Font = new Font("Consolas", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Launch.FontSize = MetroFramework.MetroButtonSize.Medium;
            btn_Launch.Location = new Point(12, 205);
            btn_Launch.Name = "btn_Launch";
            btn_Launch.Size = new Size(183, 37);
            btn_Launch.Style = MetroFramework.MetroColorStyle.Pink;
            btn_Launch.TabIndex = 0;
            btn_Launch.Text = "Launch";
            btn_Launch.Theme = MetroFramework.MetroThemeStyle.Dark;
            btn_Launch.UseSelectable = true;
            btn_Launch.Click += btn_Launch_Click;
            // 
            // pnl_Bar
            // 
            pnl_Bar.BackColor = Color.FromArgb(39, 40, 56);
            pnl_Bar.Controls.Add(btn_Minimize);
            pnl_Bar.Controls.Add(btn_Exit);
            pnl_Bar.Controls.Add(lbl_FCone);
            pnl_Bar.ForeColor = SystemColors.ControlText;
            pnl_Bar.HorizontalScrollbarBarColor = true;
            pnl_Bar.HorizontalScrollbarHighlightOnWheel = false;
            pnl_Bar.HorizontalScrollbarSize = 10;
            pnl_Bar.Location = new Point(-11, -18);
            pnl_Bar.Name = "pnl_Bar";
            pnl_Bar.Size = new Size(505, 44);
            pnl_Bar.Style = MetroFramework.MetroColorStyle.White;
            pnl_Bar.TabIndex = 1;
            pnl_Bar.UseCustomBackColor = true;
            pnl_Bar.VerticalScrollbarBarColor = true;
            pnl_Bar.VerticalScrollbarHighlightOnWheel = false;
            pnl_Bar.VerticalScrollbarSize = 10;
            pnl_Bar.Paint += pnl_Bar_Paint;
            pnl_Bar.MouseDown += pnl_Bar_MouseDown;
            pnl_Bar.MouseMove += pnl_Bar_MouseMove;
            // 
            // btn_Minimize
            // 
            btn_Minimize.Location = new Point(434, 23);
            btn_Minimize.Name = "btn_Minimize";
            btn_Minimize.Size = new Size(16, 14);
            btn_Minimize.TabIndex = 5;
            btn_Minimize.Text = "-";
            btn_Minimize.Theme = MetroFramework.MetroThemeStyle.Dark;
            btn_Minimize.UseSelectable = true;
            btn_Minimize.Click += btn_Minimize_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(456, 23);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(16, 14);
            btn_Exit.TabIndex = 4;
            btn_Exit.Text = "X";
            btn_Exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            btn_Exit.UseSelectable = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // lbl_FCone
            // 
            lbl_FCone.AutoSize = true;
            lbl_FCone.Font = new Font("Consolas", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_FCone.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            lbl_FCone.Location = new Point(14, 19);
            lbl_FCone.Name = "lbl_FCone";
            lbl_FCone.Size = new Size(58, 20);
            lbl_FCone.TabIndex = 4;
            lbl_FCone.Text = "F-Cone";
            lbl_FCone.Theme = MetroFramework.MetroThemeStyle.Dark;
            lbl_FCone.Click += lbl_FCone_Click;
            // 
            // btn_CheckForUpdates
            // 
            btn_CheckForUpdates.Font = new Font("Consolas", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CheckForUpdates.FontSize = MetroFramework.MetroButtonSize.Medium;
            btn_CheckForUpdates.Location = new Point(201, 205);
            btn_CheckForUpdates.Name = "btn_CheckForUpdates";
            btn_CheckForUpdates.Size = new Size(183, 37);
            btn_CheckForUpdates.Style = MetroFramework.MetroColorStyle.Pink;
            btn_CheckForUpdates.TabIndex = 2;
            btn_CheckForUpdates.Text = "Check for Updates";
            btn_CheckForUpdates.Theme = MetroFramework.MetroThemeStyle.Dark;
            btn_CheckForUpdates.UseSelectable = true;
            btn_CheckForUpdates.Click += btn_CheckForUpdates_Click;
            // 
            // prgsbr_Lauch
            // 
            prgsbr_Lauch.ForeColor = Color.FromArgb(52, 127, 196);
            prgsbr_Lauch.Location = new Point(12, 170);
            prgsbr_Lauch.Maximum = 300;
            prgsbr_Lauch.Name = "prgsbr_Lauch";
            prgsbr_Lauch.Size = new Size(449, 29);
            prgsbr_Lauch.TabIndex = 3;
            prgsbr_Lauch.Theme = MetroFramework.MetroThemeStyle.Dark;
            prgsbr_Lauch.Click += prgsbr_Lauch_Click;
            // 
            // rchtxtbx_PatchNotes
            // 
            rchtxtbx_PatchNotes.BackColor = Color.FromArgb(39, 40, 56);
            rchtxtbx_PatchNotes.BorderStyle = BorderStyle.None;
            rchtxtbx_PatchNotes.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rchtxtbx_PatchNotes.ForeColor = Color.FromArgb(52, 127, 196);
            rchtxtbx_PatchNotes.Location = new Point(12, 32);
            rchtxtbx_PatchNotes.Name = "rchtxtbx_PatchNotes";
            rchtxtbx_PatchNotes.ReadOnly = true;
            rchtxtbx_PatchNotes.Size = new Size(282, 132);
            rchtxtbx_PatchNotes.TabIndex = 4;
            rchtxtbx_PatchNotes.Text = "Feature not implemented yet";
            rchtxtbx_PatchNotes.TextChanged += rchtxtbx_PatchNotes_TextChanged;
            // 
            // picbx_Logo
            // 
            picbx_Logo.Image = Properties.Resources.F_Cone__Custom_;
            picbx_Logo.Location = new Point(314, 36);
            picbx_Logo.Name = "picbx_Logo";
            picbx_Logo.Size = new Size(125, 125);
            picbx_Logo.TabIndex = 5;
            picbx_Logo.TabStop = false;
            picbx_Logo.Click += picbx_Logo_Click;
            // 
            // FConeLauncher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(93, 83, 107);
            ClientSize = new Size(473, 254);
            ControlBox = false;
            Controls.Add(picbx_Logo);
            Controls.Add(rchtxtbx_PatchNotes);
            Controls.Add(prgsbr_Lauch);
            Controls.Add(btn_CheckForUpdates);
            Controls.Add(pnl_Bar);
            Controls.Add(btn_Launch);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FConeLauncher";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FConeLauncher_Load;
            pnl_Bar.ResumeLayout(false);
            pnl_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbx_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private MetroFramework.Controls.MetroButton btn_Launch;
        private MetroFramework.Controls.MetroPanel pnl_Bar;
        private MetroFramework.Controls.MetroButton btn_CheckForUpdates;
        private MetroFramework.Controls.MetroProgressBar prgsbr_Lauch;
        private MetroFramework.Controls.MetroLabel lbl_FCone;
        private MetroFramework.Controls.MetroButton btn_Minimize;
        private MetroFramework.Controls.MetroButton btn_Exit;
        private RichTextBox rchtxtbx_PatchNotes;
        private PictureBox picbx_Logo;
    }
}