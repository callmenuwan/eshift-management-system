using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift_management
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string userEmail, string userPassword)
        {
            Email = userEmail;
            Password = userPassword;
        }

        public virtual bool Login(string inputEmail, string inputPassword)
        {
            return inputEmail == Email && inputPassword == Password;
        }
    
    }

    // ------------------------
    // Step 2: Admin Class (Inheritance + Polymorphism)
    // ------------------------

    public class Admin : User
    {
        public Admin(string adminEmail, string adminPassword) : base(adminEmail, adminPassword) { }

        public override bool Login(string inputEmail, string inputPassword)
        {
            return inputEmail == "admin@eshift.com" && inputPassword == "admin123";
        }

        public bool RegisterCustomer(List<Customer> customerList, Customer newCustomer)
        {
            customerList.Add(newCustomer);
            return true;
        }
    }

    // ------------------------
    // Step 3: Customer Class (Inheritance + Polymorphism)
    // ------------------------

    public class Customer : User
    {
        public string FullName { get; set; }
        public string ContactNumber { get; set; }

        public Customer(string customerEmail, string customerPassword, string fullName, string contactNumber)
            : base(customerEmail, customerPassword)
        {
            FullName = fullName;
            ContactNumber = contactNumber;
        }

        public override bool Login(string inputEmail, string inputPassword)
        {
            return base.Login(inputEmail, inputPassword);
        }
    }

    // ------------------------
    // Step 4: Auth System for UI Usage
    // ------------------------

    public class AuthSystem
    {
        public string LoginUser(User userInstance, string loginEmail, string loginPassword)
        {
            return userInstance.Login(loginEmail, loginPassword) ? "Login Success" : "Login Failed";
        }
    }
}
