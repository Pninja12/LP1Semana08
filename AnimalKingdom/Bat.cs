namespace AnimalKingdom
{
    public class Bat : Animal, IMammal
    {
        public int NumberOfNipples{get{return 2;}}
        public override string Sound()
        {
            return base.Sound() + "<Click>";
        }
    }
}
