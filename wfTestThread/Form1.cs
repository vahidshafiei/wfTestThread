using System;

using System.IO;

using System.Windows.Forms;

using System.Diagnostics;

using System.Collections.Generic;

namespace wfTestThread
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;

        private string filePath;

        private bool fileselected;

        private bool isRecording;

        private List<double> savedTimes; // To store saved elapsed times

        private List<double> differences; // To store differences for display


        public Form1()

        {

            InitializeComponent();

            stopwatch = new Stopwatch();

            timer1.Tick += Timer_Tick;

            isRecording = false; // Initialize recording state

            savedTimes = new List<double>(); // Initialize the list for saved times

            differences = new List<double>(); // Initialize the list for differencess

        }


        private void btnSelectFile_Click(object sender, EventArgs e)

        {

            using (SaveFileDialog openFileDialog = new SaveFileDialog())

            {

                if (openFileDialog.ShowDialog() == DialogResult.OK)

                {

                    filePath = openFileDialog.FileName;

                    txtFilePath.Text = filePath;

                }

            }

        }


        private void btnStartTimer_Click(object sender, EventArgs e)

        {

            if (string.IsNullOrEmpty(filePath))

            {
                fileselected = false;
                //MessageBox.Show("Please select a file first.");               

            }
            else
            {
                fileselected = true;
            }


            if (isRecording)

            {

                // Stop the recording

                timer1.Stop();

                stopwatch.Stop();

                isRecording = false;

                btnStartTimer.Text = "Start Timer"; // Update button text

                filePath = null;
            }

            else

            {

                // Start the recording

                timer1.Interval = (int)numInterval.Value;

                isRecording = true;

                stopwatch.Restart();

                savedTimes.Clear(); // Clear previous saved times

                differences.Clear(); // Clear previous differences

                txtDifferences.Clear(); // Clear the differences display

                timer1.Start();

                btnStartTimer.Text = "Stop Timer"; // Update button text

            }

        }


        private void Timer_Tick(object sender, EventArgs e)

        {

            if (isRecording)

            {

                // Get the elapsed time

                double currentElapsed = Math.Round(stopwatch.Elapsed.TotalMilliseconds);


                // Save the current elapsed time to the list

                savedTimes.Add(currentElapsed);


                // Calculate the difference if there are at least two saved times

                if (savedTimes.Count > 1)

                {

                    double difference = currentElapsed - savedTimes[savedTimes.Count - 2];
                    if (fileselected == true)
                    {
                        File.AppendAllText(filePath, $"{difference}\n");
                    }



                    // Update the differences list and display

                    UpdateDifferencesDisplay(difference);

                }

            }

        }


        private void UpdateDifferencesDisplay(double difference)

        {

            // Add the new difference to the list

            differences.Add(difference);


            // Keep only the last 101 differences

            if (differences.Count > 101)

            {

                differences.RemoveAt(0); // Remove the oldest difference

            }


            // Format the differences as a comma-separated string

            txtDifferences.Text = string.Join(", ", differences);

        }


        protected override void OnFormClosing(FormClosingEventArgs e)

        {

            // Stop the timer and dispose of it

            timer1.Stop();

            base.OnFormClosing(e);

        }


    }
}