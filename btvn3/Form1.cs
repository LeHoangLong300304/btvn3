using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btvn3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
            {
                ListViewItem lt = lvStudent.SelectedItems[0];
                string lastname = lt.SubItems[0].Text;
                string firtname = lt.SubItems[1].Text;
                string phone = lt.SubItems[2].Text;

                txtLastName.Text = lastname;
                txtFirstName.Text = firtname;
                txtPhone.Text = phone;

            }
        }

        private void SửaThem_Click(object sender, EventArgs e)
        {
            ListViewItem it = new ListViewItem(txtLastName.Text);
            it.SubItems.Add(txtFirstName.Text);
            it.SubItems.Add(txtPhone.Text);
            lvStudent.Items.Add(it);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
            {
                lvStudent.Items.RemoveAt(lvStudent.SelectedItems[0].Index);
            }
            else
            {
                MessageBox.Show("Vui long chon dong de xoa!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
            {
                ListViewItem item = lvStudent.SelectedItems[0];
                item.SubItems[0].Text = txtLastName.Text;
                item.SubItems[1].Text = txtFirstName.Text;
                item.SubItems[2].Text = txtPhone.Text;

            }
            else
            {
                MessageBox.Show("Vui long chon dong de sua!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


