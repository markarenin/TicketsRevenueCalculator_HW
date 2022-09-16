using System.Globalization;

namespace TicketsRevenueCalculator
{
    public partial class Form1 : Form
    {
        public decimal sold_A;
        public decimal sold_B;
        public decimal sold_C;

        public decimal revenue_A;
        public decimal revenue_B;
        public decimal revenue_C;
        public decimal total_revenue;

        public Form1()
        {
            InitializeComponent();
            showResult();
        }

        public void getDataFromBoxes()
        {
            sold_A = tb_CA.Value;
            sold_B = tb_CB.Value;
            sold_C = tb_CC.Value;
        }

        public void calculate()
        {
            revenue_A = sold_A * 15;
            revenue_B = sold_B * 12;
            revenue_C = sold_C * 9;
            total_revenue = revenue_A+revenue_B+revenue_C;
        }

        public void showResult()
        {
            CultureInfo culture = new CultureInfo("et-EE");
            tb_CA_res.Text = sold_A.ToString("C2", culture);
            tb_CB_res.Text = sold_B.ToString("C2", culture);
            tb_CC_res.Text = sold_C.ToString("C2", culture);
            tb_total.Text = total_revenue.ToString("C2", culture);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getDataFromBoxes();
            calculate();
            showResult();
        }

        private void tb_ValueChanged(object sender, EventArgs e)
        {
            getDataFromBoxes();
            calculate();
            showResult();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_CA.Value = 0;
            tb_CB.Value = 0;
            tb_CC.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}