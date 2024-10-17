using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Log
{
    public partial class EditMarkForm : Form
    {
        public EditMarkForm()
        {
            InitializeComponent();
            fillGrid = FillData;
            fillGridSorted = FillSorted;
            log = LogEntities.GetInstance();

            Marks = log.marks.ToList();

            SortedGroupMarks = log.marks.ToList();
            SortedSubjectMarks = log.marks.ToList();
            subjectBindingSourceMenu.DataSource = log.subjects.ToList();
            groupBindingSourceMenu.DataSource = log.groups.ToList();
            
            FillSortedMarks();

            NewMarks = new List<mark>();

        }
        
        public LogEntities log;
        public FillDataGridView fillGrid;
        public FillDataGridView fillGridSorted;
        //public
        private bool IsClosed = false;
        bool IsSorted = false;

        public List<mark> SortedGroupMarks { get; set; }
        public List<mark> SortedSubjectMarks { get; set; }
        public List<mark> Marks { get; set; }
        public List<mark> SortedMarks { get; set; }

        private void ViewMarkForm_Load(object sender, EventArgs e)
        {
            fillGrid();
            //Задаем размер по заполнению
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns[0].Visible = false;
        }

        private void ViewMarkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClosed = true;
            log.SaveChanges();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного элемента!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            log = LogEntities.GetInstance();
            int keySelectedIndex = Convert.ToInt32(GetSelectedId());
            mark mark = log.marks.Find(keySelectedIndex);
            log.marks.Remove(mark);
            int delIndex = dataGridView.SelectedCells[0].RowIndex;
            dataGridView.Rows.RemoveAt(delIndex);
            log.SaveChanges();
        }

        public mark newMark { get; set; }

        bool CheckFillMark()
        {
            if (NewMarks.Count == 0) return true;
            foreach(mark checkMark in NewMarks)
            {
                mark mark = log.marks.Where(m => m.Id == checkMark.Id).FirstOrDefault();
                if (mark == null) continue;
                if (mark.Month == null) return false;
                if (mark.StudentId == null) return false;
                if (mark.student == null) return false;
                if (mark.subject == null) return false;
                if (mark.SubjectId == null) return false;
                if (mark.TypeId == null) return false;
                if (mark.typeMark == null) return false;
                if (mark.Value == null) return false;
            }
            
            return true;
        }

        List<mark> NewMarks;

        private void AddButton_Click(object sender, EventArgs e)
        {
            //надо выполнить, так как выполнили сохранение
            log.SaveChanges();
            log = LogEntities.GetInstance();
            newMark = new mark();
            //добавляем в массив новых отметок
            NewMarks.Add(newMark);
            if (!groupCheckBox.Checked)
            {
                newMark.student = log.students.Where(s => s.GroupId == groupComboBox.SelectedValue.ToString()).FirstOrDefault();
            }
            if (!subjectCheckBox.Checked)
            {
                newMark.subject = log.subjects.Where(subj => subj.Id == Convert.ToInt32(subjectComboBox1.SelectedValue)).FirstOrDefault();
            }
            log.marks.Add(newMark);
            //чтобы данные записались, надо сохранить
            log.SaveChanges();
            //вывести данные на форму
            FillSorted();
        }

        private void AddGroupBtn_Click(object sender, EventArgs e)
        {
            AddGroupMarkForm addGroupMarkForm = new AddGroupMarkForm(ref fillGridSorted, ref NewMarks);
            addGroupMarkForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCheckBox(groupCheckBox, groupComboBox);
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsClosed)
            {
                if (CheckFillMark())
                {
                    FillSortedGroupMarks();
                    FillSortedMarks();
                }
                else
                    MessageBox.Show("Сначала заполните данные!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                if (dataGridView.SelectedCells[0].OwningColumn.Index == 1 && !groupCheckBox.Checked)
                {
                    EditingStudentComboBox(e);
                }

                if (dataGridView.SelectedCells[0].OwningColumn.Index == 2)
                {
                    EditingSubjectComboBox(e);
                }
            }
            catch { }
        }

        private void subjectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            ChangeCheckBox(subjectCheckBox, subjectComboBox1);
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsClosed) { }
        }

        void ChangeCheckBox(CheckBox checkBox, ComboBox comboBox1)
        {

            if (checkBox.Checked)
            {
                IsSorted = false;
                comboBox1.Enabled = false;
                FillSorted();
            }
            else
            {
                IsSorted = true;
                comboBox1.Enabled = true;
                FillSorted();
            }

        }

        private void FillData()
        {
            if (!IsSorted)
            {
                log = LogEntities.GetInstance();
                groupBindingSource.DataSource = log.groups.ToList();
                studentBindingSource.DataSource = log.students.ToList();
                subjectBindingSource.DataSource = log.subjects.ToList();
                typeMarkBindingSource.DataSource = log.typeMarks.ToList();
                teacherBindingSource.DataSource = log.teachers.ToList();

                markBindingSource.DataSource = SortedMarks;
            }
            else
            {
                FillSorted();
            }
        }

        string GetSelectedId()
        {
            int rowIndex = dataGridView.SelectedCells[0].RowIndex;
            return dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private void FillSorted()
        {
            if (!LogEntities.IsExistInstance) return;
            if (!IsClosed)
            {
                log = LogEntities.GetInstance();
                //так как первоначально берем данные отсюда, то его надо обновить
                Marks = log.marks.ToList();

                if (!groupCheckBox.Checked)
                    FillSortedGroupMarks();
                else
                    SortedGroupMarks = log.marks.ToList();//!!!!!!!!!!!!!!!

                if (!subjectCheckBox.Checked)
                    FillSortedSubjectMarks();
                else
                    SortedSubjectMarks = log.marks.ToList();

                FillSortedMarks();
            }
        }

        void FillSortedMarks()
        {
            SortedMarks = SortedSubjectMarks.Intersect(SortedGroupMarks).ToList();
            markBindingSource.DataSource = SortedMarks;
            if (SortedMarks.Count != 0)
            {
                double average = SortedMarks.Average(m => Convert.ToInt32(m.Value));
                average = Math.Round(average, 2);
                averageLabel.Text = average.ToString();
            }
            else
                averageLabel.Text = "0";
            
        }

        List<mark> FillSortedGroupMarks()
        {
            string id = groupComboBox.SelectedValue?.ToString();
            SortedGroupMarks = Marks.Where(m => new[] { id }.Contains(m.student?.GroupId)).ToList();
            return SortedGroupMarks; 
        }

        List<mark> FillSortedSubjectMarks()
        {
            int id = Convert.ToInt32(subjectComboBox1?.SelectedValue);//здесь не стоит вопрос
            SortedSubjectMarks = Marks.Where(m => new[] { id }.Contains((int)m.subject?.Id)).ToList();
            return SortedSubjectMarks;
        }

        void EditingSubjectComboBox(DataGridViewEditingControlShowingEventArgs e)
        {
            if (!LogEntities.IsExistInstance) return;
            if (e.Control as ComboBox != null)
            {
                string passportId = GetPassportIdSelectedStudent();

                string groupId = log.students.Where(s => s.PassportId == passportId).First().GroupId;
                List<subjects_to_groups> subjects_To_Groups = log.subjects_to_groups.Where(sub => sub.GroupId == groupId).ToList();
                var subjectsId = subjects_To_Groups.Select(s => s.SubjectId).ToList();
                List<subject> subjects = log.subjects.Where(sb => subjectsId.Contains(sb.Id)).ToList();

                subjectBindingGridView.DataSource = subjects;
                (e.Control as ComboBox).DataSource = subjectBindingGridView;
            }
        }

        void EditingStudentComboBox(DataGridViewEditingControlShowingEventArgs e)
        {
            if (!LogEntities.IsExistInstance) return;
            if (e.Control as ComboBox != null)
            {
                string groupId = (groupComboBox.SelectedItem as group).Id;
                studentBindingGridView.DataSource = log.students.Where(s => s.GroupId == groupId).ToList();
                (e.Control as ComboBox).DataSource = studentBindingGridView;
            }
        }

        string GetPassportIdSelectedStudent()
        {
            int rowIndex = dataGridView.SelectedCells[0].RowIndex;
            return dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
        }

        private void subjectComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!IsClosed)
            {
                if (CheckFillMark())
                {
                    FillSortedSubjectMarks();
                    FillSortedMarks();
                }
                else
                    MessageBox.Show("Сначала заполните данные!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EditMarkForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckFillMark())
            {
                IsClosed = true;
            }
            else
            {
                var res =  MessageBox.Show("Есть несохраненные данные. При выходе они будут удалены.\nПродолжить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    foreach(mark delMark in NewMarks)
                    {
                        mark mark = log.marks.Find(delMark.Id);
                        if(!CheckMark(mark))
                            log.marks.Remove(mark);
                    }
                    log.SaveChanges();
                    IsClosed = true;
                }
                else
                    e.Cancel = true;
            }
        }

        bool CheckMark(mark mark)
        {
            if (mark.Month == null) return false;
            if (mark.StudentId == null) return false;
            if (mark.student == null) return false;
            if (mark.subject == null) return false;
            if (mark.SubjectId == null) return false;
            if (mark.TypeId == null) return false;
            if (mark.typeMark == null) return false;
            if (mark.Value == null) return false;
            return true;
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(log != null)
                {
                    log.SaveChanges();
                    groupBindingSource.DataSource = log.groups.ToList();
                    studentBindingSource.DataSource = log.students.ToList();
                    subjectBindingSource.DataSource = log.subjects.ToList();
                    typeMarkBindingSource.DataSource = log.typeMarks.ToList();
                    if (SortedMarks.Count != 0)
                    {
                        double average = SortedMarks.Average(m => Convert.ToInt32(m.Value));
                        average = Math.Round(average, 2);
                        averageLabel.Text = average.ToString();
                    }
                    else
                        averageLabel.Text = "0";
                    FillSorted();
                }
                
            }
            catch { }
        }

        private void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if(e.ColumnIndex == 5 || e.ColumnIndex == 6)
            try
            {
                Convert.ToInt32(e.FormattedValue);
                    
            }
            catch
            {
                MessageBox.Show("Это поле может содержать только числа!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void subjectCheckBox_Click(object sender, EventArgs e)
        {
            if (!IsClosed)
                if (!CheckFillMark())
                {
                    MessageBox.Show("Сначала заполните данные!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (((CheckBox)sender).Checked == false)
                        ((CheckBox)sender).Checked = true;
                    else
                        ((CheckBox)sender).Checked = false;
                }
        }

        private void update_Click(object sender, EventArgs e)
        {
            fillGrid = FillData;
            fillGridSorted = FillSorted;
            log = LogEntities.GetInstance();

            Marks = log.marks.ToList();

            SortedGroupMarks = log.marks.ToList();
            SortedSubjectMarks = log.marks.ToList();
            subjectBindingSourceMenu.DataSource = log.subjects.ToList();
            groupBindingSourceMenu.DataSource = log.groups.ToList();

            FillSortedMarks();

            NewMarks = new List<mark>();
        }
    }
}