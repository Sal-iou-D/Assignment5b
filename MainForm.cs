using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Assignment5b
{
    public partial class MainForm : Form
    {
        private readonly IPersonDataSource _dataSource;
        //public PersonContext? dbContext;
        public MainForm(IPersonDataSource dataSource)
        {
            InitializeComponent();
            _dataSource = dataSource;

            //dbContext = new PersonContext();
            //dbContext.Database.EnsureCreated();
            //dbContext.People.Load();

            //personBindingSource.DataSource = dbContext.People.Local.ToBindingList();
            //dataGridView.DataSource = personBindingSource;


        }

        private void MainFormLoad(Object sender, EventArgs e)
        {
            personBindingSource.DataSource = _dataSource.GetPeople();
            dataGridView.DataSource = personBindingSource;
        }


        private void saveButtonClick(object sender, EventArgs e)
        {

            _dataSource.SaveChanges();
            dataGridView.Refresh();
        }
    }
}
