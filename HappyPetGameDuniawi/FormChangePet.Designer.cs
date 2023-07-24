
namespace HappyPetGameDuniawi
{
    partial class FormChangePet
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
            this.radioButtonFish = new System.Windows.Forms.RadioButton();
            this.radioButtonCat = new System.Windows.Forms.RadioButton();
            this.radioButtonChameleon = new System.Windows.Forms.RadioButton();
            this.labelChameleon = new System.Windows.Forms.Label();
            this.labelFish = new System.Windows.Forms.Label();
            this.labelCat = new System.Windows.Forms.Label();
            this.textBoxPetName = new System.Windows.Forms.TextBox();
            this.textBoxPlayer = new System.Windows.Forms.TextBox();
            this.comboBoxEnv = new System.Windows.Forms.ComboBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelEnv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlayerData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonFish
            // 
            this.radioButtonFish.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonFish.BackgroundImage = global::HappyPetGameDuniawi.Properties.Resources.fish_happy;
            this.radioButtonFish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonFish.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonFish.Location = new System.Drawing.Point(289, 188);
            this.radioButtonFish.Name = "radioButtonFish";
            this.radioButtonFish.Size = new System.Drawing.Size(215, 173);
            this.radioButtonFish.TabIndex = 16;
            this.radioButtonFish.TabStop = true;
            this.radioButtonFish.UseVisualStyleBackColor = false;
            this.radioButtonFish.CheckedChanged += new System.EventHandler(this.radioButtonFish_CheckedChanged_1);
            // 
            // radioButtonCat
            // 
            this.radioButtonCat.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonCat.BackgroundImage = global::HappyPetGameDuniawi.Properties.Resources.cat_happy;
            this.radioButtonCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonCat.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonCat.Location = new System.Drawing.Point(55, 185);
            this.radioButtonCat.Name = "radioButtonCat";
            this.radioButtonCat.Size = new System.Drawing.Size(197, 179);
            this.radioButtonCat.TabIndex = 17;
            this.radioButtonCat.TabStop = true;
            this.radioButtonCat.UseVisualStyleBackColor = false;
            this.radioButtonCat.CheckedChanged += new System.EventHandler(this.radioButtonCat_CheckedChanged_1);
            // 
            // radioButtonChameleon
            // 
            this.radioButtonChameleon.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonChameleon.BackgroundImage = global::HappyPetGameDuniawi.Properties.Resources.chameleonG_def;
            this.radioButtonChameleon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonChameleon.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonChameleon.Location = new System.Drawing.Point(560, 185);
            this.radioButtonChameleon.Name = "radioButtonChameleon";
            this.radioButtonChameleon.Size = new System.Drawing.Size(210, 176);
            this.radioButtonChameleon.TabIndex = 18;
            this.radioButtonChameleon.TabStop = true;
            this.radioButtonChameleon.UseVisualStyleBackColor = false;
            this.radioButtonChameleon.CheckedChanged += new System.EventHandler(this.radioButtonChameleon_CheckedChanged_1);
            // 
            // labelChameleon
            // 
            this.labelChameleon.BackColor = System.Drawing.Color.Transparent;
            this.labelChameleon.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChameleon.Location = new System.Drawing.Point(598, 367);
            this.labelChameleon.Name = "labelChameleon";
            this.labelChameleon.Size = new System.Drawing.Size(119, 34);
            this.labelChameleon.TabIndex = 21;
            this.labelChameleon.Text = "Chameleon";
            this.labelChameleon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFish
            // 
            this.labelFish.BackColor = System.Drawing.Color.Transparent;
            this.labelFish.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFish.Location = new System.Drawing.Point(369, 367);
            this.labelFish.Name = "labelFish";
            this.labelFish.Size = new System.Drawing.Size(63, 34);
            this.labelFish.TabIndex = 22;
            this.labelFish.Text = "Fish";
            this.labelFish.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCat
            // 
            this.labelCat.BackColor = System.Drawing.Color.Transparent;
            this.labelCat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCat.Location = new System.Drawing.Point(123, 367);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(58, 34);
            this.labelCat.TabIndex = 23;
            this.labelCat.Text = "Cat";
            this.labelCat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxPetName
            // 
            this.textBoxPetName.Location = new System.Drawing.Point(302, 421);
            this.textBoxPetName.Name = "textBoxPetName";
            this.textBoxPetName.Size = new System.Drawing.Size(127, 22);
            this.textBoxPetName.TabIndex = 29;
            // 
            // textBoxPlayer
            // 
            this.textBoxPlayer.Location = new System.Drawing.Point(170, 48);
            this.textBoxPlayer.Name = "textBoxPlayer";
            this.textBoxPlayer.Size = new System.Drawing.Size(154, 22);
            this.textBoxPlayer.TabIndex = 28;
            // 
            // comboBoxEnv
            // 
            this.comboBoxEnv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnv.FormattingEnabled = true;
            this.comboBoxEnv.Items.AddRange(new object[] {
            "River",
            "Sea",
            "Pond"});
            this.comboBoxEnv.Location = new System.Drawing.Point(616, 420);
            this.comboBoxEnv.Name = "comboBoxEnv";
            this.comboBoxEnv.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEnv.TabIndex = 27;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(289, 503);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(213, 56);
            this.buttonPlay.TabIndex = 26;
            this.buttonPlay.Text = "Lets Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelEnv
            // 
            this.labelEnv.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnv.Location = new System.Drawing.Point(452, 414);
            this.labelEnv.Name = "labelEnv";
            this.labelEnv.Size = new System.Drawing.Size(219, 34);
            this.labelEnv.TabIndex = 25;
            this.labelEnv.Text = "Environment :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 34);
            this.label6.TabIndex = 24;
            this.label6.Text = "Enter Your Pet\'s Name :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select Your Pet : ";
            // 
            // labelPlayerData
            // 
            this.labelPlayerData.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerData.Location = new System.Drawing.Point(50, 41);
            this.labelPlayerData.Name = "labelPlayerData";
            this.labelPlayerData.Size = new System.Drawing.Size(219, 34);
            this.labelPlayerData.TabIndex = 19;
            this.labelPlayerData.Text = "Player :";
            // 
            // FormChangePet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(816, 587);
            this.Controls.Add(this.radioButtonFish);
            this.Controls.Add(this.radioButtonCat);
            this.Controls.Add(this.radioButtonChameleon);
            this.Controls.Add(this.labelChameleon);
            this.Controls.Add(this.labelFish);
            this.Controls.Add(this.labelCat);
            this.Controls.Add(this.textBoxPetName);
            this.Controls.Add(this.textBoxPlayer);
            this.Controls.Add(this.comboBoxEnv);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelEnv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPlayerData);
            this.Name = "FormChangePet";
            this.Text = "FormChangePet";
            this.Load += new System.EventHandler(this.FormChangePet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonFish;
        private System.Windows.Forms.RadioButton radioButtonCat;
        private System.Windows.Forms.RadioButton radioButtonChameleon;
        private System.Windows.Forms.Label labelChameleon;
        private System.Windows.Forms.Label labelFish;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.TextBox textBoxPetName;
        private System.Windows.Forms.TextBox textBoxPlayer;
        private System.Windows.Forms.ComboBox comboBoxEnv;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label labelEnv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPlayerData;
    }
}