using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IpTools_2
{
    public class Event
    {
        int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        bool mod;

        public bool Mod
        {
            get { return mod; }
            set { mod = value; }
        }

        bool zakl;

        public bool Zakl
        {
            get { return zakl; }
            set { zakl = value; }
        }

        string usil;

        public string Usil
        {
            get { return usil; }
            set { usil = value; }
        }

        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
