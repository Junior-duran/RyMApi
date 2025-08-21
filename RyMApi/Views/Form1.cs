using RyMApi.Controlles;
using RyMApi.Models;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyMApi
{
    public partial class Form1 : Form
    {
        private CharacterControlles controller;
       
        private List<Character> listaPersonajes; // Ahora es una lista tipada

        public Form1()
        {
            InitializeComponent();
            controller = new CharacterControlles();

            // Evento para cuando se selecciona una fila
            dgvCharacters.SelectionChanged += DataGridView1_SelectionChanged;

            // Evento para filtrar mientras escribes
            Buscar_txt.TextChanged += Buscar_txt_TextChanged;
        }

        public async void button1_Click(object sender, EventArgs e)
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
                    c.image // Guardamos la URL para usarla luego
                }).ToList();

                dgvCharacters.DataSource = vista;
                dgvCharacters.Columns["image"].Visible = false; // Ocultar URL de imagen
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los datos.");
            }
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCharacters.CurrentRow != null)
            {
                var imageUrl = dgvCharacters.CurrentRow.Cells["image"].Value?.ToString();
                if (!string.IsNullOrEmpty(imageUrl))
                {
                    using (var wc = new WebClient())
                    {
                        byte[] bytes = wc.DownloadData(imageUrl);
                        using (var ms = new System.IO.MemoryStream(bytes))
                        {
                            Personajes.Image = Image.FromStream(ms);
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
                    .ToList();

                dgvCharacters.DataSource = filtrados;
            }
            else
            {
                MessageBox.Show("No hay personajes cargados para filtrar.");
            }
        }
    }
}
