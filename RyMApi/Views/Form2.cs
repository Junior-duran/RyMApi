using RyMApi.Controlles;
using RyMApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyMApi
{
    
    public partial class Form2 : Form
    {
        private CharacterControlles controller;
        private List<Character> listaPersonajes;

        // Token de cancelación para abortar tareas asincrónicas si es necesario
        private CancellationTokenSource cts;

        public Form2()
        {
            InitializeComponent();
            controller = new CharacterControlles();

            dgvCharacters.SelectionChanged += DgvCharacters_SelectionChanged;
            Buscar_txt.TextChanged += Buscar_txt_TextChanged;
            btnLoad.Click += BtnLoad_Click;
        }


        /// Evento click del botón de carga.
        /// Se usa CancellationToken para poder cancelar una carga anterior.
        /// Llama a la API de personajes de forma asincrónica.
        /// Usa LINQ (Select + ToList) para proyectar la lista de personajes en una vista personalizada.
        private async void BtnLoad_Click(object sender, EventArgs e)
        {
            // Si había una tarea previa en ejecución, la cancelamos
            if (cts != null)
                cts.Cancel();

            cts = new CancellationTokenSource();

            try
            {
                var data = await controller.GetAllCharacters();

                if (data != null && data.results != null)
                {
                    listaPersonajes = data.results;

                    /// LINQ: 
                    /// - Select() → proyecta cada objeto Character en un objeto anónimo con solo los campos requeridos.
                    /// - ToList() → convierte la proyección en lista para poder asignarla al DataGridView.
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
            catch (OperationCanceledException)
            {
                MessageBox.Show("Carga cancelada por el usuario.");
            }
        }

        /// Evento cuando cambia la selección del DataGridView.
        /// Descarga la imagen de manera asincrónica con Task.Run()
        /// para que no bloquee la UI.
        private async void DgvCharacters_SelectionChanged(object sender, EventArgs e)
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
                    try
                    {
                        // Ejecutamos la descarga en un hilo aparte (Task.Run)
                        var img = await Task.Run(() =>
                        {
                            using (var wc = new WebClient())
                            {
                                byte[] bytes = wc.DownloadData(imageUrl);
                                using (var ms = new System.IO.MemoryStream(bytes))
                                {
                                    return System.Drawing.Image.FromStream(ms);
                                }
                            }
                        });

                        picCharacter.Image = img;
                    }
                    catch
                    {
                        picCharacter.Image = null;
                    }
                }
            }
        }

        
        /// Evento para filtrar los personajes según el texto buscado.
        /// Usa LINQ (Where + Select + ToList) para filtrar por nombre y proyectar los resultados.     
        private void Buscar_txt_TextChanged(object sender, EventArgs e)
        {
            if (listaPersonajes != null)
            {
                var filtro = Buscar_txt.Text.ToLower();

                /// LINQ:
                /// Where() → filtra los personajes cuyo nombre contiene el texto escrito.
                /// Select() → proyecta los resultados en un objeto anónimo con los campos necesarios.
                /// ToList() → convierte el resultado en lista para asignarlo al DataGridView.
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
