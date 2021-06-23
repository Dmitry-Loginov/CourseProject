using System.Linq;
using System.Windows.Forms;

namespace Log
{
    public partial class GroupsForm : Form
    {
        private LogEntities LogEntities = LogEntities.GetInstance();
        public GroupsForm()
        {
            InitializeComponent();
            groupBindingSource.DataSource = LogEntities.groups.ToList();
        }

        private void GroupsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogEntities.SaveChanges();
        }

        private void addMenu_Click(object sender, System.EventArgs e)
        {
            group group = new group();
            group.Id = "newGroup";
            LogEntities.groups.Add(group);
            LogEntities.SaveChanges();
            LogEntities = LogEntities.GetInstance();
            groupBindingSource.DataSource = LogEntities.groups.ToList();
        }

        private void delMenu_Click(object sender, System.EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Удалить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                var group = LogEntities.groups.Find(groupDataGridView.SelectedCells[0].Value);
                LogEntities.groups.Remove(group);
                LogEntities.SaveChanges();
                LogEntities = LogEntities.GetInstance();
                groupBindingSource.DataSource = LogEntities.groups.ToList();
            }
        }

        private void GroupsForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
