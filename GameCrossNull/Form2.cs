using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (label1.Text != "" && label2.Text != "")
            {
                Form1 form1 = new Form1();
                form1.StrFirstPlayer = label1.Text;
                form1.StrSecondPlayer = label2.Text;
                form1.ShowDialog();
                base.OnShown(e);
                this.Hide();
                this.Visible = false;
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                SetVisibleCore(false);
            }
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!this.IsHandleCreated)
            {
                value = false;
                CreateHandle();
            }
            base.SetVisibleCore(value);
        }


    }
}
