using Foodies_Cuisine.BL;
using ProjectConsoleBased.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foodies_Cuisine;
using Foodies_Cuisine.DL;
using Foodies_Cuisine.DLInterfaces;
using Foodies_Cuisine.Utilities;
using Foodies_Cuisine.DL.FH;

namespace ProjectConsoleBased
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUserDL userDl = new UserFH("User.txt");
            IDishDL dishDL = new DishFH("Dish.txt");
            int Option = 0;
            int AdminOption = 0;
            int CustomerOption = 0;
            while (true)
            {
                Console.Clear();
                ConsoleUtility.PrintMenu();
                Option = ConsoleUtility.PrintMain();
                if (Option == 1)
                {
                        Console.Clear();
                        ConsoleUtility.PrintMenu();
                        User user = UserUI.SignUpUI();
                        if (userDl.SignIn(user) != null)
                        {
                            Console.WriteLine("User already present");

                        }
                        else if (userDl.AddUser(user))
                        {
                            Console.WriteLine("User Added");
                        }
                    ConsoleUtility.ContinueStatement();
                }
                else if (Option == 2)
                {
                    while (true)
                    {
                        Console.Clear();
                        ConsoleUtility.PrintMenu();
                        User user = UserUI.SignInUI();
                        User checkuser = userDl.SignIn(user);
                        if (checkuser != null && checkuser.GetRole() == "Admin")
                        {
                            while (true)
                            {
                                AdminOption = 0;
                                Console.Clear();
                                ConsoleUtility.PrintMenu();
                                AdminOption = AdminUI.PrintAdminMenu();
                                if (AdminOption == 1)
                                {
                                    Console.Clear();
                                    ConsoleUtility.PrintMenu();
                                    DishUI.PrintDishs(dishDL.GetDishList());
                                }
                                else if (AdminOption == 2)
                                {
                                    Console.Clear();
                                    ConsoleUtility.PrintMenu();
                                    Dish dish = DishUI.AddDishUI();
                                    if (dishDL.CheckDish(dish))
                                    {
                                        dishDL.AddDish(dish);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Dish already exits...");
                                        ConsoleUtility.ContinueStatement();

                                    }
                                }
                                else if (AdminOption == 3)
                                {
                                    Console.Clear();
                                    ConsoleUtility.PrintMenu();
                                    Dish dish = DishUI.RemoveDishUI();
                                    if (!dishDL.CheckDish(dish))
                                    {
                                        dishDL.RemoveDish(dish);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Dish doesn't exits...");
                                        ConsoleUtility.ContinueStatement();

                                    }
                                }
                                else if (AdminOption == 4)
                                {
                                    Console.Clear();
                                    ConsoleUtility.PrintMenu();
                                    Dish dish = DishUI.UpdateDishUI();
                                    if (!dishDL.CheckDish(dish))
                                    {
                                        dishDL.UpdateDish(dish);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Dish doesn't exits...");
                                        ConsoleUtility.ContinueStatement();

                                    }
                                }
                                else if (AdminOption == 11)
                                {
                                    break;
                                }
                            }
                        }
                        else if (checkuser != null && checkuser.GetRole() == "Customer")
                        {
                            while (true)
                            {
                                Console.Clear();
                                ConsoleUtility.PrintMenu();
                                CustomerOption = CustomerUI.PrintCustomerMenu();
                                if (CustomerOption == 5)
                                {
                                    
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Credentials");
                            ConsoleUtility.ContinueStatement();
                            Console.Clear();
                        }
                        if (CustomerOption == 5 || AdminOption == 11)
                        {
                            AdminOption = 0;
                            CustomerOption = 0;
                            break;
                        }
                    }
                }
                else if (Option == 3)
                {
                    break;
                }
            }
        }
    }
}
