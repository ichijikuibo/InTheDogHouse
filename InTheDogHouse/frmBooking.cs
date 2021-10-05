using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InTheDogHouse
{
    public partial class frmBooking : Form
    {
        SqlDataAdapter daCustomer, daDog, daKennel;
        DataSet dsInTheDogHouse = new DataSet();
        SqlCommandBuilder sqlBCustomer;
        string sqlCustomer, sqlDog, sqlKennel;
        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;
        frmContainer container;

        public frmBooking(frmContainer container)
        {
            this.container = container;
            InitializeComponent();
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, container.connStr);
            sqlBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Customer");
            daCustomer.Fill(dsInTheDogHouse, "Customer");

            lstCustomer.DataSource = dsInTheDogHouse.Tables["Customer"];
        }
    }
}
