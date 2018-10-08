using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KeePass
{
    public class KeePass
    {
        private string id;
        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }


        public string title;
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string username;
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string password;
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string url;
        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }

        public string note;
        public string Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }

        public string grp;
        public string Grp
        {
            get
            {
                return grp;
            }

            set
            {
                grp = value;
            }
        }

        public static List<string> Listgrp = new List<string> { "General", "Windows", "Networking", "Internet", "Email", "Homebanking" };
        public enum group
        {
            General, Windows, Networking, Internet, Email, Homebanking
        }

        // Constructor
        public KeePass()
        {
            this.title = null;
            this.username = null;
            this.password = null;
            this.url = null;
            this.note = null;

            this.Grp = null;
        }
        public KeePass(string title, string usern, string psswrd, group grp, string url, string note)
        {
            this.id = FormMain.Data.SetID();

            this.title = title;
            this.username = usern;
            DataEncryptor de = new DataEncryptor();
            this.password = DataEncryptor.Encrypt(psswrd);
            this.url = url;
            this.note = note;

            this.grp = grp.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            KeePass kp = obj as KeePass;
            if (kp.Id == null)
                return false;
            return base.Equals(obj);
        }

        public bool Equals(KeePass other)
        {
            if (other == null)
                return false;
            return (this.Id.Equals(other.Id));
        }

        // Destructor
        ~KeePass()
        {
            this.id = null;

            this.title = null;
            this.username = null;
            this.password = null;
            this.url = null;
            this.note = null;

            this.grp = null;
        }
    }

    
}
