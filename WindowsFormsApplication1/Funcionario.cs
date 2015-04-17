using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class Funcionario
    {
        public string name;
        public string age;
        public string sex;
        public string job;
        public string civilState;
        public string kids;
        public string AOB;
        public string email;
        public string adress;
        public string money;
        public string cellphone;
            

       public  string asString()
        {
            return name + "?" + age + "?" + sex + "?" + job + "?" + civilState + "?" + kids + "?" + AOB + "?" + email + "?" + adress + "?" + money + "?" + cellphone;
        }

        public void fromString(string data)
        {
            string[] info = data.Split('?');
            
            name = info[0];
            age = info[1];
            sex = info[2];
            job = info[3];
            civilState = info[4];
            kids = info[5];
            AOB = info[6];
            email = info[7];
            adress = info[8];
            money = info[9];
            cellphone = info[10];
        }

            public Funcionario(string nome, string idad, string se, string jo, string civilStat, string kid,
                string aob, string emai, string adres, string mone, string cellphon)
            {
                name = nome;
                age = idad;
                sex = se;
                job = jo;
                civilState = civilStat;
                kids = kid;
                AOB = aob;
                email = emai;
                adress = adres;
                money = mone;
                cellphone = cellphon;
            }
    }
}
