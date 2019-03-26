using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirst_MToMRelation.DAL.Context;

namespace CodeFirst_MToMRelation
{
    public partial class Form1 : Form
    {
        UniversityContext db = DbSingleTone.GetInstance();
        public Form1()
        {
            InitializeComponent();
        }
    }
}
