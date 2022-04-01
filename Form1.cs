using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanHub {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            this.Text = "";
            this.ShowIcon = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        Settings settings;
        PersHub hub;


        private void Form1_Load(object sender, EventArgs e) {
            settings = new Settings();
            if (settings.LoadDefault()) {
                hub = new PersHub(settings);
            } else {
                hub = new PersHub(new Settings() { Username = "Newbie", Screen = 0, Title = "Welcome to StanHub" });
            }
            




        }
    }
}
