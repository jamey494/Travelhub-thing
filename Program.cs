using System;

namespace HotelHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string weekDay = ("Hello");
            double roomRate = 0;
            string roomType = ("Goodbye!");
            int roomCount = 0;
            double discountPrice = 0;
            double discountAmount = 0;


            //this while loop ensures that only valid inputs are made
            while (!(weekDay.Contains("MO") || (weekDay.Contains("TU") || (weekDay.Contains("WE") || (weekDay.Contains("TH") || (weekDay.Contains("FR") || (weekDay.Contains("SA") || (weekDay.Contains("SU")))))))))
            {

                Console.WriteLine("Welcome to Travel Hut! For when would you like to book?");
                weekDay = Console.ReadLine().ToUpper();

                // this if condition reports an incorrect input if it is made
                if (!(weekDay.Contains("MO") || (weekDay.Contains("TU") || (weekDay.Contains("WE") || (weekDay.Contains("TH") || (weekDay.Contains("FR") || (weekDay.Contains("SA") || (weekDay.Contains("SU")))))))))
                {
                    Console.WriteLine("I'm sorry, the only accepted inputs are MO, TU, WE, TU, FR, SA, SU");
                }

            }

            while (!(roomType.Contains("D") || roomType.Contains("F")))
            {


                Console.WriteLine("What room type would you like? Your choices are Double Room (D) and Family Room (F)");
                roomType = Console.ReadLine().ToUpper();

                if (!(roomType.Contains("D") || roomType.Contains("F")))
                {
                    Console.WriteLine("Please enter either D or F, for Double and Family respectively");
                }
            }

            // ensures that roomcount is kept to a reasonable number, between 1 and 10
            while (!(roomCount >= 1) && roomCount < 11)
            {


                Console.WriteLine("How many rooms of this type would you like to book? We have 10 available. Booking more than 1 room will give you a 10% discount.");
                roomCount = Convert.ToInt32(Console.ReadLine());

                if (!(roomCount >= 1) && roomCount < 11)
                {
                    Console.WriteLine("We only have up to 10 rooms available of this type");
                }


            }



            // checks if the weekday variable contains Monday and runs everything within the if statement if it does
            if (weekDay == "SU" || weekDay == "MO")
            {




                roomRate = 60;
                if (roomType.Contains("F"))
                {
                    roomRate = 99;

                }

                if (roomCount > 1)
                {
                    discountPrice = roomRate * roomCount * 0.9;
                    discountAmount = (roomRate * roomCount) - discountPrice;

                    Console.WriteLine("You would like to book? That's great, that will be £{1} please. You saved £{0:0.00}", discountAmount, discountPrice);


                }

                else
                {
                    Console.WriteLine("You would like to book? That's great, that will be £{0} please.", roomRate);
                }

            }


            else if (weekDay == "TU" || weekDay == "WE" || weekDay == "TH")
            {
                roomRate = 40;

                if (roomType.Contains("F"))
                {
                    roomRate = 49;

                }

                if (roomCount > 1)
                {
                    discountPrice = roomRate * roomCount * 0.9;
                    discountAmount = (roomRate * roomCount) - discountPrice;

                    Console.WriteLine("You would like to book multiple rooms? That's great, that will be £{1} please. You saved £{0:0.00}", discountAmount, discountPrice);


                }

                else
                {
                    Console.WriteLine("You would like to book one room? That's great, that will be £{0} please.", roomRate);
                }



            }

             else if (weekDay == "FR" || weekDay == "SA")
            {
                roomRate = 90;

                if (roomType.Contains("F"))
                {
                    roomRate = 179;

                }
                if (roomCount > 1)
                {
                    discountPrice = roomRate * roomCount * 0.9;
                    discountAmount = (roomRate * roomCount) - discountPrice;

                    Console.WriteLine("You would like to book multiple rooms? That's great, that will be £{1} please. You saved £{0:0.00}", discountAmount, discountPrice);


                }

                else
                {
                    Console.WriteLine("You would like to book one room? That's great, that will be £{0} please.", roomRate);
                }



            }

           



            }

        }
    }

