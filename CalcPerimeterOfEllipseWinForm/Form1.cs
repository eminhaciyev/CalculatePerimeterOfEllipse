using CalcPerimeterOfEllipseWinForm.Core.ApiService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CalcPerimeterOfEllipseWinForm.Response.Response;

namespace CalcPerimeterOfEllipseWinForm
{
    public partial class Form1 : Form
    {
        private readonly ApiRequestService _api = new ApiRequestService(default);
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSendToServer_Click(object sender, EventArgs e)
        {
            pcbLoader.Visible = true;

            try
            {
                uint size = Convert.ToUInt32(txtSizeValue.Text.Trim());

                var url = $"https://kutez.com/testapi/get_diameter.php?size={size}";

                //Request Get method with url

                var result = await _api.GetAsync<Root>(url);

                if (result.status == "fail")
                {
                    MessageBox.Show("You don't have to enter more than 5 or less than 1!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSizeValue.Text = "";
                    pcbLoader.Visible = false;
                    return;
                }

                lblBigDIameterValue.Text = result.BigDiameter;
                lblSmallDiameterValue.Text = result.SmallDiameter;
                pcbLoader.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Value is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pcbLoader.Visible = false;
                pcbLoader.Visible = false;
                return;
            }

            

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            pcbLoader.Visible = true;

            int bigDiameter = Convert.ToInt32(lblBigDIameterValue.Text);
            int smallDiameter = Convert.ToInt32(lblSmallDiameterValue.Text);

            // Calculate approximation formulas of perimeter of ellipse

            //Formule: 2π √(a^2 + b^2)/2

            lblPerimeterResult.Text = Perimeter(bigDiameter,  smallDiameter).ToString();

            pcbLoader.Visible = false;
        }

        public double Perimeter(int bigD, int smallD)
        {
            double result = 2 * 3.14 * Math.Sqrt((bigD * bigD) + (smallD * smallD) / 2);

            return result;
        }

        public void Reset()
        {
            txtSizeValue.Text = "";
            lblBigDIameterValue.Text = "";
            lblSmallDiameterValue.Text = "";
            lblPerimeterResult.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
