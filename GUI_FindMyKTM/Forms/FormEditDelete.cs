using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_Laporan_KTM;

namespace GUI_FindMyKTM.Forms
{
    public partial class FormEditDelete : Form
    {
        StateKTM state = new StateKTM();
        public FormEditDelete()
        {
            InitializeComponent();
            UpdateLabel();
            LabelSelamat.Visible = false;
        }
        private void UpdateLabel()
        {
            switch (state.currentState)
            {
                case StateKTM.PengerjaanState.BelumDiProses:
                    LabelProses.Text = "Belum di proses";
                    ButtonCari.Visible = true;
                    ButtonProses.Visible =false;
                    ButtonBermasalh.Visible = false;
                    break;
                case StateKTM.PengerjaanState.SudahDiProses:
                    LabelProses.Text = "Sudah di proses";
                    ButtonCari.Visible = false;
                    ButtonProses.Visible = true;
                    ButtonBermasalh.Visible = true;
                    break;
               case StateKTM.PengerjaanState.Bermasalalah:
                    LabelProses.Text = "Bermasalah";
                    ButtonCari.Visible = false;
                    ButtonProses.Visible = true;
                    ButtonBermasalh.Visible = true;
                    break;


                case StateKTM.PengerjaanState.Selesai:
                    LabelProses.Text = "Selesai ";
                    ButtonCari.Visible = false;
                    LabelSelamat.Visible = true;
                    break;
                default:
                    LabelProses.Text = "State tidak diketahui";
                    break;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            state.ActivateTrigger(StateKTM.Trigger.Bermasalah);
            UpdateLabel();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void LabelSelamat_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCari_Click(object sender, EventArgs e)
        {
            state.ActivateTrigger(StateKTM.Trigger.Cari);
            UpdateLabel();
        }

        private void ButtonProses_Click(object sender, EventArgs e)
        {
            state.ActivateTrigger(StateKTM.Trigger.Proses);
            UpdateLabel();
        }
    }
}
