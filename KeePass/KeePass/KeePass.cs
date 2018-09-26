using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeePass
{
    public class KeePass
    {
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
        public static List<string> Listgrp = new List<string> { "General", "Networking", "Internet", "Homebanking" };
        public enum group
        {
            General, Networking, Internet, Homebanking
        }

        // Constructor
        public KeePass()
        {
            this.Title = null;
            this.Username = null;
            this.Password = null;
            this.Url = null;
            this.Note = null;

            this.Grp = null;
        }
        public KeePass(string title, string usern, string psswrd, group grp, string url, string note)
        {
            this.Title = title;
            this.Username = usern;
            this.Password = psswrd;
            this.Url = url;
            this.Note = note;

            this.Grp = grp.ToString();
        }

        // Update
        public void Change(string title, string usern, string psswrd, group grp, string url, string note)
        {
            this.Title = title;
            this.Username = usern;
            this.Password = psswrd;
            this.Url = url;
            this.Note = note;

            this.Grp = grp.ToString();
        }

        // Check URL is valid
        public bool CheckURL(string url)
        {
            Uri link = new Uri(url);
            bool result = Uri.TryCreate(url, UriKind.Absolute, out link)
                   && (link.Scheme == Uri.UriSchemeHttp || link.Scheme == Uri.UriSchemeHttps);
            return result;
        }

        // Destructor
        ~KeePass()
        {
            this.Title = null;
            this.Username = null;
            this.Password = null;
            this.Url = null;
            this.Note = null;

            this.Grp = null;
        }
    }
}
