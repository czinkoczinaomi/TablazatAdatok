using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablazatAdatok
{
    public partial class Form1 : Form

    {
        private List<Auto> autokLista;
        private DataTable raktarTable;
        public Form1()
        {
            InitializeComponent();
            autokLista = new List<Auto>();
            autokLista.Add(new Auto("Jani", "fehér", "Opel"));
            autokLista.Add(new Auto("Sanyi", "zöld", "Fiat"));
            autokLista.Add(new Auto("Éva", "fehér", "Seat"));
            autokLista.Add(new Auto("Margit", "fekete", "Suzuki"));
            autokLista.Add(new Auto("Józsi", "sárga", "Opel"));
            autokLista.Add(new Auto("Erzsi", "rózsaszín", "Toyota"));

            raktarTable = new DataTable();
            TablaSemaKeszit();
            AdatokatFeltolt();
            dataGridView1.DataSource = raktarTable;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void AdatokatFeltolt() {
            foreach (Auto auto in autokLista)
            {
                DataRow dr = raktarTable.NewRow();
                dr["Gyártó"] = auto.Gyarto;
                dr["Szín"] = auto.Szin;
                dr["Név"] = auto.Nev;
                raktarTable.Rows.Add(dr);
            }

        }
        public void TablaSemaKeszit()
        {

            DataColumn gyartoColumn = new DataColumn("Gyártó", typeof(string));
            DataColumn szinColumn = new DataColumn("Szín", typeof(string));
            DataColumn nevColumn = new DataColumn("Név", typeof(string));
            DataColumn autoIdColumn = new DataColumn("AutoId", typeof(int));
            autoIdColumn.Caption="Autó id";
            autoIdColumn.ReadOnly = true;
            autoIdColumn.AllowDBNull = false;
            autoIdColumn.Unique = true;
            autoIdColumn.AutoIncrement = true;
            autoIdColumn.AutoIncrementSeed = 0;
            autoIdColumn.AutoIncrementStep = 1;


            raktarTable.Columns.AddRange(new DataColumn[] { autoIdColumn, gyartoColumn, szinColumn, nevColumn});
        }

        private void BtnTorol_Click(object sender, EventArgs e)
        {
            try
            {
                raktarTable.Rows[int.Parse(txtTorol.Text)].Delete();
                raktarTable.AcceptChanges();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

            raktarTable.Rows.Clear();
            //TablaSemaKeszit();

            AdatokatFeltolt();
            dataGridView1.DataSource = raktarTable;
            //lehetne
            //ini()
        }
        public void ini() {
            autokLista = new List<Auto>();
            autokLista.Add(new Auto("Jani", "fehér", "Opel"));
            autokLista.Add(new Auto("Sanyi", "zöld", "Fiat"));
            autokLista.Add(new Auto("Éva", "fehér", "Seat"));
            autokLista.Add(new Auto("Margit", "fekete", "Suzuki"));
            autokLista.Add(new Auto("Józsi", "sárga", "Opel"));
            autokLista.Add(new Auto("Erzsi", "rózsaszín", "Toyota"));

            raktarTable = new DataTable();
            TablaSemaKeszit();
            AdatokatFeltolt();
            dataGridView1.DataSource = raktarTable;

        }
    }
}
