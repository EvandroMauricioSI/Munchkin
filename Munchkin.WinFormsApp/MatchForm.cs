using Munchkin.ApplicationService;
using Munchkin.Domain.Entities;
using Munchkin.Domain.Entities.Cards;
using Munchkin.Domain.Entities.Decks;
using Munchkin.Domain.Enums;
using Munchkin.Domain.Shared.Abstractions;
using Munchkin.WinFormsApp.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Munchkin.WinFormsApp
{
    public partial class MatchForm : Form
    {
        private GameApplicationService _gameApplicationService;

        private Player _myselfPlayer;

        private Player _firstPlayer;
        private Player _secondPlayer;
        private Player _thirdPlayer;

        private Match _match;

        private Card _chosenCard;
        private Card _clickCard;

        private Button _choosenButton;

        public MatchForm()
        {
            InitializeComponent();


            HideCards();

            _gameApplicationService = new GameApplicationService();           
        }

        private void btn_initialize_match_Click(object sender, EventArgs e)
        {
            _match = _gameApplicationService.InitializeGame();

            _myselfPlayer = _match.Players.FirstOrDefault(x => x.Username == "Myself");

            // bot
            _firstPlayer = _match.Players.FirstOrDefault(x => x.Username == "Player1");
            _secondPlayer = _match.Players.FirstOrDefault(x => x.Username == "Player2");
            _thirdPlayer = _match.Players.FirstOrDefault(x => x.Username == "Player3"); 

            MessageBox.Show("Embaralhando cartas....");

            LoadMyselfCardForm();
            btn_initialize_match.Hide();

            ChangeCardNumbers();

            btn_open_door.Show();

            DisableBackButton();
        }

        public void DisableBackButton()
        {
            btn_back.Enabled = false;
            btn_back.BackColor = Color.Gray;
            btn_back.ForeColor = Color.DarkGray;
        }

        public void EnableBackButton()
        {
            btn_back.Enabled = true;
            btn_back.BackColor = Color.AliceBlue;
            btn_back.ForeColor = Color.Black;
        }

        private void HideCards()
        {
            btn_attack.Hide();
            btn_help.Hide();
            btn_escape.Hide();
            btn_open_door.Hide();
            btn_add.Hide();
            btn_delete.Hide();
            btn_backpack.Hide();
            btn_dice.Hide();
        }

        private void ChangeCardNumbers()
        {            
            // card numbers
            lbl_card_number_first_player.Text = _firstPlayer.Cards.Count().ToString();
            lbl_card_number_second_player.Text = _secondPlayer.Cards.Count().ToString();
            lbl_card_number_third_player.Text = _thirdPlayer.Cards.Count().ToString();
            lbl_card_number_myself.Text = _myselfPlayer.Cards.Count().ToString();

            // power
            lbl_power_number_first_player.Text = _firstPlayer.Power.ToString();
            lbl_power_numer_second_player.Text = _secondPlayer.Power.ToString();
            lbl_power_number_third_player.Text = _thirdPlayer.Power.ToString();
            lbl_power_number_myself.Text = _myselfPlayer.Power.ToString();
        }

        private void LoadMyselfCardForm()
        {
            LoadCards(_myselfPlayer.Cards);
        }

        private void LoadCards(List<Card> cards)
        {
            int startLocationX = 226, startLocationY = 204;

            foreach (var card in cards)
            {

                var button = ButtonCreator.CreateCardButton
                (
                    "btn_myself_cards",
                    card,
                    startLocationX,
                    startLocationY
                );

                button.Click += (sender, e) => Button_Click(sender, e, card);

                this.Controls.Add(button);


                startLocationX += 81;

                if ((startLocationX - 226) / 77 >= 4)
                {
                    startLocationX = 226;
                    startLocationY += 130;
                }
            }

        }


        private void Button_Click(object sender, EventArgs e, Card card)
        {
            DialogResult result = MessageBox.Show
            (
                $"Você deseja escolher a carta: {card.Name} ?",
                "Sim",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                if (card.Type == CardType.Class)
                {
                    lbl_class_myself.Text = card.Name.ToUpper();
                }
            }
            _clickCard = card;
        }

        private void btn_open_door_Click(object sender, EventArgs e)
        {
            var door = _match.Decks.OfType<Door>().FirstOrDefault();

            _chosenCard = door.ChooseCard(); 

            _choosenButton = ButtonCreator.CreateCardButton
            (
                "btn_choosen_card",
                _chosenCard,
                596,
                160
            );

            this.Controls.Add(_choosenButton);

            btn_open_door.Hide();
            if (_chosenCard.Type == CardType.Monster)
            {
                btn_attack.Show();
                btn_help.Show();
                btn_escape.Show();
            }
            else
            {
                btn_add.Show();
                btn_delete.Show();
            }
        }

        private void MatchForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_monster_Click(object sender, EventArgs e)
        {

        }

        private void btn_curse_MouseEnter(object sender, EventArgs e)
        {
            //PlayMouseEnter();
        }

        private void btn_monster_MouseEnter(object sender, EventArgs e)
        {
            PlayMouseEnter();
        }

        private void btn_treasure_MouseEnter(object sender, EventArgs e)
        {
            //PlayMouseEnter();
        }

        private void btn_class_MouseEnter(object sender, EventArgs e)
        {
            //PlayMouseEnter();
        }

        private void PlayMouseEnter()
        {
            // TOOD: Colocar o caminho dentro da aplicação
            // SoundPlayer clickSound = new SoundPlayer("C:/Users/imaud/Music/click_sound.wav");
            //clickSound.Play();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            _myselfPlayer.Backpack.AddNewCard(_chosenCard);
            
            _myselfPlayer.AddPower(_chosenCard.Effect);
            lbl_power_number_myself.Text = _myselfPlayer.Power.ToString();

            var totalCards = int.Parse(lbl_card_number_myself.Text) + 1;
            lbl_card_number_myself.Text = totalCards.ToString();

            btn_add.Hide();
            btn_delete.Hide();

            _choosenButton.Hide();

            btn_open_door.Show();
            btn_backpack.Show();

            // ir para o próximo jogador
            for (int i = 0; i < 1; i++)
            {
                FirstPlayerAction();
                SecondPlayerAction(); ;
                ThirdPlayerAction();
            }
        }

        public void FirstPlayerAction()
        {
            var totalCards = int.Parse(lbl_level_number_first_player.Text) + 1;
            lbl_level_number_first_player.Text = totalCards.ToString();

            var power = int.Parse(lbl_power_number_first_player.Text) + 3;
            lbl_power_number_first_player.Text = power.ToString();

            var cardNumber = int.Parse(lbl_card_number_first_player.Text) + 1;
            lbl_card_number_first_player.Text = cardNumber.ToString();

        }

        public void SecondPlayerAction() 
        {
            var totalCards = int.Parse(lbl_level_number_second_player.Text) + 1;
            lbl_level_number_second_player.Text = totalCards.ToString();

            var power = int.Parse(lbl_power_numer_second_player.Text) + 2;
            lbl_power_number_first_player.Text = power.ToString();

            var cardNumber = int.Parse(lbl_card_number_second_player.Text) + 1;
            lbl_card_number_second_player.Text = cardNumber.ToString();
        }

        public void ThirdPlayerAction() 
        {
            var totalCards = int.Parse(lbl_level_number_third_player.Text) + 1;
            lbl_level_number_third_player.Text = totalCards.ToString();

            var power = int.Parse(lbl_power_number_third_player.Text) + 1;           
            lbl_power_number_third_player.Text = power.ToString();


            var cardNumber = int.Parse(lbl_card_number_third_player.Text) + 1;
            lbl_card_number_third_player.Text = cardNumber.ToString();
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            _choosenButton.Hide();
            btn_add.Hide();
            btn_delete.Hide();
            btn_open_door.Show();
        }

        private void btn_backpack_Click(object sender, EventArgs e)
        {
            var backpack = new BackpackForm(_myselfPlayer.Backpack);
            backpack.ShowDialog();
        }

        private void btn_escape_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rolando dado...");
            btn_dice.Show();

            Random random = new Random();

            var number = random.Next(1, 7);

            var level = int.Parse(lbl_level_number_myself.Text);

            if (number == 6 || number == 5)
            {
                MessageBox.Show($"Número sorteado: {number} :: Você venceu o combate!! Subiu um nível!");
                level++;
            }
            else
            {
                MessageBox.Show($"Número sorteado: {number} :: Você perdeu o combate!! Desceu um nível!");

                if (level != 1)
                {
                    level--;
                }
            }

            lbl_level_number_myself.Text = level.ToString();

            lbl_dice.Hide();
            btn_dice.Hide();
            HideMonsterButtons();

            btn_open_door.Show();
            _choosenButton.Hide();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {

        }

        private void btn_attack_Click(object sender, EventArgs e)
        {
            if(_chosenCard is Monster monster)
            {
                var level = int.Parse(lbl_level_number_myself.Text);

                if (_myselfPlayer.Power > monster.Power)
                {
                    MessageBox.Show(text: $"Seu monstro é mais poderoso!! Você subiu um nível");
                    level++;
                }
                else
                {
                    if (level != 1)
                    {
                        MessageBox.Show($"Seu monstro perdeu!! Você desceu um nível");
                        level--;
                    }
                }
            }
        }

        private void HideMonsterButtons()
        {
            btn_escape.Hide();
            btn_help.Hide();
            btn_attack.Hide();
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            var mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
