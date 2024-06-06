using ProNatur___Biomarkt_GmbH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private int loadingBarValue;

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            LoadingBarTimer.Start();
        }
        private void LoadingBarTimer_Tick(object sender, EventArgs e)
        {
            loadingBarValue++;

            LblLoadingProgress.Text =loadingBarValue.ToString()+"%";
            loadingProgressBar.Value = loadingBarValue;
            if (loadingBarValue >= 100) 
            {
                LoadingBarTimer.Stop();

                //Finish Loading show main menu screen

                MainMenuScreen mainMenuScreen = new MainMenuScreen();
                mainMenuScreen.Show();

                this.Hide();
            }
        }

        
    }
}
