using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace kullanıcıgiriş
{
    public partial class üyeolform : Form
    {
        string filepath = @"D:\users.txt";
        public üyeolform()
        {
            InitializeComponent();
           
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtkullaniciadi.Text;
            string password=txtpassword.Text;   
            if(!passwordrule(password))
            {
                MessageBox.Show("şifre en az 6 karakter olmalı ve @,_,0-9 karakterlerini içermeli");
                return; 
            }
            File.AppendAllText(filepath,$"{kullaniciadi};{password}{Environment.NewLine}");
            MessageBox.Show("kayıt başarılı");
        }
        private bool passwordrule(string password)
        {
            if(password.Length<6) return false;
            if(!password.Any(char.IsUpper)) return false;
            if (!Regex.IsMatch(password, @"[0-9]")) return false;
            return true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
           
        }
    }
}
