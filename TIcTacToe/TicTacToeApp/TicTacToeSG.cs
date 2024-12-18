
using TicTacToeSystem;

namespace TIcTacToe
{
    public partial class TicTacToeSG : TicTacToeControl
    {
        Game game = new();
        List<Button> lstbuttons;
        Color defaultbackcolor;
        

        public TicTacToeSG()
        {
            InitializeComponent();
            lstbuttons = new() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            lstbuttons.ForEach(b => {
                Spot spot = game.Spots[lstbuttons.IndexOf(b)];
                b.Click += SpotButtonCLick;
                b.DataBindings.Add("Text", spot, "SpotValueDescription");
                b.DataBindings.Add("BackColor", spot, "Backcolor");
            });
            btnStart.Click += BtnStart_Click;

            lblStatus.DataBindings.Add("Text", game, "GameStatusDescription");
        }

        private void StartGame()
        {
            game.StartGame();
        }

        private void DoTurn(Button btn)
        {
            int num = lstbuttons.IndexOf(btn);
            game.TakeSpot(num);
        }

        
    
        private void SpotButtonCLick(object? sender, EventArgs e)
        {
            if (sender is Button)
            {
                DoTurn((Button)sender);

            }

        }
        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }
    }
}
