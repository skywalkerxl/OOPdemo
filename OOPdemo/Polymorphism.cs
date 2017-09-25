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
    public partial class Polymorphism : Form
    {
        public Polymorphism()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat("Tom", 6);
            MessageBox.Show(cat.shout());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog("Husky", 5);
            MessageBox.Show(dog.shout());
        }

        class Animal
        {
            protected string name = "";
            protected int shoutNum = 4;

            //  无参构造函数
            public Animal() { }

            //  带两个形参的构造函数,构造函数重载
            public Animal(string name, int shoutNum)
            {
                this.name = name;
                this.shoutNum = shoutNum;
            }

            //  
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

            public string shout()
            {
                string result = "";
                for (int i = 0 ; i < this.shoutNum; i++)
                {
                    result += getShoutSound();
                }
                return "我的名字叫:" + this.name + "," + result;
            }

            // 这里只需要给需要继承的子类使用，所以只需要设置为protected,而不需要设置为publc
            protected virtual string getShoutSound()  
            {
                return "";
            }
        }

        class Dog : Animal
        {
            public Dog() : base() { }
            public Dog(string name, int shoutNum) : base(name, shoutNum) { }

            protected override string getShoutSound()
            {
                return "嗷!";
            }
        }

        class Cat : Animal
        {
            public Cat() : base() { }
            public Cat(string name, int shoutNum) : base(name, shoutNum) { }

            protected override string getShoutSound()
            {
                return "喵!";
            }

        }

        
    }
}
