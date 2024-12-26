using System.Timers;
using OfficeOpenXml;
using System.IO;
using System.Diagnostics;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;
        private List<(string Time, string Data)> dataList;
        private ExcelPackage excelPackage;
        private ExcelWorksheet worksheet;

        public Form1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            dataList = new List<(string Time, string Data)>();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // تنظیم مجوز
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                    excelPackage = new ExcelPackage(fileInfo);
                    worksheet = excelPackage.Workbook.Worksheets[0];
                    Task.Run(() => CollectData());
                }
            }
        }
        private async Task CollectData()
        {
            try
            {
                stopwatch.Start();
                bool ok = true;
                while (dataList.Count <= 200)
                {
                    if (stopwatch.ElapsedMilliseconds == 20)
                    {
                        string currentTime = DateTime.Now.ToString("ss.fff");
                        string data = "Data ";
                        dataList.Add((currentTime, data));
                        if (dataList.Count % 100 == 0)
                        {
                            await Task.Delay(1);
                        }
                        stopwatch.Restart();

                    }

                }
                WriteDataToExcel();
            }
            catch (Exception x)
            {

                throw;
            }
        }

        private void WriteDataToExcel()
        {
            this.Invoke((MethodInvoker)delegate
            {
                for (int i = 0; i < dataList.Count; i++)
                {
                    worksheet.Cells[i + 1, 1].Value = dataList[i].Time;
                    worksheet.Cells[i + 1, 2].Value = dataList[i].Data;
                }
                excelPackage.Save();
                excelPackage.Dispose();
            });
        }
    }
}
