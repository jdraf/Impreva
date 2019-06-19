using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
   public class mylistclass
    {
        private string v1;
        private string v2;
        private string v3;

        public mylistclass(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public int id { get; set; }
        public string activity { get; set; }
        public string name { get; set; }
        public string elapstime { get; set; }
        
    }
}
