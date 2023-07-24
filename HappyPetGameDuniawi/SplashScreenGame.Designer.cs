
namespace HappyPetGameDuniawi
{
    partial class SplashScreenGame
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
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxProgressBar = new System.Windows.Forms.PictureBox();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(107, 56);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(589, 142);
            this.labelTitle.TabIndex = 21;
            this.labelTitle.Text = "Happy Pet";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxProgressBar
            // 
            this.pictureBoxProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProgressBar.Image = global::HappyPetGameDuniawi.Properties.Resources.progers_bar;
            this.pictureBoxProgressBar.Location = new System.Drawing.Point(200, 314);
            this.pictureBoxProgressBar.Name = "pictureBoxProgressBar";
            this.pictureBoxProgressBar.Size = new System.Drawing.Size(404, 57);
            this.pictureBoxProgressBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProgressBar.TabIndex = 22;
            this.pictureBoxProgressBar.TabStop = false;
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Location = new System.Drawing.Point(217, 329);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(373, 28);
            this.progressBarLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarLoading.TabIndex = 23;
            // 
            // SplashScreenGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyPetGameDuniawi.Properties.Resources.Room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxProgressBar);
            this.DoubleBuffered = true;
            this.Name = "SplashScreenGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreenGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgressBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxProgressBar;
        private System.Windows.Forms.ProgressBar progressBarLoading;
    }
}