using SVRepository.Entities;
using SVServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVPresentation.Formularios
{
    public partial class FrmNegocio : Form
    {
        private readonly INegocioService _negocioService;
        OpenFileDialog _openFileDialog = new OpenFileDialog();
        Negocio _negocio = new Negocio();

        //private readonly INegocioService _negocioService;
        public FrmNegocio(INegocioService negocioService)
        {
            InitializeComponent();
            _negocioService = negocioService;
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeSucces(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void FrmNegocio_Load(object sender, EventArgs e)
        {
            _openFileDialog.Filter = "Escoger imagen (*.JPG;*.PNG) | *.jpg;*.png";
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            _negocio = await _negocioService.Obtener();

            txbRazonSocial.Text = _negocio.RazonSocial;
            txbRuc.Text = _negocio.RUC;
            txbDireccion.Text = _negocio.Direccion;
            txbCelular.Text = _negocio.Celular;
            txbCorreo.Text = _negocio.Correo;
            txbSimboloMo.Text = _negocio.SimboloMoneda;

            string carpetaImagenes = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)!.Parent!.Parent!.Parent!.FullName, "FotosNego");

            if (!string.IsNullOrEmpty(_negocio.UrlLogo))
            {
                string rutaImagen = Path.Combine(carpetaImagenes, _negocio.UrlLogo);
                if (File.Exists(rutaImagen))
                {
                    using (FileStream fs = new(rutaImagen, FileMode.Open, FileAccess.Read))
                    {
                        pbLogo.Image = Image.FromStream(fs);
                    }
                }
                else
                {
                    MensajeError("Imagen no encontrada");
                }
            }

            //if (_negocio.UrlLogo != "")
            //{
            //    string rutaImagen = Path.Combine(carpetaImagenes, _negocio.UrlLogo!);
            //    if (File.Exists(rutaImagen))
            //    {
            //        pbLogo.Image = Image.FromFile(rutaImagen);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Imagen no encontrada");
            //    }
            //}

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Liberar la imagen anterior si existe
                if (pbLogo.Image != null)
                {
                    pbLogo.Image.Dispose();
                    pbLogo.Image = null;
                }

                string ruta = _openFileDialog.FileName;

                // Cargar nueva imagen SIN bloquear el archivo
                using (FileStream fs = new(ruta, FileMode.Open, FileAccess.Read))
                {
                    pbLogo.Image = Image.FromStream(fs);
                }

                txbRutaImagen.Text = ruta;

                //_openFileDialog.OpenFile();
                //string ruta = _openFileDialog.FileName;
                //pbLogo.Image = Image.FromFile(ruta);
                //txbRutaImagen.Text = ruta;
            }
        }

        private bool CopiarImagen(string rutaOrigen, out string nombreArchivoGenerado)
        {
            nombreArchivoGenerado = "";

            try
            {
                var extension = Path.GetExtension(rutaOrigen);
                var guid = Guid.NewGuid().ToString();
                var nombreImagen = $"{guid}{extension}";

                string carpetaDestino = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)!.Parent!.Parent!.Parent!.FullName, "FotosNego");

                if (!Directory.Exists(carpetaDestino))
                {
                    Directory.CreateDirectory(carpetaDestino);
                }

                string rutaDestino = Path.Combine(carpetaDestino, nombreImagen);

                if (!File.Exists(rutaDestino))
                {
                    File.Copy(rutaOrigen, rutaDestino);
                }

                nombreArchivoGenerado = nombreImagen;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            Negocio objeto = new Negocio();

            if (_openFileDialog.FileName != "")
            {
                if (CopiarImagen(_openFileDialog.FileName, out string nombreArchivo))
                {
                    if (!string.IsNullOrEmpty(_negocio.UrlLogo))
                    {
                        string carpetaImagenes = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)!.Parent!.Parent!.Parent!.FullName, "FotosNego");
                        string oldRutaImagen = Path.Combine(carpetaImagenes, _negocio.UrlLogo);

                        if (File.Exists(oldRutaImagen))
                        {
                            File.Delete(oldRutaImagen);
                        }
                    }
                    objeto.UrlLogo = nombreArchivo;
                    objeto.NombreLogo = Guid.NewGuid().ToString();

                }
                else
                {
                    MensajeError("Ocurrió un error al copiar la imagen, intente más tarde.");
                    return;
                }
            }
            else
            {
                objeto.UrlLogo = _negocio.UrlLogo;
                objeto.NombreLogo = _negocio.NombreLogo;
            }

            objeto.RazonSocial = txbRazonSocial.Text.Trim();
            objeto.RUC = txbRuc.Text.Trim();
            objeto.Direccion = txbDireccion.Text.Trim();
            objeto.Celular = txbCelular.Text.Trim();
            objeto.Correo = txbCorreo.Text.Trim();
            objeto.SimboloMoneda = txbSimboloMo.Text.Trim();

            try
            {
                await _negocioService.Editar(objeto);
                MensajeSucces("La información fue guardada exitosamente.");
                _negocio = objeto;
                txbRutaImagen.Text = "";
                _openFileDialog = new OpenFileDialog
                {
                    Filter = "Escoger imagen (*.JPG;*.PNG) | *.jpg;*.png"
                };
            }
            catch (Exception)
            {
                MensajeError("Ocurrió un error al guardar los cambios, intente más tarde.");
            }

        }
    }
}
