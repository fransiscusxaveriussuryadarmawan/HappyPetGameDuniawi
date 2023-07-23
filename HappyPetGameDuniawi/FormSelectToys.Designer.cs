
namespace HappyPetGameDuniawi
{
    partial class FormSelectToys
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
            this.linkLabelBuyHere = new System.Windows.Forms.LinkLabel();
            this.labelNewToy = new System.Windows.Forms.Label();
            this.buttonUse = new System.Windows.Forms.Button();
            this.comboBoxToys = new System.Windows.Forms.ComboBox();
            this.labelSelectToy = new System.Windows.Forms.Label();
            this.labelToysData = new System.Windows.Forms.Label();
            this.pictureBoxToy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToy)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelBuyHere
            // 
            this.linkLabelBuyHere.AutoSize = true;
            this.linkLabelBuyHere.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBuyHere.Location = new System.Drawing.Point(307, 457);
            this.linkLabelBuyHere.Name = "linkLabelBuyHere";
            this.linkLabelBuyHere.Size = new System.Drawing.Size(103, 29);
            this.linkLabelBuyHere.TabIndex = 11;
            this.linkLabelBuyHere.TabStop = true;
            this.linkLabelBuyHere.Text = "Buy Here";
            this.linkLabelBuyHere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBuyHere_LinkClicked);
            // 
            // labelNewToy
            // 
            this.labelNewToy.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewToy.Location = new System.Drawing.Point(55, 457);
            this.labelNewToy.Name = "labelNewToy";
            this.labelNewToy.Size = new System.Drawing.Size(246, 39);
            this.labelNewToy.TabIndex = 10;
            this.labelNewToy.Text = "Don\'t have any toys?";
            // 
            // buttonUse
            // 
            this.buttonUse.BackColor = System.Drawing.Color.Cyan;
            this.buttonUse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUse.Location = new System.Drawing.Point(138, 398);
            this.buttonUse.Name = "buttonUse";
            this.buttonUse.Size = new System.Drawing.Size(210, 56);
            this.buttonUse.TabIndex = 9;
            this.buttonUse.Text = "Use";
            this.buttonUse.UseVisualStyleBackColor = false;
            this.buttonUse.Click += new System.EventHandler(this.buttonUse_Click);
            // 
            // comboBoxToys
            // 
            this.comboBoxToys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToys.FormattingEnabled = true;
            this.comboBoxToys.Location = new System.Drawing.Point(135, 73);
            this.comboBoxToys.Name = "comboBoxToys";
            this.comboBoxToys.Size = new System.Drawing.Size(213, 24);
            this.comboBoxToys.TabIndex = 8;
            this.comboBoxToys.SelectedIndexChanged += new System.EventHandler(this.comboBoxToys_SelectedIndexChanged);
            // 
            // labelSelectToy
            // 
            this.labelSelectToy.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectToy.Location = new System.Drawing.Point(174, 23);
            this.labelSelectToy.Name = "labelSelectToy";
            this.labelSelectToy.Size = new System.Drawing.Size(136, 34);
            this.labelSelectToy.TabIndex = 7;
            this.labelSelectToy.Text = "Select Toy : ";
            // 
            // labelToysData
            // 
            this.labelToysData.BackColor = System.Drawing.Color.Snow;
            this.labelToysData.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToysData.Location = new System.Drawing.Point(133, 299);
            this.labelToysData.Name = "labelToysData";
            this.labelToysData.Size = new System.Drawing.Size(213, 96);
            this.labelToysData.TabIndex = 13;
            this.labelToysData.Text = "Toys Data";
            this.labelToysData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxToy
            // 
            this.pictureBoxToy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxToy.Location = new System.Drawing.Point(135, 103);
            this.pictureBoxToy.Name = "pictureBoxToy";
            this.pictureBoxToy.Size = new System.Drawing.Size(213, 193);
            this.pictureBoxToy.TabIndex = 12;
            this.pictureBoxToy.TabStop = false;
            // 
            // FormSelectToys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(486, 530);
            this.Controls.Add(this.labelToysData);
            this.Controls.Add(this.pictureBoxToy);
            this.Controls.Add(this.linkLabelBuyHere);
            this.Controls.Add(this.labelNewToy);
            this.Controls.Add(this.buttonUse);
            this.Controls.Add(this.comboBoxToys);
            this.Controls.Add(this.labelSelectToy);
            this.Name = "FormSelectToys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select A Toy";
            this.Load += new System.EventHandler(this.FormSelectToys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelBuyHere;
        private System.Windows.Forms.Label labelNewToy;
        private System.Windows.Forms.Button buttonUse;
        private System.Windows.Forms.ComboBox comboBoxToys;
        private System.Windows.Forms.Label labelSelectToy;
        private System.Windows.Forms.PictureBox pictureBoxToy;
        private System.Windows.Forms.Label labelToysData;
    }
}