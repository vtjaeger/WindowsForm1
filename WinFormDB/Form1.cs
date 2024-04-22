using MySql.Data.MySqlClient;

namespace WinFormDB
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=root;database=db_agenda";
                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO contato (nome, email, telefone) VALUES ('" + txtName.Text + "', '" + txtEmail.Text + "', '" + txtTelefone.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();

                comando.ExecuteReader();
                MessageBox.Show("executado");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
            finally
            {
                Conexao.Close();
            }
        }
    }
}