using System.Data;
using System.Data.SqlClient;

namespace BancoDeDadosLocal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CriarTabela(object sender, EventArgs e)
        {
            string stringDeconexão = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Miriam\\Downloads\\BancoDeDadosLocal\\DatabaseTeste.mdf;Integrated Security=True";
            string stringDocomando = "CREATE TABLE Cadastro(Id int, Nome nchar(100), Telefone nchar(9), Idade int)";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeconexão);
                SqlCommand sqlCommand = new SqlCommand(stringDocomando, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void DeletarTabela(object sender, EventArgs e)
        {
            string stringDeconexão = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Miriam\\Downloads\\BancoDeDadosLocal\\DatabaseTeste.mdf;Integrated Security=True";
            string stringDocomando = "DROP TABLE Cadastro";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeconexão);
                SqlCommand sqlCommand = new SqlCommand(stringDocomando, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void InserirDados(object sender, EventArgs e)
        {
            string stringDeconexão = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Miriam\\Downloads\\BancoDeDadosLocal\\DatabaseTeste.mdf;Integrated Security=True";
            string stringDocomando = "INSERT INTO Cadastro(Id, Nome, Telefone, Idade) VALUES (1, 'Miriam', 123456789, 19)";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeconexão);
                SqlCommand sqlCommand = new SqlCommand(stringDocomando, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
    }
}