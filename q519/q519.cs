/******************************
** q519.cs
** Goblin Day Traders
** Patrick Xie, 5/19/2011
*******************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace q519
{
    public partial class q519 : Form
    {
        WebClient myClient = new WebClient();
        private string data;
        List<string> dateList = new List<string>();
        List<double> priceList = new List<double>();
        private Bitmap myCanvas;
        private Pen linePen = new Pen(Color.Red, 1);

        public q519()
        {
            InitializeComponent();
        }

        private void q519_Load(object sender, EventArgs e)
        {
            myCanvas = new Bitmap(500, 300,
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(myCanvas);
            g.Clear(Color.White);
        }
        /*button click to start the background thread to import data*/
        private void dataButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        /*Imports the website data in another thread in background*/
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string page = "http://ichart.finance.yahoo.com/table.csv?s=" + (webAddyTextBox.Text).ToUpper() + "&d=4&e=19&f=2011&g=d&a=7&b=19&c=1900&ignore=.csv";
            try
            {
                data = myClient.DownloadString(page);
            }
            catch
            {

            }
        }

        /*Puts data from cvs file into data array and then puts into a price list and year list*/
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<string> tempList = new List<string>();
            string[] dataArray = data.Split(',', '\n');

            for (int i = 0; i < dataArray.Length; i++)
            {
                tempList.Add(dataArray[i]);
            }

            tempList.RemoveRange(0, 7);
            tempList.Reverse();
            tempList.RemoveRange(0, 1);

            for (int h = 0; h < tempList.Count; h+=7)
            {
                priceList.Add(double.Parse(tempList[h]));
            }
            for (int k = 6; k < tempList.Count; k += 7)
            {
                dateList.Add(tempList[k]);
            }
            graphData();
        }

        private void q519_Paint(object sender, PaintEventArgs e)
        {
            Pen graphPen = new Pen(Color.Black, 1);
            Font graphFont = new Font("Courier New", 8);
            SolidBrush graphBrush = new SolidBrush(Color.Black);
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(myCanvas, 50, 25, myCanvas.Width, myCanvas.Height);
        }

        private void graphData()
        {
            Graphics g = Graphics.FromImage(myCanvas);
            double minPrice = findMin(priceList);
            double maxPrice = findMax(priceList);
            double incrementY = 300.0 / maxPrice;
            double incrementX = 500.0 / dateList.Count;
            double rangePrice = (maxPrice - minPrice)/4;
            titleLabel.Text = webAddyTextBox.Text.ToUpper();
            //sets labels for Price
            priceMaxLabel.Text = String.Format("{0:0.###}",maxPrice);
            priceMaxMidLabel.Text = String.Format("{0:0.###}", (maxPrice - rangePrice));
            priceMinMidLabel.Text = String.Format("{0:0.###}", (minPrice + rangePrice));
            priceMinLabel.Text = String.Format("{0:0.###}", minPrice);
            //sets labels for Year
            int rangeYear = dateList.Count / 4;
            yearMaxLabel.Text = dateList[dateList.Count - 1].Substring(0, 4);
            yearMaxMidLabel.Text = dateList[2 * rangeYear].Substring(0, 4);
            yearMinMidLabel.Text = dateList[rangeYear].Substring(0, 4);
            yearMinLabel.Text = dateList[0].Substring(0,4);
            //graphs each line from current index to next index in list
            for(int i = 0; i< priceList.Count; i++)
            {
                if (i+1 != priceList.Count)
                {
                    g.DrawLine(linePen, (int)(i * incrementX), 300 - (int)(priceList[i] * incrementY), (int)((i + 1) * incrementX), 300 - (int)(priceList[i + 1] * incrementY));
                }
            }
            this.Refresh();
        }
        /*Clears entire graph and all data*/
        private void clearButton_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(myCanvas);
            dateList.Clear();
            priceList.Clear();
            g.Clear(Color.White);
            titleLabel.Text = "";
            priceMaxLabel.Text = "";
            priceMaxMidLabel.Text = "";
            priceMinMidLabel.Text = "";
            priceMinLabel.Text = "";
            yearMaxLabel.Text = "";
            yearMaxMidLabel.Text = "";
            yearMinMidLabel.Text = "";
            yearMinMidLabel.Text = "";
            this.Refresh();
        }
        /*finds max value from a double list*/
        private double findMax(List<double> numlist)
        {
            double max = 0.0;
            double temp;
            foreach (double i in numlist)
            {
                temp = i;
                if (temp > max)
                {
                    max = temp;
                }
            }
            return max;
        }
        /*finds min value from a double list*/
        private double findMin(List<double> numlist)
        {
            double min = 1000000.0;
            double temp;
            foreach (double i in numlist)
            {
                temp = i;
                if (temp < min)
                {
                    min = temp;
                }
            }
            return min;
        }


    }
}