using OfficeOpenXml;

namespace getRandom
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        string file_path = "";

        public Form1()
        {
            InitializeComponent();
        }

        private static List<string> GetExcelInfo(string path, string columns)
        {
            List<string> infoList_Pr = new List<string>();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage package = new ExcelPackage(new FileInfo(path));
            ExcelWorksheet sheet = package.Workbook.Worksheets[1];

            int rowCount = sheet.Dimension.End.Row;
            int columnCount = sheet.Dimension.End.Column;
            for (int i = 1; i <= columnCount; i++)
            {
                if (sheet.Cells[1, i].ToText() == null) continue;
                if (sheet.Cells[1, i].Text == columns)
                {
                    for (int j = 2; j <= rowCount; j++)
                    {
                        string value = sheet.Cells[j, i].Text;
                        infoList_Pr.Add(value == null ? "" : value);
                    }
                }
            }
            return infoList_Pr;
        }

        private static List<string> ItemByInfo(List<string> infoList, List<string> ignoreList, int count)
        {
            List<string> randomItemList = new List<string>();
            List<string> infoListCopy = new List<string>(infoList);
            infoListCopy.Remove("陈登凯");
            if (ignoreList.Count > 0)
            {
                foreach (var item in ignoreList)
                {
                    infoListCopy.Remove(item);
                }
            }
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                if (infoListCopy.Count > 0)
                {
                    int ra = random.Next(infoListCopy.Count);
                    randomItemList.Add(infoListCopy[ra]);
                    infoListCopy.RemoveAt(ra);
                }
            }
            return randomItemList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> infoList = new List<string>();
            List<string> randomItemList = new List<string>();
            List<string> ignoreItemList = new List<string>();

            if (ingoreListBox.Items.Count > 0)
            {
                foreach (var item in ingoreListBox.Items)
                {
                    ignoreItemList.Add(item.ToString() + "");
                }
            }

            if (file_path == "")
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    openFileDialog.Filter = ".xlsx|*.xlsx";
                    file_path = openFileDialog.FileName;
                    button1.Text = "抽取";
                }
            }
            if (file_path != "")
            {
                infoList = GetExcelInfo(file_path, col.Text);
                randomItemList = ItemByInfo(infoList, ignoreItemList, int.Parse(countInput.Text));
                finalListBox.Items.Clear();
                foreach (var item in randomItemList)
                {
                    finalListBox.Items.Add(item);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "选择文件并抽取";
            file_path = "";
            finalListBox.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ingoreListBox.Items.Contains(ingoreInputTextBox.Text))
            {
                ingoreListBox.Items.Remove(ingoreInputTextBox.Text);
            }
            else
            {
                ingoreListBox.Items.Add(ingoreInputTextBox.Text);
            }
            ingoreInputTextBox.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ingoreList2.Text != "")
            {
                finalListBox.Items.Add(ingoreList2.Text);
                ingoreList2.Items.Remove(ingoreList2.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (finalListBox.Text != "")
            {
                ingoreList2.Items.Add(finalListBox.Text);
                finalListBox.Items.Remove(finalListBox.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ingoreList2.Items.Contains(ingoreList2Input.Text))
            {
                ingoreList2.Items.Remove(ingoreList2Input.Text);
            }
            else
            {
                ingoreList2.Items.Add(ingoreList2Input.Text);
            }
            ingoreInputTextBox.Text = string.Empty;
        }
    }
}
