namespace LoadCalclator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.LB_LoadNum = new System.Windows.Forms.Label();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CB_Voltage = new System.Windows.Forms.ComboBox();
            this.CB_LoadType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_PowerFactor = new System.Windows.Forms.TextBox();
            this.TB_SaftyFactor = new System.Windows.Forms.TextBox();
            this.TB_DiamondFactor = new System.Windows.Forms.TextBox();
            this.TB_LoadLocation = new System.Windows.Forms.TextBox();
            this.TB_LoadPower = new System.Windows.Forms.TextBox();
            this.TB_LoadName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.PNL1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.LB_Totalcrnt = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.LB_CB = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LB_PL = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LB_MCB = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel5.SuspendLayout();
            this.PNL1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(551, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(737, 394);
            this.dataGridView1.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(34, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(549, 529);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "#Number of Loads  =";
            // 
            // LB_LoadNum
            // 
            this.LB_LoadNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_LoadNum.AutoSize = true;
            this.LB_LoadNum.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold);
            this.LB_LoadNum.Location = new System.Drawing.Point(735, 531);
            this.LB_LoadNum.Name = "LB_LoadNum";
            this.LB_LoadNum.Size = new System.Drawing.Size(38, 18);
            this.LB_LoadNum.TabIndex = 8;
            this.LB_LoadNum.Text = "###";
            // 
            // btn_Calc
            // 
            this.btn_Calc.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Calc.Location = new System.Drawing.Point(192, 549);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(142, 41);
            this.btn_Calc.TabIndex = 6;
            this.btn_Calc.Text = "Calculate";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label14.Location = new System.Drawing.Point(102, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(433, 82);
            this.label14.TabIndex = 10;
            this.label14.Text = "Load Calculator";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label17.Location = new System.Drawing.Point(824, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 41);
            this.label17.TabIndex = 10;
            this.label17.Text = "Loads Info";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label18.Location = new System.Drawing.Point(824, 561);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(168, 41);
            this.label18.TabIndex = 10;
            this.label18.Text = "Panal Load";
            this.label18.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.CB_Voltage);
            this.panel5.Controls.Add(this.CB_LoadType);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.TB_PowerFactor);
            this.panel5.Controls.Add(this.TB_SaftyFactor);
            this.panel5.Controls.Add(this.TB_DiamondFactor);
            this.panel5.Controls.Add(this.TB_LoadLocation);
            this.panel5.Controls.Add(this.TB_LoadPower);
            this.panel5.Controls.Add(this.TB_LoadName);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(35, 131);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(458, 395);
            this.panel5.TabIndex = 12;
            // 
            // CB_Voltage
            // 
            this.CB_Voltage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Voltage.FormattingEnabled = true;
            this.CB_Voltage.Items.AddRange(new object[] {
            "220",
            "380"});
            this.CB_Voltage.Location = new System.Drawing.Point(21, 227);
            this.CB_Voltage.Name = "CB_Voltage";
            this.CB_Voltage.Size = new System.Drawing.Size(164, 24);
            this.CB_Voltage.TabIndex = 44;
            // 
            // CB_LoadType
            // 
            this.CB_LoadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_LoadType.FormattingEnabled = true;
            this.CB_LoadType.Items.AddRange(new object[] {
            "Lighting",
            "Small Power ",
            "HVAC",
            "Motor",
            "other"});
            this.CB_LoadType.Location = new System.Drawing.Point(21, 144);
            this.CB_LoadType.Name = "CB_LoadType";
            this.CB_LoadType.Size = new System.Drawing.Size(164, 24);
            this.CB_LoadType.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11F);
            this.label2.Location = new System.Drawing.Point(251, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "Load Power";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11F);
            this.label4.Location = new System.Drawing.Point(251, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "Load Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11F);
            this.label8.Location = new System.Drawing.Point(251, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 22);
            this.label8.TabIndex = 37;
            this.label8.Text = "Demand factor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11F);
            this.label7.Location = new System.Drawing.Point(251, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 22);
            this.label7.TabIndex = 40;
            this.label7.Text = "Power factor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11F);
            this.label6.Location = new System.Drawing.Point(19, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Safty factor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11F);
            this.label5.Location = new System.Drawing.Point(22, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "Voltage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11F);
            this.label3.Location = new System.Drawing.Point(19, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "Load Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11F);
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "Load Name";
            // 
            // TB_PowerFactor
            // 
            this.TB_PowerFactor.Location = new System.Drawing.Point(251, 314);
            this.TB_PowerFactor.Multiline = true;
            this.TB_PowerFactor.Name = "TB_PowerFactor";
            this.TB_PowerFactor.Size = new System.Drawing.Size(171, 29);
            this.TB_PowerFactor.TabIndex = 45;
            this.TB_PowerFactor.Validated += new System.EventHandler(this.textBox7_Validated);
            // 
            // TB_SaftyFactor
            // 
            this.TB_SaftyFactor.Location = new System.Drawing.Point(21, 314);
            this.TB_SaftyFactor.Multiline = true;
            this.TB_SaftyFactor.Name = "TB_SaftyFactor";
            this.TB_SaftyFactor.Size = new System.Drawing.Size(171, 29);
            this.TB_SaftyFactor.TabIndex = 43;
            this.TB_SaftyFactor.Text = "1.25";
            this.TB_SaftyFactor.Validated += new System.EventHandler(this.SaftyFactorValidate);
            // 
            // TB_DiamondFactor
            // 
            this.TB_DiamondFactor.Location = new System.Drawing.Point(251, 228);
            this.TB_DiamondFactor.Multiline = true;
            this.TB_DiamondFactor.Name = "TB_DiamondFactor";
            this.TB_DiamondFactor.Size = new System.Drawing.Size(171, 29);
            this.TB_DiamondFactor.TabIndex = 41;
            this.TB_DiamondFactor.Validated += new System.EventHandler(this.textBox7_Validated);
            // 
            // TB_LoadLocation
            // 
            this.TB_LoadLocation.Location = new System.Drawing.Point(251, 145);
            this.TB_LoadLocation.Multiline = true;
            this.TB_LoadLocation.Name = "TB_LoadLocation";
            this.TB_LoadLocation.Size = new System.Drawing.Size(171, 29);
            this.TB_LoadLocation.TabIndex = 32;
            // 
            // TB_LoadPower
            // 
            this.TB_LoadPower.Location = new System.Drawing.Point(251, 70);
            this.TB_LoadPower.Multiline = true;
            this.TB_LoadPower.Name = "TB_LoadPower";
            this.TB_LoadPower.Size = new System.Drawing.Size(171, 29);
            this.TB_LoadPower.TabIndex = 30;
            this.TB_LoadPower.Validated += new System.EventHandler(this.textBox5_Validated);
            // 
            // TB_LoadName
            // 
            this.TB_LoadName.Location = new System.Drawing.Point(21, 70);
            this.TB_LoadName.Multiline = true;
            this.TB_LoadName.Name = "TB_LoadName";
            this.TB_LoadName.Size = new System.Drawing.Size(171, 29);
            this.TB_LoadName.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.label10.Location = new System.Drawing.Point(421, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 24);
            this.label10.TabIndex = 36;
            this.label10.Text = "W";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label16.Location = new System.Drawing.Point(137, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(220, 37);
            this.label16.TabIndex = 46;
            this.label16.Text = "Enter Load Data";
            // 
            // PNL1
            // 
            this.PNL1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL1.BackColor = System.Drawing.Color.White;
            this.PNL1.Controls.Add(this.panel2);
            this.PNL1.Controls.Add(this.panel3);
            this.PNL1.Controls.Add(this.panel4);
            this.PNL1.Controls.Add(this.panel6);
            this.PNL1.Location = new System.Drawing.Point(551, 596);
            this.PNL1.Name = "PNL1";
            this.PNL1.Size = new System.Drawing.Size(737, 110);
            this.PNL1.TabIndex = 13;
            this.PNL1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.LB_Totalcrnt);
            this.panel2.Location = new System.Drawing.Point(363, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 34);
            this.panel2.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12.2F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total current = ";
            // 
            // LB_Totalcrnt
            // 
            this.LB_Totalcrnt.AutoSize = true;
            this.LB_Totalcrnt.Font = new System.Drawing.Font("Consolas", 12.2F, System.Drawing.FontStyle.Bold);
            this.LB_Totalcrnt.ForeColor = System.Drawing.Color.White;
            this.LB_Totalcrnt.Location = new System.Drawing.Point(288, 0);
            this.LB_Totalcrnt.Name = "LB_Totalcrnt";
            this.LB_Totalcrnt.Size = new System.Drawing.Size(46, 24);
            this.LB_Totalcrnt.TabIndex = 8;
            this.LB_Totalcrnt.Text = "###";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.LB_CB);
            this.panel3.Location = new System.Drawing.Point(15, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 34);
            this.panel3.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 12.2F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "I_Circuit breaker =";
            // 
            // LB_CB
            // 
            this.LB_CB.AutoSize = true;
            this.LB_CB.Font = new System.Drawing.Font("Consolas", 12.2F, System.Drawing.FontStyle.Bold);
            this.LB_CB.ForeColor = System.Drawing.Color.White;
            this.LB_CB.Location = new System.Drawing.Point(243, 4);
            this.LB_CB.Name = "LB_CB";
            this.LB_CB.Size = new System.Drawing.Size(46, 24);
            this.LB_CB.TabIndex = 8;
            this.LB_CB.Text = "###";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.LB_PL);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(15, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 34);
            this.panel4.TabIndex = 13;
            // 
            // LB_PL
            // 
            this.LB_PL.AutoSize = true;
            this.LB_PL.Font = new System.Drawing.Font("Consolas", 12.2F, System.Drawing.FontStyle.Bold);
            this.LB_PL.ForeColor = System.Drawing.Color.White;
            this.LB_PL.Location = new System.Drawing.Point(243, 4);
            this.LB_PL.Name = "LB_PL";
            this.LB_PL.Size = new System.Drawing.Size(46, 24);
            this.LB_PL.TabIndex = 8;
            this.LB_PL.Text = "###";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 12.2F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 24);
            this.label15.TabIndex = 0;
            this.label15.Text = "Panal load = ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.LB_MCB);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(363, 60);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(358, 34);
            this.panel6.TabIndex = 14;
            // 
            // LB_MCB
            // 
            this.LB_MCB.AutoSize = true;
            this.LB_MCB.Font = new System.Drawing.Font("Consolas", 12.2F, System.Drawing.FontStyle.Bold);
            this.LB_MCB.ForeColor = System.Drawing.Color.White;
            this.LB_MCB.Location = new System.Drawing.Point(288, 4);
            this.LB_MCB.Name = "LB_MCB";
            this.LB_MCB.Size = new System.Drawing.Size(46, 24);
            this.LB_MCB.TabIndex = 8;
            this.LB_MCB.Text = "###";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 12.2F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(286, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Main circuit breaker = ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(350, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Reset);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoadCalclator.Properties.Resources.ELE;
            this.pictureBox1.Location = new System.Drawing.Point(482, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 739);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.PNL1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.LB_LoadNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label18);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.PNL1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LB_LoadNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CB_Voltage;
        private System.Windows.Forms.ComboBox CB_LoadType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_PowerFactor;
        private System.Windows.Forms.TextBox TB_SaftyFactor;
        private System.Windows.Forms.TextBox TB_DiamondFactor;
        private System.Windows.Forms.TextBox TB_LoadLocation;
        private System.Windows.Forms.TextBox TB_LoadPower;
        private System.Windows.Forms.TextBox TB_LoadName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel PNL1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LB_Totalcrnt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LB_CB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LB_PL;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label LB_MCB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
    }
}

