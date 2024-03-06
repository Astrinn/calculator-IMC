using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textHeight.Clear();
            cmbSex.Text = "";
            textName.Focus();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            try //tente executar
            {
                Double Height = 0, PesoIdeal = 0;
                Height = double.Parse(textHeight.Text);
                if (cmbSex.Text == "Feminine")
                {
                    PesoIdeal = (62.7 * Height) - 44.7;
                    MessageBox.Show(textName.Text + " your ideal weight is: " + PesoIdeal.ToString() + " KG", "Ideal Weigth", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (cmbSex.Text == "Masculine")
                {
                    PesoIdeal = (72.7 * Height) - 58;
                    MessageBox.Show(textName.Text + " your ideal weight is: " + PesoIdeal.ToString() + " KG", "Ideal Weigth", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Select your gender", "Ideal Weigth", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception) //caso de erro execute isso
            {
                MessageBox.Show("CHECK THE INFORMED VALUES", "Ideal Weigth", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void textHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
