using Munchkin.Domain.Entities;
using Munchkin.WinFormsApp.Utils;

namespace Munchkin.WinFormsApp
{
    public partial class BackpackForm : Form
    {
        private Backpack _backpack;
        public BackpackForm(Backpack backpack)
        {
            InitializeComponent();
            _backpack = backpack;
        }

        private void BackpackForm_Load(object sender, EventArgs e)
        {
            ShowNewCards();
        }

        public void ShowNewCards()
        {
            var index = 0;
            int startLocationX = 226, startLocationY = 204;

            foreach (var card in _backpack.NewCards)
            {
                var newCardsButtons = ButtonCreator.CreateCardButton
                (
                    $"btn_new_card_myself_{index}",
                    card,
                    startLocationX,
                   startLocationY
                );

                this.Controls.Add(newCardsButtons);
                index++;

                startLocationX += 81;

                if ((startLocationX - 226) / 77 >= 4)
                {
                    startLocationX = 226;
                    startLocationY += 130;
                }
            }
        }
    }
}
