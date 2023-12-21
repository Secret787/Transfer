namespace Lab4
{
    public partial class Form1 : Form
    {
        Dictionary<char, double> ansambl = new Dictionary<char, double>();
        Dictionary<char, Dictionary<char, double>> collection = new Dictionary<char, Dictionary<char, double>>();
        public Form1()
        {
            InitializeComponent();
        }
        private void func (DataGridView dgv, int i, int j, string value1, string value2)
        {

        }


        private void btn_ok_Click(object sender, System.EventArgs e)
        {
            ansambl.Clear();
            collection.Clear();

            string text = tbx_message.Text;
            char[] symbols = text.ToCharArray();


            foreach (char ch in text)
            {
                if (!ansambl.ContainsKey(ch))
                {
                    ansambl[ch] = 1.0 * text.Count(x => x == ch) / text.Length;
                }
            }


            foreach (char ch in ansambl.Keys)
            {
                collection.Add(ch, new Dictionary<char, double>());
                foreach (char ch2 in ansambl.Keys)
                {
                    if (ch != ch2) collection[ch].Add(ch2, 0.0);
                    else collection[ch].Add(ch2, ansambl[ch]);
                }
            }

            dgv_source.RowCount = ansambl.Count + 1;
            dgv_source.ColumnCount = 2;

            dgv_source.Rows[0].Cells[0].Value = "Символ";
            dgv_source.Rows[0].Cells[1].Value = "Частота";

            int k = 1;
            foreach (var symbol in ansambl)
            {
                dgv_source.Rows[k].Cells[0].Value = symbol.Key;
                dgv_source.Rows[k].Cells[1].Value = Math.Round(Convert.ToDouble(symbol.Value), 3);
                k++;
            }

            dgv_channel.RowCount = ansambl.Count + 1;
            dgv_channel.ColumnCount = ansambl.Count + 1;


            int i = 0;
            foreach (char ch in ansambl.Keys)
            {
                dgv_channel.Rows[0].Cells[i + 1].Value = ch + " (прием.)";
                dgv_channel.Rows[i + 1].Cells[0].Value = ch + " (ист.)";
                dgv_channel.Columns[i + 1].Width = 45;

                i++;
            }

            int row = 0;

            foreach (char ch in ansambl.Keys)
            {
                int col = 0;
                foreach (char ch2 in ansambl.Keys)
                {
                    dgv_channel.Rows[row + 1].Cells[col + 1].Value = Math.Round(Convert.ToDouble(collection[ch][ch2]), 3);
                    col++;
                }
                row++;
            }

        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            Dictionary<char, double> sum_row = new Dictionary<char, double>();
            Dictionary<char, double> sum_col = new Dictionary<char, double>();
            Random r = new Random();
            foreach (char ch in ansambl.Keys)
            {
                sum_row[ch] = 0;
                sum_col[ch] = 0;
            }

            foreach (char ch in ansambl.Keys)
            {
                foreach (char ch2 in ansambl.Keys)
                {
                    collection[ch][ch2] = r.NextDouble();
                    sum_row[ch] += collection[ch][ch2];
                    sum_col[ch2] += collection[ch][ch2];
                }
            }

            foreach (char ch in ansambl.Keys)
            {
                foreach (char ch2 in ansambl.Keys)
                {
                    collection[ch][ch2] = collection[ch][ch2] / sum_row[ch] * ansambl[ch];
                }
            }


            int row = 0;
            foreach (char ch in ansambl.Keys)
            {
                int col = 0;
                foreach (char ch2 in ansambl.Keys)
                {
                    dgv_channel.Rows[row + 1].Cells[col + 1].Value = Math.Round(Convert.ToDouble(collection[ch][ch2]), 3);
                    col++;
                }
                row++;
            }
        }

        private void bnt_sym_Click(object sender, EventArgs e)
        {
            Dictionary<char, double> sum_row = new Dictionary<char, double>();
            Dictionary<char, double> sum_col = new Dictionary<char, double>();
            foreach (char ch in ansambl.Keys)
            {
                sum_row[ch] = 0;
                sum_col[ch] = 0;
            }

            try
            {
                double proba = Convert.ToDouble(tbx_proba.Text);
                foreach (char ch in ansambl.Keys)
                {
                    foreach (char ch2 in ansambl.Keys)
                    {
                        if (ch == ch2) collection[ch][ch2] = 1 - proba;
                        else collection[ch][ch2] = proba / (collection.Count - 1);
                        sum_row[ch] += collection[ch][ch2];
                        sum_col[ch2] += collection[ch][ch2];
                    }
                }

                foreach (char ch in ansambl.Keys)
                {
                    foreach (char ch2 in ansambl.Keys)
                    {
                        collection[ch][ch2] = collection[ch][ch2] / sum_row[ch] * ansambl[ch];
                    }
                }


                int row = 0;

                foreach (char ch in ansambl.Keys)
                {
                    int col = 0;
                    foreach (char ch2 in ansambl.Keys)
                    {
                        dgv_channel.Rows[row + 1].Cells[col + 1].Value = Math.Round(Convert.ToDouble(collection[ch][ch2]), 3);
                        col++;
                    }
                    row++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверное число: " + tbx_proba.Text, "Ошибка!!!");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbx_message.Clear();
            dgv_channel.Columns.Clear();
            dgv_channel.Rows.Clear();

            dgv_source.Columns.Clear();
            dgv_source.Rows.Clear();

            dgv_info.Columns.Clear();
            dgv_info.Rows.Clear();

            lbl_max_res.Text = string.Empty;
            lbl_cross_res.Text = string.Empty;
        }

        private void btn_solve_Click(object sender, EventArgs e)
        {
            double ce = 0;
            for (int i = 1; i < dgv_channel.RowCount; i++)
                for (int j = 1; j < dgv_channel.ColumnCount; j++)
                {
                    double p = Convert.ToDouble(dgv_channel.Rows[i].Cells[j].Value);
                    if (p > 0) ce += -p * Math.Log(p) / Math.Log(2);
                }
            lbl_cross_res.Text = Math.Round(ce,4).ToString();
            lbl_max_res.Text = Math.Round((Math.Log(dgv_channel.RowCount - 1) / Math.Log(2)), 4).ToString();

            dgv_info.RowCount = ansambl.Count + 1;
            dgv_info.ColumnCount = 2;

            dgv_info.Rows[0].Cells[0].Value = "Символ";
            dgv_info.Rows[0].Cells[1].Value = "Информация";

            int k = 0;
            foreach (char ch in ansambl.Keys)
            {
                k++;
                dgv_info.Rows[k].Cells[0].Value = ch;
                dgv_info.Rows[k].Cells[1].Value = Math.Round(Convert.ToDouble(-Math.Log(ansambl[ch]) / Math.Log(2)), 3);
            }
        }

    }
}