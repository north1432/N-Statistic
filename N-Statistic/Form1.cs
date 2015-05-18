using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace N_Statistic
{
    public partial class Form1 : Form
    {
        List<double> data = new List<double>();
        List<int> count = new List<int>();
        double min = 99999999, max = -99999999, sum=0, countdata=0, sumsquare=0, mean=0, sbchali=0, q1=0, q2=0, q3=0, SD=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int i, j = 0, k = 0, counting=1, number_of_count=0, max_counting=0;
            data.Clear();
            count.Clear();
            min = 99999999;
            max = -99999999;
            sum = 0;
            countdata = 0;
            sumsquare = 0;
            mean = 0;
            sbchali = 0;
            ZOutput.Text = "";
            Input.Text = Input.Text.Replace(",", " ");
            //Input.Text = Input.Text.Replace(".", " ");
            Input.Text = Input.Text.Replace("\n", " ");
            Input.Text = Input.Text.Replace("/", " ");
            Input.Text = Input.Text.Replace("\\", " ");
            Input.Text = Input.Text.Replace("    ", " ");
            Input.Text = Input.Text.Replace("   ", " ");
            Input.Text = Input.Text.Replace("  ", " ");
            while (Input.Text.StartsWith(" ")) Input.Text = Input.Text.Substring(1);
            while (Input.Text.EndsWith(" ")) Input.Text = Input.Text.Remove(Input.TextLength - 1);
            String[] s = Input.Text.Split(' ');
            int n = s.Count();
            if (s[0] == "")
            {
                new Form2().Show();
                goto end_of_function;
            }
               
            for (i=0;i<n;i++)
            {
                if (!double.TryParse(s[i], out countdata))
                {
                    new Form2().Show();
                    return;
                }
                data.Add(countdata);
                sum += countdata;
                sumsquare += countdata * countdata;
                if (countdata > max) max = countdata;
                if (countdata < min) min = countdata;
            }
            data.Sort();

            // Mean
            mean = sum / n;
            MeanLabel.Text = (mean).ToString();

            // Median
            if (n % 2 == 1)
            {
                MedianLabel.Text = data[n / 2].ToString();
            }
            else
            {
                MedianLabel.Text = ((data[n / 2 - 1] + data[n / 2]) / 2).ToString();
            }

            // Mode

            countdata = data[0];
            for (i = 1; i < n; i++)
            {
                if (data[i] == countdata) counting++;
                else
                {
                    if (counting > max_counting) max_counting = counting;
                    count.Add(counting);
                    counting = 1;
                    countdata = data[i];
                    number_of_count++;
                }
            }

            if (counting > max_counting) max_counting = counting;
            count.Add(counting);
            counting = 1;
            countdata = data[n-1];
            number_of_count++;
            for (i = 0; i < number_of_count; i++)
            {
                if (count[i] == max_counting && j == 0)
                {
                    for (j = 0; j < i; j++)
                    {
                        k += count[j];
                    }
                    ModeLabel.Text = data[k].ToString();
                    j = 1;
                }
                else if (count[i] == max_counting && j == 1)
                {
                    for (j = 0; j < i; j++)
                    {
                        k += count[j];
                    }
                    ModeLabel.Text += ", " + data[k].ToString();
                    j = 2;
                }
                else if (count[i] == max_counting && j >= 2)
                {
                    ModeLabel.Text = "No Mode in this group of data";
                    goto end_of_mode;
                }
            }
        end_of_mode: ;
            
            //Max Min Range
            MaxLabel.Text = max.ToString();
            MinLabel.Text = min.ToString();
            RangeLabel.Text = (max-min).ToString();

            
            //S.D.
            SD = Math.Sqrt(sumsquare / n - mean * mean);
            SDLabel.Text = SD.ToString();

            //Variant
            VariantLabel.Text = (SD * SD).ToString();


            //SbChalier
            for (i = 0; i < n; i++)
            {
                if (data[i] - mean < 0) sbchali += mean - data[i];
                else sbchali += data[i] - mean;
            }
            SbchalierLabel.Text = sbchali.ToString();

            //Quartile
            //Q1
            if (n == 1)
            {
                q1 = q2 = q3 = data[0];
            }
            else if (n == 2)
            {
                q1 = 0.75 * data[0];
                q2 = float.Parse(MedianLabel.Text);
                q3 = 0;
            }
            else if (n == 3)
            {
                q1 = data[0];
                q2 = data[1];
                q3 = data[2];
            }
            else
            {
                q1 = data[(n + 1) / 4 - 1] + ((data[(n + 1) / 4] - data[(n + 1) / 4 - 1]) * ((float)(n + 1) / 4 - Math.Floor((double)(n + 1) / 4)));
                q2 = float.Parse(MedianLabel.Text);
                q3 = data[(3 * (n + 1) / 4) - 1] + ((data[3 * (n + 1) / 4] - data[3 * (n + 1) / 4 - 1]) * ((float)3 * (n + 1) / 4 - Math.Floor((double)3 * (n + 1) / 4))); // เกร๋ๆ
            }
            
            Q1Label.Text = q1.ToString();
            Q2Label.Text = q2.ToString();
            Q3Label.Text = q3.ToString();

            // C.R.
            CRLabel.Text = ((max - min) / (max + min)).ToString();

            // C.Q.
            CQLabel.Text = ((q3 - q1) / (q3 + q1)).ToString();

            // C.M.
            CMlabel.Text = (sbchali / mean).ToString();

            // C.V.
            CVLabel.Text = (SD / mean).ToString();

            // Sort, Z
            SortOutput.Text = "";
            for (i = 0; i < n; i++)
            {
                SortOutput.Text += data[i] + " ";
                double d = (data[i] - mean) / SD;
                ZOutput.Text += String.Format("{0:F2}", d) + " ";
            }

        end_of_function: ;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            data.Clear();
            count.Clear();
            min = 99999999;
            max = -99999999;
            sum = 0;
            countdata = 0;
            sumsquare = 0;
            mean = 0;
            q1 = 0;
            q2 = 0;
            q3 = 0;
            Input.Text = "";
            MedianLabel.Text = "";
            MeanLabel.Text = "";
            ModeLabel.Text = "";
            MaxLabel.Text = "";
            MinLabel.Text = "";
            RangeLabel.Text = "";
            SDLabel.Text = "";
            SortOutput.Text = "";
            SbchalierLabel.Text = "";
            VariantLabel.Text = "";
            Q1Label.Text = "";
            Q2Label.Text = "";
            Q3Label.Text = "";
            ZOutput.Text = "";
            CRLabel.Text = "";
            CMlabel.Text = "";
            CVLabel.Text = "";
            CQLabel.Text = "";
        }
    }
}
