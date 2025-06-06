﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento = txtNombre.Text;
           
            //listView es un objeto tipo List.
            lwElementos.Items.Add(elemento);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Azul");
            cboColorFavorito.Items.Add("Negro");
            cboColorFavorito.Items.Add("Blanco");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text; 
            DateTime fecha = dtpFechaNacimiento.Value;

            // operador ternario -> es un IF en una sola linea..
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta ni aca el chocolate";
            string tipo;
            if (rbtMuggle.Checked)
                tipo = "Muggle";
            else if (rbtWizzard.Checked)
                tipo = "Wizzard";
            else
                tipo = "Sqibs";

            string colorFavorito = cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString();
            string mensaje = chocolate + ", es " + tipo + ", su color favorito es: " + colorFavorito + ", su número favorito es: " + numeroFavorito; 
            MessageBox.Show("Nomkbre: " + nombre + " Fecha: " + fecha + " " + mensaje);
        }
    }
}
