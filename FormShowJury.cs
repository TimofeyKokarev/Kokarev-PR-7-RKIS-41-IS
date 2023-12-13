using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KokarevPR7.DBCon;

namespace KokarevPR7
{
    public partial class FormShowJury : Form
    {
        public FormShowJury()
        {
            InitializeComponent();
        }

        private void FromShowJury_Load(object sender, EventArgs e)
        {
            int number = 1;
            foreach (int i in MainForm.JuriList)
            {
                User user = DBConst.model.User.Find(i);
                UserControJuri usercontrol = new UserControJuri();
                usercontrol.Fill(user,number);
                flowLayoutPanel1.Controls.Add(usercontrol);
                number++;
            }
        }
    }
}
