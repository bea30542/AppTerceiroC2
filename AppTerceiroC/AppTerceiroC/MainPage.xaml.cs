using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTerceiroC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSalvar_Clicked(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Conexao.strConexao);
            MySqlCommand inserirNome = new MySqlCommand(ComandoSQL.inserirNome, conn);

            inserirNome.Parameters.AddWithValue("@ID_ALUNO_CPF", txtNome.Text);
            conn.Open();
            inserirNome.ExecuteNonQuery();
            conn.Close();
            txtNome.Text = "";

        }
    }
}
