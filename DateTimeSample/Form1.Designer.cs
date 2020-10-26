namespace DateTimeSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btNow = new System.Windows.Forms.Button();
            this.tbNowDisp = new System.Windows.Forms.TextBox();
            this.nudDayBeforeAfter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btBefore = new System.Windows.Forms.Button();
            this.btAfter = new System.Windows.Forms.Button();
            this.tbBeforeAfterDisp = new System.Windows.Forms.TextBox();
            this.tbLeapYear = new System.Windows.Forms.TextBox();
            this.nudMonthsBeforeAfter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btCountDay = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCountDay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mcBirthday = new System.Windows.Forms.MonthCalendar();
            this.btFileWrite = new System.Windows.Forms.Button();
            this.lbTextList = new System.Windows.Forms.ListBox();
            this.ofdFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdFileSave = new System.Windows.Forms.SaveFileDialog();
            this.btFileRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayBeforeAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthsBeforeAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // btNow
            // 
            this.btNow.Location = new System.Drawing.Point(31, 39);
            this.btNow.Name = "btNow";
            this.btNow.Size = new System.Drawing.Size(120, 37);
            this.btNow.TabIndex = 1;
            this.btNow.Text = "現在日時";
            this.btNow.UseVisualStyleBackColor = true;
            this.btNow.Click += new System.EventHandler(this.btNow_Click);
            // 
            // tbNowDisp
            // 
            this.tbNowDisp.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbNowDisp.Location = new System.Drawing.Point(183, 39);
            this.tbNowDisp.Multiline = true;
            this.tbNowDisp.Name = "tbNowDisp";
            this.tbNowDisp.ReadOnly = true;
            this.tbNowDisp.Size = new System.Drawing.Size(365, 37);
            this.tbNowDisp.TabIndex = 3;
            this.tbNowDisp.TabStop = false;
            // 
            // nudDayBeforeAfter
            // 
            this.nudDayBeforeAfter.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudDayBeforeAfter.Location = new System.Drawing.Point(384, 112);
            this.nudDayBeforeAfter.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudDayBeforeAfter.Name = "nudDayBeforeAfter";
            this.nudDayBeforeAfter.Size = new System.Drawing.Size(120, 39);
            this.nudDayBeforeAfter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(510, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "日";
            // 
            // btBefore
            // 
            this.btBefore.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBefore.Location = new System.Drawing.Point(184, 188);
            this.btBefore.Name = "btBefore";
            this.btBefore.Size = new System.Drawing.Size(81, 63);
            this.btBefore.TabIndex = 4;
            this.btBefore.Text = "前";
            this.btBefore.UseVisualStyleBackColor = true;
            this.btBefore.Click += new System.EventHandler(this.btBefore_Click);
            // 
            // btAfter
            // 
            this.btAfter.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAfter.Location = new System.Drawing.Point(291, 188);
            this.btAfter.Name = "btAfter";
            this.btAfter.Size = new System.Drawing.Size(81, 63);
            this.btAfter.TabIndex = 5;
            this.btAfter.Text = "後";
            this.btAfter.UseVisualStyleBackColor = true;
            this.btAfter.Click += new System.EventHandler(this.btAfter_Click);
            // 
            // tbBeforeAfterDisp
            // 
            this.tbBeforeAfterDisp.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbBeforeAfterDisp.Location = new System.Drawing.Point(184, 277);
            this.tbBeforeAfterDisp.Multiline = true;
            this.tbBeforeAfterDisp.Name = "tbBeforeAfterDisp";
            this.tbBeforeAfterDisp.ReadOnly = true;
            this.tbBeforeAfterDisp.Size = new System.Drawing.Size(365, 37);
            this.tbBeforeAfterDisp.TabIndex = 0;
            this.tbBeforeAfterDisp.TabStop = false;
            // 
            // tbLeapYear
            // 
            this.tbLeapYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbLeapYear.Location = new System.Drawing.Point(184, 320);
            this.tbLeapYear.Multiline = true;
            this.tbLeapYear.Name = "tbLeapYear";
            this.tbLeapYear.ReadOnly = true;
            this.tbLeapYear.Size = new System.Drawing.Size(365, 37);
            this.tbLeapYear.TabIndex = 8;
            this.tbLeapYear.TabStop = false;
            // 
            // nudMonthsBeforeAfter
            // 
            this.nudMonthsBeforeAfter.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.nudMonthsBeforeAfter.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudMonthsBeforeAfter.Location = new System.Drawing.Point(184, 112);
            this.nudMonthsBeforeAfter.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudMonthsBeforeAfter.Name = "nudMonthsBeforeAfter";
            this.nudMonthsBeforeAfter.Size = new System.Drawing.Size(120, 39);
            this.nudMonthsBeforeAfter.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(310, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "ヶ月";
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(25, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 33);
            this.label7.TabIndex = 3;
            this.label7.Text = "生年月日";
            // 
            // btCountDay
            // 
            this.btCountDay.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCountDay.Location = new System.Drawing.Point(259, 439);
            this.btCountDay.Name = "btCountDay";
            this.btCountDay.Size = new System.Drawing.Size(168, 46);
            this.btCountDay.TabIndex = 9;
            this.btCountDay.Text = "日数計算";
            this.btCountDay.UseVisualStyleBackColor = true;
            this.btCountDay.Click += new System.EventHandler(this.btCountDay_Click);
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(255, 516);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 33);
            this.label8.TabIndex = 3;
            this.label8.Text = "生まれてから";
            // 
            // tbCountDay
            // 
            this.tbCountDay.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbCountDay.Location = new System.Drawing.Point(259, 564);
            this.tbCountDay.Multiline = true;
            this.tbCountDay.Name = "tbCountDay";
            this.tbCountDay.ReadOnly = true;
            this.tbCountDay.Size = new System.Drawing.Size(196, 37);
            this.tbCountDay.TabIndex = 1;
            this.tbCountDay.TabStop = false;
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(461, 568);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 33);
            this.label9.TabIndex = 3;
            this.label9.Text = "日目です";
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(25, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 33);
            this.label10.TabIndex = 3;
            this.label10.Text = "閏年判定";
            // 
            // mcBirthday
            // 
            this.mcBirthday.Location = new System.Drawing.Point(31, 439);
            this.mcBirthday.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.mcBirthday.MaxSelectionCount = 1;
            this.mcBirthday.MinDate = new System.DateTime(1945, 1, 1, 0, 0, 0, 0);
            this.mcBirthday.Name = "mcBirthday";
            this.mcBirthday.ShowToday = false;
            this.mcBirthday.ShowTodayCircle = false;
            this.mcBirthday.TabIndex = 10;
            // 
            // btFileWrite
            // 
            this.btFileWrite.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btFileWrite.Location = new System.Drawing.Point(615, 39);
            this.btFileWrite.Name = "btFileWrite";
            this.btFileWrite.Size = new System.Drawing.Size(163, 63);
            this.btFileWrite.TabIndex = 11;
            this.btFileWrite.Text = "ファイル作成";
            this.btFileWrite.UseVisualStyleBackColor = true;
            this.btFileWrite.Click += new System.EventHandler(this.btFileWrite_Click);
            // 
            // lbTextList
            // 
            this.lbTextList.FormattingEnabled = true;
            this.lbTextList.ItemHeight = 12;
            this.lbTextList.Location = new System.Drawing.Point(615, 118);
            this.lbTextList.Name = "lbTextList";
            this.lbTextList.Size = new System.Drawing.Size(553, 484);
            this.lbTextList.TabIndex = 14;
            // 
            // ofdFileOpen
            // 
            this.ofdFileOpen.FileName = "openFileDialog1";
            // 
            // btFileRead
            // 
            this.btFileRead.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btFileRead.Location = new System.Drawing.Point(801, 39);
            this.btFileRead.Name = "btFileRead";
            this.btFileRead.Size = new System.Drawing.Size(172, 60);
            this.btFileRead.TabIndex = 15;
            this.btFileRead.Text = "ファイル読込";
            this.btFileRead.UseVisualStyleBackColor = true;
            this.btFileRead.Click += new System.EventHandler(this.btFileRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 639);
            this.Controls.Add(this.btFileRead);
            this.Controls.Add(this.lbTextList);
            this.Controls.Add(this.btFileWrite);
            this.Controls.Add(this.mcBirthday);
            this.Controls.Add(this.btCountDay);
            this.Controls.Add(this.btAfter);
            this.Controls.Add(this.btBefore);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMonthsBeforeAfter);
            this.Controls.Add(this.nudDayBeforeAfter);
            this.Controls.Add(this.tbLeapYear);
            this.Controls.Add(this.tbCountDay);
            this.Controls.Add(this.tbBeforeAfterDisp);
            this.Controls.Add(this.tbNowDisp);
            this.Controls.Add(this.btNow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDayBeforeAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthsBeforeAfter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNow;
        private System.Windows.Forms.TextBox tbNowDisp;
        private System.Windows.Forms.NumericUpDown nudDayBeforeAfter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBefore;
        private System.Windows.Forms.Button btAfter;
        private System.Windows.Forms.TextBox tbBeforeAfterDisp;
        private System.Windows.Forms.TextBox tbLeapYear;
        private System.Windows.Forms.NumericUpDown nudMonthsBeforeAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCountDay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCountDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MonthCalendar mcBirthday;
        private System.Windows.Forms.Button btFileWrite;
        private System.Windows.Forms.ListBox lbTextList;
        private System.Windows.Forms.OpenFileDialog ofdFileOpen;
        private System.Windows.Forms.SaveFileDialog sfdFileSave;
        private System.Windows.Forms.Button btFileRead;
    }
}

