using System.Threading.Tasks;

namespace SLib23T1020357.DesktopApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public void openIsMdiChild<T>() where T : Form, new()
        {
            var child = this.MdiChildren.OfType<T>().FirstOrDefault();
            if (child != null)
            {
                child.Activate(); 
            }
            else
            {
                T frm = new T();
                frm.MdiParent = this;
                frm.Show();
            }
        }


        private void mniPublisher_Click(object sender, EventArgs e)
        {
            openIsMdiChild<Properties.DataDictionary.Publishers.FormPublisher>();
        }

        private void mniAuthor_Click(object sender, EventArgs e)
        {
            openIsMdiChild<Properties.DataDictionary.Authors.FormAuthor>();
        }

        private void mniLanguage_Click(object sender, EventArgs e)
        {
            openIsMdiChild<Properties.DataDictionary.Languages.FormLanguage>();
        }

        private void mniCategory_Click(object sender, EventArgs e)
        {
            openIsMdiChild<Properties.DataDictionary.Categories.FormCategory>();
        }

        private void mniLocation_Click(object sender, EventArgs e)
        {
            openIsMdiChild<Properties.DataDictionary.Locations.FormLocation>();
        }
    }
}
 