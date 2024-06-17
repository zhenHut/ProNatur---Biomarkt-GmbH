using System;
using System.Windows.Forms;

namespace ProNatur___Biomarkt_GmbH
{
    public partial class MainMenuScreen : Form
    {
        #region Constructor
        public MainMenuScreen()
        {
            InitializeComponent();
        }
        #endregion


        #region Events
        private void BtnProduct_Click(object sender, EventArgs e)
        {
            ProductsScreen productsScreen = new ProductsScreen();
            productsScreen.Show();
            this.Hide();
        }

        private void MainMenuScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
