namespace 代理模式 {
    public class BCosPlayerProxy : ICosPlayer {

        ACosPlayer aCos ;
        
        public BCosPlayerProxy(CCosPlayer c){
            aCos=new ACosPlayer(c);
        }
        public void GiveWeChat () {
            aCos.GiveWeChat ();
        }
        public void GiveFlower () {
            aCos.GiveFlower ();
        }
        public void WatchMovie () {
            aCos.WatchMovie ();
        }
        public void HavingDinner () {
            aCos.HavingDinner ();
        }
    }
}