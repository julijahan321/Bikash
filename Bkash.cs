class Bikash
{
    int count = 1;
    public void BikashSystem()
    {
            Console.WriteLine("bKash System");
            if (Console.ReadLine() == "*247#")
            {
                while(true)
                {
                Console.WriteLine("bKash");
                Console.WriteLine(count++ + " Send Money");
                Console.WriteLine(count++ + " Send Money to Non-bKash User");
                Console.WriteLine(count++ + " Mobile Reacherge");
                Console.WriteLine(count++ + " Payment");
                Console.WriteLine(count++ + " Cash Out");
                Console.WriteLine(count++ + " Pay Bill");
                Console.WriteLine(count++ + " Microfinance");
                Console.WriteLine(count++ + " Download bKash App");
                Console.WriteLine(count++ + " My bKash");
                Console.WriteLine(count++ + " Reset PIN");
                count = 1;

                //string press = Console.ReadLine();
                int press1 = int.Parse(Console.ReadLine());

                if (press1 == 1)
                {

                    Console.WriteLine("Enter Receiver bKash Account No:");
                    int ACCOUNTNo = int.Parse(Console.ReadLine());
                    Console.WriteLine("FREE Send Money to 5 Priyo Numbers.\r\nDial *247# and select number finde\r\npriyo Numbers.\r\nEnter Amount:");

                    int AMOUNT = int.Parse(Console.ReadLine());
                    Console.WriteLine("FREE Send Money to 5 Priyo numbers up\r\nto 25,000 Tk. every month\r\nEnter Reference:");
                    int REFERENCE = int.Parse(Console.ReadLine());
                    Console.WriteLine("Add up to Priyo Numbers to Send\r\nMoney for FREE.\r\nTo:" + ACCOUNTNo + "\r\nAmount:" + AMOUNT + "\r\nRefference:" + REFERENCE + "\r\nEnter Menu PIN to confirm");
                    count = 1;
                    Console.ReadLine();
                }
                //int press2 = int.Parse(Console.ReadLine());


                if (press1 == 2)
                {
                    Console.WriteLine("Enter Receiver Number:");
                    int ACCOUNTNo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Amount:");

                    int AMOUNT = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Reference:");
                    int REFERENCE = int.Parse(Console.ReadLine());
                    Console.WriteLine("Send Monet to Non-bKash User\r\nTo:" + ACCOUNTNo + "\r\nAmount:" + AMOUNT + "\r\nRefference:" + REFERENCE + "\r\nEnter Menu PIN to confirm");
                    count = 1;
                    Console.ReadLine();

                }
                    while (press1==3)
                    {

                        Console.WriteLine("bKas");
                        Console.WriteLine(count++ + " Robi");
                        Console.WriteLine(count++ + " Airtel");
                        Console.WriteLine(count++ + " Banglalink");
                        Console.WriteLine(count++ + " Grameenphone");
                        Console.WriteLine(count++ + " Teletalk");
                        Console.WriteLine(count++ + " Pay Bill");
                        Console.WriteLine(count++ + " Get Up To 150 Tk Cashback to bKash Recharge");
                        Console.WriteLine(0 + " Main Menu");

                        count = 1;
                        int press4 = int.Parse(Console.ReadLine());
                        if (press4 == 0)
                        {
                            break;
                        }
                        if (press4 == 4)
                        {
                            Console.WriteLine("bKash");
                            Console.WriteLine(count++ + " prepaid");
                            Console.WriteLine(count++ + " postpaid");
                            Console.WriteLine(count++ + " skitto");
                            Console.WriteLine(count++ + " auto-recherge");
                            Console.WriteLine(count++ + " best offers");
                            Console.WriteLine(count++ + " internate pack");
                            Console.WriteLine(count++ + " voice pack");
                            Console.WriteLine(count++ + " Bundle packs");
                            Console.WriteLine(0+ " Main Menu");
                            count = 1;
                            int press0or1=int.Parse(Console.ReadLine());
                             if ( press0or1== 0)
                             {
                                break;
                            }
                            if (press0or1 == 1)
                            {
                                Console.WriteLine("Enter Grameenphone Mobile No");
                                int ACCOUNTNo = int.Parse(Console.ReadLine());
                                Console.WriteLine("6TkCashback+30Min-150Day on 197Tk\r\nRecharge\r\nEnter Recherge Amount");

                                int AMOUNT = int.Parse(Console.ReadLine());
                                Console.WriteLine("Mobile Reacherge\r\nTo:" + ACCOUNTNo + "\r\nAmount:" + AMOUNT + "\r\nTo Know the amount is " + AMOUNT + " for " + ACCOUNTNo + " recherge offer,contact mobile operator.\r\nEnter Menu PIN to confirm:");
                                Console.ReadLine();
                                Console.WriteLine("recherg successfully");
                            }   
                        }
                }
                if (press1 == 4)
                {
                    Console.WriteLine("Enter Merchant bKash Account No:");
                    int ACCOUNTNo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Amount:");

                    int AMOUNT = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Reference:");
                    int REFERENCE = int.Parse(Console.ReadLine());
                    Console.WriteLine("Payment.\r\nTo:" + ACCOUNTNo + "\r\nAmount:Tk" + AMOUNT + "\r\nRefference:" + REFERENCE + "\r\nEnter Menu PIN to confirm");
                    count = 1;
                    Console.ReadLine();
                }
                if (press1 == 5)
                {
                    Console.WriteLine("bKash");
                    Console.WriteLine(count++ + " From Agent");
                    Console.WriteLine(count++ + " From ATM");

                    Console.WriteLine(count++ + " Priyo Agent Number");
                    Console.WriteLine(count++ + " Set Priyo Number to Cash Out at 1.49%");
                    count = 3;

                    int pressforagent = int.Parse(Console.ReadLine());

                    if (pressforagent == 1)
                    {
                        Console.WriteLine("Cash Out at 1.49% byte adding 1 Priyo Agent Number.\r\nDial *247# select option 9 then select option 4 \r\nEnter Agent bKash Number No :");
                    }
                    if (pressforagent == 3)
                    {
                        Console.WriteLine("Priyo Agent Number");
                        Console.WriteLine(count++ + " Add Priyo Agent Number");
                        Console.WriteLine(count++ + " Remove Priyo Agent Number");
                        Console.WriteLine(count++ + " Check Priyo Agent Number");
                        Console.WriteLine(count++ + " Check Priyo Agent Number Trx limit");
                        count = 1;
                        Console.ReadLine();
                    }
                    count = 1;
                }
                if (press1 == 9)
                {
                    Console.WriteLine("bKash");
                    Console.WriteLine(count++ + " Check Balance");
                    Console.WriteLine(count++ + " Request  Statement");
                    Console.WriteLine(count++ + " Change PIN");
                    Console.WriteLine(count++ + " Priyo Numbers");
                    Console.WriteLine(count++ + " Update MNP");
                    Console.WriteLine(count++ + " Confirm iPhone Login");
                    Console.WriteLine(count++ + " iPhone PIN Reset");
                    Console.WriteLine(count++ + " Helpline");
                    count = 1;

                    int pressforcheckbalance = int.Parse(Console.ReadLine());
                    if (pressforcheckbalance == 1)
                    {
                        Console.WriteLine("Enter Menu PIN:");
                        Console.ReadLine();
                    }
                    Console.ReadLine();
                }
            }
            int press = int.Parse(Console.ReadLine());
        }
    }
 }









