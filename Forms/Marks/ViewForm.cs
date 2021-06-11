using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Log
{
    public partial class ViewForm : Form
    {
        
        public ViewForm()
        {
            InitializeComponent();
            Log = LogEntities.GetInstance();
            markToJsons = new List<MarkToJson>();
            groupBindingSource.DataSource = Log.groups.ToList();
        }

        LogEntities Log { get; set; }
        List<MarkToJson> markToJsons { get; set; }
        

        IQueryable<subjects_to_groups> GetSubjects()
        {
            return Log.subjects_to_groups.Where(s => s.GroupId == groupComboBox.SelectedValue.ToString());
        }

        private void serialize_Click(object sender, EventArgs e)
        {
            var marksToGroup = Log.marks.Where(m => m.studetn.group == groupComboBox.SelectedItem);
            List<mark> marksToMonth;
            for (int i = 0; i<12; i++)
            {
                marksToMonth = marksToGroup.Where(m => m.Month == i).ToList();
                for (int k = 0; k<marksToMonth.ToList().Count; k++)
                {
                    MarkToJson json = new MarkToJson(marksToMonth[k].studetn.Fio, marksToMonth[k].subject.SubjectName, i, marksToMonth);

                    markToJsons.Add(json);
                }
            }
            MessageBox.Show(markToJsons.Count.ToString());
        }

        class MarkToJson
        {
            string student { get; set; }
            string subject { get; set; }
            int month { get; set; }
            int[] marks;
            public MarkToJson(string student, string subject, int month, List<mark> marks)
            {
                this.student = student;
                this.subject = subject;
                this.month = month;
                this.marks = new int[marks.Count]; 
                for(int i = 0; i< marks.Count; i++)
                {
                    this.marks[i] = Convert.ToInt32(marks[i].Value);
                }
            }

        }
    }
}
