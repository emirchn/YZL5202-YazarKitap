using YazarKitap.Dal.Context;
using YazarKitap.Entity.Models.Concrete;
using YazarKitap.Presentation.Infrastruccture;

namespace YazarKitap.Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _context = new ProjectContext();
            _aRepo = new AuthorRepository(_context);
        }

        private readonly ProjectContext _context;
        private YazarKitap.Dal.Repository.Concrete.AuthorRepository _aRepo;

        private void Form1_Load(object sender, EventArgs e)
        {
            //db olanlarý listview'a doldurmak isterim.
            GetAllAuthors(_aRepo.GetAll());
            //GetAllAuthors(_aRepo.GetAll(async => a.Statu != Statu.Deleted));
        }

        private void GetAllAuthors(List<Author> list)
        {
            lsYazarlar.Items.Clear();
            foreach (Author item in list)
            {
                ListViewItem lsi = new ListViewItem();
                lsi.Text = item.Id.ToString();
                lsi.SubItems.Add(item.FirstName);
                lsi.SubItems.Add(item.LastName);
                lsi.SubItems.Add(item.BirthDate.ToString());
                lsi.SubItems.Add(item.Biography);
                lsi.SubItems.Add(item.Statu.ToString());

                lsYazarlar.Items.Add(lsi);
            }
        }
        Author author;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            // toDo : Kontrol . nullable ?!

            string ad = txtAd.Text, soyad = txtSoyad.Text, biyografi = txtBiyografi.Text;
            DateTime dt = dtpTarih.Value;

            author = new Author()
            {
                FirstName = ad,
                LastName = soyad,
                BirthDate = dt,
                Biography = biyografi,
            };
            Author author1 = _aRepo.Add(author);
            MessageBox.Show($"{author1.FirstName} {author1.LastName} eklendi. \n Yazar id : {author1.Id} ve Doðum tarihi {author1.BirthDate}");
        }

        private void lsYazarlar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(lsYazarlar.SelectedItems[0].Text);
            author = _aRepo.Get(id);
            txtAd.Text = author.FirstName;
            txtSoyad.Text = author.LastName;
            txtBiyografi.Text = author.Biography;
            dtpTarih.Value = author.BirthDate;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //todo: control nullable ? 
            if (author is not null)
            {
                author.FirstName = txtAd.Text;
                author.LastName = txtSoyad.Text;
                author.Biography = txtBiyografi.Text;
                author.BirthDate = dtpTarih.Value;

                _aRepo.Update(author);
                GetAllAuthors(_aRepo.GetAll());
                Helper.Clear(this.Controls);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lsYazarlar.SelectedItems.Count > 0)
            {
                _aRepo.Delete(author);
                Helper.Clear(this.Controls);
                GetAllAuthors(_aRepo.GetAll());
            }
        }


        // toDo'lar ile yapýlacak.
        private void button1_Click(object sender, EventArgs e)
        {
            // silinmeyenleri listview 'a getirsin.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // herkesi doðum tarihine göre yaþlýdan gence getirsin.
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // db deki tüm yazarlarý getirsin.
        }
    }
}