namespace AnimalKingdom
{
    public abstract class Animal: IMammal
    {
        public virtual string Sound()
        {
            return "Sound will be ";
        }
    }
}
