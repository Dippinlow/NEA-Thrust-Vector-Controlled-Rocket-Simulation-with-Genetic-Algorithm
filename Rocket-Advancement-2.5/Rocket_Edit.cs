using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rocket_Advancement_2._5
{
    public partial class Rocket_Edit : Form
    {
        public Rocket_Edit()
        {
            InitializeComponent();
            
            txt_width.Text = Convert.ToString(Sim_Data.WIDTH);
            txt_height.Text = Convert.ToString(Sim_Data.HEIGHT);
            txt_fmass.Text = Convert.ToString(Sim_Data.FUEL_MASS);
            txt_dmass.Text = Convert.ToString(Sim_Data.DRY_MASS);
            txt_thrust.Text = Convert.ToString(Sim_Data.MAX_THRUST);
            txt_throttle.Text = Convert.ToString(Sim_Data.THROTTLE_LIMIT);
            txt_gimbal.Text = Convert.ToString(Sim_Data.GIMBAL_RANGE);
            txt_ldrag.Text = Convert.ToString(Sim_Data.LINEAR_DRAG_CONSTANT);
            txt_rdrag.Text = Convert.ToString(Sim_Data.ANGULAR_DRAG_CONSTANT);
            txt_depletion.Text = Convert.ToString(Sim_Data.DEPLETION_RATE);
        }

        private void txt_width_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_height_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_fmass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_dmass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_thrust_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_throttle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_gimbal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_ldrag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_rdrag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_depletion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_setProperties_Click(object sender, EventArgs e)
        {
            try
            {
                Sim_Data.WIDTH = float.Parse(txt_width.Text);
                Sim_Data.HEIGHT = float.Parse(txt_height.Text);
                Sim_Data.FUEL_MASS = float.Parse(txt_fmass.Text);
                Sim_Data.DRY_MASS = float.Parse(txt_dmass.Text);
                Sim_Data.MAX_THRUST = float.Parse(txt_thrust.Text);
                Sim_Data.THROTTLE_LIMIT = float.Parse(txt_throttle.Text);
                Sim_Data.GIMBAL_RANGE = float.Parse(txt_gimbal.Text);
                Sim_Data.LINEAR_DRAG_CONSTANT = float.Parse(txt_ldrag.Text);
                Sim_Data.ANGULAR_DRAG_CONSTANT = float.Parse(txt_rdrag.Text);
                Sim_Data.DEPLETION_RATE = float.Parse(txt_depletion.Text);

                Close();
            }
            catch
            {
                btn_setProperties.BackColor = Color.Red;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
