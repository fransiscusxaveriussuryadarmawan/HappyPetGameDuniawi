
namespace HappyPetGameDuniawi
{
    partial class FormHelp
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
            this.labelHelp1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelHelpPet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHelp1
            // 
            this.labelHelp1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelp1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHelp1.Location = new System.Drawing.Point(-1, -1);
            this.labelHelp1.Name = "labelHelp1";
            this.labelHelp1.Size = new System.Drawing.Size(803, 199);
            this.labelHelp1.TabIndex = 0;
            this.labelHelp1.Text = "Tempatnya disini";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Black;
            this.buttonClose.Location = new System.Drawing.Point(661, 557);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(127, 34);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelHelpPet
            // 
            this.labelHelpPet.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelpPet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHelpPet.Location = new System.Drawing.Point(-1, 207);
            this.labelHelpPet.Name = "labelHelpPet";
            this.labelHelpPet.Size = new System.Drawing.Size(803, 347);
            this.labelHelpPet.TabIndex = 2;
            this.labelHelpPet.Text = "Tempatnya disini";
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.ControlBox = false;
            this.Controls.Add(this.labelHelpPet);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelHelp1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FormHelp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHelp_FormClosing);
            this.Load += new System.EventHandler(this.FormHelp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHelp1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelHelpPet;
    }
}