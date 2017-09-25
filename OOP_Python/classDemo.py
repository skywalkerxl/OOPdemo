class Cat:
    def __init__(self, name="小花", shoutNum=3):
        self.name = name
        self.shoutNum = shoutNum

    def shout(self):
        result = ""

        for i in range(self.shoutNum):
            result += "喵!"

        return "我的名字叫:" + self.name + "," + result

cat = Cat("可爱的猫咪", 10)


print(cat.shout())