using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excercise4
{
    public partial class Form1 : Form
    {
        RealEstateEntities re = new RealEstateEntities();
        //List<Flat> Flats = new List<Flat>();
        List<Flat> flats;
        void LoadData()
        {
            flats = re.Flat.ToList();
        }

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
