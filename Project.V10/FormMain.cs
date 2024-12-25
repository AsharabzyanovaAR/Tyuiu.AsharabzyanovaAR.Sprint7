using System.Windows.Forms;
using Tyuiu.AsharabzyanovaAR.Sprint7.Project.V10.Lib;
namespace Project.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_AAR.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_AAR.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        string openFilePath;
        public bool fileOpened = false;

        //Общая функция поиска
        public void Search(DataGridView dataGrid, string searchValue, int searchableValue)
        {
            dataGrid.ClearSelection();
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[searchableValue].Value.ToString().ToUpper() == searchValue)
                {
                    dataGrid.FirstDisplayedScrollingRowIndex = row.Index;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Selected = true;
                    }
                }
            }
        }

        //Общее сокрытие рядов
        public void InvisibleRowsByColors(DataGridView dataGrid, Color color, bool rowVisibility)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[0].Style.BackColor == color)
                {
                    row.Visible = rowVisibility;
                }
            }
        }

        private void AddedRowsToolStripMenuItem_AAR_CheckedChanged(object sender, EventArgs e)
        {

            if (AddedRowsToolStripMenuItem_AAR.Checked)
            {
                InvisibleRowsByColors(dataGridViewEdit_AAR, Color.Aqua, true);
            }
            else
            {
                InvisibleRowsByColors(dataGridViewEdit_AAR, Color.Aqua, false);
            }
        }

        private void DeletedRowsToolStripMenuItem_AAR_CheckedChanged(object sender, EventArgs e)
        {

            if (DeletedRowsToolStripMenuItem_AAR.Checked)
            {
                InvisibleRowsByColors(dataGridViewEdit_AAR, Color.OrangeRed, true);
            }
            else
            {
                InvisibleRowsByColors(dataGridViewEdit_AAR, Color.OrangeRed, false);
            }
        }

        //Переключение видимости кнопок редактирования строк
        private void tabControlTable_AAR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlTable_AAR.SelectedIndex == 1 && fileOpened)
            {
                this.buttonAddRow_AAR.Enabled = true;
                this.buttonDeleteMarkedRow_AAR.Enabled = true;
                checkBoxMarkRow_AAR.Enabled = true;
                filterToolStripMenuItem_AAR.Enabled = true;
                if (checkBoxMarkRow_AAR.Checked)
                {
                    buttonMarkDelete_AAR.Enabled = true;
                    buttonUnmarkDelete_AAR.Enabled = true;
                }

            }
            else
            {
                filterToolStripMenuItem_AAR.Enabled = false;
                this.buttonAddRow_AAR.Enabled = false;
                this.buttonDeleteMarkedRow_AAR.Enabled = false;
                checkBoxMarkRow_AAR.Enabled = false;
                buttonMarkDelete_AAR.Enabled = false;
                buttonUnmarkDelete_AAR.Enabled = false;
            }
        }

        //Поиск
        private void buttonReadOnlySearchOrderID_AAR_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxReadOnlySearchOrderID_AAR.Text;
            Search(dataGridViewReadOnly_AAR, searchValue, 0);
        }
        private void buttonReadOnlySearchUserID_AAR_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxReadOnlySearchUserID_AAR.Text;
            Search(dataGridViewReadOnly_AAR, searchValue, 1);
        }
        private void buttonEditSearchOrderID_AAR_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxEditSearchOrderID_AAR.Text;
            Search(dataGridViewEdit_AAR, searchValue, 0);
        }
        private void buttonEditSearchUserID_AAR_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxEditSearchUserID_AAR.Text;
            Search(dataGridViewEdit_AAR, searchValue, 1);
        }


        private void checkBoxMarkRow_AAR_Checked(object sender, EventArgs e)
        {
            if (checkBoxMarkRow_AAR.CheckState == CheckState.Checked)
            {
                buttonMarkDelete_AAR.Enabled = true;
                buttonUnmarkDelete_AAR.Enabled = true;
                dataGridViewEdit_AAR.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                buttonMarkDelete_AAR.Enabled = false;
                buttonUnmarkDelete_AAR.Enabled = false;
                dataGridViewEdit_AAR.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }
        //Добавление строки
        private void buttonAdd_AAR_Click(object sender, EventArgs e)
        {
            dataGridViewEdit_AAR.Rows.Add(0, 0,"НЕИЗВЕСТНО","01.01.2025", 0, "НЕИЗВЕСТНО", 0, 0);
            foreach (DataGridViewCell cell in dataGridViewEdit_AAR.Rows[^1].Cells)
            {
                cell.Style.BackColor = Color.Aqua;
            }
        }
        //Окрашивание ячейки при изменении
        private void dataGridViewEdit_AAR_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridViewEdit_AAR.Rows[e.RowIndex].Cells[e.ColumnIndex];

                var previousValue = dataGridViewEdit_AAR.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag;

                if (previousValue == null || !cell.Value.Equals(previousValue))
                {
                    cell.Style.BackColor = Color.Green;
                }

                cell.Tag = cell.Value;
            }
        }
        //Проверка на пустое содержание ячейки
        private void dataGridViewEdit_AAR_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridViewEdit_AAR.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Tag = cell.Value;
            }
        }
        //Проверка на пустое содержание ячейки
        private void dataGridViewEdit_AAR_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridViewEdit_AAR.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    e.Cancel = true;

                    cell.Value = cell.Tag;
                }
            }
        }

        //Покраска выделенных ячеек на удаление
        private void buttonMarkDelete_AAR_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewEdit_AAR.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.OrangeRed;
                }
            }
        }

        //Удаление строки
        private void buttonDeleteMarkedRow_AAR_Click(object sender, EventArgs e)
        {
            for (int i = dataGridViewEdit_AAR.Rows.Count - 1; i >= 0; i--)
            {
                if (dataGridViewEdit_AAR.Rows[i].Cells[0].Style.BackColor == Color.OrangeRed)
                {
                    dataGridViewEdit_AAR.Rows.RemoveAt(i);
                }
            }
        }

        //Убирание покраски удаления
        private void buttonUnmarkDelete_AAR_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewEdit_AAR.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Style.BackColor == Color.OrangeRed)
                    {
                        cell.Style.BackColor = Color.FromKnownColor(KnownColor.ControlLightLight);
                    }
                }
            }
        }
        //Открытие файла
        private void buttonOpenFile_AAR_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            openFileDialogTask_AAR.ShowDialog();
            openFilePath = openFileDialogTask_AAR.FileName;

            string[,] arrayValues = ds.GetMatrix(openFilePath);

            dataGridViewReadOnly_AAR.RowCount = arrayValues.GetLength(0);
            dataGridViewEdit_AAR.RowCount = arrayValues.GetLength(0);

            dataGridViewReadOnly_AAR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewEdit_AAR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            buttonSaveFile_AAR.Enabled = true;
            fileOpened = true;

            for (int i = 0; i < dataGridViewReadOnly_AAR.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewReadOnly_AAR.Columns.Count; j++)
                {
                    if (j == 0 || j == 1 || j == 4 || j == 6 || j == 7)
                    {
                        dataGridViewEdit_AAR.Rows[i].Cells[j].Value = Convert.ToInt32(arrayValues[i, j]);
                        dataGridViewReadOnly_AAR.Rows[i].Cells[j].Value = Convert.ToInt32(arrayValues[i, j]);
                        dataGridViewEdit_AAR.Columns[j].ValueType = typeof(int);
                    }
                    else if (j == 3)
                    {
                        DateOnly date;
                        date = DateOnly.ParseExact(arrayValues[i, j], "dd.MM.yyyy", null);
                        dataGridViewEdit_AAR.Rows[i].Cells[j].Value = date;
                        dataGridViewReadOnly_AAR.Rows[i].Cells[j].Value = date;
                    }
                    else
                    {
                        dataGridViewEdit_AAR.Rows[i].Cells[j].Value = arrayValues[i, j].ToUpper();
                        dataGridViewReadOnly_AAR.Rows[i].Cells[j].Value = arrayValues[i, j].ToUpper();
                        dataGridViewEdit_AAR.Columns[j].ValueType = typeof(string);
                    }
                }
            }
            foreach (DataGridViewRow row in dataGridViewEdit_AAR.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                    cell.Tag = null;
                }
            }
        }

        private void buttonSaveFile_AAR_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_AAR.FileName = "SaveDataFile.csv";
            saveFileDialogTask_AAR.InitialDirectory = @"C:\DataSprint7";
            saveFileDialogTask_AAR.ShowDialog();

            string path = saveFileDialogTask_AAR.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";

            for (int i = 0; i < dataGridViewEdit_AAR.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewEdit_AAR.ColumnCount; j++)
                {
                    if (dataGridViewEdit_AAR.Rows[i].Cells[j].Style.BackColor == Color.Orange) break;

                    if (j != dataGridViewEdit_AAR.ColumnCount - 1)
                    {
                        str += dataGridViewEdit_AAR.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewEdit_AAR.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void statsToolStripMenuItem_AAR_Click(object sender, EventArgs e)
        {
            FormStatistic formStatistic = new FormStatistic(dataGridViewEdit_AAR);
            formStatistic.ShowDialog();
        }

        private void infoToolStripMenuItem_AAR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void guideToolStripMenuItem_AAR_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }
    }
}
