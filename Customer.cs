namespace Pariveda_Project
{
    public class Customer
    {
        private int preference;

    

        public void SetPreference(int preference)
        {
            this.preference = preference; //sets specific instance of the object to its correct title **known as data shadowing
        }

        public int GetPreference()
        {
            return preference;
        }
    }
}