using System;
using System.Collections;
using System.Collections.Generic;


namespace Week11LabProgram
{
    // Create the class for a Contact with details such as name and phone number
    public class Contact
    {
        // Declare a variable for Name along with accessor
        private string name;
        public string Name
        { 
            get => name;
            set => name = value;
        }
        // Declare a varibale for PhoneNumber along with accessor
        private string phoneNumber;
        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }
    }

    // Create the class for managing multiple contracts 
    // implementing the IEnumerable
    public class Contacts : IEnumerator<Contact>, IEnumerable<Contact>
    {
        // Create a list of contacts along with accessor
        public List<Contact> contacts;
        private int position = -1;

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Contact Current
        {
            get
            {
                try
                {
                    return contacts[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        // Implement of IEnumerable<Contact> GetEnumerator
        public IEnumerator<Contact> GetEnumerator()
        {
            // write the code from the method implementation
            return this;
        }

        public bool MoveNext()
        {
            position++;
            return (position < contacts.Count);
        }

        public void Reset() => position = -1;

        // Implement IEnumerable.GetEnumerator 
        IEnumerator IEnumerable.GetEnumerator()
        {
            // write the code from the method implementation
            return GetEnumerator();
        }

        public void Dispose() { }
    }
    
    class IenumerableDemo
    {
        static void Main(string[] args)
        {
            // Create new contracts
            var myContacts = new Contacts();
            var a = new Contact() { Name = "a", PhoneNumber = "123456789" };
            var b = new Contact() { Name = "b", PhoneNumber = "125656789" };
            var c = new Contact() { Name = "c", PhoneNumber = "789456789" };
            var d = new Contact() { Name = "d", PhoneNumber = "123676789" };

            // Add new contracts into the list
            myContacts.contacts = new List<Contact>();
            myContacts.contacts.Add(a);
            myContacts.contacts.Add(b);
            myContacts.contacts.Add(c);
            myContacts.contacts.Add(d);

            // Use foreach to iterate all the contacts
            foreach (var i in myContacts)
            {
                Console.WriteLine("Name: "+i.Name +"  Phone:"+ i.PhoneNumber);
            }

            Console.ReadKey();
        }
    }
}

/* Test case:
 * Expected output:
 * 
    Name: a  Phone:123456789
    Name: b  Phone:125656789
    Name: c  Phone:789456789
    Name: d  Phone:123676789
 * 
 */