using Rodney_Stock_WindowsFormApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rodney_Stock_WindowsFormApp
{
    public partial class VariantForm : Form
    {
        public ProductVariant NewVariant { get; private set; } //***//
        private RodneyStockDB db = new RodneyStockDB();
        public VariantForm()
        {
            InitializeComponent();
        }

        private void btn_xml_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_varyasyonTuru.Text) || string.IsNullOrEmpty(tb_deger.Text))
            {
                MessageBox.Show("Varyasyon türü ve değeri boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nud_stok.Value < 0)
            {
                MessageBox.Show("Stok miktarı negatif olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Variant v = new Variant();
            v.VariantType = tb_varyasyonTuru.Text;
            v.VariantValue = tb_deger.Text;

            db.Variants.Add(v);
            db.SaveChanges();

            NewVariant = new ProductVariant();
            NewVariant.VariantID = v.ID;
            NewVariant.Stock = Convert.ToInt32(nud_stok.Value);
            NewVariant.Variant = v;

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
