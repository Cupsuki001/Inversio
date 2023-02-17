namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double inv, ing, egr, util, imp;

            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("El campo <<Inversión>> no puede estar en blanco", "Warning");
            }
            else
            {
                inv = double.Parse(maskedTextBox1.Text);
                if(inv < 500 && inv > 250000)
                {
                    MessageBox.Show("Rango de inversión de 500 a 250000", "Error");
                    maskedTextBox1.Text = "";
                    maskedTextBox1.Focus();
                }
                else
                {
                    ing = double.Parse(maskedTextBox2.Text);
                    egr = double.Parse(maskedTextBox3.Text);
                    if(egr >= ing)
                    {
                        MessageBox.Show("El ingreso no puede ser menor o igual que el egreso", "Error");
                        maskedTextBox2.Text = "";
                        maskedTextBox2.Focus();
                        maskedTextBox3.Text = "";
                    }
                    else
                    {
                        if (comboBox1.Text.Equals("Corto (1-3 años)"))
                        {
                            dataGridView1.ColumnCount = 4;
                            dataGridView1.RowCount = 4;

                            for (int i = 0; i < 4; i++)
                            {
                                dataGridView1[i, 0].Value = ing;
                                dataGridView1[i, 1].Value = egr;
                                util = ing - egr;
                                dataGridView1[i, 2].Value = util;
                                imp = util * 0.30;
                                dataGridView1[i, 3].Value = imp;
                                ing = ing + (ing * 0.10);
                            }

                        }
                        if (comboBox1.Text.Equals("Mediano (4-10 años)"))
                        {
                            dataGridView1.ColumnCount = 11;
                            dataGridView1.RowCount = 4;

                            for (int i = 0; i < 11; i++)
                            {
                                dataGridView1[i, 0].Value = ing;
                                dataGridView1[i, 1].Value = egr;
                                util = ing - egr;
                                dataGridView1[i, 2].Value = util;
                                imp = util * 0.30;
                                dataGridView1[i, 3].Value = imp;
                                ing = ing + (ing * 0.10);
                            }


                        }
                        if (comboBox1.Text.Equals("Largo (10-15 años)"))
                        {
                            dataGridView1.ColumnCount = 16;
                            dataGridView1.RowCount = 4;
                            for (int i = 0; i < 16; i++)
                            {
                                dataGridView1[i, 0].Value = ing;
                                dataGridView1[i, 1].Value = egr;
                                util = ing - egr;
                                dataGridView1[i, 2].Value = util;
                                imp = util * 0.30;
                                dataGridView1[i, 3].Value = imp;
                                ing = ing + (ing * 0.10);
                            }

                        }

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            comboBox1.Text = "";
        }
    }
}