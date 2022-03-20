using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Threading;

namespace FYP_Supervision_Merger
{
    public partial class Form1 : Form
    {
        // Headers for FYP Supervision Number
        const string FACULTY_NAME = "faculty name";
        const string TOTAL_FYP = "total fyp";

        // Headers for Current Assigned
        const string STAFF = "staff";
        const string SUP = "sup.";
        const string SEM1 = "sem1";
        const string SEM2 = "sem2";
        Dictionary<string, Result> results = new Dictionary<string, Result>();

        // FYP Supervision Number File
        int facultyIndex = 0;
        int totalFypIndex = 0;
        bool supState = false;
        string supFilePath = "";

        // Current Assigned File
        int staffIndex = 1;
        int sem1Index = 1;
        int sem2Index = 1;
        int startRow = 3;
        bool currState = false;
        string currFilePath = "";

   
        public Form1()
        {
            InitializeComponent();

            dgv.AutoGenerateColumns = false;
            dgv.RowHeadersVisible = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "No.",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 10
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Name",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 90
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }



        private void btnSupUpload_Click(object sender, EventArgs e)
        {
            // Reset values
            progressBar1.Visible = true;
            cbSupFacultyName.Checked = false;
            cbSupTotalFyp.Checked = false;
            lblSupUpload.Text = "";

            try
            {
                this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
                openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
                openFileDialog1.ShowDialog();
                supFilePath = openFileDialog1.FileName;
              
                lblSupUpload.Text = "Uploaded: " + supFilePath;

                progressBar1.Value = 0;
                for (int i = 0; i < 50; i++)
                {
                    progressBar1.Value += 1;
                }
                using (var reader = new StreamReader(supFilePath))
                {
                    // Validate if there is the correct fields
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    for (int i = 0; i < values.Length; i++)
                    {
                        if (values[i].ToLower() == FACULTY_NAME)
                        {
                            facultyIndex = i;
                            cbSupFacultyName.Checked = true;
                        }
                        if (values[i].ToLower() == TOTAL_FYP)
                        {
                            totalFypIndex = i;
                            cbSupTotalFyp.Checked = true;
                        }
                    }
                }
            
                for (int i = 0; i < 50; i++)
                {
                    progressBar1.Value += 1;
                }
            }
            catch
            {
                progressBar1.Value = 0;
            }
            
            if (cbSupFacultyName.Checked && cbSupTotalFyp.Checked)
            {
                supState = true;
            }
            else
            {
                supState = false;
            }
        }

        private void btnCurrUpload_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            cbCurrStaff.Checked = false;
            cbCurrSupSem1.Checked = false;
            cbCurrSupSem2.Checked = false;
           


            try
            {
                this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
                openFileDialog1.Filter = "Excel Files|  *.xlsx";
                openFileDialog1.ShowDialog();
                currFilePath = openFileDialog1.FileName;
                lblCurrUpload.Text = "Uploaded: " + currFilePath;

                progressBar1.Value = 0;
                for (int i = 0; i < 25; i++)
                {
                    progressBar1.Value += 1;
                }

                _Application excel = new _Excel.Application();
                Workbook wb = excel.Workbooks.Open(currFilePath);
                Worksheet ws = wb.Worksheets[1];
                var range = ws.UsedRange;



                // Validate if there is the correct fields
                for (int j = 1; j <= range.Columns.Count; j++)
                {
                    string str = (range.Cells[startRow, j] as _Excel.Range).Value2?.ToString();

                    if (str?.ToLower() == STAFF)
                    {
                        staffIndex = j;
                        cbCurrStaff.Checked = true;
                    }
                    if (str?.ToLower() == SUP)
                    {

                        str = (range.Cells[startRow + 1, j] as _Excel.Range).Value2?.ToString();

                        if (str?.ToLower() == SEM1)
                        {
                            sem1Index = j;
                            cbCurrSupSem1.Checked = true;
                        }
                        if (str?.ToLower() == SEM2)
                        {
                            sem2Index = j;
                            cbCurrSupSem2.Checked = true;
                        }
                    }
                }
                for (int i = 0; i < 25; i++)
                {
                    progressBar1.Value += 1;
                }

                wb.Close(true, null, null);
                excel.Quit();

                Marshal.ReleaseComObject(ws);
                Marshal.ReleaseComObject(wb);
                Marshal.ReleaseComObject(excel);

                for (int i = 0; i < 50; i++)
                {
                    progressBar1.Value += 1;
                }
            }
            catch
            {
                progressBar1.Value = 0;
            }

            if (cbCurrStaff.Checked && cbCurrSupSem1.Checked && cbCurrSupSem2.Checked)
            {
                currState = true;
            }
            else
            {
                currState = false;
            }
            
          
        }
        private void SaveResults()
        {
            // Reset results
            results = new Dictionary<string, Result>();

            for (int i = 0; i < 50; i++)
            {
                progressBar1.Value += 1;
            }
            Thread.Sleep(400);
           
            //Read from FYP Supervision Number File
            using (var reader = new StreamReader(supFilePath))
            {
                reader.ReadLine();

                // Read through CSV and store
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    var values = line.Split(',');
                    string faculty = values[facultyIndex];
                    if (faculty != "")
                    {
                        Result result = new Result();
                        result.TotalFyp = Convert.ToInt32(values[totalFypIndex]);
                        result.Name = faculty;
                        result.FileId = 1;
                        Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                        results[rgx.Replace(faculty.Trim().ToLower(), "")] = result;
                    }
                }
            }

