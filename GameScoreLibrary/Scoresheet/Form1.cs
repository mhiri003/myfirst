using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameScoreLibrary;
using System.IO;
namespace Scoresheet
{
    public partial class Form1 : Form
    {
        GameFactory gfactory;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenGameList_Click(object sender, EventArgs e)
        {
            gfactory = new GameFactory();
            gfactory.CreateGameList();
        }

        private void btnSerializeList_Click(object sender, EventArgs e)
        {
            gfactory.FilePath = "../../games.xml";
            gfactory.SerializeGameList();
        }
    }
}
