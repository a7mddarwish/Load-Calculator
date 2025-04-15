using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadCalclator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class LoadInfo
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Type { get; set; }
            public int Power { get; set; }
            public int Voltage { get; set; }
            public double PowerFactor { get; set; }
            public double SaftyFactor { get; set; }
            public double DemandFactor { get; set; }


        }
        class LoadResult
        {
            public string LoadName { get; set; }
            public int LoadPower { get; set; }
            public double Current { get; set; }
            public double I_CB { get; set; }
            public int CB { get; set; }



        }

        List<LoadInfo> Loads = new List<LoadInfo>();

        List<LoadResult> EachLoadResult = new List<LoadResult>();



        // Valiedate Region
        #region
        private void textBox5_Validated(object sender, EventArgs e)
        {
            if (!int.TryParse(TB_LoadPower.Text, out int Value))
            {
                errorProvider1.SetError(TB_LoadPower, "Please enter a valied value");
                TB_LoadPower.Focus();
                TB_LoadPower.Text = string.Empty;

            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void textBox7_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(((TextBox)sender).Text, out double Value))
            {
                errorProvider1.SetError(((TextBox)sender), "Please enter a valied value");
                ((TextBox)sender).Focus();
                ((TextBox)sender).Text = string.Empty;

            }
            else if (Value < 0 || Value > 1)
            {
                errorProvider1.SetError((Control)sender, "Please enter Value From [0] to [1]");
                ((Control)sender).Focus();
                ((TextBox)sender).Text = string.Empty;

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private bool CheckValidateInputs()
        {
            // هنا هنتأكد انه دخل كل الحاجات المطلوب انه يدخلها 
            if (string.IsNullOrWhiteSpace(TB_DiamondFactor.Text) ||
                string.IsNullOrWhiteSpace(TB_LoadLocation.Text) ||
                string.IsNullOrWhiteSpace(TB_LoadName.Text) ||
                string.IsNullOrWhiteSpace(TB_LoadPower.Text) ||
                string.IsNullOrWhiteSpace(TB_PowerFactor.Text) ||
                string.IsNullOrWhiteSpace(TB_SaftyFactor.Text))
            {
                return false;
            }

            // هنا هنتأكد انه اختار الفولت و اختار نوع الحمل من الدروب داون ليست
            if (CB_LoadType.SelectedIndex == -1 || CB_Voltage.SelectedIndex == -1)
            {
                // MessageBox.Show("Choice Load type and Voltage", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }




            return true;
        }

        private void SaftyFactorValidate(object sender, EventArgs e)
        {
            if (!double.TryParse(((TextBox)sender).Text, out double Value))
            {
                errorProvider1.SetError(((TextBox)sender), "Please enter a valied value");
                ((TextBox)sender).Focus();
                ((TextBox)sender).Text = string.Empty;

            }
            else if (Value < 1)
            {
                errorProvider1.SetError((Control)sender, "Please enter Value greater than 0");
                ((Control)sender).Focus();
                ((TextBox)sender).Text = string.Empty;

            }
            else
            {
                errorProvider1.Clear();
            }
        }
        #endregion



        private int GetMainCB(double CB)
        {
            List<int> MainCBS = new List<int>
            {
                10 ,16, 20, 25, 30, 35, 40, 45, 50, 60, 70, 80, 90, 100, 110, 125, 150, 175, 200, 225,
                  250, 300, 350, 400, 450, 500, 600, 700, 800, 1000, 1200,1600,200,2500,3000,4000,
                  5000,6000
            };
            
            int closest = -1;

            foreach (int number in MainCBS)
            {
                if (number > CB)
                {
                    if (closest == -1 || number < closest)
                    {
                        closest = number;
                    }
                }
            }

            return closest;



        }
        private LoadInfo CollectData()
        {
            LoadInfo Load = new LoadInfo();

            Load.Location = TB_LoadLocation.Text;
            Load.Name = TB_LoadName.Text;
            Load.PowerFactor = double.Parse(TB_PowerFactor.Text);
            Load.SaftyFactor = double.Parse(TB_SaftyFactor.Text);
            Load.DemandFactor = double.Parse(TB_DiamondFactor.Text);
            Load.Power = Convert.ToInt32(TB_LoadPower.Text);
            Load.Type = CB_LoadType.SelectedItem.ToString();
            Load.Voltage = Convert.ToInt32(CB_Voltage.SelectedItem);

            return Load;
        }


        private double CalculateAmber(LoadInfo Load)
        {
            double Result = 0;
            switch (Load.Voltage)
            {
                case 220:
                    {
                        Result = (Load.DemandFactor * (double)Load.Power) / (Load.Voltage * Load.PowerFactor);
                        break;

                    }
                case 380:
                    {
                        Result = (Load.DemandFactor * (double)Load.Power) / ((Math.Pow(Load.Voltage, 1.0 / 3.0) * Load.PowerFactor));
                        break;

                    }

            }

            return Result;


        }
        private LoadResult CalCLoadResult(LoadInfo Load)
        {
            LoadResult Result = new LoadResult();

            Result.LoadName = Load.Name;
            Result.LoadPower = Load.Power;

            Result.Current = Math.Round(CalculateAmber(Load), 3);
            Result.I_CB = Math.Round((Result.Current * Load.SaftyFactor), 3);

            Result.CB = GetMainCB(Result.I_CB);





            return Result;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (! CheckValidateInputs())
            {
                MessageBox.Show("Please enter full data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            LoadInfo Load = CollectData();
            Loads.Add(Load);


            LoadResult Result = CalCLoadResult(Load);

            EachLoadResult.Add(Result);

            RefreshDGV();

            ClearAllInputs();

        }

        private void ClearAllInputs()
        {
            // Data Field
            TB_DiamondFactor.Clear();
            TB_LoadLocation.Clear();
            TB_LoadName.Clear();
            TB_LoadPower.Clear();
            TB_PowerFactor.Clear();
            TB_SaftyFactor.Clear();
            CB_LoadType.SelectedIndex = -1;
            CB_Voltage.SelectedIndex = -1;

            // Resut Field

            LB_CB.Text = "###";
            LB_MCB.Text = "###";
            LB_PL.Text = "###";
            LB_Totalcrnt.Text = "###";


        }

        private void RefreshDGV()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = EachLoadResult;
            dataGridView1.Columns[0].HeaderText = "Load Name";
            dataGridView1.Columns[1].HeaderText = "Load Power [W]";
            dataGridView1.Columns[2].HeaderText = "Current [A]";
            dataGridView1.Columns[3].HeaderText = "I C.B [A]";
            dataGridView1.Columns[4].HeaderText = "C.B";



            LB_LoadNum.Text = EachLoadResult.Count.ToString();


        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            // هنظهر الحاجات اللي هنعرض عليها في الواجهة 
            PNL1.Visible = true;
            label18.Visible = true;

            // هنحسب التوتال باور
            int TotalPower = 0;
            for (int i = 0; i < Loads.Count; i++)
            {
                TotalPower += Loads[i].Power;
            }



            // Calculation
            double TotalCurrent = ((double)TotalPower) / 660;
            double CB = TotalCurrent * 1.25;

            int MainCB = GetMainCB(CB);

            if (MainCB < 25)
            {
                MainCB = 25;
            }


            // هنعرض النتايج في الواحهة من خلال ال <Labels>
             LB_MCB.Text = MainCB.ToString();

            LB_Totalcrnt.Text = Math.Round(((double)TotalPower / 660), 3).ToString();

            LB_CB.Text = Math.Round((((double)TotalPower / 660) * 1.25), 3).ToString();






            LB_PL.Text = TotalPower.ToString();




        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(240, 244, 248);
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).BorderStyle = BorderStyle.None;
                    control.BackColor = Color.White;
                    control.Font = new Font("Segoe UI", 10F);

                    // إضافة تأثير الظل
                    Panel panel = new Panel();
                    panel.BorderStyle = BorderStyle.None;
                    panel.Size = new Size(control.Width + 4, control.Height + 4);
                    panel.Location = new Point(control.Left - 2, control.Top - 2);
                    panel.BackColor = Color.LightGray;
                    this.Controls.Add(panel);
                    panel.BringToFront();
                    control.Parent = panel;
                    control.Location = new Point(2, 2);
                }
                else if (control is Button)
                {
                    ((Button)control).FlatStyle = FlatStyle.Flat;
                    ((Button)control).FlatAppearance.BorderSize = 0;
                    control.BackColor = Color.FromArgb(52, 152, 219); // لون أزرق فاتح
                    control.ForeColor = Color.White;
                    control.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    ((Button)control).Cursor = Cursors.Hand;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).FlatStyle = FlatStyle.Flat;
                    control.BackColor = Color.White;
                }
            }
        }

        private void btn_Reset(object sender, EventArgs e)
        {
            PNL1.Visible = false;
            label18.Visible = false;
            EachLoadResult.Clear();
            Loads.Clear();
            RefreshDGV();
            ClearAllInputs();

        }

        
    }
    
}

