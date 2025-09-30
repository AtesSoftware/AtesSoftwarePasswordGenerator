namespace PassGenerator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackbar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.generatebutton = new Guna.UI2.WinForms.Guna2Button();
            this.pswsize = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.numberscheckbox = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.copy = new Guna.UI2.WinForms.Guna2Button();
            this.copylabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nums = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.specialcheckbox = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.chara = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.capitalcheckbox = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackbar
            // 
            this.trackbar.BackColor = System.Drawing.Color.Transparent;
            this.trackbar.HoverState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.trackbar.LargeChange = 1;
            this.trackbar.Location = new System.Drawing.Point(11, 87);
            this.trackbar.Margin = new System.Windows.Forms.Padding(2);
            this.trackbar.Maximum = 50;
            this.trackbar.Minimum = 5;
            this.trackbar.Name = "trackbar";
            this.trackbar.Size = new System.Drawing.Size(306, 51);
            this.trackbar.TabIndex = 1;
            this.trackbar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.trackbar.Value = 10;
            this.trackbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackbar_Scroll);
            // 
            // pass
            // 
            this.pass.Animated = true;
            this.pass.BorderRadius = 10;
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.DefaultText = "";
            this.pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.Black;
            this.pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass.Location = new System.Drawing.Point(7, 46);
            this.pass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pass.Name = "pass";
            this.pass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.pass.PlaceholderText = "";
            this.pass.ReadOnly = true;
            this.pass.SelectedText = "";
            this.pass.Size = new System.Drawing.Size(466, 46);
            this.pass.TabIndex = 3;
            // 
            // generatebutton
            // 
            this.generatebutton.Animated = true;
            this.generatebutton.BackColor = System.Drawing.Color.Transparent;
            this.generatebutton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.generatebutton.BorderRadius = 9;
            this.generatebutton.BorderThickness = 1;
            this.generatebutton.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.generatebutton.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.generatebutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generatebutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generatebutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generatebutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generatebutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.generatebutton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold);
            this.generatebutton.ForeColor = System.Drawing.Color.White;
            this.generatebutton.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.generatebutton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.generatebutton.Location = new System.Drawing.Point(360, 126);
            this.generatebutton.Margin = new System.Windows.Forms.Padding(2);
            this.generatebutton.Name = "generatebutton";
            this.generatebutton.Size = new System.Drawing.Size(117, 41);
            this.generatebutton.TabIndex = 6;
            this.generatebutton.Text = "Şifre Oluştur";
            this.generatebutton.Tile = true;
            this.generatebutton.UseTransparentBackground = true;
            this.generatebutton.Click += new System.EventHandler(this.generatebutton_Click);
            // 
            // pswsize
            // 
            this.pswsize.BackColor = System.Drawing.Color.Transparent;
            this.pswsize.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswsize.ForeColor = System.Drawing.Color.White;
            this.pswsize.Location = new System.Drawing.Point(11, 143);
            this.pswsize.Margin = new System.Windows.Forms.Padding(2);
            this.pswsize.Name = "pswsize";
            this.pswsize.Size = new System.Drawing.Size(91, 20);
            this.pswsize.TabIndex = 7;
            this.pswsize.Text = "Şifre Uzunluğu:";
            // 
            // numberscheckbox
            // 
            this.numberscheckbox.Animated = true;
            this.numberscheckbox.AutoRoundedCorners = true;
            this.numberscheckbox.Checked = true;
            this.numberscheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.numberscheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.numberscheckbox.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.numberscheckbox.CheckedState.InnerColor = System.Drawing.Color.White;
            this.numberscheckbox.Location = new System.Drawing.Point(14, 192);
            this.numberscheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.numberscheckbox.Name = "numberscheckbox";
            this.numberscheckbox.Size = new System.Drawing.Size(43, 20);
            this.numberscheckbox.TabIndex = 8;
            this.numberscheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numberscheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numberscheckbox.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.numberscheckbox.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // copy
            // 
            this.copy.Animated = true;
            this.copy.BackColor = System.Drawing.Color.Transparent;
            this.copy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.copy.BorderRadius = 9;
            this.copy.BorderThickness = 1;
            this.copy.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.copy.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.copy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.copy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.copy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.copy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.copy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.copy.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy.ForeColor = System.Drawing.Color.White;
            this.copy.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.copy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.copy.Location = new System.Drawing.Point(395, 97);
            this.copy.Margin = new System.Windows.Forms.Padding(2);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(82, 25);
            this.copy.TabIndex = 10;
            this.copy.Text = "Kopyala";
            this.copy.Tile = true;
            this.copy.UseTransparentBackground = true;
            this.copy.Visible = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // copylabel
            // 
            this.copylabel.BackColor = System.Drawing.Color.Transparent;
            this.copylabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copylabel.ForeColor = System.Drawing.Color.Lime;
            this.copylabel.Location = new System.Drawing.Point(346, 171);
            this.copylabel.Margin = new System.Windows.Forms.Padding(2);
            this.copylabel.Name = "copylabel";
            this.copylabel.Size = new System.Drawing.Size(131, 16);
            this.copylabel.TabIndex = 11;
            this.copylabel.Text = "Şifre Başarıyla Kopyalandı!";
            this.copylabel.Visible = false;
            this.copylabel.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // nums
            // 
            this.nums.BackColor = System.Drawing.Color.Transparent;
            this.nums.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nums.ForeColor = System.Drawing.Color.White;
            this.nums.Location = new System.Drawing.Point(62, 192);
            this.nums.Margin = new System.Windows.Forms.Padding(2);
            this.nums.Name = "nums";
            this.nums.Size = new System.Drawing.Size(44, 20);
            this.nums.TabIndex = 12;
            this.nums.Text = "Sayılar";
            // 
            // specialcheckbox
            // 
            this.specialcheckbox.Animated = true;
            this.specialcheckbox.AutoRoundedCorners = true;
            this.specialcheckbox.Checked = true;
            this.specialcheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.specialcheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.specialcheckbox.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.specialcheckbox.CheckedState.InnerColor = System.Drawing.Color.White;
            this.specialcheckbox.Location = new System.Drawing.Point(14, 167);
            this.specialcheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.specialcheckbox.Name = "specialcheckbox";
            this.specialcheckbox.Size = new System.Drawing.Size(43, 20);
            this.specialcheckbox.TabIndex = 13;
            this.specialcheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.specialcheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.specialcheckbox.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.specialcheckbox.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // chara
            // 
            this.chara.BackColor = System.Drawing.Color.Transparent;
            this.chara.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chara.ForeColor = System.Drawing.Color.White;
            this.chara.Location = new System.Drawing.Point(62, 167);
            this.chara.Margin = new System.Windows.Forms.Padding(2);
            this.chara.Name = "chara";
            this.chara.Size = new System.Drawing.Size(101, 20);
            this.chara.TabIndex = 14;
            this.chara.Text = "Özel Karakterler";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(222, 192);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(84, 20);
            this.guna2HtmlLabel1.TabIndex = 16;
            this.guna2HtmlLabel1.Text = "Büyük Harfler";
            // 
            // capitalcheckbox
            // 
            this.capitalcheckbox.Animated = true;
            this.capitalcheckbox.AutoRoundedCorners = true;
            this.capitalcheckbox.Checked = true;
            this.capitalcheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.capitalcheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.capitalcheckbox.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.capitalcheckbox.CheckedState.InnerColor = System.Drawing.Color.White;
            this.capitalcheckbox.Location = new System.Drawing.Point(174, 192);
            this.capitalcheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.capitalcheckbox.Name = "capitalcheckbox";
            this.capitalcheckbox.Size = new System.Drawing.Size(43, 20);
            this.capitalcheckbox.TabIndex = 15;
            this.capitalcheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.capitalcheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.capitalcheckbox.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.capitalcheckbox.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Black;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(311, 192);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(29, 29);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 17;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.PaleGreen;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(346, 192);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(131, 29);
            this.guna2HtmlLabel2.TabIndex = 18;
            this.guna2HtmlLabel2.Text = "AtesSoftware";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.IndianRed;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.LightGray;
            this.guna2Button1.Location = new System.Drawing.Point(395, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(37, 35);
            this.guna2Button1.TabIndex = 19;
            this.guna2Button1.Text = "➖";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.IndianRed;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.LightGray;
            this.guna2Button2.Location = new System.Drawing.Point(436, 5);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(37, 35);
            this.guna2Button2.TabIndex = 20;
            this.guna2Button2.Text = "X";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(495, 223);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.generatebutton);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.capitalcheckbox);
            this.Controls.Add(this.chara);
            this.Controls.Add(this.specialcheckbox);
            this.Controls.Add(this.nums);
            this.Controls.Add(this.copylabel);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.numberscheckbox);
            this.Controls.Add(this.pswsize);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.trackbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TrackBar trackbar;
        private Guna.UI2.WinForms.Guna2TextBox pass;
        private Guna.UI2.WinForms.Guna2Button generatebutton;
        private Guna.UI2.WinForms.Guna2HtmlLabel pswsize;
        private Guna.UI2.WinForms.Guna2ToggleSwitch numberscheckbox;
        private Guna.UI2.WinForms.Guna2Button copy;
        private Guna.UI2.WinForms.Guna2HtmlLabel copylabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel nums;
        private Guna.UI2.WinForms.Guna2ToggleSwitch specialcheckbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel chara;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch capitalcheckbox;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}

