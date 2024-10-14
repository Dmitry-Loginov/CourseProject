using System;
using System.Linq;

using System.Windows.Forms;

namespace Log
{
    public partial class AddSubjectToGroup : Form
    {
        private LogEntities LogEntities = LogEntities.GetInstance();

        private FillSubjectToGroupGrid FillSubjectToGroup { get; set; }
        public AddSubjectToGroup(FillSubjectToGroupGrid fillSubjectToGroup)
        {
            InitializeComponent();
            subjects_to_groups subjects_To_Groups = new subjects_to_groups();
            subjects_to_groupsBindingSource.DataSource = subjects_To_Groups;
            subjectBindingSource.DataSource = LogEntities.subjects.ToList();
            groupBindingSource.DataSource = LogEntities.groups.ToList();
            FillSubjectToGroup = fillSubjectToGroup;
        }

        private void add_Click(object sender, EventArgs e)
        {

            subjects_to_groups sg = new subjects_to_groups()
            {
                GroupId = groupIdComboBox.SelectedValue.ToString(),
                SubjectId = Convert.ToInt32(subjectIdListBox.SelectedValue)
            };

            subjects_to_groups checkSubject = LogEntities.subjects_to_groups.Where(s => s.GroupId == sg.GroupId && s.SubjectId == sg.SubjectId).FirstOrDefault();
            if(checkSubject != default)
            {
                MessageBox.Show("Такая связь уже существует!");
                return;
            }
            LogEntities.subjects_to_groups.Add(sg);
            LogEntities.SaveChanges();
            FillSubjectToGroup();
        }

        private void subjects_to_groupsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjects_to_groupsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.logDataSet);

        }

        private void AddSubjectToGroup_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logDataSet.subjects_to_groups". При необходимости она может быть перемещена или удалена.
            this.subjects_to_groupsTableAdapter.Fill(this.logDataSet.subjects_to_groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logDataSet.subjects_to_groups". При необходимости она может быть перемещена или удалена.
            this.subjects_to_groupsTableAdapter.Fill(this.logDataSet.subjects_to_groups);

        }

        private void subjects_to_groupsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.subjects_to_groupsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.logDataSet);

        }
    }
}
