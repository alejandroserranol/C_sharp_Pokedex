using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_Pokedex
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 0; //El pokemon que estamos viendo


        public VentanaPrincipal()
        {
            InitializeComponent();
            dataGridView1.DataSource = miConexion.getTodosPokemons();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void izq_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual <= 0) { idActual = 1; }

            misPokemons = miConexion.getPokemonPorId(idActual);
            numPkmn.Text = "#" + misPokemons.Rows[0]["id"].ToString();
            nombrePkmn.Text = misPokemons.Rows[0]["nombre"].ToString();
            especiePkmn.Text = misPokemons.Rows[0]["especie"].ToString();
            pesoPkmn.Text = misPokemons.Rows[0]["peso"].ToString();
            alturaPkmn.Text = misPokemons.Rows[0]["altura"].ToString();
            tipo1.Text = misPokemons.Rows[0]["tipo1"].ToString();
            tipo2.Text = misPokemons.Rows[0]["tipo2"].ToString();
            movimiento1.Text = misPokemons.Rows[0]["movimiento1"].ToString();
            movimiento2.Text = misPokemons.Rows[0]["movimiento2"].ToString();
            movimiento3.Text = misPokemons.Rows[0]["movimiento3"].ToString();
            movimiento4.Text = misPokemons.Rows[0]["movimiento4"].ToString();
            imagenPkmn.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void der_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual <= 0) { idActual = 1; }

            misPokemons = miConexion.getPokemonPorId(idActual);
            numPkmn.Text = "#" + misPokemons.Rows[0]["id"].ToString();
            nombrePkmn.Text = misPokemons.Rows[0]["nombre"].ToString();
            especiePkmn.Text = misPokemons.Rows[0]["especie"].ToString();
            pesoPkmn.Text = misPokemons.Rows[0]["peso"].ToString();
            alturaPkmn.Text = misPokemons.Rows[0]["altura"].ToString();
            tipo1.Text = misPokemons.Rows[0]["tipo1"].ToString();
            tipo2.Text = misPokemons.Rows[0]["tipo2"].ToString();
            movimiento1.Text = misPokemons.Rows[0]["movimiento1"].ToString();
            movimiento2.Text = misPokemons.Rows[0]["movimiento2"].ToString();
            movimiento3.Text = misPokemons.Rows[0]["movimiento3"].ToString();
            movimiento4.Text = misPokemons.Rows[0]["movimiento4"].ToString();
            imagenPkmn.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }        
        
        private void off_Click(object sender, EventArgs e)
        {
            idActual = 0;
            numPkmn.Text = "";
            numPkmn.Text = "";
            especiePkmn.Text = "";
            pesoPkmn.Text = "";
            alturaPkmn.Text = "";
            tipo1.Text = "";
            tipo2.Text = "";
            movimiento1.Text = "";
            movimiento2.Text = "";
            movimiento3.Text = "";
            movimiento4.Text = "";
            imagenPkmn.Image = Properties.Resources.pokemon_logo;
        }

        private void sum5_Click(object sender, EventArgs e)
        {
            idActual += 5;
            if (idActual >= 151) { idActual = 151; }

            misPokemons = miConexion.getPokemonPorId(idActual);
            numPkmn.Text = "#" + misPokemons.Rows[0]["id"].ToString();
            nombrePkmn.Text = misPokemons.Rows[0]["nombre"].ToString();
            especiePkmn.Text = misPokemons.Rows[0]["especie"].ToString();
            pesoPkmn.Text = misPokemons.Rows[0]["peso"].ToString();
            alturaPkmn.Text = misPokemons.Rows[0]["altura"].ToString();
            tipo1.Text = misPokemons.Rows[0]["tipo1"].ToString();
            tipo2.Text = misPokemons.Rows[0]["tipo2"].ToString();
            movimiento1.Text = misPokemons.Rows[0]["movimiento1"].ToString();
            movimiento2.Text = misPokemons.Rows[0]["movimiento2"].ToString();
            movimiento3.Text = misPokemons.Rows[0]["movimiento3"].ToString();
            movimiento4.Text = misPokemons.Rows[0]["movimiento4"].ToString();
            imagenPkmn.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void res5_Click(object sender, EventArgs e)
        {
            idActual -= 5;
            if (idActual <= 5) { idActual = 1; }

            misPokemons = miConexion.getPokemonPorId(idActual);
            numPkmn.Text = "#" + misPokemons.Rows[0]["id"].ToString();
            nombrePkmn.Text = misPokemons.Rows[0]["nombre"].ToString();
            especiePkmn.Text = misPokemons.Rows[0]["especie"].ToString();
            pesoPkmn.Text = misPokemons.Rows[0]["peso"].ToString();
            alturaPkmn.Text = misPokemons.Rows[0]["altura"].ToString();
            tipo1.Text = misPokemons.Rows[0]["tipo1"].ToString();
            tipo2.Text = misPokemons.Rows[0]["tipo2"].ToString();
            movimiento1.Text = misPokemons.Rows[0]["movimiento1"].ToString();
            movimiento2.Text = misPokemons.Rows[0]["movimiento2"].ToString();
            movimiento3.Text = misPokemons.Rows[0]["movimiento3"].ToString();
            movimiento4.Text = misPokemons.Rows[0]["movimiento4"].ToString();
            imagenPkmn.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numPkmn.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            nombrePkmn.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            especiePkmn.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            pesoPkmn.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            alturaPkmn.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            tipo1.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            tipo2.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            movimiento1.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            movimiento2.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            movimiento3.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            movimiento4.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            imagenPkmn.Image = convierteBlobAImagen((byte[])dataGridView1.Rows[e.RowIndex].Cells["imagen"].Value);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            String nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            String id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();

            MessageBox.Show(miConexion.actualizaPokemons(id, nombre));
        }


        //Método para cerrar la aplicación entera cuando se cierra el form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }
    }
}
