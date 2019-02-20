﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaSis.Forms.Aluno
{
    public partial class MensalidadeManter : Form
    {
        public MensalidadeManter()
        {
            InitializeComponent();
        }

        private void txbDataPagto_ValueChanged(object sender, EventArgs e)
        {
            txbDataPagto.Format = DateTimePickerFormat.Short;
        }

        private void txbDataPagto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                txbDataPagto.Format = DateTimePickerFormat.Custom;
                txbValorPatoMens.Value = 0;
            }
        }
    }
}