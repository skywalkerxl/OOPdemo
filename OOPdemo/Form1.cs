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
            Cat cat = new Cat("Tom", 3);
            cat.ShoutNum = 5;
            MessageBox.Show(cat.Shout());
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
                    result += "喵";
                }

                return "我的名字叫" + name + result;
            }
            public virtual string getShoutCount()
            {
                return "";
            }
        }

        // 在这里我们用Dog类继承
        class Dog : Animal
        {
            public Dog() : base() { }
            public Dog(string name) : base(name) { }
            public string Shout()
            {
                string result = "";
                
                for(int i = 0; i< shoutNum; i++)
                {
                    result += "汪";
                }

                return "I am a single dog " + name + result;
            }
        }

        // 在这里我们实现一个简单的Cat类
        class Cat:Animal
        {
            public Cat() : base() { }
            public Cat(string name) : base(name) { }
            public string Shout()
            {
                string result = "";
                for (int i = 0; i < shoutNum; i++)
                {
                    result += "喵";
                }

                return "我的名字叫" + name + result;
            }
        }

    }
}
