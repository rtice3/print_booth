using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PrintBooth
{
    public partial class Form1 : Form
    {
        private int lefty_jobs = 0;
        private string path = "C:\\";
        private List<PrintDocument> left_queue;
        private PrinterSettings left_settings;

        
        public Form1()
        {
            InitializeComponent();
            left_queue = new List<PrintDocument>();
        //    left_settings = new PrinterSettings();
        }

        private void select_btn_left_Click(object sender, EventArgs e)
        {
            this.left_print_diag.PrinterSettings = this.left_settings;
            DialogResult result = this.left_print_diag.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.printer_txt_left.Text = this.left_print_diag.PrinterSettings.PrinterName;
                left_settings = this.left_print_diag.PrinterSettings;
                this.paper_size_combo.Items.Clear();

                foreach (PaperSize ps in this.left_print_diag.PrinterSettings.PaperSizes)
                    this.paper_size_combo.Items.Add(ps);
            }
        }
      
        private void update_queue_lbl(int val, Label lbl)
        {
            lbl.Text = val + " Jobs in Queue";
        }

        private void end_left_print(object sender, PrintEventArgs e)
        {
            if (lefty_jobs > 0) {
                lefty_jobs--;
                left_queue.Remove(left_queue.Last());
            }
            else
                lefty_jobs = 0;
            update_queue_lbl(lefty_jobs, queue_lbl_left);
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintDialog diag;
            PrintDocument doc = new PrintDocument();
            
            diag = this.left_print_diag;
            left_queue.Add(doc);
            left_queue.Last().EndPrint += new System.Drawing.Printing.PrintEventHandler(this.end_left_print);
            lefty_jobs++;
            update_queue_lbl(lefty_jobs, this.queue_lbl_left);
                
            diag.Document = doc;
            diag.PrinterSettings.Copies = (short)this.combo.Value;
            doc.PrinterSettings = this.left_settings;
            doc.PrinterSettings.PrinterName = this.printer_txt_left.Text;
            doc.PrinterSettings.Copies = diag.PrinterSettings.Copies;
            doc.PrintPage += (esender, args) =>
                {
                    Image i = this.picture_view.Image;
             //       args.PageSettings.PaperSize.Width = (int)this.width_num.Value * 100;
             //       args.PageSettings.PaperSize.Height = (int)this.height_num.Value * 100;
                    if(this.paper_size_combo.Items.Count > 0)
                        args.PageSettings.PaperSize = (PaperSize)this.paper_size_combo.SelectedItem;
                    args.Graphics.DrawImage(i, args.PageBounds);
               //     MessageBox.Show("Height:" + args.PageBounds.Height + " Width:" + args.PageBounds.Width);          
                };
      //      MessageBox.Show("Printing to " + doc.PrinterSettings.PrinterName + " with copies " + doc.PrinterSettings.Copies);
            doc.Print();
            this.serial_txt.Text = "";
            this.picture_view.Image = null;
            this.print_btn.Enabled = false;
            this.combo.Value = 1;
        }

        private void serial_txt_TextChanged(object sender, EventArgs e)
        {
            string date = "";
            if (this.serial_txt.Text == "")
            {
                this.clear_btn.Enabled = false;
            }
            else
            {
                this.clear_btn.Enabled = true;
            }
            if (this.override_check.Checked)
            {
                date = this.date_override.Value.ToString("MM_dd_yyyy");
            }
            else
            {
                DateTime cur = DateTime.Now;
                TimeSpan five = new TimeSpan(05, 0, 0);
                TimeSpan now = DateTime.Now.TimeOfDay;

                if (now < five)
                    date = cur.AddDays(-1).ToString("MM_dd_yyyy");
                else
                    date = cur.ToString("MM_dd_yyyy");
            }

            string foldername = this.dir_txt.Text + "\\" + date + "\\Post";
            string filename = this.serial_txt.Text + ".jpg";
            if (!Directory.Exists(foldername))
            {
                DialogResult result = MessageBox.Show("Create directory \"" + foldername + "\"?", "Confirm Create Directory", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    Directory.CreateDirectory(foldername);
                }
                else
                {
                    MessageBox.Show("Cannot search path:" + foldername + " for image.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
            }
            string full_path = foldername + "\\" + filename;
            if (File.Exists(full_path))
            {
                this.picture_view.Image = new Bitmap(full_path);
                this.print_btn.Enabled = true;
                this.print_btn_Click(this.print_btn, EventArgs.Empty);
            }
            else
            {
                this.picture_view.Image = null;
                this.print_btn.Enabled = false;
            }
        }
        private void serial_txt_LostFocus(object sender, EventArgs e)
        {
            this.serial_txt.Focus();
        }

        private string get_actual_date()
        {
            DateTime cur = DateTime.Now;
            return cur.ToString("MM_dd_yyyy");
        }

        private string get_time()
        {
            DateTime cur = DateTime.Now;
            return cur.ToString("h:mm:ss tt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dir_txt.Text = path;

            DialogResult result = MessageBox.Show("Please confirm the current date and time: " + this.get_actual_date() + " " + this.get_time(), "Confirm Date Time", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Please fix system clock and re-run PhotoBooth.", "Fix System Clock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = this.folderBrowserDialog1.SelectedPath;
                this.dir_txt.Text = path;
            }
            serial_txt_TextChanged(this.serial_txt, EventArgs.Empty);
        }

        private void override_check_CheckedChanged(object sender, EventArgs e)
        {
            if (this.override_check.Checked)
            {
                this.date_override.Enabled = true;
            }
            else
            {
                this.date_override.Enabled = false;
            }
            this.date_override.Value = DateTime.Now;
            serial_txt_TextChanged(this.serial_txt, EventArgs.Empty);
        }

        private void date_override_ValueChanged(object sender, EventArgs e)
        {
            serial_txt_TextChanged(this.serial_txt, EventArgs.Empty);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            this.serial_txt.Text = "";
        }   
    }
}
