using AlbumsTS.Model;
using AlbumsTS.Controller;
using Microsoft.IdentityModel.Logging;
using System.Net;

namespace AlbumsTS
{
    public partial class Form1 : Form
    {
        private IControllerTS controller = new ControllerTS();
        private List<TSmodel> albums = new List<TSmodel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAlbums();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            try
            {
                albums = controller.GetAlbums();

                cmbTS.DisplayMember = "Nombre";
                cmbTS.ValueMember = "ImagenURL";
                cmbTS.DataSource = albums;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error al cargar los albums: " + ex.Message);
            }
        }

        private async Task LoadImage(string url)
        {
            //try
            //{
            //    if (string.IsNullOrWhiteSpace(url) || !Uri.IsWellFormedUriString(url, UriKind.Absolute))
            //    {
            //        throw new Exception("URL de imagen no válida.");
            //    }

            //    using (HttpClient client = new HttpClient())
            //    {
            //        HttpResponseMessage response = await client.DeleteAsync(url);

            //        if (!response.IsSuccessStatusCode)
            //        {
            //            throw new Exception($"Error al obtener la imagen. Código HTTP: {response.StatusCode}");
            //        }

            //        byte[] imageBytes = await response.Content.ReadAsByteArrayAsync();

            //        using (var ms = new System.IO.MemoryStream(imageBytes))
            //        {
            //            pctboxTS.Image = Image.FromStream(ms);
            //        }
            //    }
            //}
            //catch (HttpRequestException ex)
            //{
            //    MessageBox.Show("Error de conexión al obtener la imagen: " + ex.Message);
            //    pctboxTS.Image = null;
            //}
            //catch (ArgumentException ex)
            //{
            //    MessageBox.Show("La imagen descargada no es válida: " + ex.Message);
            //    pctboxTS.Image = null;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("No se pudo cargar la imagen: " + ex.Message);
            //    pctboxTS.Image = null;
            //}
            try
            {
                using (HttpClient client = new HttpClient())  // Usamos HttpClient en lugar de WebClient
                {
                    byte[] imageBytes = await client.GetByteArrayAsync(url);  // Método asincrónico para descargar los datos
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        pctboxTS.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.Message);
                pctboxTS.Image = null;
            }
        }

        private void LoadAlbums()
        {
            try
            {
                dataGridTS.DataSource = controller.GetAlbums();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private async void cmbTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? imgUrl = cmbTS.SelectedValue as string;

            if (!string.IsNullOrEmpty(imgUrl))
            {
                await LoadImage(imgUrl);
            }
            else
            {
                pctboxTS.Image = null;
            }
        }
    }
}
