using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanHub {
    class Settings {

        private string title = "";
        private string username = "";
        private string saveLocal = "";
        private int screen = 0;

        public string Title { get => title; set => title = value; }
        public string Username { get => username; set => username = value; }
        public string SaveLocal { get => saveLocal; set => saveLocal = value; }
        public int Screen { get => screen; set => screen = value; }

        public void Init() {

        }

        public bool Load() {
            bool curr = false;

            return curr;
        }

        public bool LoadDefault() {
            bool curr = false;

            return curr;
        }

        public bool usingPrimaryScreen() {
            if(Screen == 0) {
                return true;
            }else {
                return false;
            }
        }

    }
}
