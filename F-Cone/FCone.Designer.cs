namespace F_Cone
{
    partial class FCone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCone));
            pnl_Bar = new MetroFramework.Controls.MetroPanel();
            btn_Exit = new MetroFramework.Controls.MetroButton();
            lbl_FCone = new MetroFramework.Controls.MetroLabel();
            btn_Minimize = new MetroFramework.Controls.MetroButton();
            pnl_Bar.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Bar
            // 
            pnl_Bar.BackColor = Color.FromArgb(39, 40, 56);
            pnl_Bar.Controls.Add(btn_Minimize);
            pnl_Bar.Controls.Add(btn_Exit);
            pnl_Bar.Controls.Add(lbl_FCone);
            pnl_Bar.HorizontalScrollbarBarColor = true;
            pnl_Bar.HorizontalScrollbarHighlightOnWheel = false;
            pnl_Bar.HorizontalScrollbarSize = 10;
            pnl_Bar.Location = new Point(-7, -13);
            pnl_Bar.Name = "pnl_Bar";
            pnl_Bar.Size = new Size(819, 42);
            pnl_Bar.TabIndex = 0;
            pnl_Bar.UseCustomBackColor = true;
            pnl_Bar.VerticalScrollbarBarColor = true;
            pnl_Bar.VerticalScrollbarHighlightOnWheel = false;
            pnl_Bar.VerticalScrollbarSize = 10;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(779, 16);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(22, 20);
            btn_Exit.TabIndex = 5;
            btn_Exit.Text = "X";
            btn_Exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            btn_Exit.UseSelectable = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // lbl_FCone
            // 
            lbl_FCone.AutoSize = true;
            lbl_FCone.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            lbl_FCone.Location = new Point(16, 17);
            lbl_FCone.Name = "lbl_FCone";
            lbl_FCone.Size = new Size(58, 20);
            lbl_FCone.TabIndex = 2;
            lbl_FCone.Text = "F-Cone";
            lbl_FCone.Theme = MetroFramework.MetroThemeStyle.Dark;
            lbl_FCone.Click += lbl_FCone_Click;
            // 
            // btn_Minimize
            // 
            btn_Minimize.Location = new Point(751, 16);
            btn_Minimize.Name = "btn_Minimize";
            btn_Minimize.Size = new Size(22, 20);
            btn_Minimize.TabIndex = 6;
            btn_Minimize.Text = "-";
            btn_Minimize.Theme = MetroFramework.MetroThemeStyle.Dark;
            btn_Minimize.UseSelectable = true;
            btn_Minimize.Click += btn_Minimize_Click;
            // 
            // FCone
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(93, 83, 107);
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_Bar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FCone";
            Text = "F-Cone";
            pnl_Bar.ResumeLayout(false);
            pnl_Bar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnl_Bar;
        private MetroFramework.Controls.MetroLabel lbl_FCone;
        private MetroFramework.Controls.MetroButton btn_Exit;
        private MetroFramework.Controls.MetroButton btn_Minimize;
    }
}