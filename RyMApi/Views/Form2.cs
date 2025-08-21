using RyMApi.Controlles;
using RyMApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace RyMApi
{
    public partial class Form2 : Form
    {
        private CharacterControlles controller;
        private List<Character> listaPersonajes;

        public Form2()
        {
            InitializeComponent();
            controller = new CharacterControlles();

            dgvCharacters.SelectionChanged += DgvCharacters_SelectionChanged;
            Buscar_txt.TextChanged += Buscar_txt_TextChanged;
            btnLoad.Click += BtnLoad_Click;
        }

        private async void BtnLoad_Click(object sender, EventArgs e)
        {
            var data = await controller.GetAllCharacters();

            if (data != null && data.results != null)
            {
                listaPersonajes = data.results;

                var vista = listaPersonajes.Select(c => new
                {
                    c.id,
                    c.name,
                    c.status,
                    c.species,
                    Origin = c.origin?.name,
                    Location = c.location?.name,
                    c.image
                }).ToList();

                dgvCharacters.DataSource = vista;
                dgvCharacters.Columns["image"].Visible = false;
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos.");
            }
        }

        private void DgvCharacters_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCharacters.CurrentRow != null)
            {
                var selectedRow = dgvCharacters.CurrentRow;
                txtName.Text = selectedRow.Cells["name"].Value?.ToString();
                txtSpecies.Text = selectedRow.Cells["species"].Value?.ToString();
                txtOrigin.Text = selectedRow.Cells["Origin"].Value?.ToString();
                txtStatus.Text = selectedRow.Cells["status"].Value?.ToString();

                var imageUrl = selectedRow.Cells["image"].Value?.ToString();
                if (!string.IsNullOrEmpty(imageUrl))
                {
                    using (var wc = new WebClient())
                    {
                        try
                        {
                            byte[] bytes = wc.DownloadData(imageUrl);
                            using (var ms = new System.IO.MemoryStream(bytes))
                            {
                                picCharacter.Image = System.Drawing.Image.FromStream(ms);
                            }
                        }
                        catch
                        {
                            picCharacter.Image = null;
                        }
                    }
                }
            }
        }

        private void Buscar_txt_TextChanged(object sender, EventArgs e)
        {
            if (listaPersonajes != null)
            {
                var filtro = Buscar_txt.Text.ToLower();
                var filtrados = listaPersonajes
                    .Where(p => p.name.ToLower().Contains(filtro))
                    .Select(c => new
                    {
                        c.id,
                        c.name,
                        c.status,
                        c.species,
                        Origin = c.origin?.name,
                        Location = c.location?.name,
                        c.image
                    }).ToList();

                dgvCharacters.DataSource = filtrados;
                dgvCharacters.Columns["image"].Visible = false;
            }
        }
    }
}
