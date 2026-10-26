
using System;
using System.IO;
using System.Windows.Forms;

namespace FaylMeneceri
{
    public partial class Form1 : Form
    {
        string qovluqYolu = "";

        public Form1()
        {
            InitializeComponent();

            btnQovluq.Click += btnQovluq_Click;
            btnAc.Click += btnAc_Click;
            btnSaxla.Click += btnSaxla_Click;
            btnSil.Click += btnSil_Click;
            lstFayllar.SelectedIndexChanged += lstFayllar_SelectedIndexChanged;

            lblStatus.Text = "Hazırdır";
            lblFaylSayi.Text = "| Fayl sayı: 0";
            txtYol.ReadOnly = true;
            txtMetn.Multiline = true;
            txtMetn.ScrollBars = RichTextBoxScrollBars.Vertical;
        }

        private void btnQovluq_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog q = new FolderBrowserDialog();

            if (q.ShowDialog() == DialogResult.OK)
            {
                qovluqYolu = q.SelectedPath;
                txtYol.Text = qovluqYolu;

                FayllariGoster();

                txtMetn.Clear();
                lblMelumat.Text = "";
            }
        }

        private void FayllariGoster()
        {
            lstFayllar.Items.Clear();

            if (Directory.Exists(qovluqYolu))
            {
                string[] fayllar = Directory.GetFiles(qovluqYolu);

                foreach (string fayl in fayllar)
                {
                    lstFayllar.Items.Add(Path.GetFileName(fayl));
                }

                lblFaylSayi.Text = "| Fayl sayı: " + fayllar.Length;
            }
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            if (lstFayllar.SelectedItem == null)
            {
                MessageBox.Show("Fayl seçilməyib", "Xəta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string fayl = Path.Combine(
                    qovluqYolu, lstFayllar.SelectedItem.ToString());

                txtMetn.Text = File.ReadAllText(fayl);
                txtYol.Text = fayl;

                MelumatGoster(fayl);

                lblStatus.Text = "Fayl açıldı";
            }
        }

        private void btnSaxla_Click(object sender, EventArgs e)
        {
            if (qovluqYolu == "")
            {
                MessageBox.Show("Əvvəlcə qovluq seçin", "Xəta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog sv = new SaveFileDialog();

            sv.InitialDirectory = qovluqYolu;
            sv.Filter = "Mətn faylı (*.txt)|*.txt";
            sv.FileName = "yeni_fayl.txt";

            if (sv.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sv.FileName, txtMetn.Text);

                FayllariGoster();

                string ad = Path.GetFileName(sv.FileName);

                if (lstFayllar.Items.Contains(ad))
                {
                    lstFayllar.SelectedItem = ad;
                }

                txtYol.Text = sv.FileName;

                MelumatGoster(sv.FileName);

                lblStatus.Text = "Fayl yadda saxlanıldı";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstFayllar.SelectedItem == null)
            {
                MessageBox.Show("Silinəcək fayl seçilməyib",
                    "Xəta", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string fayl = Path.Combine(
                qovluqYolu, lstFayllar.SelectedItem.ToString());

            DialogResult d = MessageBox.Show(
                "Seçilmiş fayl silinsinmi?",
                "Sual",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                File.Delete(fayl);

                txtMetn.Clear();
                lblMelumat.Text = "";
                txtYol.Text = qovluqYolu;

                FayllariGoster();

                lblStatus.Text = "Fayl silindi";
            }
        }

        private void lstFayllar_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (lstFayllar.SelectedItem != null)
            {
                string fayl = Path.Combine(
                    qovluqYolu, lstFayllar.SelectedItem.ToString());

                txtYol.Text = fayl;

                MelumatGoster(fayl);
            }
        }

        private void MelumatGoster(string fayl)
        {
            FileInfo f = new FileInfo(fayl);

            double olcu = f.Length / 1024.0;

            lblMelumat.Text =
                "Ad: " + f.Name +
                "     Ölçü: " + olcu.ToString("0.0") + " KB" +
                "     Yaranma tarixi: " +
                f.CreationTime.ToString("dd.MM.yyyy");
        }
    }
}
