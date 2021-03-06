### 立体几何模拟器(项目名称待定)
#### 1.创意来源
Unity全球学生开发挑战赛，比赛要求以"教授技能"为主题来创作一个3D项目。看了部分已经提交的游戏，多是电影式的教育，借助VR，AR或是其他一些技术实现的叙事性质的游戏。个人感觉确实创意不错，但是缺乏游戏性，游戏扩展性不高，可玩部分不多，更像是精美的艺术品。一个游戏需要比较完整的游戏规则与设定，而且本次比赛又要以"教授技能"为主题，因此创意玩法应该与教育很好的结合起来才行。前些天在看一些高中的立体几何知识，发现立体几何这些对于学生的想象力有不小要求，也有很多学生说"立体几何很困难"。因此，做一个立体几何相关的游戏，帮助学生理解立体几何，个人感觉是很有必要的。
#### 2.游戏设计

>高中立体几何有着自己一套完整的公理定理等——这就是游戏规则。

>每道题目要求证明线面平行，垂直等问题——这就是游戏要达成的目的。

实际上一道立体几何的证明题就是一个完整的游戏关卡了不是么？如何将这个证明过程(也就是游戏的过程)，以一个比较趣味的方式展现出来，是目前比较麻烦的问题。我目前的设计思路如下：
* 关卡设计

>关卡由一道道的立体几何证明题开始，由简到难，玩家根据题目的已知条件开始进行，直到证明完成，则顺利通关。(感觉带上了一点解密元素，haha)关卡挑战中有时间计时，如果计时结束，尚未证明成功，则挑战失败——考试中往往我们还是需要在很短时间内做出这道题目的。

* 人物设计

>游戏只有玩家一种角色，且暂时只有一位玩家。玩家可以在空间中自由移动，第一人称，且游戏右上方应该有预览的小地图。

* 规则设计

>根据立体几何证明规则，核心包括：
><br/>
>1. 平行：在互相平行的线段之间能够进行相互跳跃
>2. 直角：任何直角位置处都能拿取方块

* 道具设计

>主要包括延长时间道具，提示道具等。
