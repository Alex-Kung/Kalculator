namespace Калькулятор_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textbox = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bplus = new System.Windows.Forms.Button();
            this.bmult = new System.Windows.Forms.Button();
            this.bdel = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bend = new System.Windows.Forms.Button();
            this.bminus = new System.Windows.Forms.Button();
            this.bprocent = new System.Windows.Forms.Button();
            this.brect = new System.Windows.Forms.Button();
            this.bclear = new System.Windows.Forms.Button();
            this.berase = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.MemClearb = new System.Windows.Forms.Button();
            this.MemReadb = new System.Windows.Forms.Button();
            this.MemSaveb = new System.Windows.Forms.Button();
            this.MemPlusb = new System.Windows.Forms.Button();
            this.MemMinusb = new System.Windows.Forms.Button();
            this.MemLabel = new System.Windows.Forms.Label();
            this.SetPMb = new System.Windows.Forms.Button();
            this.drob = new System.Windows.Forms.Button();
            this.sqrtb = new System.Windows.Forms.Button();
            this.DateStart = new System.Windows.Forms.DateTimePicker();
            this.DateFin = new System.Windows.Forms.DateTimePicker();
            this.Panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dateb = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox.HideSelection = false;
            this.textbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox.Location = new System.Drawing.Point(10, 27);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(201, 30);
            this.textbox.TabIndex = 0;
            this.textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_LastSymb);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b1.Location = new System.Drawing.Point(12, 154);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(35, 25);
            this.b1.TabIndex = 1;
            this.b1.Tag = "1";
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b4.Location = new System.Drawing.Point(12, 185);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(35, 25);
            this.b4.TabIndex = 2;
            this.b4.Tag = "4";
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b7.Location = new System.Drawing.Point(12, 216);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(35, 25);
            this.b7.TabIndex = 3;
            this.b7.Tag = "7";
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b2.Location = new System.Drawing.Point(53, 154);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(35, 25);
            this.b2.TabIndex = 4;
            this.b2.Tag = "2";
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b5.Location = new System.Drawing.Point(53, 185);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(35, 25);
            this.b5.TabIndex = 5;
            this.b5.Tag = "5";
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b8.Location = new System.Drawing.Point(53, 216);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(35, 25);
            this.b8.TabIndex = 6;
            this.b8.Tag = "8";
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b3.Location = new System.Drawing.Point(94, 154);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(35, 25);
            this.b3.TabIndex = 7;
            this.b3.Tag = "3";
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b6.Location = new System.Drawing.Point(94, 185);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(35, 25);
            this.b6.TabIndex = 8;
            this.b6.Tag = "6";
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b9.Location = new System.Drawing.Point(94, 216);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(35, 25);
            this.b9.TabIndex = 9;
            this.b9.Tag = "9";
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            // 
            // bplus
            // 
            this.bplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bplus.Location = new System.Drawing.Point(134, 247);
            this.bplus.Name = "bplus";
            this.bplus.Size = new System.Drawing.Size(35, 25);
            this.bplus.TabIndex = 10;
            this.bplus.Tag = "+";
            this.bplus.Text = "+";
            this.bplus.UseVisualStyleBackColor = true;
            // 
            // bmult
            // 
            this.bmult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bmult.Location = new System.Drawing.Point(134, 185);
            this.bmult.Name = "bmult";
            this.bmult.Size = new System.Drawing.Size(35, 25);
            this.bmult.TabIndex = 11;
            this.bmult.Tag = "*";
            this.bmult.Text = "*";
            this.bmult.UseVisualStyleBackColor = true;
            // 
            // bdel
            // 
            this.bdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bdel.Location = new System.Drawing.Point(134, 154);
            this.bdel.Name = "bdel";
            this.bdel.Size = new System.Drawing.Size(35, 25);
            this.bdel.TabIndex = 12;
            this.bdel.Tag = "/";
            this.bdel.Text = "/";
            this.bdel.UseVisualStyleBackColor = true;
            // 
            // bdot
            // 
            this.bdot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bdot.Location = new System.Drawing.Point(93, 247);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(35, 25);
            this.bdot.TabIndex = 13;
            this.bdot.Tag = ",";
            this.bdot.Text = ",";
            this.bdot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bdot.UseVisualStyleBackColor = true;
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b0.Location = new System.Drawing.Point(12, 247);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(76, 25);
            this.b0.TabIndex = 14;
            this.b0.Tag = "0";
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            // 
            // bend
            // 
            this.bend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bend.Location = new System.Drawing.Point(175, 216);
            this.bend.Name = "bend";
            this.bend.Size = new System.Drawing.Size(35, 56);
            this.bend.TabIndex = 15;
            this.bend.Tag = "";
            this.bend.Text = "=";
            this.bend.UseVisualStyleBackColor = true;
            // 
            // bminus
            // 
            this.bminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bminus.Location = new System.Drawing.Point(134, 216);
            this.bminus.Name = "bminus";
            this.bminus.Size = new System.Drawing.Size(35, 25);
            this.bminus.TabIndex = 16;
            this.bminus.Tag = "-";
            this.bminus.Text = "-";
            this.bminus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bminus.UseVisualStyleBackColor = true;
            // 
            // bprocent
            // 
            this.bprocent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bprocent.Location = new System.Drawing.Point(175, 154);
            this.bprocent.Name = "bprocent";
            this.bprocent.Size = new System.Drawing.Size(35, 25);
            this.bprocent.TabIndex = 18;
            this.bprocent.Tag = "%";
            this.bprocent.Text = "%";
            this.bprocent.UseVisualStyleBackColor = true;
            // 
            // brect
            // 
            this.brect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brect.Location = new System.Drawing.Point(134, 123);
            this.brect.Name = "brect";
            this.brect.Size = new System.Drawing.Size(35, 25);
            this.brect.TabIndex = 20;
            this.brect.Tag = "^";
            this.brect.Text = "^";
            this.brect.UseVisualStyleBackColor = true;
            // 
            // bclear
            // 
            this.bclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bclear.Location = new System.Drawing.Point(53, 123);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(35, 25);
            this.bclear.TabIndex = 21;
            this.bclear.Text = "C";
            this.bclear.UseVisualStyleBackColor = true;
            // 
            // berase
            // 
            this.berase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.berase.Location = new System.Drawing.Point(12, 123);
            this.berase.Name = "berase";
            this.berase.Size = new System.Drawing.Size(35, 25);
            this.berase.TabIndex = 22;
            this.berase.Text = "CE";
            this.berase.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.TSMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.TSMenu_Click);
            // 
            // TSMenu
            // 
            this.TSMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeStrip});
            this.TSMenu.Name = "TSMenu";
            this.TSMenu.Size = new System.Drawing.Size(83, 20);
            this.TSMenu.Text = "Параметры";
            // 
            // TimeStrip
            // 
            this.TimeStrip.CheckOnClick = true;
            this.TimeStrip.Name = "TimeStrip";
            this.TimeStrip.Size = new System.Drawing.Size(139, 22);
            this.TimeStrip.Text = "Дата/Время";
            this.TimeStrip.CheckedChanged += new System.EventHandler(this.DateMode_CheckedChanged);
            // 
            // MemClearb
            // 
            this.MemClearb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemClearb.Location = new System.Drawing.Point(12, 92);
            this.MemClearb.Name = "MemClearb";
            this.MemClearb.Size = new System.Drawing.Size(35, 25);
            this.MemClearb.TabIndex = 26;
            this.MemClearb.Tag = "C";
            this.MemClearb.Text = "MC";
            this.MemClearb.UseVisualStyleBackColor = true;
            // 
            // MemReadb
            // 
            this.MemReadb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemReadb.Location = new System.Drawing.Point(53, 92);
            this.MemReadb.Name = "MemReadb";
            this.MemReadb.Size = new System.Drawing.Size(35, 25);
            this.MemReadb.TabIndex = 27;
            this.MemReadb.Tag = "R";
            this.MemReadb.Text = "MR";
            this.MemReadb.UseVisualStyleBackColor = true;
            // 
            // MemSaveb
            // 
            this.MemSaveb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemSaveb.Location = new System.Drawing.Point(94, 92);
            this.MemSaveb.Name = "MemSaveb";
            this.MemSaveb.Size = new System.Drawing.Size(35, 25);
            this.MemSaveb.TabIndex = 28;
            this.MemSaveb.Tag = "S";
            this.MemSaveb.Text = "MS";
            this.MemSaveb.UseVisualStyleBackColor = true;
            // 
            // MemPlusb
            // 
            this.MemPlusb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemPlusb.Location = new System.Drawing.Point(134, 92);
            this.MemPlusb.Name = "MemPlusb";
            this.MemPlusb.Size = new System.Drawing.Size(35, 25);
            this.MemPlusb.TabIndex = 29;
            this.MemPlusb.Tag = "+";
            this.MemPlusb.Text = "M+";
            this.MemPlusb.UseVisualStyleBackColor = true;
            // 
            // MemMinusb
            // 
            this.MemMinusb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemMinusb.Location = new System.Drawing.Point(175, 92);
            this.MemMinusb.Name = "MemMinusb";
            this.MemMinusb.Size = new System.Drawing.Size(35, 25);
            this.MemMinusb.TabIndex = 30;
            this.MemMinusb.Tag = "-";
            this.MemMinusb.Text = "M-";
            this.MemMinusb.UseVisualStyleBackColor = true;
            // 
            // MemLabel
            // 
            this.MemLabel.AutoSize = true;
            this.MemLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemLabel.Location = new System.Drawing.Point(12, 60);
            this.MemLabel.Name = "MemLabel";
            this.MemLabel.Size = new System.Drawing.Size(2, 26);
            this.MemLabel.TabIndex = 31;
            // 
            // SetPMb
            // 
            this.SetPMb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetPMb.Location = new System.Drawing.Point(94, 123);
            this.SetPMb.Name = "SetPMb";
            this.SetPMb.Size = new System.Drawing.Size(35, 25);
            this.SetPMb.TabIndex = 32;
            this.SetPMb.Tag = "±";
            this.SetPMb.Text = "±";
            this.SetPMb.UseVisualStyleBackColor = true;
            // 
            // drob
            // 
            this.drob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drob.Location = new System.Drawing.Point(175, 123);
            this.drob.Name = "drob";
            this.drob.Size = new System.Drawing.Size(35, 25);
            this.drob.TabIndex = 33;
            this.drob.Tag = "\\";
            this.drob.Text = "1/x";
            this.drob.UseVisualStyleBackColor = true;
            // 
            // sqrtb
            // 
            this.sqrtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrtb.Location = new System.Drawing.Point(175, 184);
            this.sqrtb.Name = "sqrtb";
            this.sqrtb.Size = new System.Drawing.Size(35, 25);
            this.sqrtb.TabIndex = 34;
            this.sqrtb.Tag = "√";
            this.sqrtb.Text = "√";
            this.sqrtb.UseVisualStyleBackColor = true;
            // 
            // DateStart
            // 
            this.DateStart.Location = new System.Drawing.Point(3, 16);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(195, 20);
            this.DateStart.TabIndex = 35;
            // 
            // DateFin
            // 
            this.DateFin.Location = new System.Drawing.Point(3, 55);
            this.DateFin.Name = "DateFin";
            this.DateFin.Size = new System.Drawing.Size(195, 20);
            this.DateFin.TabIndex = 36;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel1.AutoSize = true;
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.DateStart);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.DateFin);
            this.Panel1.Controls.Add(this.Dateb);
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.DateBox);
            this.Panel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Panel1.Location = new System.Drawing.Point(227, 27);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(201, 150);
            this.Panel1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Начальная дата";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Конечная дата";
            // 
            // Dateb
            // 
            this.Dateb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dateb.Location = new System.Drawing.Point(63, 81);
            this.Dateb.Name = "Dateb";
            this.Dateb.Size = new System.Drawing.Size(75, 23);
            this.Dateb.TabIndex = 41;
            this.Dateb.Text = "Вычислить";
            this.Dateb.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Результат:";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(3, 123);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(185, 20);
            this.DateBox.TabIndex = 42;
            // 
            // Form1
            // 
            this.AcceptButton = this.bend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(434, 277);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.sqrtb);
            this.Controls.Add(this.drob);
            this.Controls.Add(this.SetPMb);
            this.Controls.Add(this.MemLabel);
            this.Controls.Add(this.MemMinusb);
            this.Controls.Add(this.MemPlusb);
            this.Controls.Add(this.MemSaveb);
            this.Controls.Add(this.MemReadb);
            this.Controls.Add(this.MemClearb);
            this.Controls.Add(this.berase);
            this.Controls.Add(this.bclear);
            this.Controls.Add(this.brect);
            this.Controls.Add(this.bprocent);
            this.Controls.Add(this.bminus);
            this.Controls.Add(this.bend);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bdot);
            this.Controls.Add(this.bdel);
            this.Controls.Add(this.bmult);
            this.Controls.Add(this.bplus);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " Калькулятор";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_keydown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bplus;
        private System.Windows.Forms.Button bmult;
        private System.Windows.Forms.Button bdel;
        private System.Windows.Forms.Button bdot;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bend;
        private System.Windows.Forms.Button bminus;
        private System.Windows.Forms.Button bprocent;
        private System.Windows.Forms.Button brect;
        private System.Windows.Forms.Button bclear;
        private System.Windows.Forms.Button berase;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMenu;
        private System.Windows.Forms.ToolStripMenuItem TimeStrip;
        private System.Windows.Forms.Button MemClearb;
        private System.Windows.Forms.Button MemReadb;
        private System.Windows.Forms.Button MemSaveb;
        private System.Windows.Forms.Button MemPlusb;
        private System.Windows.Forms.Button MemMinusb;
        private System.Windows.Forms.Label MemLabel;
        private System.Windows.Forms.Button SetPMb;
        private System.Windows.Forms.Button drob;
        private System.Windows.Forms.Button sqrtb;
        private System.Windows.Forms.FlowLayoutPanel Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker DateStart;
        public System.Windows.Forms.DateTimePicker DateFin;
        public System.Windows.Forms.Button Dateb;
        public System.Windows.Forms.TextBox DateBox;
    }
}

