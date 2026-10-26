
namespace FaylMeneceri
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnQovluq = new Button();
            btnAc = new Button();
            btnSaxla = new Button();
            btnSil = new Button();
            lstFayllar = new ListBox();
            txtMetn = new RichTextBox();
            txtYol = new TextBox();
            lblMelumat = new Label();
            lblFayllar = new Label();
            lblMetn = new Label();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblFaylSayi = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();

            btnQovluq.Location = new Point(30, 25);
            btnQovluq.Size = new Size(130, 38);
            btnQovluq.Text = "Qovluq seç";
            btnQovluq.UseVisualStyleBackColor = true;

            btnAc.Location = new Point(175, 25);
            btnAc.Size = new Size(120, 38);
            btnAc.Text = "Aç";
            btnAc.UseVisualStyleBackColor = true;

            btnSaxla.Location = new Point(310, 25);
            btnSaxla.Size = new Size(130, 38);
            btnSaxla.Text = "Yadda saxla";
            btnSaxla.UseVisualStyleBackColor = true;

            btnSil.Location = new Point(455, 25);
            btnSil.Size = new Size(120, 38);
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;

            txtYol.Location = new Point(590, 30);
            txtYol.Size = new Size(370, 23);
            txtYol.ReadOnly = true;
            txtYol.Anchor = AnchorStyles.Top | AnchorStyles.Left |
                            AnchorStyles.Right;

            lblFayllar.Location = new Point(30, 80);
            lblFayllar.Size = new Size(240, 20);
            lblFayllar.Text = "Fayllar";

            lstFayllar.Location = new Point(30, 105);
            lstFayllar.Size = new Size(240, 350);
            lstFayllar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                                AnchorStyles.Left;

            lblMetn.Location = new Point(285, 80);
            lblMetn.Size = new Size(100, 20);
            lblMetn.Text = "Mətn";

            txtMetn.Location = new Point(285, 105);
            txtMetn.Size = new Size(675, 350);
            txtMetn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                             AnchorStyles.Left | AnchorStyles.Right;
            txtMetn.ScrollBars = RichTextBoxScrollBars.Vertical;

            lblMelumat.BorderStyle = BorderStyle.FixedSingle;
            lblMelumat.Location = new Point(30, 475);
            lblMelumat.Size = new Size(930, 55);
            lblMelumat.Text = "Fayl haqqında məlumat";
            lblMelumat.TextAlign = ContentAlignment.MiddleLeft;
            lblMelumat.Padding = new Padding(8);
            lblMelumat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left |
                                AnchorStyles.Right;

            statusStrip1.Items.AddRange(new ToolStripItem[]
            {
                lblStatus,
                lblFaylSayi
            });

            statusStrip1.Location = new Point(0, 608);
            statusStrip1.Size = new Size(1000, 22);

            lblStatus.Text = "Hazırdır";
            lblFaylSayi.Text = "| Fayl sayı: 0";

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 240, 248);
            ClientSize = new Size(1000, 650);
            MinimumSize = new Size(850, 550);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fayl Meneceri";

            Controls.Add(btnQovluq);
            Controls.Add(btnAc);
            Controls.Add(btnSaxla);
            Controls.Add(btnSil);
            Controls.Add(txtYol);
            Controls.Add(lblFayllar);
            Controls.Add(lstFayllar);
            Controls.Add(lblMetn);
            Controls.Add(txtMetn);
            Controls.Add(lblMelumat);
            Controls.Add(statusStrip1);

            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnQovluq;
        private Button btnAc;
        private Button btnSaxla;
        private Button btnSil;
        private ListBox lstFayllar;
        private RichTextBox txtMetn;
        private TextBox txtYol;
        private Label lblMelumat;
        private Label lblFayllar;
        private Label lblMetn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblFaylSayi;
    }
}
