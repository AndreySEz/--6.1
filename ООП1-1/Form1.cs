using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Person
        {
            public string Name;
            public string Surname;

            public Person()
            {
                Name="";
                Surname="";
            }

            public Person(string personName)
            {
                Name = personName;
                Surname = "";
            }

            public Person(string personName, string personSurname)
            {
                Name = personName;
                Surname = personSurname;
            }
        }
    }
}
