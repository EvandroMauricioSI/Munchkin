using System.Media;

namespace Munchkin.WinFormsApp
{
    public partial class MainForm : Form
    {
        private bool _sound;
        private SoundPlayer _soundPlayerInitialGame;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _sound = true;

            // TOOD: Colocar o caminho dentro da aplicação
            //_soundPlayerInitialGame = new SoundPlayer("C:/Users/imaud/Music/start_sound.wav");
            //PlaySound();
        }

        private void PlaySound()
        {
            _soundPlayerInitialGame.PlayLooping();
        }

        private void StopSound()
        {
            _soundPlayerInitialGame.Stop();
        }

        private void btn_bot_Click(object sender, EventArgs e)
        {
            this.Hide();

            // TOOD: Colocar o caminho dentro da aplicação
            // SoundPlayer clickSound = new SoundPlayer("C:/Users/imaud/Music/click_sound.wav");
            //clickSound.Play();

            MatchForm matchForm = new MatchForm();
            matchForm.ShowDialog();
        }

        private void btn_sound_Click(object sender, EventArgs e)
        {
            if(_sound)
            {
                _sound = false;
                ChangeSoundButtonOff();
                //StopSound();
            }
            else
            {
                _sound = true;
                ChangeSoundButtonOn();
                //PlaySound();
            }
        }

        private void ChangeSoundButtonOff()
        {
            btn_sound.Text = "OFF";
            btn_sound.BackColor = Color.Red;
        }

        private void ChangeSoundButtonOn()
        {
            btn_sound.Text = "ON";
            btn_sound.BackColor = Color.ForestGreen;
        }
    }
}
