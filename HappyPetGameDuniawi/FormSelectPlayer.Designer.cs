
namespace HappyPetGameDuniawi
{
    partial class FormSelectPlayer
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
            this.labelSelectPlayer = new System.Windows.Forms.Label();
            this.comboBoxPlayer = new System.Windows.Forms.ComboBox();
            this.buttonLetsPlay = new System.Windows.Forms.Button();
            this.labelNewPlayer = new System.Windows.Forms.Label();
            this.linkLabelClickHere = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelSelectPlayer
            // 
            this.labelSelectPlayer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectPlayer.Location = new System.Drawing.Point(96, 49);
            this.labelSelectPlayer.Name = "labelSelectPlayer";
            this.labelSelectPlayer.Size = new System.Drawing.Size(162, 34);
            this.labelSelectPlayer.TabIndex = 1;
            this.labelSelectPlayer.Text = "Select Player : ";
            // 
            // comboBoxPlayer
            // 
            this.comboBoxPlayer.FormattingEnabled = true;
            this.comboBoxPlayer.Location = new System.Drawing.Point(76, 115);
            this.comboBoxPlayer.Name = "comboBoxPlayer";
            this.comboBoxPlayer.Size = new System.Drawing.Size(207, 24);
            this.comboBoxPlayer.TabIndex = 2;
            // 
            // buttonLetsPlay
            // 
            this.buttonLetsPlay.BackColor = System.Drawing.Color.Cyan;
            this.buttonLetsPlay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLetsPlay.Location = new System.Drawing.Point(70, 193);
            this.buttonLetsPlay.Name = "buttonLetsPlay";
            this.buttonLetsPlay.Size = new System.Drawing.Size(213, 56);
            this.buttonLetsPlay.TabIndex = 4;
            this.buttonLetsPlay.Text = "Lets Play";
            this.buttonLetsPlay.UseVisualStyleBackColor = false;
            this.buttonLetsPlay.Click += new System.EventHandler(this.buttonLetsPlay_Click);
            // 
            // labelNewPlayer
            // 
            this.labelNewPlayer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPlayer.Location = new System.Drawing.Point(49, 304);
            this.labelNewPlayer.Name = "labelNewPlayer";
            this.labelNewPlayer.Size = new System.Drawing.Size(162, 34);
            this.labelNewPlayer.TabIndex = 5;
            this.labelNewPlayer.Text = "New Player ?";
            // 
            // linkLabelClickHere
            // 
            this.linkLabelClickHere.AutoSize = true;
            this.linkLabelClickHere.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelClickHere.Location = new System.Drawing.Point(202, 304);
            this.linkLabelClickHere.Name = "linkLabelClickHere";
            this.linkLabelClickHere.Size = new System.Drawing.Size(113, 29);
            this.linkLabelClickHere.TabIndex = 6;
            this.linkLabelClickHere.TabStop = true;
            this.linkLabelClickHere.Text = "Click Here";
            this.linkLabelClickHere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClickHere_LinkClicked);
            // 
            // FormSelectPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(355, 390);
            this.Controls.Add(this.linkLabelClickHere);
            this.Controls.Add(this.labelNewPlayer);
            this.Controls.Add(this.buttonLetsPlay);
            this.Controls.Add(this.comboBoxPlayer);
            this.Controls.Add(this.labelSelectPlayer);
            this.Name = "FormSelectPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Player";
            this.Load += new System.EventHandler(this.FormSelectPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectPlayer;
        private System.Windows.Forms.ComboBox comboBoxPlayer;
        private System.Windows.Forms.Button buttonLetsPlay;
        private System.Windows.Forms.Label labelNewPlayer;
        private System.Windows.Forms.LinkLabel linkLabelClickHere;
    }
}