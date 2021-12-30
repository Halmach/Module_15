namespace Module_15
{
    internal class Contact
    {
        public Contact()
        {
        }

        public Contact(string Name, long Phone, string Email)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
        }

        public string Name { get; set; }
        public long Phone { get; set; }
        public string Email { get; }
    }
}