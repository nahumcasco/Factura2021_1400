﻿using System.Windows.Forms;
using Factura2021_1400.Controladores;

namespace Factura2021_1400.Vistas
{
    public partial class FacturaView : Form
    {
        public FacturaView()
        {
            InitializeComponent();
            FacturaController controlador = new FacturaController(this);
        }
    }
}
