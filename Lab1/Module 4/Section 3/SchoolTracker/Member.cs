namespace SchoolTracker
{
    public class Member
    {
        public string Name;
        public string Address;
        private int phone;

        public int Phone
        {
            set { phone = value; }
        }
    }

    public interface IGraduate
    {
        void graduate();
    }
}