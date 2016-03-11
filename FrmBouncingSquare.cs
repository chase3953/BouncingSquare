using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmBouncingSquare : Form
    {
        Random rnd = new Random();
        Paddle paddle = null;
        //List<Square> squares = new List<Square>();
        public frmBouncingSquare()
        {
            InitializeComponent();
            this.KeyDown += FrmBouncingSquare_KeyDown;
            this.Load += FrmBouncingSquare_Load;
            Cursor.Hide();

        }

        private void FrmBouncingSquare_Load(object sender, EventArgs e)
        {
            paddle = new Paddle(this, rnd);
        }

        private void FrmBouncingSquare_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Application.Exit();
            else if (e.KeyData == Keys.N)
            {
                Square square = new Square(this, rnd);
            }
            else if (e.KeyData == Keys.Left || e.KeyData == Keys.Right)
            {
                paddle.Key = e.KeyData;
            }
        }


    }
}

