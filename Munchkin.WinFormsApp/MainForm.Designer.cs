namespace Munchkin.WinFormsApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btn_bot = new Button();
            btn_sound = new Button();
            SuspendLayout();
            // 
            // btn_bot
            // 
            btn_bot.BackColor = Color.SaddleBrown;
            btn_bot.Font = new Font("Berlin Sans FB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_bot.ForeColor = SystemColors.ControlLightLight;
            btn_bot.Location = new Point(287, 327);
            btn_bot.Name = "btn_bot";
            btn_bot.Size = new Size(122, 40);
            btn_bot.TabIndex = 0;
            btn_bot.Text = "PLAY";
            btn_bot.UseVisualStyleBackColor = false;
            btn_bot.Click += btn_bot_Click;
            // 
            // btn_sound
            // 
            btn_sound.BackColor = Color.ForestGreen;
            btn_sound.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sound.ForeColor = Color.Snow;
            btn_sound.Location = new Point(12, 348);
            btn_sound.Name = "btn_sound";
            btn_sound.Size = new Size(44, 28);
            btn_sound.TabIndex = 2;
            btn_sound.Text = "ON";
            btn_sound.UseVisualStyleBackColor = false;
            btn_sound.Click += btn_sound_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(688, 391);
            Controls.Add(btn_sound);
            Controls.Add(btn_bot);
            Cursor = Cursors.Hand;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "start";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_start;
        private Button btn_bot;
        private Button btn_sound;
    }
}
