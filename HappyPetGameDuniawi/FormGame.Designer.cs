
namespace HappyPetGameDuniawi
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelData = new System.Windows.Forms.Panel();
            this.pictureBoxCoins = new System.Windows.Forms.PictureBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelPetData = new System.Windows.Forms.Label();
            this.labelPlayerData = new System.Windows.Forms.Label();
            this.panelActivity = new System.Windows.Forms.Panel();
            this.buttonSleep = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonVaccinate = new System.Windows.Forms.Button();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.buttonBath = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxPet = new System.Windows.Forms.PictureBox();
            this.timerFeed = new System.Windows.Forms.Timer(this.components);
            this.timerPictureActivity = new System.Windows.Forms.Timer(this.components);
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.timerSleep = new System.Windows.Forms.Timer(this.components);
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.timerBath = new System.Windows.Forms.Timer(this.components);
            this.timerClean = new System.Windows.Forms.Timer(this.components);
            this.timerChameleonAfk = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoins)).BeginInit();
            this.panelActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playGameToolStripMenuItem,
            this.changePetToolStripMenuItem,
            this.resetGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(79, 33);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // playGameToolStripMenuItem
            // 
            this.playGameToolStripMenuItem.Name = "playGameToolStripMenuItem";
            this.playGameToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.playGameToolStripMenuItem.Text = "Play Game";
            this.playGameToolStripMenuItem.Click += new System.EventHandler(this.playGameToolStripMenuItem_Click);
            // 
            // changePetToolStripMenuItem
            // 
            this.changePetToolStripMenuItem.Name = "changePetToolStripMenuItem";
            this.changePetToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.changePetToolStripMenuItem.Text = "Change Pet";
            this.changePetToolStripMenuItem.Click += new System.EventHandler(this.changePetToolStripMenuItem_Click);
            // 
            // resetGameToolStripMenuItem
            // 
            this.resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            this.resetGameToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.resetGameToolStripMenuItem.Text = "Reset Game";
            this.resetGameToolStripMenuItem.Click += new System.EventHandler(this.resetGameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(69, 33);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(66, 33);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelData
            // 
            this.panelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.Controls.Add(this.pictureBoxCoins);
            this.panelData.Controls.Add(this.labelDateTime);
            this.panelData.Controls.Add(this.labelPetData);
            this.panelData.Controls.Add(this.labelPlayerData);
            this.panelData.Location = new System.Drawing.Point(0, 40);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1063, 119);
            this.panelData.TabIndex = 1;
            // 
            // pictureBoxCoins
            // 
            this.pictureBoxCoins.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoins.Location = new System.Drawing.Point(143, 43);
            this.pictureBoxCoins.Name = "pictureBoxCoins";
            this.pictureBoxCoins.Size = new System.Drawing.Size(33, 33);
            this.pictureBoxCoins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoins.TabIndex = 4;
            this.pictureBoxCoins.TabStop = false;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.Location = new System.Drawing.Point(889, 17);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(162, 34);
            this.labelDateTime.TabIndex = 2;
            this.labelDateTime.Text = "labelDateTime";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPetData
            // 
            this.labelPetData.BackColor = System.Drawing.Color.LemonChiffon;
            this.labelPetData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPetData.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetData.ForeColor = System.Drawing.Color.Red;
            this.labelPetData.Location = new System.Drawing.Point(181, 17);
            this.labelPetData.Name = "labelPetData";
            this.labelPetData.Size = new System.Drawing.Size(702, 91);
            this.labelPetData.TabIndex = 1;
            this.labelPetData.Text = "labelPetData";
            this.labelPetData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPlayerData
            // 
            this.labelPlayerData.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPlayerData.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerData.Location = new System.Drawing.Point(13, 17);
            this.labelPlayerData.Name = "labelPlayerData";
            this.labelPlayerData.Size = new System.Drawing.Size(162, 91);
            this.labelPlayerData.TabIndex = 0;
            this.labelPlayerData.Text = "labelPlayerData";
            // 
            // panelActivity
            // 
            this.panelActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelActivity.BackColor = System.Drawing.Color.Transparent;
            this.panelActivity.Controls.Add(this.buttonSleep);
            this.panelActivity.Controls.Add(this.buttonClean);
            this.panelActivity.Controls.Add(this.buttonVaccinate);
            this.panelActivity.Controls.Add(this.buttonFeed);
            this.panelActivity.Controls.Add(this.buttonBath);
            this.panelActivity.Controls.Add(this.buttonPlay);
            this.panelActivity.Location = new System.Drawing.Point(0, 441);
            this.panelActivity.Name = "panelActivity";
            this.panelActivity.Size = new System.Drawing.Size(1063, 100);
            this.panelActivity.TabIndex = 2;
            // 
            // buttonSleep
            // 
            this.buttonSleep.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSleep.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSleep.Location = new System.Drawing.Point(192, 22);
            this.buttonSleep.Name = "buttonSleep";
            this.buttonSleep.Size = new System.Drawing.Size(165, 56);
            this.buttonSleep.TabIndex = 8;
            this.buttonSleep.Text = "Sleep";
            this.buttonSleep.UseVisualStyleBackColor = false;
            this.buttonSleep.Click += new System.EventHandler(this.buttonSleep_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonClean.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClean.Location = new System.Drawing.Point(877, 22);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(165, 56);
            this.buttonClean.TabIndex = 7;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = false;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonVaccinate
            // 
            this.buttonVaccinate.BackColor = System.Drawing.Color.Violet;
            this.buttonVaccinate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVaccinate.Location = new System.Drawing.Point(705, 22);
            this.buttonVaccinate.Name = "buttonVaccinate";
            this.buttonVaccinate.Size = new System.Drawing.Size(165, 56);
            this.buttonVaccinate.TabIndex = 6;
            this.buttonVaccinate.Text = "Vaccinate";
            this.buttonVaccinate.UseVisualStyleBackColor = false;
            this.buttonVaccinate.Click += new System.EventHandler(this.buttonVaccinate_Click);
            // 
            // buttonFeed
            // 
            this.buttonFeed.BackColor = System.Drawing.Color.Crimson;
            this.buttonFeed.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFeed.Location = new System.Drawing.Point(21, 22);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(165, 56);
            this.buttonFeed.TabIndex = 3;
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.UseVisualStyleBackColor = false;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // buttonBath
            // 
            this.buttonBath.BackColor = System.Drawing.Color.Yellow;
            this.buttonBath.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBath.Location = new System.Drawing.Point(534, 22);
            this.buttonBath.Name = "buttonBath";
            this.buttonBath.Size = new System.Drawing.Size(165, 56);
            this.buttonBath.TabIndex = 5;
            this.buttonBath.Text = "Bath";
            this.buttonBath.UseVisualStyleBackColor = false;
            this.buttonBath.Click += new System.EventHandler(this.buttonBath_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Lime;
            this.buttonPlay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(363, 22);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(165, 56);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(424, 429);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(220, 123);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Happy Pet Game";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPet
            // 
            this.pictureBoxPet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPet.Location = new System.Drawing.Point(398, 165);
            this.pictureBoxPet.Name = "pictureBoxPet";
            this.pictureBoxPet.Size = new System.Drawing.Size(281, 270);
            this.pictureBoxPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPet.TabIndex = 3;
            this.pictureBoxPet.TabStop = false;
            // 
            // timerFeed
            // 
            this.timerFeed.Interval = 3000;
            this.timerFeed.Tick += new System.EventHandler(this.timerFeed_Tick);
            // 
            // timerPictureActivity
            // 
            this.timerPictureActivity.Interval = 1000;
            this.timerPictureActivity.Tick += new System.EventHandler(this.timerPictureActivity_Tick);
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // timerSleep
            // 
            this.timerSleep.Interval = 3000;
            this.timerSleep.Tick += new System.EventHandler(this.timerSleep_Tick);
            // 
            // timerPlay
            // 
            this.timerPlay.Interval = 3000;
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // timerBath
            // 
            this.timerBath.Interval = 3000;
            this.timerBath.Tick += new System.EventHandler(this.timerBath_Tick);
            // 
            // timerClean
            // 
            this.timerClean.Interval = 3000;
            this.timerClean.Tick += new System.EventHandler(this.timerClean_Tick);
            // 
            // timerChameleonAfk
            // 
            this.timerChameleonAfk.Interval = 1000;
            this.timerChameleonAfk.Tick += new System.EventHandler(this.timerChameleonAfk_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyPetGameDuniawi.Properties.Resources.Room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 573);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxPet);
            this.Controls.Add(this.panelActivity);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Happy Pet Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGame_FormClosing);
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoins)).EndInit();
            this.panelActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button buttonFeed;
        private System.Windows.Forms.Button buttonBath;
        private System.Windows.Forms.Button buttonVaccinate;
        private System.Windows.Forms.Button buttonClean;
        public System.Windows.Forms.Label labelPetData;
        public System.Windows.Forms.Label labelPlayerData;
        public System.Windows.Forms.Panel panelData;
        public System.Windows.Forms.Label labelDateTime;
        public System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.Panel panelActivity;
        private System.Windows.Forms.PictureBox pictureBoxPet;
        private System.Windows.Forms.Button buttonSleep;
        private System.Windows.Forms.Timer timerFeed;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Timer timerPictureActivity;
        private System.Windows.Forms.Timer timerSleep;
        private System.Windows.Forms.Timer timerBath;
        private System.Windows.Forms.Timer timerClean;
        public System.Windows.Forms.Button buttonPlay;
        public System.Windows.Forms.Timer timerPlay;
        private System.Windows.Forms.Timer timerChameleonAfk;
        public System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.PictureBox pictureBoxCoins;
    }
}

