namespace OzluSozler
{
    public partial class Form1 : Form
    {
        List<OzluSoz> sozler = OrnekVeri.Getir();

        public Form1()
        {
            InitializeComponent();
            cboSiralama.SelectedIndex = 0;
            VerileriListele();
        }

        private void VerileriListele()
        {
            string ara = txtAra.Text;
            lstSozler.Items.Clear();

            List<OzluSoz> sirali;

            if (cboSiralama.SelectedIndex == 1)
                sirali = sozler.OrderBy(x => x.Derece).ToList();
            else if (cboSiralama.SelectedIndex == 2)
                sirali = sozler.OrderByDescending(x => x.Derece).ToList();
            else
                sirali = sozler;

            foreach (OzluSoz soz in sirali)
            {
                if (string.IsNullOrEmpty(ara) || soz.Soz.Contains(ara, StringComparison.CurrentCultureIgnoreCase) || soz.Yazar.Contains(ara, StringComparison.CurrentCultureIgnoreCase))
                    lstSozler.Items.Add(soz);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OzluSoz ozluSoz = new OzluSoz();
            ozluSoz.Soz = txtSoz.Text;
            ozluSoz.Yazar = txtYazar.Text;
            ozluSoz.Derece = (int)nudDerece.Value;
            sozler.Add(ozluSoz);
            VerileriListele();

            txtSoz.Clear();
            txtYazar.Clear();
            nudDerece.Value = 1;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            VerileriListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstSozler.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Seçili sözü silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (dr == DialogResult.Yes)
                {
                    OzluSoz soz = (OzluSoz)lstSozler.SelectedItem;
                    sozler.Remove(soz);
                    VerileriListele();
                }
            }
        }

        private void cboSiralama_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerileriListele();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("bye bye..");
            // burada kaydetme işlemi (haftaya)
        }
    }
}