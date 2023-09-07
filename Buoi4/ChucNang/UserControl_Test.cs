using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChucNang
{
    public partial class UserControl_Test : UserControl
    {
        public UserControl_Test()
        {
            InitializeComponent();
        }

        private void UserControl_Test_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("ThanhPho.txt");
            while(!sr.EndOfStream)
            {
                comboBox1.Items.Add(sr.ReadLine());
            }
        }
    }
}
