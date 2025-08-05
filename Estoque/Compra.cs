using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estoque.Classes;
using Estoque.Databse;
using Npgsql;

namespace Estoque
{
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();

        }

        private async Task button1_Click(object sender, EventArgs e)
        {


        }

        private async Task Inserir()
        {
            string connection_string = "Host=ep-flat-frog-ack9fft2-pooler.sa-east-1.aws.neon.tech; Database=neondb; Username=neondb_owner; Password=npg_Zokm0BVp2XAT; SSL Mode=VerifyFull; Channel Binding=Require;";

            await using var conn = new NpgsqlConnection(connection_string);

            try
            {
                await conn.OpenAsync();

                await using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;

                    cmd.CommandText = "INSERT INTO produtos (name, value) VALUES (@name, @value);";
                    cmd.Parameters.AddWithValue("name", "Teste C#");
                    cmd.Parameters.AddWithValue("value", 1);
                    await cmd.ExecuteNonQueryAsync();
                    cmd.Parameters.Clear();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InserirLinq();
        }

        private async Task InserirLinq()
        {
            DbConnection _context = new DbConnection();
            //Produtos p = new Produtos("banana", 22);
            //_context.Produtos.Add(p);
            //await _context.SaveChangesAsync();
        }
    }
}
