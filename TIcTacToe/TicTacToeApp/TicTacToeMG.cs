using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIcTacToe
{
    public partial class TicTacToeMG : TicTacToeControl
    {
        List<Button> lstbuttons;
        public TicTacToeMG()
        {
            InitializeComponent();

            lstbuttons = new() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
        }
    }
}
