using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sheep sheep = new Sheep("羊咩咩");
           
            MessageBox.Show(sheep.Shout());
        }
        
        

        class Animal
        {
            protected string name = "";
            protected int shoutNum = 3;

            public Animal(string name)
            {
                this.name = name;
            }

            public Animal()
            {
                this.name = "no name";
            }

            public int ShoutNum
            {
                get
                {
                    return shoutNum;
                }
                set
                {
                    shoutNum = value;
                }
            }

            public string Shout()
            {
                string result = "";

                for(int i = 0; i < shoutNum; i++)
                {
                    result += getShoutSount() + "！";
                }

                return "我的名字叫" + name + " " + result;
            }
            public virtual string getShoutSount()
            {
                return "";
            }
        }

        // 在这里我们用Dog类继承
        class Dog : Animal
        {
            public Dog() : base() { }
            
            public Dog(string name) : base(name) { }

            public override string getShoutSount()
            {
                return "汪";
            }
        }

        // 在这里我们实现一个简单的Cat类
        class Cat:Animal
        {
            public Cat() : base() { }
            
            public Cat(string name) : base(name) { }

            public override string getShoutSount()
            {
                return "喵";
            }
        }

        // 我们还可以实现Sheep类
        class Sheep : Animal
        {
            public Sheep() : base() { }

            public Sheep(string name) : base(name) { }

            public override string getShoutSount()
            {
                return "咩";
            }
        }
    }
}