            for (int i = 0; i < 25; i++)
            {
                progressBar1.Value += 1;
            }
            Thread.Sleep(100);

            // Read from Current Assigned File
            _Application excel = new _Excel.Application();
            Workbook wb = excel.Workbooks.Open(currFilePath);
            Worksheet ws = wb.Worksheets[1];
            var range = ws.UsedRange;
            for (int i = startRow + 1; i <= range.Rows.Count; i++)
            {
                string staffStr = (range.Cells[i, staffIndex] as _Excel.Range).Value2?.ToString();

                if (staffStr != null)
                {
                    Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                    string staffStrTrimmed = rgx.Replace(staffStr.Trim().ToLower(), "");
                    if (results.ContainsKey(staffStrTrimmed))
                    {
                        int sem1 = Convert.ToInt32((range.Cells[i, sem1Index] as _Excel.Range).Value2);
                        int sem2 = Convert.ToInt32((range.Cells[i, sem2Index] as _Excel.Range).Value2);

                        results[staffStrTrimmed].Sem1 = sem1;
                        results[staffStrTrimmed].Sem2 = sem2;
                        results[staffStrTrimmed].IsMerged = true;
                    }
                    else
                    {
                        Result result = new Result();
                        result.Name = staffStr;
                        result.FileId = 2;
                        results[staffStr] = result;
                    }
                }
            }


            wb.Close(true, null, null);
            excel.Quit();

            Marshal.ReleaseComObject(ws);
            Marshal.ReleaseComObject(wb);
            Marshal.ReleaseComObject(excel);


            int counter = 0;
            foreach (var x in results)
            {
                if (x.Value.IsMerged)
                {
                    counter += 1;
                    Debug.WriteLine(counter + ". " + x.Value.Name);
                    Debug.WriteLine(x.Value.Sem1);
                    Debug.WriteLine(x.Value.Sem2);
                }

            }
            
        }
        private void DisplayUnmerged()
        {
            // Clear datas
            dgv.Rows.Clear();

            for (int i = 0; i < 25; i++)
            {
                progressBar1.Value += 1;
            }
            Thread.Sleep(100);

            foreach (var x in results)
            {
                if (x.Value.IsMerged == false)
                {
                    dgv.Rows.Add(new String[] { x.Value.FileId.ToString(), x.Value.Name });
                  
                }
            }
        }

        private void btnGenerateSem1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            if (supState && currState)
            {
                progressBar1.Value = 0;
                SaveResults();
                DisplayUnmerged();
                progressBar1.Value = 100;
                WriteToFile(SEM1);
            }
            else
            {
                progressBar1.Visible = false;
                lblError.Text = "Please check for the missing fields.";
            }
        }
        private void btnGenerateSem2_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            if (supState && currState)
            {
                progressBar1.Value = 0;
                SaveResults();
                DisplayUnmerged();
                progressBar1.Value = 100;
                WriteToFile(SEM2);
            }
            else
            {
                progressBar1.Visible = false;
                lblError.Text = "Please check for the missing fields.";
            }
        }
        private void WriteToFile(string sem)
        {
            if (sem == SEM1)
            {
                string newFilePath = supFilePath.Replace(".csv", "_sem1.csv"); 
                using (StreamWriter file = new StreamWriter(newFilePath))
                {
                    file.WriteLine("Faculty Name,Total FYP,Currently Assigned,Expected to be assigned,Proposals required");

                    foreach (var x in results)
                    {
                        file.Write(x.Key + ",");
                        file.Write(x.Value.TotalFyp + ",");
                        file.Write(x.Value.Sem1 + ",");
                        file.Write(x.Value.TotalFyp - x.Value.Sem1 + ",");
                        file.WriteLine(x.Value.TotalFyp - x.Value.Sem1 + 2 + ",");
                    }
                }
            }
            if (sem == SEM2)
            {
                string newFilePath = supFilePath.Replace(".csv", "_sem2.csv");
                using (StreamWriter file = new StreamWriter(newFilePath))
                {
                    file.WriteLine("Faculty Name,Total FYP,Currently Assigned,Expected to be assigned,Proposals required");
                    foreach (var x in results)
                    {
                        file.Write(x.Key + ",");
                        file.Write(x.Value.TotalFyp + ",");
                        file.Write(x.Value.Sem2 + ",");
                        file.Write(x.Value.TotalFyp - x.Value.Sem2 + ",");
                        file.WriteLine(x.Value.TotalFyp - x.Value.Sem2 + 2 + ",");
                    }
                }
            }
        }

       
    }
}
