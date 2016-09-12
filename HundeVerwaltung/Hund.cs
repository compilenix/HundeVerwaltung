using System;
using System.Collections.Generic;
using System.Text;

namespace HundeVerwaltung {
    class Hund {
        private int size;
        private String name;
        public const int cSize = 0;
        public const String cName = "NoName";

        public Hund() {
            this.Name = cName;
            this.Size = cSize;
        }

        public Hund(String name) {
            this.Name = name;
            this.Size = cSize;
        }

        public Hund(int size) {
            this.Name = cName;
            this.Size = size;
        }

        public Hund(int newSize, String newName) {
            this.Name = newName;
            this.Size = newSize;
        }

        public int Size { set { size = value; } get { return size; } }
		
        public String Name {
            set {
                name = value;
            }
            get {
                return name;
            }
        }

        public String Bellen() {
            if (this.Size > 60) {
                return "Wuff! Wuff!";
            } else if (this.Size > 14) {
                return "Wau! Wau!";
            } else {
                return "Jipp! Jipp!";
            }
        }

        public String[] Bellen(int countOf) {
            String[] outPutArr = new String[countOf];
            String outPutStr;
            if (this.Size > 60) {
                outPutStr = "Wuff! Wuff!";
            } else if (this.Size > 14) {
                outPutStr = "Wau! Wau!";
            } else {
                outPutStr = "Jipp! Jipp!";
            }
            for (int i = 0; i < countOf; i++) {
                outPutArr.SetValue(outPutStr, i);
            }
            return outPutArr;
        }
    }
}
