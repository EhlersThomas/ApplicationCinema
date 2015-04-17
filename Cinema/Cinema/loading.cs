using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class loading : Form
    {
        public delegate void add_file();
        public delegate void show(int total);
        public add_file add;
        public show show_form;

        public loading()
        {
            add = add_loaded;
            show_form = show_frm;
            InitializeComponent();
            this.lbl_current.Text = "0";
        }

        private void add_loaded()
        {
            this.lbl_current.Text = (Convert.ToInt32(lbl_current.Text)+1).ToString();
        }

        public void show_frm(int total_nb)
        {
            this.lbl_total.Text = total_nb.ToString();
        }




        
    }
}
