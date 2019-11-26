using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Informatika
{
    #region User
    public class User
    {
        #region Member Variables
        protected string _username;
        protected string _password;
        protected string _nama;
        protected string _status;
        #endregion
        #region Constructors
        public User() { }
        public User(string password, string nama, string status)
        {
            this._password=password;
            this._nama=nama;
            this._status=status;
        }
        #endregion
        #region Public Properties
        public virtual string Username
        {
            get {return _username;}
            set {_username=value;}
        }
        public virtual string Password
        {
            get {return _password;}
            set {_password=value;}
        }
        public virtual string Nama
        {
            get {return _nama;}
            set {_nama=value;}
        }
        public virtual string Status
        {
            get {return _status;}
            set {_status=value;}
        }
        #endregion
    }
    #endregion
}