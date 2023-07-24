using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGameDuniawi
{
    public partial class FormScoreBoard : Form
    {
        public FormScoreBoard()
        {
            InitializeComponent();
        }
        FormGame frmGame;

        private void FormScoreBoard_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner;
        }
    }
}
