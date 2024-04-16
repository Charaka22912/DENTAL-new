using System.Collections;

namespace DENTAL

{

    public class Program
    {
        static void Main(string[] args)
        {
            {

                
                bool exit = false; // Variable to control program exit
                while (!exit)
                {
                    Console.WriteLine("------Welcome to The Dental Master-----");
                    Console.WriteLine("***Menu***");
                    Console.WriteLine("Select Your Preference");
                    Console.WriteLine("1.Register User");
                    Console.WriteLine("2.Log In");
                    Console.WriteLine("3.Exit");
                    int menu = Convert.ToInt32(Console.ReadLine());

                    switch (menu)
                    {
                        case 1:
                            // Create an instance of the Register class
                            Register register = new Register();

                            // Call the CollectUserDataFromConsole method to collect user data
                            Register userData = Register.CollectUserDataFromConsole();

                            // Insert the user data into the database
                            string connectionString = "Data Source=HARL0CK;Initial Catalog=Dental;Integrated Security=True";
                            userData.InsertUserData(connectionString);
                            
                            Console.WriteLine("User registration successful!");
                            break;

                        case 2:
                            Login login = new Login();

                            // Call VerifyLogin method and pass connection string
                            if (login.VerifyLogin("Data Source=HARL0CK;Initial Catalog=Dental;Integrated Security=True"))
                            {
                                // User is successfully logged in
                                Console.WriteLine("User logged in successfully!");
                                // Add code to navigate to the main application or perform other actions
                            }
                            else
                            {
                                // Login failed
                                Console.WriteLine("Login failed. Please try again.");
                            }
                            break;

                        case 3:
                            exit = true; // Set exit to true to break out of the loop
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please select a valid option.");
                            break;
                    }
                }
            }
        }
    }  
}