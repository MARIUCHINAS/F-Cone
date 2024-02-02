using System;
using System.Diagnostics.Eventing.Reader;

namespace F_Cone
{
    public partial class FConeLauncher : Form
    {   // https://coolors.co/272838-5d536b-7d6b91-989fce-347fc4

        private Form _FConeForm = new FCone();



        public FConeLauncher()
        {
            InitializeComponent();

        }

        private void FConeLauncher_Load(object sender, EventArgs e)
        {

        }

        private void lbl_FCone_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Launch_Click(object sender, EventArgs e)
        {
            while (prgsbr_Lauch.Value != 300)
            {
                prgsbr_Lauch.Value += 1;
                Thread.Sleep(1);
                if (prgsbr_Lauch.Value == 300)
                {
                    Hide();
                    _FConeForm.Show();

                }

            }

        }

        private void btn_CheckForUpdates_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not implemented yet");
        }
        Point lastPoint;
        private void pnl_Bar_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pnl_Bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void picbx_Logo_Click(object sender, EventArgs e)
        {

        }

        private void rchtxtbx_PatchNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void prgsbr_Lauch_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Bar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}