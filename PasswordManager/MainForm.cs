namespace PasswordManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void NewDatabase(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new();
            sfd.FileName = "Base de données";
            sfd.Filter = "Fichier MPM de myPasswordManager | *.mpm ";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var dbFile = sfd.FileName;
                NewDatabaseForm newDatabaseForm = new();

                if (newDatabaseForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialization code that should run when the form loads can go here.
        }
    }
}
