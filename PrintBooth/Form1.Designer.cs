namespace PrintBooth
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serial_txt = new System.Windows.Forms.TextBox();
            this.serial_lbl = new System.Windows.Forms.Label();
            this.combo_lbl = new System.Windows.Forms.Label();
            this.date_override = new System.Windows.Forms.DateTimePicker();
            this.print_btn = new System.Windows.Forms.Button();
            this.printer_txt_left = new System.Windows.Forms.TextBox();
            this.select_btn_left = new System.Windows.Forms.Button();
            this.queue_lbl_left = new System.Windows.Forms.Label();
            this.combo = new System.Windows.Forms.NumericUpDown();
            this.picture_view = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.browse_btn = new System.Windows.Forms.Button();
            this.dir_txt = new System.Windows.Forms.TextBox();
            this.left_print_diag = new System.Windows.Forms.PrintDialog();
            this.override_check = new System.Windows.Forms.CheckBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.logo_lbl = new System.Windows.Forms.Label();
            this.print_grp = new System.Windows.Forms.GroupBox();
            this.paper_size_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.combo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_view)).BeginInit();
            this.print_grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // serial_txt
            // 
            this.serial_txt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.serial_txt.Location = new System.Drawing.Point(55, 210);
            this.serial_txt.Name = "serial_txt";
            this.serial_txt.Size = new System.Drawing.Size(287, 20);
            this.serial_txt.TabIndex = 0;
            this.serial_txt.TextChanged += new System.EventHandler(this.serial_txt_TextChanged);
            this.serial_txt.LostFocus += new System.EventHandler(this.serial_txt_LostFocus);
            // 
            // serial_lbl
            // 
            this.serial_lbl.AutoSize = true;
            this.serial_lbl.Location = new System.Drawing.Point(13, 214);
            this.serial_lbl.Name = "serial_lbl";
            this.serial_lbl.Size = new System.Drawing.Size(36, 13);
            this.serial_lbl.TabIndex = 2;
            this.serial_lbl.Text = "Serial:";
            // 
            // combo_lbl
            // 
            this.combo_lbl.AutoSize = true;
            this.combo_lbl.Location = new System.Drawing.Point(6, 96);
            this.combo_lbl.Name = "combo_lbl";
            this.combo_lbl.Size = new System.Drawing.Size(54, 13);
            this.combo_lbl.TabIndex = 7;
            this.combo_lbl.Text = "# To Print";
            // 
            // date_override
            // 
            this.date_override.CalendarMonthBackground = System.Drawing.SystemColors.ControlDarkDark;
            this.date_override.Enabled = false;
            this.date_override.Location = new System.Drawing.Point(366, 12);
            this.date_override.Name = "date_override";
            this.date_override.Size = new System.Drawing.Size(200, 20);
            this.date_override.TabIndex = 8;
            this.date_override.ValueChanged += new System.EventHandler(this.date_override_ValueChanged);
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.print_btn.Enabled = false;
            this.print_btn.ForeColor = System.Drawing.Color.Black;
            this.print_btn.Location = new System.Drawing.Point(290, 91);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(75, 23);
            this.print_btn.TabIndex = 10;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // printer_txt_left
            // 
            this.printer_txt_left.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.printer_txt_left.Location = new System.Drawing.Point(101, 32);
            this.printer_txt_left.Name = "printer_txt_left";
            this.printer_txt_left.ReadOnly = true;
            this.printer_txt_left.Size = new System.Drawing.Size(245, 20);
            this.printer_txt_left.TabIndex = 14;
            // 
            // select_btn_left
            // 
            this.select_btn_left.BackColor = System.Drawing.SystemColors.ControlDark;
            this.select_btn_left.ForeColor = System.Drawing.Color.Black;
            this.select_btn_left.Location = new System.Drawing.Point(9, 30);
            this.select_btn_left.Name = "select_btn_left";
            this.select_btn_left.Size = new System.Drawing.Size(75, 23);
            this.select_btn_left.TabIndex = 13;
            this.select_btn_left.Text = "Select";
            this.select_btn_left.UseVisualStyleBackColor = false;
            this.select_btn_left.Click += new System.EventHandler(this.select_btn_left_Click);
            // 
            // queue_lbl_left
            // 
            this.queue_lbl_left.AutoSize = true;
            this.queue_lbl_left.Location = new System.Drawing.Point(111, 64);
            this.queue_lbl_left.Name = "queue_lbl_left";
            this.queue_lbl_left.Size = new System.Drawing.Size(84, 13);
            this.queue_lbl_left.TabIndex = 15;
            this.queue_lbl_left.Text = "0 Jobs in Queue";
            // 
            // combo
            // 
            this.combo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.combo.Location = new System.Drawing.Point(66, 94);
            this.combo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(120, 20);
            this.combo.TabIndex = 17;
            this.combo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // picture_view
            // 
            this.picture_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_view.Location = new System.Drawing.Point(15, 236);
            this.picture_view.Name = "picture_view";
            this.picture_view.Size = new System.Drawing.Size(551, 458);
            this.picture_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_view.TabIndex = 18;
            this.picture_view.TabStop = false;
            // 
            // browse_btn
            // 
            this.browse_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.browse_btn.ForeColor = System.Drawing.Color.Black;
            this.browse_btn.Location = new System.Drawing.Point(15, 12);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(75, 23);
            this.browse_btn.TabIndex = 19;
            this.browse_btn.Text = "Browse";
            this.browse_btn.UseVisualStyleBackColor = false;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // dir_txt
            // 
            this.dir_txt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dir_txt.Location = new System.Drawing.Point(97, 12);
            this.dir_txt.Name = "dir_txt";
            this.dir_txt.ReadOnly = true;
            this.dir_txt.Size = new System.Drawing.Size(244, 20);
            this.dir_txt.TabIndex = 20;
            // 
            // left_print_diag
            // 
            this.left_print_diag.UseEXDialog = true;
            // 
            // override_check
            // 
            this.override_check.AutoSize = true;
            this.override_check.Location = new System.Drawing.Point(418, 38);
            this.override_check.Name = "override_check";
            this.override_check.Size = new System.Drawing.Size(92, 17);
            this.override_check.TabIndex = 21;
            this.override_check.Text = "Override Date";
            this.override_check.UseVisualStyleBackColor = true;
            this.override_check.CheckedChanged += new System.EventHandler(this.override_check_CheckedChanged);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clear_btn.Enabled = false;
            this.clear_btn.ForeColor = System.Drawing.Color.Black;
            this.clear_btn.Location = new System.Drawing.Point(352, 210);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 22;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // logo_lbl
            // 
            this.logo_lbl.AutoSize = true;
            this.logo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_lbl.Location = new System.Drawing.Point(221, 724);
            this.logo_lbl.Name = "logo_lbl";
            this.logo_lbl.Size = new System.Drawing.Size(135, 13);
            this.logo_lbl.TabIndex = 23;
            this.logo_lbl.Text = "Powered by Orchid Studios";
            // 
            // print_grp
            // 
            this.print_grp.Controls.Add(this.select_btn_left);
            this.print_grp.Controls.Add(this.printer_txt_left);
            this.print_grp.Controls.Add(this.queue_lbl_left);
            this.print_grp.Controls.Add(this.combo_lbl);
            this.print_grp.Controls.Add(this.combo);
            this.print_grp.Controls.Add(this.print_btn);
            this.print_grp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.print_grp.Location = new System.Drawing.Point(15, 53);
            this.print_grp.Name = "print_grp";
            this.print_grp.Size = new System.Drawing.Size(388, 133);
            this.print_grp.TabIndex = 24;
            this.print_grp.TabStop = false;
            this.print_grp.Text = "Printer Settings";
            // 
            // paper_size_combo
            // 
            this.paper_size_combo.FormattingEnabled = true;
            this.paper_size_combo.Location = new System.Drawing.Point(418, 127);
            this.paper_size_combo.Name = "paper_size_combo";
            this.paper_size_combo.Size = new System.Drawing.Size(121, 21);
            this.paper_size_combo.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Paper Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paper_size_combo);
            this.Controls.Add(this.print_grp);
            this.Controls.Add(this.logo_lbl);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.override_check);
            this.Controls.Add(this.dir_txt);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.picture_view);
            this.Controls.Add(this.date_override);
            this.Controls.Add(this.serial_lbl);
            this.Controls.Add(this.serial_txt);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Jason Bohrer Print Booth";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.combo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_view)).EndInit();
            this.print_grp.ResumeLayout(false);
            this.print_grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serial_txt;
        private System.Windows.Forms.Label serial_lbl;
        private System.Windows.Forms.Label combo_lbl;
        private System.Windows.Forms.DateTimePicker date_override;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.TextBox printer_txt_left;
        private System.Windows.Forms.Button select_btn_left;
        private System.Windows.Forms.Label queue_lbl_left;
        private System.Windows.Forms.NumericUpDown combo;
        private System.Windows.Forms.PictureBox picture_view;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.TextBox dir_txt;
        private System.Windows.Forms.PrintDialog left_print_diag;
        private System.Windows.Forms.CheckBox override_check;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label logo_lbl;
        private System.Windows.Forms.GroupBox print_grp;
        private System.Windows.Forms.ComboBox paper_size_combo;
        private System.Windows.Forms.Label label1;
    }
}

