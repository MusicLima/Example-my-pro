using System;

namespace NewPro
{
    class Program
    {
        static void Main(string[] args)
        //start
        {

            int member = 0;
            int a = 0;
            int room = 0;
            do
            {
                Console.WriteLine(" Welcome to SE Hotel Reservation");
                Console.WriteLine("--------------------------------");
                Console.WriteLine(" Would you like to reserve your room?");
                Console.WriteLine(" 1.Yes or 2.No ");
                Console.WriteLine(" Please write only number!");
                Console.Write(" You select: ");

                int reserve = int.Parse(Console.ReadLine());

                if (reserve == 1)//reserve
                {

                    Console.WriteLine("--------------------------------");

                    Console.WriteLine(" Enter your date of check-in");

                    DateTime checkin = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine(" Enter your date of check-out");
                    DateTime checkout = DateTime.Parse(Console.ReadLine());

                    TimeSpan timesp = checkout - checkin;






                    Console.WriteLine("--------------------------------");
                    //member 
                    Console.Write(" How many members?: ");
                    //chooseroom
                    member = int.Parse(Console.ReadLine());


                    do
                    {
                        if (member <= 5)
                        {
                            string roomsize1 = " Smallroom";
                            string roomsize2 = " Largeroom";
                            Console.WriteLine(" Please select room size");
                            Console.WriteLine(" 1." + roomsize1 + "or 2." + roomsize2);
                            Console.Write(" You Choose :");
                            room = int.Parse(Console.ReadLine());


                            switch (room)
                            {
                                case 1:
                                    string roomsize3 = " Smallroom";
                                    Console.WriteLine(" Price 1/day for" + roomsize3 + "is $ 15000\n");

                                    break;

                                case 2:
                                    string roomsize4 = " Largeroom";
                                    Console.WriteLine(" Price 1/day for " + roomsize4 + " is $25000\n");


                                    break;
                                default:
                                    Console.WriteLine(" Select 1 or 2 Please try again\n");
                                    break;

                            }//switch(room)


                        }// if (member <= 5)

                        else if (member >= 5 && member <= 10)
                        {
                            string roomsize5 = " Largeroom";
                            Console.WriteLine(" Your room  is Large room");
                            Console.WriteLine(" Price 1/day for " + roomsize5 + " is $25000\n");

                        }//else if(member >= 5 && member <= 10)

                        else
                        {
                            Console.WriteLine(" *Over limit*");
                        }//else
                    } while (room >= 3);

                    Console.WriteLine(" --------------------------------");
                    Console.WriteLine(" Your Reservation ");
                    Console.WriteLine(" Check - in :" + checkin);
                    Console.WriteLine(" Check - out :" + checkout);
                    Console.WriteLine(" Total day: " + (timesp.TotalDays));
                    Console.WriteLine(" Total member :" + member);
                    if (room == 1)
                    {

                        Console.WriteLine(" Total price : $ " + (timesp.TotalDays) * 15000);
                    }
                    else
                    {

                        Console.WriteLine(" Total price :  $ " + (timesp.TotalDays) * 25000);
                    }

                    if (room == 1)
                    {
                        Console.WriteLine(" Room size : Small room");
                    }
                    else
                    {
                        Console.WriteLine(" Room size : Large room");
                    }

                    Namearray(member);

                }//if
                else if (reserve == 2)
                {

                    Console.WriteLine(" Thank you ");

                }//Else if

                Console.WriteLine(" --------------------------------");
                Console.WriteLine($" Would you like to reserve your room again?\nEnter 1 for Reservation\nEnter 2 for End");
                a = int.Parse(Console.ReadLine());
            } while (a != 2);
            Console.WriteLine(" Thank you");

        }//Main

        public static void Namearray(int member1)
        {

            int[] phNum = new int[2];

            string YN, Name;

            Console.WriteLine(" --------------------------------");
            Console.Write(" Do you want to confirm\nYes or No:\n:");
            YN = Convert.ToString(Console.ReadLine());
            string YN2 = YN.ToUpper();

            switch (YN2)
            {

                case "YES":

                    Console.Write(" Please give your name\n:");
                    Name = Convert.ToString(Console.ReadLine());

                    if (member1 >= 2)
                    {
                        Console.WriteLine(" Please leave some of your phone number");
                        for (int i = 0; i < phNum.Length; i++)
                        {
                            Console.Write(" : ");
                            phNum[i] = Convert.ToInt32(Console.ReadLine());

                        }

                    }
                    else
                    {
                        Console.WriteLine(" Please leave your phone number");
                        for (int i = 1; i < phNum.Length; i++)
                        {
                            Console.Write(" : ");
                            phNum[i] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    break;
                case "NO":

                    Console.WriteLine(" Thank you for your attention");
                    break;







            }//switchYN2


        }//Namearray

    }//class

}//name
