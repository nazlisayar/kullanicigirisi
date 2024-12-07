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

namespace kullanıcıgiriş
{
    public partial class üyegirisi : Form
    {
        string filepath = @"D:\users.txt";
        public üyegirisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           üyeolform ileri=new üyeolform(); 
            ileri.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kullaniciadi=txtkullaniciadi1.Text;  
            string password=txtpassword1.Text; 
            if(File.Exists(filepath))
            {
                var lines=File.ReadAllLines(filepath);
                foreach (var line in lines)
                {
                    var data = line.Split(';');
                    if (data[0] == kullaniciadi && data[1] == password)
                    {
                        hoşgeldiniz yenisayfa = new hoşgeldiniz();
                        yenisayfa.ShowDialog();
                    }
                }
            }
            MessageBox.Show("kullanıcı adi veya şifre hatalı"); 
        }
    }
}
