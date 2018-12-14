using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;



namespace losowanie
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Wyniki.AllowUserToResizeColumns = false;
            Wyniki.AllowUserToResizeRows = false;
                    }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        public Losowanie losowanko;

        private void button1_Click(object sender, EventArgs e)
        {
            losowanko = new Losowanie();
            if (losowanko.loadFile() == 0)
            {
                losowanko.Losuj(Wyniki);
            };

        }
    

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Wyniki_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == again.Index)
            {
                losowanko.dolosuj(Wyniki, e);
            }
        }
    }






}
