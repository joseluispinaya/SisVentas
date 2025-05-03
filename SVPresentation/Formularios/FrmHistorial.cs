using Microsoft.Extensions.DependencyInjection;
using SVPresentation.Utilidades;
using SVPresentation.ViewModels;
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
    public partial class FrmHistorial : Form
    {
        private readonly IVentaService _ventaService;
        private readonly IServiceProvider _serviceProvider;
        public FrmHistorial(IVentaService ventaService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _ventaService = ventaService;
            _serviceProvider = serviceProvider;
        }

        private async Task MostarVenta()
        {
            var listaventa = await _ventaService.Lista(
                dtpFechaInicio.Value.ToString("dd/MM/yyyy"),
                dtpFechaFin.Value.ToString("dd/MM/yyyy"),
                txbEncontrar.Text.Trim()
                );

            var listaVN = listaventa.Select(item => new VentaVM
            {
                FechaRegistro = item.FechaRegistro,
                NumeroVenta = item.NumeroVenta,
                Usuario = item.UsuarioRegistro!.NombreUsuario,
                Cliente = item.NombreCliente,
                CantidadTotal = item.CantidadTotal,
                Total = item.PrecioTotal
            }).ToList();

            dgvVenta.DataSource = listaVN;
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            dgvVenta.ImplementarConfiguracion("Ver");
            dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            await MostarVenta();
        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVenta.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var filaSeleccionada = (VentaVM)dgvVenta.CurrentRow.DataBoundItem;
                var _formDetalle = _serviceProvider.GetRequiredService<FrmDetalleVenta>();
                _formDetalle._numeroVenta = filaSeleccionada.NumeroVenta;
                _formDetalle.ShowDialog();

            }
        }
    }
}
