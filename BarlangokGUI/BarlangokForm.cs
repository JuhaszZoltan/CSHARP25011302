using System.Text;

namespace BarlangokGUI
{
    public partial class BarlangokForm : Form
    {
        const string PATH = "C:\\PROJECTS\\CSHARP25011302\\BarlangokGUI\\RESOURCES\\barlangok.txt";
        List<Barlang> barlangok = [];
        Barlang selBarlang = null;

        public BarlangokForm()
        {
            InitializeComponent();
            this.Load += BarlangokFormLoad;
            btnKeres.Click += BtnKeresClick;
            btnMent.Click += BtnMentClick;
        }

        private void BtnMentClick(object sender, EventArgs e)
        {
            int eHossz = selBarlang.Hossz;
            try
            {
                selBarlang.Hossz = int.Parse(tbxHossz.Text);
                selBarlang.Melyseg = int.Parse(tbxMely.Text);
            }
            catch (Exception ex)
            {
                selBarlang.Hossz = eHossz;
                _ = MessageBox.Show(ex.Message);
            }
            finally
            {
                EredetiAllapot();
            }
        }

        private void BtnKeresClick(object? sender, EventArgs e)
        {
            selBarlang = barlangok.SingleOrDefault(b => b.Azon == int.Parse(tbxAzon.Text));
            if (selBarlang is null)
            {
                _ = MessageBox.Show("Ezzel az azonosítóval nem létezik barlang");
                EredetiAllapot();
            }
            else
            {
                lblNev.Text = selBarlang.Nev;
                tbxHossz.Text = $"{selBarlang.Hossz}";
                tbxMely.Text = $"{selBarlang.Melyseg}";
                btnMent.Enabled = true;
            }
        }

        private void BarlangokFormLoad(object? sender, EventArgs e)
        {
            StreamReader sr = new(PATH, Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream) barlangok.Add(new(sr.ReadLine()));
        }

        public void EredetiAllapot()
        {
            tbxAzon.Text = string.Empty;
            lblNev.Text = string.Empty;
            tbxHossz.Text = string.Empty;
            tbxMely.Text = string.Empty;
            btnMent.Enabled = false;
        }
    }
}
