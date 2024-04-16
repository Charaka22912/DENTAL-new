using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;

public class Register
{
    public string FirstName;
    public string LastName;
    public string Address;
    public string ContactNo;
    public string ContactEmail;
    public DateTime DOB;
    public int NIC;
    public string UserType;
    public string Username;
    public string Password;

  

    public Register(string FirstName, string LastName, string Address, string ContactNo, string ContactEmail, DateTime DOB, int NIC, string UserType, string Username, string Password)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Address = Address;
        this.ContactNo = ContactNo;
        this.ContactEmail = ContactEmail;
        this.DOB = DOB;
        this.NIC = NIC;
        this.UserType = UserType;
        this.Username = Username;
        this.Password = Password;
    }

    public Register()
    {
    }


    public void InsertUserData(string connectionString)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Userinfo (FirstName, LastName, Address, ContactNo, ContactEmail, DOB, NIC, UserType, Username, Password) " +
                           "VALUES (@FirstName, @LastName, @Address, @ContactNo, @ContactEmail, @DOB, @NIC, @UserType, @Username, @Password)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@ContactNo", ContactNo);
            command.Parameters.AddWithValue("@ContactEmail", ContactEmail);
            command.Parameters.AddWithValue("@DOB", DOB);
            command.Parameters.AddWithValue("@NIC", NIC);
            command.Parameters.AddWithValue("@UserType", UserType);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public static Register CollectUserDataFromConsole()
    {
        Console.WriteLine("Enter First Name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter Last Name:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter Address:");
        string address = Console.ReadLine();

        Console.WriteLine("Enter Contact Number:");
        string contactNo = Console.ReadLine();

        Console.WriteLine("Enter Contact Email:");
        string contactEmail = Console.ReadLine();

        Console.WriteLine("Enter Date of Birth (YYYY-MM-DD):");
        DateTime dob;
        while (!DateTime.TryParse(Console.ReadLine(), out dob))
        {
            Console.WriteLine("Invalid date format. Please enter the date in YYYY-MM-DD format:");
        }

        Console.WriteLine("Enter NIC:");
        int nic;
        while (!int.TryParse(Console.ReadLine(), out nic))
        {
            Console.WriteLine("Invalid NIC. Please enter a valid number:");
        }

        Console.WriteLine("Enter User Type:");
        string userType = Console.ReadLine();

        Console.WriteLine("Enter Username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter Password:");
        string password = Console.ReadLine();

        return new Register(firstName, lastName, address, contactNo, contactEmail, dob, nic, userType, username, password);
    }
}

    

