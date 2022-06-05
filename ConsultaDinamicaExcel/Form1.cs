using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ConsultaDinamicaExcel
{
    public partial class Form1 : Form
    {
        private string arquivoExel = @"estrutura";

        public Form1()
        {
            InitializeComponent();
        }
        private void CarregarDadosExcel()
        {
            try
            {
                //limpa o combobox
                cbo_Busca.Items.Clear();

                //converter dados para um datatable
                DataTable dt = GetTabelaExcel(arquivoExel);
                dgv_dados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgv_dados.DataSource = dt;

                //total de registros
                label_numero_registros.Text = (dgv_dados.Rows.Count - 1).ToString();
                string[] listaNomeColunas = dt.Columns.OfType<DataColumn>().Select(x => x.ColumnName).ToArray();

                //nome das colunas no combobox
                cbo_Busca.Items.AddRange(listaNomeColunas);

                if (cbo_Busca.Items.Count > 0)
                {
                    cbo_Busca.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro :" + ex.Message);
            }
        }

        private DataTable GetTabelaExcel(string arquivoExcel)
        {
            DataTable dt = new();
            try
            {
                //pega a extensão do arquivo
                string Ext = Path.GetExtension(arquivoExcel);
                string connectionString = "";

                //verifica a versão do Excel pela extensão
                if (Ext == ".xls")
                { //para o  Excel 97-03    
                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + arquivoExcel + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                else if (Ext == ".xlsx")
                { //para o  Excel 07 e superior
                    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + arquivoExcel + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }

                OleDbConnection conn = new(connectionString);
                OleDbCommand cmd = new();
                OleDbDataAdapter dataAdapter = new();
                cmd.Connection = conn;
                conn.Open();
                DataTable dtSchema;
                dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string nomePlanilha = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                conn.Close();
                //le todos os dados da planilha para o Data Table    
                conn.Open();
                cmd.CommandText = "SELECT * From [" + nomePlanilha + "]";
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        private void btn_Procurar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dgv_dados.DataSource).DefaultView.RowFilter = string.Format("" + cbo_Busca.Text + " like '%{0}%'", txt_Criterio.Text.Trim().Replace("'", "''"));
                label_numero_registros.Text = (dgv_dados.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
        }

        private void btn_importar_excel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btn_arquivo.Text) && File.Exists(btn_arquivo.Text))
            {
                arquivoExel = btn_arquivo.Text;
                CarregarDadosExcel();
            }
            else
            {
                CarregarDadosExcel();
            }
        }

        private void btn_Exibir_Todos_Click(object sender, EventArgs e)
        {
            CarregarDadosExcel();
        }

        private void btn_arquivo_Click(object sender, EventArgs e)
        {
            DialogResult drResult = ofd1.ShowDialog();

            if (drResult == System.Windows.Forms.DialogResult.OK)
                btn_arquivo.Text = ofd1.FileName;
        }
    }
}