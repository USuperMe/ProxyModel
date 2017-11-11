using System;
namespace 代理模式 {
    
    public class ACosPlayer : ICosPlayer {
        CCosPlayer c;
        public ACosPlayer (CCosPlayer c) {
            this.c = c;
        }
        public void GiveWeChat () {
            Console.WriteLine ("要微信");
        }
        public void GiveFlower () {
            Console.WriteLine ("送小花花");
        }
        public void WatchMovie () {
            Console.WriteLine ("看电影");
        }
        public void HavingDinner () {
            Console.WriteLine ("共进晚餐");
        }
    }
}