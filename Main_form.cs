using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_shop_application
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            
                InitializeComponent();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {

        }

        private void Contex_manu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Registration_Click(object sender, EventArgs e)
        {
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void itemRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration_form reg = new Registration_form();
            reg.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void employeRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployRegistration.Empreg er = new EmployRegistration.Empreg();
            er.ShowDialog();
        }

        private void itemRegistrationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Item_registration.item_Registration item = new Item_registration.item_Registration();
            item.ShowDialog();
           
        }

        private void companyRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company.Company_reg creg = new Company.Company_reg();
            creg.ShowDialog();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void passwordResetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userRegestrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserRegestration.user ur = new UserRegestration.user();
            ur.ShowDialog();

        }

        private void custToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer.customer_reg creg = new Customer.customer_reg();
            creg.ShowDialog();
        }

        private void newPurcheaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parchas.parchasfrm pfrm = new Parchas.parchasfrm();
            pfrm.ShowDialog();
        }

        private void returnPurcheaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parchas.parchasreturnfrm prfrm = new Parchas.parchasreturnfrm();
            prfrm.ShowDialog();
        }

        private void newSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale.Sale_Section ss = new Sale.Sale_Section();
            ss.ShowDialog();

        }

        private void returnSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale.Sale_Return sr = new Sale.Sale_Return();
            sr.ShowDialog();
        }

        private void parchasListViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parchas.Parchasview pv = new Parchas.Parchasview();
            pv.ShowDialog();

        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {

        }

        private void parchasReturnListViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Parchas.ParchasRview prv = new Parchas.ParchasRview();
            prv.ShowDialog();
        }

        private void suplairRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company.Suplair_registration sr = new Company.Suplair_registration();
            sr.ShowDialog();
        }

        private void saleListViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale.Sale_view sv = new Sale.Sale_view();
            sv.ShowDialog();
        }

        private void listOfReturnSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale.Sale_return_view sr = new Sale.Sale_return_view();
            sr.ShowDialog();
        }
    }
}
