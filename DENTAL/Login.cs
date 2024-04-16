using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DENTAL
{
    public class Login
    {
        public string UserName;
        public string Password;

        public Login()
        {
        }

        public Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public bool VerifyLogin(string connectionString)
        {
            bool loginSuccessful = false;

            Console.WriteLine("Welcome to the Login System");
            Console.WriteLine("---------------------------");

            // Get username from user
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            // Get password from user (masked)
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.WriteLine();

            // Create connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Define query to retrieve password associated with the username
                string query = "SELECT Password FROM Userinfo WHERE Username = @Username";

                // Create command
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter for username
                    command.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        // Open connection
                        connection.Open();

                        // Execute command
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read()) // If a record is found
                        {
                            // Retrieve password from database
                            string dbPassword = reader["Password"].ToString();

                            // Compare passwords
                            if (dbPassword == password)
                            {
                                // Passwords match - login successful
                                loginSuccessful = true;
                                Console.WriteLine("Login successful!");
                            }
                            else
                            {
                                // Invalid password
                                Console.WriteLine("Invalid password. Please try again.");
                            }
                        }
                        else
                        {
                            // Invalid username
                            Console.WriteLine("User not found. Please try again.");
                        }

                        // Close reader
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return loginSuccessful;
        }

        
    }
}

